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
            this.group1 = this.Factory.CreateRibbonGroup();
            this.tabAddins = this.Factory.CreateRibbonTab();
            this.group2 = this.Factory.CreateRibbonGroup();
            this.btnAddEmailToTfs = this.Factory.CreateRibbonButton();
            this.btnAddEmailToTfs2 = this.Factory.CreateRibbonButton();
            this.tabCustomHome.SuspendLayout();
            this.group1.SuspendLayout();
            this.tabAddins.SuspendLayout();
            this.group2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCustomHome
            // 
            this.tabCustomHome.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tabCustomHome.ControlId.OfficeId = "TabMail";
            this.tabCustomHome.Groups.Add(this.group1);
            this.tabCustomHome.Label = "TabMail";
            this.tabCustomHome.Name = "tabCustomHome";
            // 
            // group1
            // 
            this.group1.Items.Add(this.btnAddEmailToTfs);
            this.group1.Label = "TFS";
            this.group1.Name = "group1";
            // 
            // tabAddins
            // 
            this.tabAddins.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tabAddins.Groups.Add(this.group2);
            this.tabAddins.Label = "tabAddins";
            this.tabAddins.Name = "tabAddins";
            // 
            // group2
            // 
            this.group2.Items.Add(this.btnAddEmailToTfs2);
            this.group2.Label = "TFS";
            this.group2.Name = "group2";
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
            // btnAddEmailToTfs2
            // 
            this.btnAddEmailToTfs2.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnAddEmailToTfs2.Image = ((System.Drawing.Image)(resources.GetObject("btnAddEmailToTfs2.Image")));
            this.btnAddEmailToTfs2.Label = "Add Email To TFS";
            this.btnAddEmailToTfs2.Name = "btnAddEmailToTfs2";
            this.btnAddEmailToTfs2.ShowImage = true;
            this.btnAddEmailToTfs2.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnAddEmailToTfs_Click);
            // 
            // OutlookTfsConnectorRibbon
            // 
            this.Name = "OutlookTfsConnectorRibbon";
            this.RibbonType = "Microsoft.Outlook.Explorer";
            this.Tabs.Add(this.tabCustomHome);
            this.Tabs.Add(this.tabAddins);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.OutlookTfsConnectorRibbon_Load);
            this.tabCustomHome.ResumeLayout(false);
            this.tabCustomHome.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.tabAddins.ResumeLayout(false);
            this.tabAddins.PerformLayout();
            this.group2.ResumeLayout(false);
            this.group2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tabCustomHome;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnAddEmailToTfs;
        private Microsoft.Office.Tools.Ribbon.RibbonTab tabAddins;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group2;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnAddEmailToTfs2;
    }

    partial class ThisRibbonCollection
    {
        internal OutlookTfsConnectorRibbon OutlookTfsConnectorRibbon
        {
            get { return this.GetRibbon<OutlookTfsConnectorRibbon>(); }
        }
    }
}
