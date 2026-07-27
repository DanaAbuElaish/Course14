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
            this.groupBoxSize = new System.Windows.Forms.GroupBox();
            this.rbThinCrust = new System.Windows.Forms.RadioButton();
            this.rbThinkCrust = new System.Windows.Forms.RadioButton();
            this.groupBoxCrustType = new System.Windows.Forms.GroupBox();
            this.groupBoxToppings = new System.Windows.Forms.GroupBox();
            this.checkBoxGreenPeppers = new System.Windows.Forms.CheckBox();
            this.checkBoxOlives = new System.Windows.Forms.CheckBox();
            this.checkBoxOnion = new System.Windows.Forms.CheckBox();
            this.checkBoxTomatoes = new System.Windows.Forms.CheckBox();
            this.checkBoxMushrooms = new System.Windows.Forms.CheckBox();
            this.checkBoxExtraCheese = new System.Windows.Forms.CheckBox();
            this.groupBoxWhereToEat = new System.Windows.Forms.GroupBox();
            this.radioButtonResetForm = new System.Windows.Forms.RadioButton();
            this.radioButtonEatIn = new System.Windows.Forms.RadioButton();
            this.btnOrderPizza = new System.Windows.Forms.Button();
            this.btnEsetForm = new System.Windows.Forms.Button();
            this.groupBoxOrderSummary = new System.Windows.Forms.GroupBox();
            this.lblToppingsOnOrderSummary = new System.Windows.Forms.Label();
            this.lblWhereToEatOnOrderSummary = new System.Windows.Forms.Label();
            this.lblCrustTypeOnOrderSummary = new System.Windows.Forms.Label();
            this.lblSizeOnOrderSummary = new System.Windows.Forms.Label();
            this.lblWhereToEat = new System.Windows.Forms.Label();
            this.lblCrustType = new System.Windows.Forms.Label();
            this.lblToppings = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblTotalPriceOnOrderSummary = new System.Windows.Forms.Label();
            this.groupBoxSize.SuspendLayout();
            this.groupBoxCrustType.SuspendLayout();
            this.groupBoxToppings.SuspendLayout();
            this.groupBoxWhereToEat.SuspendLayout();
            this.groupBoxOrderSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMakeYourPizza
            // 
            this.lblMakeYourPizza.AutoSize = true;
            this.lblMakeYourPizza.Font = new System.Drawing.Font("Georgia", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMakeYourPizza.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMakeYourPizza.Location = new System.Drawing.Point(173, 19);
            this.lblMakeYourPizza.Name = "lblMakeYourPizza";
            this.lblMakeYourPizza.Size = new System.Drawing.Size(546, 69);
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
            this.rbSmall.CheckedChanged += new System.EventHandler(this.rbSmall_CheckedChanged);
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
            this.rbMeduim.CheckedChanged += new System.EventHandler(this.rbMeduim_CheckedChanged);
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
            this.rbLarge.CheckedChanged += new System.EventHandler(this.rbLarge_CheckedChanged);
            // 
            // groupBoxSize
            // 
            this.groupBoxSize.Controls.Add(this.rbSmall);
            this.groupBoxSize.Controls.Add(this.rbLarge);
            this.groupBoxSize.Controls.Add(this.rbMeduim);
            this.groupBoxSize.Location = new System.Drawing.Point(27, 103);
            this.groupBoxSize.Name = "groupBoxSize";
            this.groupBoxSize.Size = new System.Drawing.Size(152, 146);
            this.groupBoxSize.TabIndex = 9;
            this.groupBoxSize.TabStop = false;
            this.groupBoxSize.Text = "Size";
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
            this.rbThinCrust.CheckedChanged += new System.EventHandler(this.rbThinCrust_CheckedChanged);
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
            this.rbThinkCrust.CheckedChanged += new System.EventHandler(this.rbThinkCrust_CheckedChanged);
            // 
            // groupBoxCrustType
            // 
            this.groupBoxCrustType.Controls.Add(this.rbThinCrust);
            this.groupBoxCrustType.Controls.Add(this.rbThinkCrust);
            this.groupBoxCrustType.Location = new System.Drawing.Point(27, 276);
            this.groupBoxCrustType.Name = "groupBoxCrustType";
            this.groupBoxCrustType.Size = new System.Drawing.Size(152, 146);
            this.groupBoxCrustType.TabIndex = 10;
            this.groupBoxCrustType.TabStop = false;
            this.groupBoxCrustType.Text = "Crust Type";
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
            // checkBoxGreenPeppers
            // 
            this.checkBoxGreenPeppers.AutoSize = true;
            this.checkBoxGreenPeppers.Location = new System.Drawing.Point(140, 106);
            this.checkBoxGreenPeppers.Name = "checkBoxGreenPeppers";
            this.checkBoxGreenPeppers.Size = new System.Drawing.Size(121, 20);
            this.checkBoxGreenPeppers.TabIndex = 25;
            this.checkBoxGreenPeppers.Text = "Green Peppers";
            this.checkBoxGreenPeppers.UseVisualStyleBackColor = true;
            this.checkBoxGreenPeppers.CheckedChanged += new System.EventHandler(this.checkBoxGreenPeppers_CheckedChanged);
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
            this.checkBoxOlives.CheckedChanged += new System.EventHandler(this.checkBoxOlives_CheckedChanged);
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
            this.checkBoxOnion.CheckedChanged += new System.EventHandler(this.checkBoxOnion_CheckedChanged);
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
            this.checkBoxTomatoes.CheckedChanged += new System.EventHandler(this.checkBoxTomatoes_CheckedChanged);
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
            this.checkBoxMushrooms.CheckedChanged += new System.EventHandler(this.checkBoxMushrooms_CheckedChanged);
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
            this.checkBoxExtraCheese.CheckedChanged += new System.EventHandler(this.checkBoxExtraCheese_CheckedChanged);
            // 
            // groupBoxWhereToEat
            // 
            this.groupBoxWhereToEat.Controls.Add(this.radioButtonResetForm);
            this.groupBoxWhereToEat.Controls.Add(this.radioButtonEatIn);
            this.groupBoxWhereToEat.Location = new System.Drawing.Point(306, 276);
            this.groupBoxWhereToEat.Name = "groupBoxWhereToEat";
            this.groupBoxWhereToEat.Size = new System.Drawing.Size(223, 74);
            this.groupBoxWhereToEat.TabIndex = 20;
            this.groupBoxWhereToEat.TabStop = false;
            this.groupBoxWhereToEat.Text = "Where To Eat";
            // 
            // radioButtonResetForm
            // 
            this.radioButtonResetForm.AutoSize = true;
            this.radioButtonResetForm.Location = new System.Drawing.Point(107, 35);
            this.radioButtonResetForm.Name = "radioButtonResetForm";
            this.radioButtonResetForm.Size = new System.Drawing.Size(98, 20);
            this.radioButtonResetForm.TabIndex = 21;
            this.radioButtonResetForm.TabStop = true;
            this.radioButtonResetForm.Text = "Reset Form";
            this.radioButtonResetForm.UseVisualStyleBackColor = true;
            this.radioButtonResetForm.CheckedChanged += new System.EventHandler(this.radioButtonResetForm_CheckedChanged);
            // 
            // radioButtonEatIn
            // 
            this.radioButtonEatIn.AutoSize = true;
            this.radioButtonEatIn.Location = new System.Drawing.Point(11, 35);
            this.radioButtonEatIn.Name = "radioButtonEatIn";
            this.radioButtonEatIn.Size = new System.Drawing.Size(61, 20);
            this.radioButtonEatIn.TabIndex = 20;
            this.radioButtonEatIn.TabStop = true;
            this.radioButtonEatIn.Text = "Eat In";
            this.radioButtonEatIn.UseVisualStyleBackColor = true;
            this.radioButtonEatIn.CheckedChanged += new System.EventHandler(this.radioButtonEatIn_CheckedChanged);
            // 
            // btnOrderPizza
            // 
            this.btnOrderPizza.Location = new System.Drawing.Point(317, 383);
            this.btnOrderPizza.Name = "btnOrderPizza";
            this.btnOrderPizza.Size = new System.Drawing.Size(109, 39);
            this.btnOrderPizza.TabIndex = 21;
            this.btnOrderPizza.Text = "Order Pizza";
            this.btnOrderPizza.UseVisualStyleBackColor = true;
            this.btnOrderPizza.Click += new System.EventHandler(this.btnOrderPizza_Click);
            // 
            // btnEsetForm
            // 
            this.btnEsetForm.Location = new System.Drawing.Point(458, 383);
            this.btnEsetForm.Name = "btnEsetForm";
            this.btnEsetForm.Size = new System.Drawing.Size(109, 39);
            this.btnEsetForm.TabIndex = 22;
            this.btnEsetForm.Text = "Reset Form";
            this.btnEsetForm.UseVisualStyleBackColor = true;
            this.btnEsetForm.Click += new System.EventHandler(this.btnEsetForm_Click);
            // 
            // groupBoxOrderSummary
            // 
            this.groupBoxOrderSummary.Controls.Add(this.lblTotalPriceOnOrderSummary);
            this.groupBoxOrderSummary.Controls.Add(this.lblTotalPrice);
            this.groupBoxOrderSummary.Controls.Add(this.lblToppingsOnOrderSummary);
            this.groupBoxOrderSummary.Controls.Add(this.lblWhereToEatOnOrderSummary);
            this.groupBoxOrderSummary.Controls.Add(this.lblCrustTypeOnOrderSummary);
            this.groupBoxOrderSummary.Controls.Add(this.lblSizeOnOrderSummary);
            this.groupBoxOrderSummary.Controls.Add(this.lblWhereToEat);
            this.groupBoxOrderSummary.Controls.Add(this.lblCrustType);
            this.groupBoxOrderSummary.Controls.Add(this.lblToppings);
            this.groupBoxOrderSummary.Controls.Add(this.lblSize);
            this.groupBoxOrderSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxOrderSummary.Location = new System.Drawing.Point(635, 111);
            this.groupBoxOrderSummary.Name = "groupBoxOrderSummary";
            this.groupBoxOrderSummary.Size = new System.Drawing.Size(518, 265);
            this.groupBoxOrderSummary.TabIndex = 32;
            this.groupBoxOrderSummary.TabStop = false;
            this.groupBoxOrderSummary.Text = "Order Summary";
            this.groupBoxOrderSummary.Enter += new System.EventHandler(this.groupBoxOrderSummary_Enter);
            // 
            // lblToppingsOnOrderSummary
            // 
            this.lblToppingsOnOrderSummary.AutoSize = true;
            this.lblToppingsOnOrderSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToppingsOnOrderSummary.Location = new System.Drawing.Point(54, 86);
            this.lblToppingsOnOrderSummary.Name = "lblToppingsOnOrderSummary";
            this.lblToppingsOnOrderSummary.Size = new System.Drawing.Size(44, 16);
            this.lblToppingsOnOrderSummary.TabIndex = 26;
            this.lblToppingsOnOrderSummary.Text = "label1";
            // 
            // lblWhereToEatOnOrderSummary
            // 
            this.lblWhereToEatOnOrderSummary.AutoSize = true;
            this.lblWhereToEatOnOrderSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhereToEatOnOrderSummary.Location = new System.Drawing.Point(112, 155);
            this.lblWhereToEatOnOrderSummary.Name = "lblWhereToEatOnOrderSummary";
            this.lblWhereToEatOnOrderSummary.Size = new System.Drawing.Size(44, 16);
            this.lblWhereToEatOnOrderSummary.TabIndex = 12;
            this.lblWhereToEatOnOrderSummary.Text = "label1";
            // 
            // lblCrustTypeOnOrderSummary
            // 
            this.lblCrustTypeOnOrderSummary.AutoSize = true;
            this.lblCrustTypeOnOrderSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrustTypeOnOrderSummary.Location = new System.Drawing.Point(89, 118);
            this.lblCrustTypeOnOrderSummary.Name = "lblCrustTypeOnOrderSummary";
            this.lblCrustTypeOnOrderSummary.Size = new System.Drawing.Size(44, 16);
            this.lblCrustTypeOnOrderSummary.TabIndex = 8;
            this.lblCrustTypeOnOrderSummary.Text = "label1";
            // 
            // lblSizeOnOrderSummary
            // 
            this.lblSizeOnOrderSummary.AutoSize = true;
            this.lblSizeOnOrderSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSizeOnOrderSummary.Location = new System.Drawing.Point(66, 41);
            this.lblSizeOnOrderSummary.Name = "lblSizeOnOrderSummary";
            this.lblSizeOnOrderSummary.Size = new System.Drawing.Size(44, 16);
            this.lblSizeOnOrderSummary.TabIndex = 33;
            this.lblSizeOnOrderSummary.Text = "label1";
            // 
            // lblWhereToEat
            // 
            this.lblWhereToEat.AutoSize = true;
            this.lblWhereToEat.Location = new System.Drawing.Point(25, 139);
            this.lblWhereToEat.Name = "lblWhereToEat";
            this.lblWhereToEat.Size = new System.Drawing.Size(108, 16);
            this.lblWhereToEat.TabIndex = 35;
            this.lblWhereToEat.Text = "Where to Eat : ";
            // 
            // lblCrustType
            // 
            this.lblCrustType.AutoSize = true;
            this.lblCrustType.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrustType.Location = new System.Drawing.Point(25, 102);
            this.lblCrustType.Name = "lblCrustType";
            this.lblCrustType.Size = new System.Drawing.Size(94, 16);
            this.lblCrustType.TabIndex = 34;
            this.lblCrustType.Text = "Crust Type : ";
            // 
            // lblToppings
            // 
            this.lblToppings.AutoSize = true;
            this.lblToppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToppings.Location = new System.Drawing.Point(25, 63);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(85, 16);
            this.lblToppings.TabIndex = 33;
            this.lblToppings.Text = "Toppings : ";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.Location = new System.Drawing.Point(25, 25);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(49, 16);
            this.lblSize.TabIndex = 32;
            this.lblSize.Text = "Size : ";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(25, 187);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(95, 16);
            this.lblTotalPrice.TabIndex = 37;
            this.lblTotalPrice.Text = "Total Price : ";
            // 
            // lblTotalPriceOnOrderSummary
            // 
            this.lblTotalPriceOnOrderSummary.AutoSize = true;
            this.lblTotalPriceOnOrderSummary.Font = new System.Drawing.Font("Segoe Print", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPriceOnOrderSummary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblTotalPriceOnOrderSummary.Location = new System.Drawing.Point(126, 187);
            this.lblTotalPriceOnOrderSummary.Name = "lblTotalPriceOnOrderSummary";
            this.lblTotalPriceOnOrderSummary.Size = new System.Drawing.Size(48, 65);
            this.lblTotalPriceOnOrderSummary.TabIndex = 33;
            this.lblTotalPriceOnOrderSummary.Text = "$";
            // 
            // Pizza_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 450);
            this.Controls.Add(this.groupBoxOrderSummary);
            this.Controls.Add(this.btnEsetForm);
            this.Controls.Add(this.btnOrderPizza);
            this.Controls.Add(this.groupBoxWhereToEat);
            this.Controls.Add(this.groupBoxToppings);
            this.Controls.Add(this.groupBoxCrustType);
            this.Controls.Add(this.groupBoxSize);
            this.Controls.Add(this.lblMakeYourPizza);
            this.Name = "Pizza_Order";
            this.Text = "Pizza Order";
            this.groupBoxSize.ResumeLayout(false);
            this.groupBoxSize.PerformLayout();
            this.groupBoxCrustType.ResumeLayout(false);
            this.groupBoxCrustType.PerformLayout();
            this.groupBoxToppings.ResumeLayout(false);
            this.groupBoxToppings.PerformLayout();
            this.groupBoxWhereToEat.ResumeLayout(false);
            this.groupBoxWhereToEat.PerformLayout();
            this.groupBoxOrderSummary.ResumeLayout(false);
            this.groupBoxOrderSummary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMakeYourPizza;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.RadioButton rbMeduim;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.GroupBox groupBoxSize;
        private System.Windows.Forms.RadioButton rbThinCrust;
        private System.Windows.Forms.RadioButton rbThinkCrust;
        private System.Windows.Forms.GroupBox groupBoxCrustType;
        private System.Windows.Forms.GroupBox groupBoxToppings;
        private System.Windows.Forms.CheckBox checkBoxGreenPeppers;
        private System.Windows.Forms.CheckBox checkBoxOlives;
        private System.Windows.Forms.CheckBox checkBoxOnion;
        private System.Windows.Forms.CheckBox checkBoxTomatoes;
        private System.Windows.Forms.CheckBox checkBoxMushrooms;
        private System.Windows.Forms.CheckBox checkBoxExtraCheese;
        private System.Windows.Forms.GroupBox groupBoxWhereToEat;
        private System.Windows.Forms.RadioButton radioButtonResetForm;
        private System.Windows.Forms.RadioButton radioButtonEatIn;
        private System.Windows.Forms.Button btnOrderPizza;
        private System.Windows.Forms.Button btnEsetForm;
        private System.Windows.Forms.GroupBox groupBoxOrderSummary;
        private System.Windows.Forms.Label lblWhereToEat;
        private System.Windows.Forms.Label lblCrustType;
        private System.Windows.Forms.Label lblToppings;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblSizeOnOrderSummary;
        private System.Windows.Forms.Label lblCrustTypeOnOrderSummary;
        private System.Windows.Forms.Label lblToppingsOnOrderSummary;
        private System.Windows.Forms.Label lblWhereToEatOnOrderSummary;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblTotalPriceOnOrderSummary;
    }
}