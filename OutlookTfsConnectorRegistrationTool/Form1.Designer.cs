namespace OutlookTfsConnectorRegistrationTool
{
    partial class Form1
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
            this.btRegister = new System.Windows.Forms.Button();
            this.btUnregister = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btRegister
            // 
            this.btRegister.Location = new System.Drawing.Point(35, 79);
            this.btRegister.Name = "btRegister";
            this.btRegister.Size = new System.Drawing.Size(166, 58);
            this.btRegister.TabIndex = 0;
            this.btRegister.Text = "Register";
            this.btRegister.UseVisualStyleBackColor = true;
            this.btRegister.Click += new System.EventHandler(this.btRegister_Click);
            // 
            // btUnregister
            // 
            this.btUnregister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btUnregister.Location = new System.Drawing.Point(256, 79);
            this.btUnregister.Name = "btUnregister";
            this.btUnregister.Size = new System.Drawing.Size(166, 58);
            this.btUnregister.TabIndex = 1;
            this.btUnregister.Text = "Unregister";
            this.btUnregister.UseVisualStyleBackColor = true;
            this.btUnregister.Click += new System.EventHandler(this.btUnregister_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(35, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Outlook TFS Connector Registration Tool";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 196);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btUnregister);
            this.Controls.Add(this.btRegister);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btRegister;
        private System.Windows.Forms.Button btUnregister;
        private System.Windows.Forms.Label label1;
    }
}

