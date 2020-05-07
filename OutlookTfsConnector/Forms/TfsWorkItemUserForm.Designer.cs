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
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(729, 631);
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
            this.cbWorkItemType.FormattingEnabled = true;
            this.cbWorkItemType.Items.AddRange(new object[] {
            "Task",
            "Bug",
            "Feature",
            "Issue"});
            this.cbWorkItemType.Location = new System.Drawing.Point(16, 34);
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
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Work Item Type *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Title *";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(16, 98);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(831, 22);
            this.txtTitle.TabIndex = 4;
            this.txtTitle.TextChanged += new System.EventHandler(this.txtTitle_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 142);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Body *";
            // 
            // txtBody
            // 
            this.txtBody.Location = new System.Drawing.Point(16, 161);
            this.txtBody.Margin = new System.Windows.Forms.Padding(4);
            this.txtBody.Multiline = true;
            this.txtBody.Name = "txtBody";
            this.txtBody.Size = new System.Drawing.Size(831, 216);
            this.txtBody.TabIndex = 6;
            this.txtBody.TextChanged += new System.EventHandler(this.txtBody_TextChanged);
            // 
            // btnSaveNClose
            // 
            this.btnSaveNClose.Location = new System.Drawing.Point(600, 631);
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
            this.lblAttachements.AutoSize = true;
            this.lblAttachements.Location = new System.Drawing.Point(12, 385);
            this.lblAttachements.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAttachements.Name = "lblAttachements";
            this.lblAttachements.Size = new System.Drawing.Size(94, 17);
            this.lblAttachements.TabIndex = 8;
            this.lblAttachements.Text = "Attachments: ";
            // 
            // chkLstBoxAttachements
            // 
            this.chkLstBoxAttachements.FormattingEnabled = true;
            this.chkLstBoxAttachements.Location = new System.Drawing.Point(16, 416);
            this.chkLstBoxAttachements.Margin = new System.Windows.Forms.Padding(4);
            this.chkLstBoxAttachements.Name = "chkLstBoxAttachements";
            this.chkLstBoxAttachements.Size = new System.Drawing.Size(379, 191);
            this.chkLstBoxAttachements.TabIndex = 9;
            // 
            // txtSystemInformation
            // 
            this.txtSystemInformation.Location = new System.Drawing.Point(424, 416);
            this.txtSystemInformation.Margin = new System.Windows.Forms.Padding(4);
            this.txtSystemInformation.Multiline = true;
            this.txtSystemInformation.Name = "txtSystemInformation";
            this.txtSystemInformation.Size = new System.Drawing.Size(423, 207);
            this.txtSystemInformation.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(420, 385);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "System Information";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(295, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
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
            this.cbPriority.Location = new System.Drawing.Point(299, 34);
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
            this.label6.Location = new System.Drawing.Point(420, 11);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
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
            this.cbSeverity.Location = new System.Drawing.Point(424, 34);
            this.cbSeverity.Margin = new System.Windows.Forms.Padding(4);
            this.cbSeverity.Name = "cbSeverity";
            this.cbSeverity.Size = new System.Drawing.Size(172, 24);
            this.cbSeverity.TabIndex = 15;
            this.cbSeverity.Text = "3 - Medium";
            this.cbSeverity.SelectedIndexChanged += new System.EventHandler(this.cbSeverity_SelectedIndexChanged);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Location = new System.Drawing.Point(16, 631);
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
            this.cbProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProject.FormattingEnabled = true;
            this.cbProject.Location = new System.Drawing.Point(657, 34);
            this.cbProject.Margin = new System.Windows.Forms.Padding(4);
            this.cbProject.Name = "cbProject";
            this.cbProject.Size = new System.Drawing.Size(172, 24);
            this.cbProject.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(654, 13);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Project";
            // 
            // TfsWorkItemUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 671);
            this.Controls.Add(this.cbProject);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSelectAll);
            this.Controls.Add(this.cbSeverity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbPriority);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSystemInformation);
            this.Controls.Add(this.chkLstBoxAttachements);
            this.Controls.Add(this.lblAttachements);
            this.Controls.Add(this.btnSaveNClose);
            this.Controls.Add(this.txtBody);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbWorkItemType);
            this.Controls.Add(this.btnClose);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TfsWorkItemUserForm";
            this.Text = "TFS Work Item Information";
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
    }
}