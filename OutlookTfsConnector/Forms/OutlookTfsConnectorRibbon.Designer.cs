namespace OutlookTfsConnector
{
    partial class OutlookTfsConnectorRibbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public OutlookTfsConnectorRibbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OutlookTfsConnectorRibbon));
            this.tabCustomHome = this.Factory.CreateRibbonTab();
            this.groupTabMailExplorer = this.Factory.CreateRibbonGroup();
            this.tabReadMessage = this.Factory.CreateRibbonTab();
            this.group2 = this.Factory.CreateRibbonGroup();
            this.tabNewMailMessage = this.Factory.CreateRibbonTab();
            this.group3 = this.Factory.CreateRibbonGroup();
            this.tab1 = this.Factory.CreateRibbonTab();
            this.group4 = this.Factory.CreateRibbonGroup();
            this.button3 = this.Factory.CreateRibbonButton();
            this.btnAddEmailToTfs = this.Factory.CreateRibbonButton();
            this.btnSettings = this.Factory.CreateRibbonButton();
            this.btnAddEmailToTfs2 = this.Factory.CreateRibbonButton();
            this.button1 = this.Factory.CreateRibbonButton();
            this.button2 = this.Factory.CreateRibbonButton();
            this.tabCustomHome.SuspendLayout();
            this.groupTabMailExplorer.SuspendLayout();
            this.tabReadMessage.SuspendLayout();
            this.group2.SuspendLayout();
            this.tabNewMailMessage.SuspendLayout();
            this.group3.SuspendLayout();
            this.tab1.SuspendLayout();
            this.group4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCustomHome
            // 
            this.tabCustomHome.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tabCustomHome.ControlId.OfficeId = "TabMail";
            this.tabCustomHome.Groups.Add(this.groupTabMailExplorer);
            this.tabCustomHome.Label = "TabMail";
            this.tabCustomHome.Name = "tabCustomHome";
            // 
            // groupTabMailExplorer
            // 
            this.groupTabMailExplorer.Items.Add(this.btnAddEmailToTfs);
            this.groupTabMailExplorer.Items.Add(this.btnSettings);
            this.groupTabMailExplorer.Label = "TFS";
            this.groupTabMailExplorer.Name = "groupTabMailExplorer";
            this.groupTabMailExplorer.Position = this.Factory.RibbonPosition.BeforeOfficeId("GroupContactFind");
            // 
            // tabReadMessage
            // 
            this.tabReadMessage.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tabReadMessage.ControlId.OfficeId = "TabReadMessage";
            this.tabReadMessage.Groups.Add(this.group2);
            this.tabReadMessage.Label = "TabReadMessage";
            this.tabReadMessage.Name = "tabReadMessage";
            // 
            // group2
            // 
            this.group2.Items.Add(this.btnAddEmailToTfs2);
            this.group2.Label = "TFS";
            this.group2.Name = "group2";
            // 
            // tabNewMailMessage
            // 
            this.tabNewMailMessage.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tabNewMailMessage.ControlId.OfficeId = "TabNewMailMessage";
            this.tabNewMailMessage.Groups.Add(this.group3);
            this.tabNewMailMessage.Label = "TabNewMailMessage";
            this.tabNewMailMessage.Name = "tabNewMailMessage";
            // 
            // group3
            // 
            this.group3.Items.Add(this.button1);
            this.group3.Label = "TFS";
            this.group3.Name = "group3";
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.ControlId.OfficeId = "TabMeetingResponse";
            this.tab1.Groups.Add(this.group4);
            this.tab1.Label = "TabMeetingResponse";
            this.tab1.Name = "tab1";
            // 
            // group4
            // 
            this.group4.Items.Add(this.button2);
            this.group4.Label = "TFS";
            this.group4.Name = "group4";
            // 
            // button3
            // 
            this.button3.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button3.Label = "TFS Addin Settings";
            this.button3.Name = "button3";
            this.button3.OfficeImageId = "SetAsDefault";
            this.button3.ScreenTip = "Settings";
            this.button3.ShowImage = true;
            this.button3.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnSettings_Click);
            // 
            // btnAddEmailToTfs
            // 
            this.btnAddEmailToTfs.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnAddEmailToTfs.Image = ((System.Drawing.Image)(resources.GetObject("btnAddEmailToTfs.Image")));
            this.btnAddEmailToTfs.Label = "Add Email To TFS";
            this.btnAddEmailToTfs.Name = "btnAddEmailToTfs";
            this.btnAddEmailToTfs.ShowImage = true;
            this.btnAddEmailToTfs.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnAddEmailToTfs_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnSettings.Label = "Settings";
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.OfficeImageId = "SetAsDefault";
            this.btnSettings.ScreenTip = "Settings";
            this.btnSettings.ShowImage = true;
            this.btnSettings.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnSettings_Click);
            // 
            // btnAddEmailToTfs2
            // 
            this.btnAddEmailToTfs2.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnAddEmailToTfs2.Image = ((System.Drawing.Image)(resources.GetObject("btnAddEmailToTfs2.Image")));
            this.btnAddEmailToTfs2.Label = "Add Email To TFS";
            this.btnAddEmailToTfs2.Name = "btnAddEmailToTfs2";
            this.btnAddEmailToTfs2.ShowImage = true;
            this.btnAddEmailToTfs2.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnAddEmailToTfs_Click);
            // 
            // button1
            // 
            this.button1.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Label = "Add Email To TFS";
            this.button1.Name = "button1";
            this.button1.ShowImage = true;
            this.button1.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnAddEmailToTfsNewEmail_Click);
            // 
            // button2
            // 
            this.button2.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Label = "Add Email To TFS";
            this.button2.Name = "button2";
            this.button2.ShowImage = true;
            this.button2.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnAddEmailToTfs_Click);
            // 
            // OutlookTfsConnectorRibbon
            // 
            this.Name = "OutlookTfsConnectorRibbon";
            // 
            // OutlookTfsConnectorRibbon.OfficeMenu
            // 
            this.OfficeMenu.Items.Add(this.button3);
            this.RibbonType = "Microsoft.Outlook.Explorer, Microsoft.Outlook.Mail.Compose, Microsoft.Outlook.Mai" +
    "l.Read, Microsoft.Outlook.Response.Read";
            this.Tabs.Add(this.tabCustomHome);
            this.Tabs.Add(this.tabReadMessage);
            this.Tabs.Add(this.tabNewMailMessage);
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.OutlookTfsConnectorRibbon_Load);
            this.tabCustomHome.ResumeLayout(false);
            this.tabCustomHome.PerformLayout();
            this.groupTabMailExplorer.ResumeLayout(false);
            this.groupTabMailExplorer.PerformLayout();
            this.tabReadMessage.ResumeLayout(false);
            this.tabReadMessage.PerformLayout();
            this.group2.ResumeLayout(false);
            this.group2.PerformLayout();
            this.tabNewMailMessage.ResumeLayout(false);
            this.tabNewMailMessage.PerformLayout();
            this.group3.ResumeLayout(false);
            this.group3.PerformLayout();
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.group4.ResumeLayout(false);
            this.group4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tabCustomHome;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup groupTabMailExplorer;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnAddEmailToTfs;
        private Microsoft.Office.Tools.Ribbon.RibbonTab tabReadMessage;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group2;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnAddEmailToTfs2;
        private Microsoft.Office.Tools.Ribbon.RibbonTab tabNewMailMessage;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group3;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnSettings;
        private Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group4;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button2;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button3;
    }

    partial class ThisRibbonCollection
    {
        internal OutlookTfsConnectorRibbon OutlookTfsConnectorRibbon
        {
            get { return this.GetRibbon<OutlookTfsConnectorRibbon>(); }
        }
    }
}
