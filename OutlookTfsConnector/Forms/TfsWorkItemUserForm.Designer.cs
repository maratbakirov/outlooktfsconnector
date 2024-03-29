﻿namespace OutlookTfsConnector
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
            this.txtParentItem = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabUpdateItem = new System.Windows.Forms.TabPage();
            this.txtExistingItemId = new System.Windows.Forms.TextBox();
            this.lblExistingItemId = new System.Windows.Forms.Label();
            this.txtLogMessage = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtAttachementComment = new System.Windows.Forms.TextBox();
            this.lblAttachementComment = new System.Windows.Forms.Label();
            this.pbDonate = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabNewItem.SuspendLayout();
            this.tabUpdateItem.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDonate)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(556, 626);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(89, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cbWorkItemType
            // 
            this.cbWorkItemType.FormattingEnabled = true;
            this.cbWorkItemType.Items.AddRange(new object[] {
            "Task",
            "Bug",
            "Feature",
            "User Story",
            "Issue"});
            this.cbWorkItemType.Location = new System.Drawing.Point(136, 21);
            this.cbWorkItemType.Name = "cbWorkItemType";
            this.cbWorkItemType.Size = new System.Drawing.Size(182, 21);
            this.cbWorkItemType.TabIndex = 1;
            this.cbWorkItemType.Text = "Task";
            this.cbWorkItemType.SelectedIndexChanged += new System.EventHandler(this.cbWorkItemType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Work Item Type *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Title *";
            // 
            // txtTitle
            // 
            this.txtTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTitle.Location = new System.Drawing.Point(12, 181);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(634, 20);
            this.txtTitle.TabIndex = 4;
            this.txtTitle.TextChanged += new System.EventHandler(this.txtTitle_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Body *";
            // 
            // txtBody
            // 
            this.txtBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBody.Location = new System.Drawing.Point(12, 228);
            this.txtBody.Multiline = true;
            this.txtBody.Name = "txtBody";
            this.txtBody.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBody.Size = new System.Drawing.Size(438, 192);
            this.txtBody.TabIndex = 6;
            this.txtBody.TextChanged += new System.EventHandler(this.txtBody_TextChanged);
            // 
            // btnSaveNClose
            // 
            this.btnSaveNClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveNClose.Enabled = false;
            this.btnSaveNClose.Location = new System.Drawing.Point(347, 626);
            this.btnSaveNClose.Name = "btnSaveNClose";
            this.btnSaveNClose.Size = new System.Drawing.Size(91, 23);
            this.btnSaveNClose.TabIndex = 7;
            this.btnSaveNClose.Text = "Save && Close";
            this.btnSaveNClose.UseVisualStyleBackColor = true;
            this.btnSaveNClose.Click += new System.EventHandler(this.btnSaveNClose_Click);
            // 
            // lblAttachements
            // 
            this.lblAttachements.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAttachements.AutoSize = true;
            this.lblAttachements.Location = new System.Drawing.Point(10, 429);
            this.lblAttachements.Name = "lblAttachements";
            this.lblAttachements.Size = new System.Drawing.Size(72, 13);
            this.lblAttachements.TabIndex = 8;
            this.lblAttachements.Text = "Attachments: ";
            // 
            // chkLstBoxAttachements
            // 
            this.chkLstBoxAttachements.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkLstBoxAttachements.FormattingEnabled = true;
            this.chkLstBoxAttachements.Location = new System.Drawing.Point(12, 451);
            this.chkLstBoxAttachements.Name = "chkLstBoxAttachements";
            this.chkLstBoxAttachements.ScrollAlwaysVisible = true;
            this.chkLstBoxAttachements.Size = new System.Drawing.Size(285, 124);
            this.chkLstBoxAttachements.TabIndex = 9;
            this.chkLstBoxAttachements.SelectedIndexChanged += new System.EventHandler(this.chkLstBoxAttachements_SelectedIndexChanged);
            // 
            // txtSystemInformation
            // 
            this.txtSystemInformation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSystemInformation.Location = new System.Drawing.Point(475, 228);
            this.txtSystemInformation.Multiline = true;
            this.txtSystemInformation.Name = "txtSystemInformation";
            this.txtSystemInformation.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSystemInformation.Size = new System.Drawing.Size(183, 192);
            this.txtSystemInformation.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(478, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "System Information";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(357, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Priority *";
            // 
            // cbPriority
            // 
            this.cbPriority.FormattingEnabled = true;
            this.cbPriority.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbPriority.Location = new System.Drawing.Point(360, 21);
            this.cbPriority.Name = "cbPriority";
            this.cbPriority.Size = new System.Drawing.Size(73, 21);
            this.cbPriority.TabIndex = 13;
            this.cbPriority.Text = "1";
            this.cbPriority.SelectedIndexChanged += new System.EventHandler(this.cbPriority_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(451, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Severity *";
            // 
            // cbSeverity
            // 
            this.cbSeverity.FormattingEnabled = true;
            this.cbSeverity.Items.AddRange(new object[] {
            "1 - Critical",
            "2 - High",
            "3 - Medium",
            "4 - Low"});
            this.cbSeverity.Location = new System.Drawing.Point(454, 21);
            this.cbSeverity.Name = "cbSeverity";
            this.cbSeverity.Size = new System.Drawing.Size(130, 21);
            this.cbSeverity.TabIndex = 15;
            this.cbSeverity.Text = "3 - Medium";
            this.cbSeverity.SelectedIndexChanged += new System.EventHandler(this.cbSeverity_SelectedIndexChanged);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSelectAll.Location = new System.Drawing.Point(12, 626);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(154, 23);
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
            this.cbProject.Location = new System.Drawing.Point(514, 7);
            this.cbProject.Name = "cbProject";
            this.cbProject.Size = new System.Drawing.Size(130, 21);
            this.cbProject.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(458, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Project";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabNewItem);
            this.tabControl1.Controls.Add(this.tabUpdateItem);
            this.tabControl1.Location = new System.Drawing.Point(12, 11);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(634, 93);
            this.tabControl1.TabIndex = 19;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabNewItem
            // 
            this.tabNewItem.AutoScroll = true;
            this.tabNewItem.Controls.Add(this.txtParentItem);
            this.tabNewItem.Controls.Add(this.label8);
            this.tabNewItem.Controls.Add(this.label1);
            this.tabNewItem.Controls.Add(this.cbWorkItemType);
            this.tabNewItem.Controls.Add(this.label5);
            this.tabNewItem.Controls.Add(this.cbSeverity);
            this.tabNewItem.Controls.Add(this.cbPriority);
            this.tabNewItem.Controls.Add(this.label6);
            this.tabNewItem.Location = new System.Drawing.Point(4, 22);
            this.tabNewItem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabNewItem.Name = "tabNewItem";
            this.tabNewItem.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabNewItem.Size = new System.Drawing.Size(626, 67);
            this.tabNewItem.TabIndex = 0;
            this.tabNewItem.Text = "NewItem";
            this.tabNewItem.UseVisualStyleBackColor = true;
            // 
            // txtParentItem
            // 
            this.txtParentItem.Location = new System.Drawing.Point(16, 21);
            this.txtParentItem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtParentItem.Name = "txtParentItem";
            this.txtParentItem.Size = new System.Drawing.Size(76, 20);
            this.txtParentItem.TabIndex = 17;
            this.txtParentItem.Leave += new System.EventHandler(this.txtParentItem_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 2);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Parent Item Id";
            // 
            // tabUpdateItem
            // 
            this.tabUpdateItem.AutoScroll = true;
            this.tabUpdateItem.Controls.Add(this.txtExistingItemId);
            this.tabUpdateItem.Controls.Add(this.lblExistingItemId);
            this.tabUpdateItem.Location = new System.Drawing.Point(4, 22);
            this.tabUpdateItem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabUpdateItem.Name = "tabUpdateItem";
            this.tabUpdateItem.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabUpdateItem.Size = new System.Drawing.Size(626, 67);
            this.tabUpdateItem.TabIndex = 1;
            this.tabUpdateItem.Text = "UpdateItem";
            this.tabUpdateItem.UseVisualStyleBackColor = true;
            // 
            // txtExistingItemId
            // 
            this.txtExistingItemId.Location = new System.Drawing.Point(13, 28);
            this.txtExistingItemId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtExistingItemId.Name = "txtExistingItemId";
            this.txtExistingItemId.Size = new System.Drawing.Size(76, 20);
            this.txtExistingItemId.TabIndex = 19;
            this.txtExistingItemId.Leave += new System.EventHandler(this.txtExistingItemId_Leave);
            // 
            // lblExistingItemId
            // 
            this.lblExistingItemId.AutoSize = true;
            this.lblExistingItemId.Location = new System.Drawing.Point(11, 10);
            this.lblExistingItemId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExistingItemId.Name = "lblExistingItemId";
            this.lblExistingItemId.Size = new System.Drawing.Size(78, 13);
            this.lblExistingItemId.TabIndex = 18;
            this.lblExistingItemId.Text = "Existing Item Id";
            // 
            // txtLogMessage
            // 
            this.txtLogMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLogMessage.Location = new System.Drawing.Point(12, 109);
            this.txtLogMessage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLogMessage.Multiline = true;
            this.txtLogMessage.Name = "txtLogMessage";
            this.txtLogMessage.ReadOnly = true;
            this.txtLogMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLogMessage.Size = new System.Drawing.Size(636, 49);
            this.txtLogMessage.TabIndex = 18;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(452, 626);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(91, 23);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(325, 451);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(323, 156);
            this.panel1.TabIndex = 21;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(14, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(374, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtAttachementComment
            // 
            this.txtAttachementComment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtAttachementComment.Location = new System.Drawing.Point(9, 601);
            this.txtAttachementComment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAttachementComment.Name = "txtAttachementComment";
            this.txtAttachementComment.Size = new System.Drawing.Size(288, 20);
            this.txtAttachementComment.TabIndex = 22;
            // 
            // lblAttachementComment
            // 
            this.lblAttachementComment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAttachementComment.AutoSize = true;
            this.lblAttachementComment.Location = new System.Drawing.Point(9, 583);
            this.lblAttachementComment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAttachementComment.Name = "lblAttachementComment";
            this.lblAttachementComment.Size = new System.Drawing.Size(113, 13);
            this.lblAttachementComment.TabIndex = 23;
            this.lblAttachementComment.Text = "Attachments Comment";
            // 
            // pbDonate
            // 
            this.pbDonate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbDonate.Image = global::OutlookTfsConnector.Properties.Resources.btn_donateCC_LG_1_;
            this.pbDonate.ImageLocation = "";
            this.pbDonate.InitialImage = global::OutlookTfsConnector.Properties.Resources.btn_donateCC_LG_1_;
            this.pbDonate.Location = new System.Drawing.Point(194, 626);
            this.pbDonate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbDonate.Name = "pbDonate";
            this.pbDonate.Size = new System.Drawing.Size(71, 22);
            this.pbDonate.TabIndex = 24;
            this.pbDonate.TabStop = false;
            this.pbDonate.Click += new System.EventHandler(this.pbDonate_Click);
            // 
            // TfsWorkItemUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 658);
            this.Controls.Add(this.pbDonate);
            this.Controls.Add(this.lblAttachementComment);
            this.Controls.Add(this.txtAttachementComment);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtLogMessage);
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
            this.Name = "TfsWorkItemUserForm";
            this.Text = "TFS Work Item Information";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TfsWorkItemUserForm_FormClosed);
            this.tabControl1.ResumeLayout(false);
            this.tabNewItem.ResumeLayout(false);
            this.tabNewItem.PerformLayout();
            this.tabUpdateItem.ResumeLayout(false);
            this.tabUpdateItem.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDonate)).EndInit();
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
        private System.Windows.Forms.TextBox txtLogMessage;
        private System.Windows.Forms.TextBox txtExistingItemId;
        private System.Windows.Forms.Label lblExistingItemId;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtAttachementComment;
        private System.Windows.Forms.Label lblAttachementComment;
        private System.Windows.Forms.PictureBox pbDonate;
    }
}