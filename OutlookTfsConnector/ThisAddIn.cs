using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Outlook = Microsoft.Office.Interop.Outlook;
using Office = Microsoft.Office.Core;
using System.Windows.Forms;
using System.IO;
using System.Configuration;

namespace OutlookTfsConnector
{
    public partial class ThisAddIn
    {

        public string TfsUrl { get { return _tfsUrl; } }
        public string TfsProject { get { return _tfsProject; } }
        public string TfsUserName { get { return _userName; } }
        public string TfsUserToken { get { return _userToken; } }
        public bool EnableAddinFunctions { get { return _enableFunction; } }

        private string _tfsUrl;
        private string _tfsProject;
        private string _userName;
        private string _userToken;

        private bool _enableFunction;

        //private const string configFilePath = @"C:\Temp\OutlookTfsConfig\OutlookTfsAddinConfig.txt";

        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            _enableFunction = true;
            _tfsUrl = ConfigurationManager.AppSettings["TFS_URL"];
            _tfsProject = ConfigurationManager.AppSettings["TFS_PROJECT"];
            _userName = ConfigurationManager.AppSettings["TFS_USERNAME"];
            _userToken = ConfigurationManager.AppSettings["TFS_USERTOKEN"];
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
            // Note: Outlook no longer raises this event. If you have code that 
            //    must run when Outlook shuts down, see https://go.microsoft.com/fwlink/?LinkId=506785
            MessageBox.Show("Outlook TFS Connector, Addin Shutting Down");
        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion
    }
}
