namespace OutlookTfsConnector
{
    partial class TfsWorkItemUserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClose = new System.Windows.Forms.Button();
            this.cbWorkItemType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBody = new System.Windows.Forms.TextBox();
            this.btnSaveNClose = new System.Windows.Forms.Button();
            this.lblAttachements = new System.Windows.Forms.Label();
            this.chkLstBoxAttachements = new System.Windows.Forms.CheckedListBox();
            this.txtSystemInformation = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbPriority = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbSeverity = new System.Windows.Forms.ComboBox();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.cbProject = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabNewItem = new System.Windows.Forms.TabPage();
            this.tabUpdateItem = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.txtParentItem = new System.Windows.Forms.TextBox();
            this.txtParentItemDetails = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabNewItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(742, 686);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(119, 28);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cbWorkItemType
            // 
            this.cbWorkItemType.Enabled = false;
            this.cbWorkItemType.FormattingEnabled = true;
            this.cbWorkItemType.Items.AddRange(new object[] {
            "Task",
            "Bug",
            "Feature",
            "Issue"});
            this.cbWorkItemType.Location = new System.Drawing.Point(263, 26);
            this.cbWorkItemType.Margin = new System.Windows.Forms.Padding(4);
            this.cbWorkItemType.Name = "cbWorkItemType";
            this.cbWorkItemType.Size = new System.Drawing.Size(241, 24);
            this.cbWorkItemType.TabIndex = 1;
            this.cbWorkItemType.Text = "Task";
            this.cbWorkItemType.SelectedIndexChanged += new System.EventHandler(this.cbWorkItemType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(259, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Work Item Type *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 169);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Title *";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(16, 188);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(844, 22);
            this.txtTitle.TabIndex = 4;
            this.txtTitle.TextChanged += new System.EventHandler(this.txtTitle_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 219);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Body *";
            // 
            // txtBody
            // 
            this.txtBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBody.Location = new System.Drawing.Point(16, 253);
            this.txtBody.Margin = new System.Windows.Forms.Padding(4);
            this.txtBody.Multiline = true;
            this.txtBody.Name = "txtBody";
            this.txtBody.Size = new System.Drawing.Size(844, 179);
            this.txtBody.TabIndex = 6;
            this.txtBody.TextChanged += new System.EventHandler(this.txtBody_TextChanged);
            // 
            // btnSaveNClose
            // 
            this.btnSaveNClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveNClose.Enabled = false;
            this.btnSaveNClose.Location = new System.Drawing.Point(613, 686);
            this.btnSaveNClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveNClose.Name = "btnSaveNClose";
            this.btnSaveNClose.Size = new System.Drawing.Size(121, 28);
            this.btnSaveNClose.TabIndex = 7;
            this.btnSaveNClose.Text = "Save && Close";
            this.btnSaveNClose.UseVisualStyleBackColor = true;
            this.btnSaveNClose.Click += new System.EventHandler(this.btnSaveNClose_Click);
            // 
            // lblAttachements
            // 
            this.lblAttachements.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAttachements.AutoSize = true;
            this.lblAttachements.Location = new System.Drawing.Point(12, 440);
            this.lblAttachements.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAttachements.Name = "lblAttachements";
            this.lblAttachements.Size = new System.Drawing.Size(94, 17);
            this.lblAttachements.TabIndex = 8;
            this.lblAttachements.Text = "Attachments: ";
            // 
            // chkLstBoxAttachements
            // 
            this.chkLstBoxAttachements.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkLstBoxAttachements.FormattingEnabled = true;
            this.chkLstBoxAttachements.Location = new System.Drawing.Point(16, 471);
            this.chkLstBoxAttachements.Margin = new System.Windows.Forms.Padding(4);
            this.chkLstBoxAttachements.Name = "chkLstBoxAttachements";
            this.chkLstBoxAttachements.Size = new System.Drawing.Size(379, 191);
            this.chkLstBoxAttachements.TabIndex = 9;
            // 
            // txtSystemInformation
            // 
            this.txtSystemInformation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSystemInformation.Location = new System.Drawing.Point(424, 471);
            this.txtSystemInformation.Margin = new System.Windows.Forms.Padding(4);
            this.txtSystemInformation.Multiline = true;
            this.txtSystemInformation.Name = "txtSystemInformation";
            this.txtSystemInformation.Size = new System.Drawing.Size(436, 207);
            this.txtSystemInformation.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(420, 440);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "System Information";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(542, 3);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Priority *";
            // 
            // cbPriority
            // 
            this.cbPriority.Enabled = false;
            this.cbPriority.FormattingEnabled = true;
            this.cbPriority.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbPriority.Location = new System.Drawing.Point(546, 26);
            this.cbPriority.Margin = new System.Windows.Forms.Padding(4);
            this.cbPriority.Name = "cbPriority";
            this.cbPriority.Size = new System.Drawing.Size(96, 24);
            this.cbPriority.TabIndex = 13;
            this.cbPriority.Text = "1";
            this.cbPriority.SelectedIndexChanged += new System.EventHandler(this.cbPriority_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(667, 3);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Severity *";
            // 
            // cbSeverity
            // 
            this.cbSeverity.Enabled = false;
            this.cbSeverity.FormattingEnabled = true;
            this.cbSeverity.Items.AddRange(new object[] {
            "1 - Critical",
            "2 - High",
            "3 - Medium",
            "4 - Low"});
            this.cbSeverity.Location = new System.Drawing.Point(671, 26);
            this.cbSeverity.Margin = new System.Windows.Forms.Padding(4);
            this.cbSeverity.Name = "cbSeverity";
            this.cbSeverity.Size = new System.Drawing.Size(172, 24);
            this.cbSeverity.TabIndex = 15;
            this.cbSeverity.Text = "3 - Medium";
            this.cbSeverity.SelectedIndexChanged += new System.EventHandler(this.cbSeverity_SelectedIndexChanged);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSelectAll.Location = new System.Drawing.Point(16, 686);
            this.btnSelectAll.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(243, 28);
            this.btnSelectAll.TabIndex = 16;
            this.btnSelectAll.Text = "De/Select All Attachements";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // cbProject
            // 
            this.cbProject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProject.FormattingEnabled = true;
            this.cbProject.Location = new System.Drawing.Point(686, 9);
            this.cbProject.Margin = new System.Windows.Forms.Padding(4);
            this.cbProject.Name = "cbProject";
            this.cbProject.Size = new System.Drawing.Size(172, 24);
            this.cbProject.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(610, 9);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Project";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabNewItem);
            this.tabControl1.Controls.Add(this.tabUpdateItem);
            this.tabControl1.Location = new System.Drawing.Point(16, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(845, 98);
            this.tabControl1.TabIndex = 19;
            // 
            // tabNewItem
            // 
            this.tabNewItem.Controls.Add(this.txtParentItem);
            this.tabNewItem.Controls.Add(this.label8);
            this.tabNewItem.Controls.Add(this.label1);
            this.tabNewItem.Controls.Add(this.cbWorkItemType);
            this.tabNewItem.Controls.Add(this.label5);
            this.tabNewItem.Controls.Add(this.cbSeverity);
            this.tabNewItem.Controls.Add(this.cbPriority);
            this.tabNewItem.Controls.Add(this.label6);
            this.tabNewItem.Location = new System.Drawing.Point(4, 25);
            this.tabNewItem.Name = "tabNewItem";
            this.tabNewItem.Padding = new System.Windows.Forms.Padding(3);
            this.tabNewItem.Size = new System.Drawing.Size(837, 69);
            this.tabNewItem.TabIndex = 0;
            this.tabNewItem.Text = "NewItem";
            this.tabNewItem.UseVisualStyleBackColor = true;
            // 
            // tabUpdateItem
            // 
            this.tabUpdateItem.Location = new System.Drawing.Point(4, 25);
            this.tabUpdateItem.Name = "tabUpdateItem";
            this.tabUpdateItem.Padding = new System.Windows.Forms.Padding(3);
            this.tabUpdateItem.Size = new System.Drawing.Size(837, 92);
            this.tabUpdateItem.TabIndex = 1;
            this.tabUpdateItem.Text = "UpdateItem";
            this.tabUpdateItem.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Parent Item Id";
            // 
            // txtParentItem
            // 
            this.txtParentItem.Location = new System.Drawing.Point(21, 26);
            this.txtParentItem.Name = "txtParentItem";
            this.txtParentItem.Size = new System.Drawing.Size(100, 22);
            this.txtParentItem.TabIndex = 17;
            this.txtParentItem.Leave += new System.EventHandler(this.txtParentItem_Leave);
            // 
            // txtParentItemDetails
            // 
            this.txtParentItemDetails.Location = new System.Drawing.Point(16, 117);
            this.txtParentItemDetails.Multiline = true;
            this.txtParentItemDetails.Name = "txtParentItemDetails";
            this.txtParentItemDetails.ReadOnly = true;
            this.txtParentItemDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtParentItemDetails.Size = new System.Drawing.Size(847, 41);
            this.txtParentItemDetails.TabIndex = 18;
            // 
            // TfsWorkItemUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 726);
            this.Controls.Add(this.txtParentItemDetails);
            this.Controls.Add(this.cbProject);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSelectAll);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSystemInformation);
            this.Controls.Add(this.chkLstBoxAttachements);
            this.Controls.Add(this.lblAttachements);
            this.Controls.Add(this.btnSaveNClose);
            this.Controls.Add(this.txtBody);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TfsWorkItemUserForm";
            this.Text = "TFS Work Item Information";
            this.tabControl1.ResumeLayout(false);
            this.tabNewItem.ResumeLayout(false);
            this.tabNewItem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cbWorkItemType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBody;
        private System.Windows.Forms.Button btnSaveNClose;
        private System.Windows.Forms.Label lblAttachements;
        private System.Windows.Forms.CheckedListBox chkLstBoxAttachements;
        private System.Windows.Forms.TextBox txtSystemInformation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbPriority;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbSeverity;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.ComboBox cbProject;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabUpdateItem;
        private System.Windows.Forms.TabPage tabNewItem;
        private System.Windows.Forms.TextBox txtParentItem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtParentItemDetails;
    }
}