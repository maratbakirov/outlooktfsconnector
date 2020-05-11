using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop.Outlook;
using Microsoft.Office.Tools.Ribbon;
using Microsoft.TeamFoundation.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.WebApi;
using Microsoft.VisualStudio.Services.Common;
using Microsoft.VisualStudio.Services.WebApi;
using Microsoft.VisualStudio.Services.WebApi.Patch;
using Microsoft.VisualStudio.Services.WebApi.Patch.Json;

namespace OutlookTfsConnector
{
    public partial class OutlookTfsConnectorRibbon
    {
        Microsoft.Office.Interop.Outlook.Application outlookApp;
        ThisAddIn outlookAddin;
        private void OutlookTfsConnectorRibbon_Load(object sender, RibbonUIEventArgs e)
        {
            outlookApp = Globals.ThisAddIn.Application as Microsoft.Office.Interop.Outlook.Application;
            outlookAddin = Globals.ThisAddIn;
            //btnAddEmailToTfs.Enabled = outlookAddin.EnableAddinFunctions;
            //tabNewMailMessage.Ribbon = 

        }

    
        private void btnAddEmailToTfs_Click(object sender, RibbonControlEventArgs e)
        {

            ExchangeUser currentOutlookUser = outlookApp.Session.CurrentUser.
            AddressEntry.GetExchangeUser();

            if (outlookApp.ActiveExplorer().Selection.Count > 0)
            {
                Object selObject = outlookApp.ActiveExplorer().Selection[1];
                if (selObject is Microsoft.Office.Interop.Outlook.MailItem)
                {
                    Microsoft.Office.Interop.Outlook.MailItem mailItem =
                        (selObject as Microsoft.Office.Interop.Outlook.MailItem);

                    TfsWorkItemUserForm userForm = new TfsWorkItemUserForm(mailItem , outlookAddin , currentOutlookUser);
                    userForm.ShowDialog();
                    
                }
            }
        }
        private void btnAddEmailToTfsNewEmail_Click(object sender, RibbonControlEventArgs e)
        {
            var context = e.Control.Context;
            var mailItem = context.CurrentItem as MailItem;

            ExchangeUser currentOutlookUser = outlookApp.Session.CurrentUser.
            AddressEntry.GetExchangeUser();

            if (mailItem != null)
            {
                TfsWorkItemUserForm userForm = new TfsWorkItemUserForm(mailItem, outlookAddin, currentOutlookUser);
                userForm.ShowDialog();
            }
        }

        private void btnSettings_Click(object sender, RibbonControlEventArgs e)
        {
            SettingsForm userForm = new SettingsForm();
            userForm.ShowDialog();

        }
    }
}
