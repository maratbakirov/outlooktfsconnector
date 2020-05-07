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
using OutlookTfsConnector.Code;

namespace OutlookTfsConnector
{
    public partial class ThisAddIn
    {
        public Settings Settings { get; private set; }
        //public bool EnableAddinFunctions { get { return _enableFunction; } }

        //private bool _enableFunction;

        //private const string configFilePath = @"C:\Temp\OutlookTfsConfig\OutlookTfsAddinConfig.txt";

        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            if (Settings == null)
            {
                Settings = new Settings();
                Settings.Load();
            }
            //_enableFunction = true;
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
