namespace OutlookTfsConnector
{
    partial class SettingsForm
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
            this.btnSaveNClose = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtRegExp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pbDonate = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDonate)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSaveNClose
            // 
            this.btnSaveNClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveNClose.Location = new System.Drawing.Point(539, 418);
            this.btnSaveNClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveNClose.Name = "btnSaveNClose";
            this.btnSaveNClose.Size = new System.Drawing.Size(121, 61);
            this.btnSaveNClose.TabIndex = 9;
            this.btnSaveNClose.Text = "Save && Close";
            this.btnSaveNClose.UseVisualStyleBackColor = true;
            this.btnSaveNClose.Click += new System.EventHandler(this.btnSaveNClose_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(668, 418);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(119, 61);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtRegExp
            // 
            this.txtRegExp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRegExp.Location = new System.Drawing.Point(26, 42);
            this.txtRegExp.Margin = new System.Windows.Forms.Padding(4);
            this.txtRegExp.Name = "txtRegExp";
            this.txtRegExp.Size = new System.Drawing.Size(745, 22);
            this.txtRegExp.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Regex Expression For The Email Subjects";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tfs Connections";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 124);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(745, 273);
            this.dataGridView1.TabIndex = 14;
            // 
            // pbDonate
            // 
            this.pbDonate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbDonate.Image = global::OutlookTfsConnector.Properties.Resources.btn_donateCC_LG_1_;
            this.pbDonate.ImageLocation = "";
            this.pbDonate.Location = new System.Drawing.Point(26, 418);
            this.pbDonate.Name = "pbDonate";
            this.pbDonate.Size = new System.Drawing.Size(186, 61);
            this.pbDonate.TabIndex = 15;
            this.pbDonate.TabStop = false;
            this.pbDonate.Click += new System.EventHandler(this.pbDonate_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 492);
            this.Controls.Add(this.pbDonate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRegExp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSaveNClose);
            this.Controls.Add(this.btnClose);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDonate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaveNClose;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtRegExp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pbDonate;
    }
}