﻿using Microsoft.Office.Interop.Outlook;
using Microsoft.TeamFoundation.WorkItemTracking.WebApi;
using Microsoft.TeamFoundation.WorkItemTracking.WebApi.Models;
using Microsoft.VisualStudio.Services.Common;
using Microsoft.VisualStudio.Services.WebApi;
using Microsoft.VisualStudio.Services.WebApi.Patch;
using Microsoft.VisualStudio.Services.WebApi.Patch.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OutlookTfsConnector
{
    public partial class TfsWorkItemUserForm : Form
    {
        private Microsoft.Office.Interop.Outlook.MailItem _outlookCurrentMailItem;
        private ThisAddIn _thisAddIn;
        private ExchangeUser _exchangeUser;
        public TfsWorkItemUserForm(Microsoft.Office.Interop.Outlook.MailItem outlookCurrentMailItem , ThisAddIn thisAddIn, ExchangeUser exchangeUser)
        {
            _outlookCurrentMailItem = outlookCurrentMailItem;
            _thisAddIn = thisAddIn;
            _exchangeUser = exchangeUser;
            InitializeComponent();
            this.CenterToScreen();
            btnSaveNClose.Enabled = false;

            txtTitle.Text = _outlookCurrentMailItem.Subject;
            txtBody.Text = _outlookCurrentMailItem.Body;

            lblAttachements.Text = lblAttachements.Text + _outlookCurrentMailItem.Attachments.Count;

            for (int i = 1; i <= _outlookCurrentMailItem.Attachments.Count; i++)
            {
                chkLstBoxAttachements.Items.Add(_outlookCurrentMailItem.Attachments[i].FileName, false);
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnSaveNClose_Click(object sender, EventArgs e)
        {
            var connection = new VssConnection(new Uri(_thisAddIn.TfsUrl), new VssBasicCredential(string.Empty, _thisAddIn.TfsUserToken));
            var witClient = connection.GetClient<WorkItemTrackingHttpClient>();

            JsonPatchDocument patchDocument = new JsonPatchDocument();

            //add fields and their values to your patch document
            patchDocument.Add(
                new JsonPatchOperation()
                {
                    Operation = Operation.Add,
                    Path = "/fields/System.Title",
                    Value = txtTitle.Text
                }
            );

            StringBuilder bodyText = new StringBuilder();
            bodyText.Append(txtBody.Text.Replace(Environment.NewLine, "<br/>"));
            bodyText.Append("<br/>");
            bodyText.Append("From : " + _outlookCurrentMailItem.SenderName + " (" +  GetSenderEmailAddress(_outlookCurrentMailItem) + ")");

            patchDocument.Add(
                new JsonPatchOperation()
                {
                    Operation = Operation.Add,
                    Path = "/fields/Microsoft.VSTS.TCM.ReproSteps",
                    Value = bodyText.ToString()
                }
            );

            patchDocument.Add(
                new JsonPatchOperation()
                {
                    Operation = Operation.Add,
                    Path = "/fields/System.Description",
                    Value = bodyText.ToString()
                }
            );

            patchDocument.Add(
                new JsonPatchOperation()
                {
                    Operation = Operation.Add,
                    Path = "/fields/Microsoft.VSTS.TCM.SystemInfo",
                    Value = txtSystemInformation.Text
                }
            );
            
            patchDocument.Add(
                new JsonPatchOperation()
                {
                    Operation = Operation.Add,
                    Path = "/fields/Microsoft.VSTS.Common.Priority",
                    Value = cbPriority.Text
                }
            );

            patchDocument.Add(
                new JsonPatchOperation()
                {
                    Operation = Operation.Add,
                    Path = "/fields/Microsoft.VSTS.Common.Severity",
                    Value = cbSeverity.Text
                }
                );

            patchDocument.Add(
                new JsonPatchOperation()
                {
                    Operation = Operation.Add,
                    Path = "/fields/System.AssignedTo",
                    Value = _exchangeUser.Name + " <" + _exchangeUser.PrimarySmtpAddress + ">"
                }
            );

            /*
            patchDocument.Add(
                new JsonPatchOperation()
                {
                    Operation = Operation.Add,
                    Path = "/fields/Microsoft.VSTS.Common.ReviewedBy",
                    Value = _outlookCurrentMailItem.SenderName + " <" + _outlookCurrentMailItem.Sender.GetExchangeUser().PrimarySmtpAddress + ">"
                }
            );
            */

            WorkItem result = witClient.CreateWorkItemAsync(patchDocument, _thisAddIn.TfsProject, cbWorkItemType.Text).Result;

            List<string> saveFilePaths = new List<string>();

            for (int i = 0; i < chkLstBoxAttachements.Items.Count; i++)
            {
                if (chkLstBoxAttachements.GetItemChecked(i))
                {
                    
                    string fPath = ConfigurationManager.AppSettings["TMP_ATTACH_FOLDER"] + _outlookCurrentMailItem.Attachments[i + 1].FileName;
                    saveFilePaths.Add(fPath);
                    _outlookCurrentMailItem.Attachments[i + 1].SaveAsFile(fPath); 
                }
            }


            if (saveFilePaths.Count > 0)
            {
                JsonPatchDocument attachDocument = new JsonPatchDocument();
                List<string> uploadedAttachementUrl = new List<string>();
                foreach (string fp in saveFilePaths)
                {
                    AttachmentReference attachment = null;

                    Task taskAttach = new Task(() => { attachment = witClient.CreateAttachmentAsync(fp).Result; });
                    taskAttach.Start();
                    Task.WaitAll(new[] { taskAttach });

                    attachDocument.Add(
                         new JsonPatchOperation()
                         {
                             Operation = Operation.Add,
                             Path = "/relations/-",
                             Value = new
                             {
                                 rel = "AttachedFile",
                                 url = attachment.Url,

                                 attributes = new
                                 {
                                     name = Path.GetFileName(fp),
                                     comment = "Adding new attachment for item, Outlook TFS Add-in"
                                 }
                             }
                         }
                     );
                    uploadedAttachementUrl.Add(attachment.Url);
                }

                WorkItem attachmentResult = witClient.UpdateWorkItemAsync(attachDocument, result.Id.Value).Result;

                foreach (string fp in saveFilePaths)
                {
                    if(File.Exists(fp))
                        File.Delete(fp);
                }


                //Prepare new body text

                bodyText.Append("<br/>");
                foreach (string ustr in uploadedAttachementUrl)
                {
                    bodyText.Append("<br/>");
                    bodyText.Append(String.Format("<img src =\"{0}\"/> " , ustr));
                }

                JsonPatchDocument updatedItemBody = new JsonPatchDocument();
                updatedItemBody.Add(
                    new JsonPatchOperation()
                    {
                        Operation = Operation.Add,
                        Path = "/fields/Microsoft.VSTS.TCM.ReproSteps",
                        Value = bodyText.ToString()
                    }
                );

                updatedItemBody.Add(
                    new JsonPatchOperation()
                    {
                        Operation = Operation.Add,
                        Path = "/fields/System.Description",
                        Value = bodyText.ToString()
                    }
                );

                WorkItem finalResult = witClient.UpdateWorkItemAsync(updatedItemBody, result.Id.Value).Result;

                MessageBox.Show("Item Created Sucessfully, with ID: " + finalResult.Id + "\r\n\r\n" + finalResult.Url , "Item Created With Attachement");
            }
            else
            {
                MessageBox.Show("Item Created Sucessfully, with ID: " + result.Id + "\r\n\r\n" + result.Url, "Item Created");
            }

            this.Close();
            this.Dispose();
        }

        private string GetSenderEmailAddress(MailItem mail)
        {
            AddressEntry sender = mail.Sender;
            string SenderEmailAddress = "";

            if (sender.AddressEntryUserType == OlAddressEntryUserType.olExchangeUserAddressEntry || sender.AddressEntryUserType == OlAddressEntryUserType.olExchangeRemoteUserAddressEntry)
            {
                ExchangeUser exchUser = sender.GetExchangeUser();
                if (exchUser != null)
                {
                    SenderEmailAddress = exchUser.PrimarySmtpAddress;
                }
            }
            else
            {
                SenderEmailAddress = mail.SenderEmailAddress;
            }

            return SenderEmailAddress;
        }

        private void CheckAndEnableSaveButton()
        {
            if (cbWorkItemType.SelectedIndex >= 0 && cbPriority.SelectedIndex >= 0 && cbSeverity.SelectedIndex >= 0
                && txtBody.TextLength > 0 && txtTitle.TextLength > 0)
                btnSaveNClose.Enabled = true;
            else
                btnSaveNClose.Enabled = false;
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            if (chkLstBoxAttachements.Items.Count != chkLstBoxAttachements.CheckedItems.Count)
            {
                for (int i = 0; i < chkLstBoxAttachements.Items.Count; i++)
                {
                    chkLstBoxAttachements.SetItemChecked(i, true);
                }
            }
            else
            {
                for (int i = 0; i < chkLstBoxAttachements.Items.Count; i++)
                {
                    chkLstBoxAttachements.SetItemChecked(i, false);
                }
            }
        }

        private void cbWorkItemType_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckAndEnableSaveButton();
        }

        private void cbPriority_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckAndEnableSaveButton();
        }

        private void cbSeverity_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckAndEnableSaveButton();
        }

        private void txtBody_TextChanged(object sender, EventArgs e)
        {
            CheckAndEnableSaveButton();
        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {
            CheckAndEnableSaveButton();
        }
    }
}
