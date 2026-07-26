namespace Course14
{
    partial class frmChkRadioGroup
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
            this.chkRecieveEmails = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkRecieveEmails
            // 
            this.chkRecieveEmails.AutoSize = true;
            this.chkRecieveEmails.Location = new System.Drawing.Point(73, 95);
            this.chkRecieveEmails.Name = "chkRecieveEmails";
            this.chkRecieveEmails.Size = new System.Drawing.Size(214, 20);
            this.chkRecieveEmails.TabIndex = 0;
            this.chkRecieveEmails.Text = "Do you want to recieve emails?";
            this.chkRecieveEmails.UseVisualStyleBackColor = true;
            this.chkRecieveEmails.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(73, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 83);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmChkRadioGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chkRecieveEmails);
            this.Name = "frmChkRadioGroup";
            this.Text = "frmChkRadioGroup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkRecieveEmails;
        private System.Windows.Forms.Button button1;
    }
}