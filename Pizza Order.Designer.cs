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
            this.rbThinCrust = new System.Windows.Forms.RadioButton();
            this.rbThinkCrust = new System.Windows.Forms.RadioButton();
            this.gbCrustType = new System.Windows.Forms.GroupBox();
            this.groupBoxToppings = new System.Windows.Forms.GroupBox();
            this.checkBoxExtraCheese = new System.Windows.Forms.CheckBox();
            this.checkBoxMushrooms = new System.Windows.Forms.CheckBox();
            this.checkBoxGreenPeppers = new System.Windows.Forms.CheckBox();
            this.checkBoxOlives = new System.Windows.Forms.CheckBox();
            this.checkBoxOnion = new System.Windows.Forms.CheckBox();
            this.checkBoxTomatoes = new System.Windows.Forms.CheckBox();
            this.gbSize.SuspendLayout();
            this.gbCrustType.SuspendLayout();
            this.groupBoxToppings.SuspendLayout();
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
            // rbThinCrust
            // 
            this.rbThinCrust.AutoSize = true;
            this.rbThinCrust.Location = new System.Drawing.Point(32, 42);
            this.rbThinCrust.Name = "rbThinCrust";
            this.rbThinCrust.Size = new System.Drawing.Size(87, 20);
            this.rbThinCrust.TabIndex = 10;
            this.rbThinCrust.TabStop = true;
            this.rbThinCrust.Text = "Thin Crust";
            this.rbThinCrust.UseVisualStyleBackColor = true;
            // 
            // rbThinkCrust
            // 
            this.rbThinkCrust.AutoSize = true;
            this.rbThinkCrust.Location = new System.Drawing.Point(32, 80);
            this.rbThinkCrust.Name = "rbThinkCrust";
            this.rbThinkCrust.Size = new System.Drawing.Size(94, 20);
            this.rbThinkCrust.TabIndex = 11;
            this.rbThinkCrust.TabStop = true;
            this.rbThinkCrust.Text = "Think Crust";
            this.rbThinkCrust.UseVisualStyleBackColor = true;
            // 
            // gbCrustType
            // 
            this.gbCrustType.Controls.Add(this.rbThinCrust);
            this.gbCrustType.Controls.Add(this.rbThinkCrust);
            this.gbCrustType.Location = new System.Drawing.Point(27, 276);
            this.gbCrustType.Name = "gbCrustType";
            this.gbCrustType.Size = new System.Drawing.Size(152, 146);
            this.gbCrustType.TabIndex = 10;
            this.gbCrustType.TabStop = false;
            this.gbCrustType.Text = "Crust Type";
            // 
            // groupBoxToppings
            // 
            this.groupBoxToppings.Controls.Add(this.checkBoxGreenPeppers);
            this.groupBoxToppings.Controls.Add(this.checkBoxOlives);
            this.groupBoxToppings.Controls.Add(this.checkBoxOnion);
            this.groupBoxToppings.Controls.Add(this.checkBoxTomatoes);
            this.groupBoxToppings.Controls.Add(this.checkBoxMushrooms);
            this.groupBoxToppings.Controls.Add(this.checkBoxExtraCheese);
            this.groupBoxToppings.Location = new System.Drawing.Point(306, 111);
            this.groupBoxToppings.Name = "groupBoxToppings";
            this.groupBoxToppings.Size = new System.Drawing.Size(267, 138);
            this.groupBoxToppings.TabIndex = 17;
            this.groupBoxToppings.TabStop = false;
            this.groupBoxToppings.Text = "Toppings";
            // 
            // checkBoxExtraCheese
            // 
            this.checkBoxExtraCheese.AutoSize = true;
            this.checkBoxExtraCheese.Location = new System.Drawing.Point(11, 33);
            this.checkBoxExtraCheese.Name = "checkBoxExtraCheese";
            this.checkBoxExtraCheese.Size = new System.Drawing.Size(109, 20);
            this.checkBoxExtraCheese.TabIndex = 12;
            this.checkBoxExtraCheese.Text = "Extra Cheese";
            this.checkBoxExtraCheese.UseVisualStyleBackColor = true;
            // 
            // checkBoxMushrooms
            // 
            this.checkBoxMushrooms.AutoSize = true;
            this.checkBoxMushrooms.Location = new System.Drawing.Point(11, 69);
            this.checkBoxMushrooms.Name = "checkBoxMushrooms";
            this.checkBoxMushrooms.Size = new System.Drawing.Size(99, 20);
            this.checkBoxMushrooms.TabIndex = 13;
            this.checkBoxMushrooms.Text = "Mushrooms";
            this.checkBoxMushrooms.UseVisualStyleBackColor = true;
            // 
            // checkBoxGreenPeppers
            // 
            this.checkBoxGreenPeppers.AutoSize = true;
            this.checkBoxGreenPeppers.Location = new System.Drawing.Point(140, 106);
            this.checkBoxGreenPeppers.Name = "checkBoxGreenPeppers";
            this.checkBoxGreenPeppers.Size = new System.Drawing.Size(121, 20);
            this.checkBoxGreenPeppers.TabIndex = 25;
            this.checkBoxGreenPeppers.Text = "Green Peppers";
            this.checkBoxGreenPeppers.UseVisualStyleBackColor = true;
            // 
            // checkBoxOlives
            // 
            this.checkBoxOlives.AutoSize = true;
            this.checkBoxOlives.Location = new System.Drawing.Point(141, 69);
            this.checkBoxOlives.Name = "checkBoxOlives";
            this.checkBoxOlives.Size = new System.Drawing.Size(67, 20);
            this.checkBoxOlives.TabIndex = 24;
            this.checkBoxOlives.Text = "Olives";
            this.checkBoxOlives.UseVisualStyleBackColor = true;
            // 
            // checkBoxOnion
            // 
            this.checkBoxOnion.AutoSize = true;
            this.checkBoxOnion.Location = new System.Drawing.Point(141, 33);
            this.checkBoxOnion.Name = "checkBoxOnion";
            this.checkBoxOnion.Size = new System.Drawing.Size(64, 20);
            this.checkBoxOnion.TabIndex = 23;
            this.checkBoxOnion.Text = "Onion";
            this.checkBoxOnion.UseVisualStyleBackColor = true;
            // 
            // checkBoxTomatoes
            // 
            this.checkBoxTomatoes.AutoSize = true;
            this.checkBoxTomatoes.Location = new System.Drawing.Point(11, 106);
            this.checkBoxTomatoes.Name = "checkBoxTomatoes";
            this.checkBoxTomatoes.Size = new System.Drawing.Size(91, 20);
            this.checkBoxTomatoes.TabIndex = 22;
            this.checkBoxTomatoes.Text = "Tomatoes";
            this.checkBoxTomatoes.UseVisualStyleBackColor = true;
            // 
            // Pizza_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 450);
            this.Controls.Add(this.groupBoxToppings);
            this.Controls.Add(this.gbCrustType);
            this.Controls.Add(this.gbSize);
            this.Controls.Add(this.lblMakeYourPizza);
            this.Name = "Pizza_Order";
            this.Text = "Pizza Order";
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.gbCrustType.ResumeLayout(false);
            this.gbCrustType.PerformLayout();
            this.groupBoxToppings.ResumeLayout(false);
            this.groupBoxToppings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMakeYourPizza;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.RadioButton rbMeduim;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.RadioButton rbThinCrust;
        private System.Windows.Forms.RadioButton rbThinkCrust;
        private System.Windows.Forms.GroupBox gbCrustType;
        private System.Windows.Forms.GroupBox groupBoxToppings;
        private System.Windows.Forms.CheckBox checkBoxGreenPeppers;
        private System.Windows.Forms.CheckBox checkBoxOlives;
        private System.Windows.Forms.CheckBox checkBoxOnion;
        private System.Windows.Forms.CheckBox checkBoxTomatoes;
        private System.Windows.Forms.CheckBox checkBoxMushrooms;
        private System.Windows.Forms.CheckBox checkBoxExtraCheese;
    }
}