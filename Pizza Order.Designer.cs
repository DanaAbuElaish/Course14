namespace Course14
{
    partial class Pizza_Order
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
            this.lblMakeYourPizza = new System.Windows.Forms.Label();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.rbMeduim = new System.Windows.Forms.RadioButton();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.rbThinCust = new System.Windows.Forms.RadioButton();
            this.rbThinkCust = new System.Windows.Forms.RadioButton();
            this.gbSize.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMakeYourPizza
            // 
            this.lblMakeYourPizza.AutoSize = true;
            this.lblMakeYourPizza.Location = new System.Drawing.Point(303, 33);
            this.lblMakeYourPizza.Name = "lblMakeYourPizza";
            this.lblMakeYourPizza.Size = new System.Drawing.Size(107, 16);
            this.lblMakeYourPizza.TabIndex = 3;
            this.lblMakeYourPizza.Text = "Make Your Pizza";
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Location = new System.Drawing.Point(42, 31);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(62, 20);
            this.rbSmall.TabIndex = 5;
            this.rbSmall.TabStop = true;
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = true;
            // 
            // rbMeduim
            // 
            this.rbMeduim.AutoSize = true;
            this.rbMeduim.Location = new System.Drawing.Point(42, 71);
            this.rbMeduim.Name = "rbMeduim";
            this.rbMeduim.Size = new System.Drawing.Size(76, 20);
            this.rbMeduim.TabIndex = 6;
            this.rbMeduim.TabStop = true;
            this.rbMeduim.Text = "Meduim";
            this.rbMeduim.UseVisualStyleBackColor = true;
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.Location = new System.Drawing.Point(42, 109);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(63, 20);
            this.rbLarge.TabIndex = 7;
            this.rbLarge.TabStop = true;
            this.rbLarge.Text = "Large";
            this.rbLarge.UseVisualStyleBackColor = true;
            // 
            // gbSize
            // 
            this.gbSize.Controls.Add(this.rbSmall);
            this.gbSize.Controls.Add(this.rbLarge);
            this.gbSize.Controls.Add(this.rbMeduim);
            this.gbSize.Location = new System.Drawing.Point(27, 103);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(152, 146);
            this.gbSize.TabIndex = 9;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Size";
            // 
            // rbThinCust
            // 
            this.rbThinCust.AutoSize = true;
            this.rbThinCust.Location = new System.Drawing.Point(83, 329);
            this.rbThinCust.Name = "rbThinCust";
            this.rbThinCust.Size = new System.Drawing.Size(83, 20);
            this.rbThinCust.TabIndex = 10;
            this.rbThinCust.TabStop = true;
            this.rbThinCust.Text = "Thin Cust";
            this.rbThinCust.UseVisualStyleBackColor = true;
            // 
            // rbThinkCust
            // 
            this.rbThinkCust.AutoSize = true;
            this.rbThinkCust.Location = new System.Drawing.Point(83, 355);
            this.rbThinkCust.Name = "rbThinkCust";
            this.rbThinkCust.Size = new System.Drawing.Size(90, 20);
            this.rbThinkCust.TabIndex = 11;
            this.rbThinkCust.TabStop = true;
            this.rbThinkCust.Text = "Think Cust";
            this.rbThinkCust.UseVisualStyleBackColor = true;
            // 
            // Pizza_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rbThinkCust);
            this.Controls.Add(this.rbThinCust);
            this.Controls.Add(this.gbSize);
            this.Controls.Add(this.lblMakeYourPizza);
            this.Name = "Pizza_Order";
            this.Text = "Pizza Order";
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMakeYourPizza;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.RadioButton rbMeduim;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.RadioButton rbThinCust;
        private System.Windows.Forms.RadioButton rbThinkCust;
    }
}