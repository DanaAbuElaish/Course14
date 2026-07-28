namespace Course14
{
    partial class PictureBoxExerxise
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.radioButtonBoy = new System.Windows.Forms.RadioButton();
            this.radioButtonGirl = new System.Windows.Forms.RadioButton();
            this.radioButtonBook = new System.Windows.Forms.RadioButton();
            this.radioButtonPen = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Monotype Corsiva", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelTitle.Location = new System.Drawing.Point(338, -5);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(178, 97);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Title";
            // 
            // radioButtonBoy
            // 
            this.radioButtonBoy.AutoSize = true;
            this.radioButtonBoy.Location = new System.Drawing.Point(182, 392);
            this.radioButtonBoy.Name = "radioButtonBoy";
            this.radioButtonBoy.Size = new System.Drawing.Size(52, 20);
            this.radioButtonBoy.TabIndex = 1;
            this.radioButtonBoy.TabStop = true;
            this.radioButtonBoy.Text = "Boy";
            this.radioButtonBoy.UseVisualStyleBackColor = true;
            // 
            // radioButtonGirl
            // 
            this.radioButtonGirl.AutoSize = true;
            this.radioButtonGirl.Location = new System.Drawing.Point(313, 392);
            this.radioButtonGirl.Name = "radioButtonGirl";
            this.radioButtonGirl.Size = new System.Drawing.Size(48, 20);
            this.radioButtonGirl.TabIndex = 2;
            this.radioButtonGirl.TabStop = true;
            this.radioButtonGirl.Text = "Girl";
            this.radioButtonGirl.UseVisualStyleBackColor = true;
            // 
            // radioButtonBook
            // 
            this.radioButtonBook.AutoSize = true;
            this.radioButtonBook.Location = new System.Drawing.Point(466, 392);
            this.radioButtonBook.Name = "radioButtonBook";
            this.radioButtonBook.Size = new System.Drawing.Size(60, 20);
            this.radioButtonBook.TabIndex = 3;
            this.radioButtonBook.TabStop = true;
            this.radioButtonBook.Text = "Book";
            this.radioButtonBook.UseVisualStyleBackColor = true;
            // 
            // radioButtonPen
            // 
            this.radioButtonPen.AutoSize = true;
            this.radioButtonPen.Location = new System.Drawing.Point(626, 392);
            this.radioButtonPen.Name = "radioButtonPen";
            this.radioButtonPen.Size = new System.Drawing.Size(52, 20);
            this.radioButtonPen.TabIndex = 4;
            this.radioButtonPen.TabStop = true;
            this.radioButtonPen.Text = "Pen";
            this.radioButtonPen.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(202, 95);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(435, 263);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // PictureBoxExerxise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 495);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.radioButtonPen);
            this.Controls.Add(this.radioButtonBook);
            this.Controls.Add(this.radioButtonGirl);
            this.Controls.Add(this.radioButtonBoy);
            this.Controls.Add(this.labelTitle);
            this.Name = "PictureBoxExerxise";
            this.Text = "PictureBoxExerxise";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.RadioButton radioButtonBoy;
        private System.Windows.Forms.RadioButton radioButtonGirl;
        private System.Windows.Forms.RadioButton radioButtonBook;
        private System.Windows.Forms.RadioButton radioButtonPen;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}