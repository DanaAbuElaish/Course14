namespace Course14
{
    partial class MyPizzaOeder
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.groupBoxSize = new System.Windows.Forms.GroupBox();
            this.radioButtonLarge = new System.Windows.Forms.RadioButton();
            this.radioButtonMeduim = new System.Windows.Forms.RadioButton();
            this.radioButtonSmall = new System.Windows.Forms.RadioButton();
            this.groupBoxCrustType = new System.Windows.Forms.GroupBox();
            this.radioButtonThickCrust = new System.Windows.Forms.RadioButton();
            this.radioButtonThinCrust = new System.Windows.Forms.RadioButton();
            this.groupBoxWhereToEat = new System.Windows.Forms.GroupBox();
            this.radioButtonTakeOut = new System.Windows.Forms.RadioButton();
            this.radioButtonEatIn = new System.Windows.Forms.RadioButton();
            this.buttonOrderPizza = new System.Windows.Forms.Button();
            this.buttonResetForm = new System.Windows.Forms.Button();
            this.groupBoxToppings = new System.Windows.Forms.GroupBox();
            this.checkBoxGreenPeppers = new System.Windows.Forms.CheckBox();
            this.checkBoxOlives = new System.Windows.Forms.CheckBox();
            this.checkBoxOnion = new System.Windows.Forms.CheckBox();
            this.checkBoxTomatoes = new System.Windows.Forms.CheckBox();
            this.checkBoxMushrooms = new System.Windows.Forms.CheckBox();
            this.checkBoxExtraCheese = new System.Windows.Forms.CheckBox();
            this.groupBoxOrderSummary = new System.Windows.Forms.GroupBox();
            this.labelAnserTotalPrice = new System.Windows.Forms.Label();
            this.labelAnswerForWhereToEatOnOrderSummary = new System.Windows.Forms.Label();
            this.labelAnswerForCrustTypeOnOrderSummary = new System.Windows.Forms.Label();
            this.labelAnswerForToppingsOnOrderSummary = new System.Windows.Forms.Label();
            this.labelAnswerForSizeOnOrderSummary = new System.Windows.Forms.Label();
            this.labelTotalPrice = new System.Windows.Forms.Label();
            this.labelWhereToEat = new System.Windows.Forms.Label();
            this.labelCrustType = new System.Windows.Forms.Label();
            this.labelToppings = new System.Windows.Forms.Label();
            this.labelSize = new System.Windows.Forms.Label();
            this.groupBoxSize.SuspendLayout();
            this.groupBoxCrustType.SuspendLayout();
            this.groupBoxWhereToEat.SuspendLayout();
            this.groupBoxToppings.SuspendLayout();
            this.groupBoxOrderSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(83, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(640, 79);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "MAKE YOUR PIZZA";
            // 
            // groupBoxSize
            // 
            this.groupBoxSize.Controls.Add(this.radioButtonLarge);
            this.groupBoxSize.Controls.Add(this.radioButtonMeduim);
            this.groupBoxSize.Controls.Add(this.radioButtonSmall);
            this.groupBoxSize.Location = new System.Drawing.Point(12, 119);
            this.groupBoxSize.Name = "groupBoxSize";
            this.groupBoxSize.Size = new System.Drawing.Size(200, 136);
            this.groupBoxSize.TabIndex = 4;
            this.groupBoxSize.TabStop = false;
            this.groupBoxSize.Text = "Size";
            // 
            // radioButtonLarge
            // 
            this.radioButtonLarge.AutoSize = true;
            this.radioButtonLarge.Location = new System.Drawing.Point(19, 110);
            this.radioButtonLarge.Name = "radioButtonLarge";
            this.radioButtonLarge.Size = new System.Drawing.Size(63, 20);
            this.radioButtonLarge.TabIndex = 5;
            this.radioButtonLarge.TabStop = true;
            this.radioButtonLarge.Text = "Large";
            this.radioButtonLarge.UseVisualStyleBackColor = true;
            this.radioButtonLarge.CheckedChanged += new System.EventHandler(this.radioButtonLarge_CheckedChanged);
            // 
            // radioButtonMeduim
            // 
            this.radioButtonMeduim.AutoSize = true;
            this.radioButtonMeduim.Enabled = false;
            this.radioButtonMeduim.Location = new System.Drawing.Point(19, 71);
            this.radioButtonMeduim.Name = "radioButtonMeduim";
            this.radioButtonMeduim.Size = new System.Drawing.Size(76, 20);
            this.radioButtonMeduim.TabIndex = 4;
            this.radioButtonMeduim.TabStop = true;
            this.radioButtonMeduim.Text = "Meduim";
            this.radioButtonMeduim.UseVisualStyleBackColor = true;
            this.radioButtonMeduim.CheckedChanged += new System.EventHandler(this.radioButtonMeduim_CheckedChanged);
            // 
            // radioButtonSmall
            // 
            this.radioButtonSmall.AutoSize = true;
            this.radioButtonSmall.Location = new System.Drawing.Point(20, 34);
            this.radioButtonSmall.Name = "radioButtonSmall";
            this.radioButtonSmall.Size = new System.Drawing.Size(62, 20);
            this.radioButtonSmall.TabIndex = 3;
            this.radioButtonSmall.TabStop = true;
            this.radioButtonSmall.Text = "Small";
            this.radioButtonSmall.UseVisualStyleBackColor = true;
            this.radioButtonSmall.CheckedChanged += new System.EventHandler(this.radioButtonSmall_CheckedChanged);
            // 
            // groupBoxCrustType
            // 
            this.groupBoxCrustType.Controls.Add(this.radioButtonThickCrust);
            this.groupBoxCrustType.Controls.Add(this.radioButtonThinCrust);
            this.groupBoxCrustType.Location = new System.Drawing.Point(12, 297);
            this.groupBoxCrustType.Name = "groupBoxCrustType";
            this.groupBoxCrustType.Size = new System.Drawing.Size(200, 100);
            this.groupBoxCrustType.TabIndex = 8;
            this.groupBoxCrustType.TabStop = false;
            this.groupBoxCrustType.Text = "CrustType";
            // 
            // radioButtonThickCrust
            // 
            this.radioButtonThickCrust.AutoSize = true;
            this.radioButtonThickCrust.Location = new System.Drawing.Point(19, 74);
            this.radioButtonThickCrust.Name = "radioButtonThickCrust";
            this.radioButtonThickCrust.Size = new System.Drawing.Size(94, 20);
            this.radioButtonThickCrust.TabIndex = 9;
            this.radioButtonThickCrust.TabStop = true;
            this.radioButtonThickCrust.Text = "Thick Crust";
            this.radioButtonThickCrust.UseVisualStyleBackColor = true;
            this.radioButtonThickCrust.CheckedChanged += new System.EventHandler(this.radioButtonThinkCrust_CheckedChanged);
            // 
            // radioButtonThinCrust
            // 
            this.radioButtonThinCrust.AutoSize = true;
            this.radioButtonThinCrust.Location = new System.Drawing.Point(19, 35);
            this.radioButtonThinCrust.Name = "radioButtonThinCrust";
            this.radioButtonThinCrust.Size = new System.Drawing.Size(87, 20);
            this.radioButtonThinCrust.TabIndex = 8;
            this.radioButtonThinCrust.TabStop = true;
            this.radioButtonThinCrust.Text = "Thin Crust";
            this.radioButtonThinCrust.UseVisualStyleBackColor = true;
            this.radioButtonThinCrust.CheckedChanged += new System.EventHandler(this.radioButtonThinCrust_CheckedChanged);
            // 
            // groupBoxWhereToEat
            // 
            this.groupBoxWhereToEat.Controls.Add(this.radioButtonTakeOut);
            this.groupBoxWhereToEat.Controls.Add(this.radioButtonEatIn);
            this.groupBoxWhereToEat.Location = new System.Drawing.Point(288, 309);
            this.groupBoxWhereToEat.Name = "groupBoxWhereToEat";
            this.groupBoxWhereToEat.Size = new System.Drawing.Size(281, 67);
            this.groupBoxWhereToEat.TabIndex = 11;
            this.groupBoxWhereToEat.TabStop = false;
            this.groupBoxWhereToEat.Text = "Where To Eat";
            // 
            // radioButtonTakeOut
            // 
            this.radioButtonTakeOut.AutoSize = true;
            this.radioButtonTakeOut.Location = new System.Drawing.Point(147, 23);
            this.radioButtonTakeOut.Name = "radioButtonTakeOut";
            this.radioButtonTakeOut.Size = new System.Drawing.Size(83, 20);
            this.radioButtonTakeOut.TabIndex = 12;
            this.radioButtonTakeOut.TabStop = true;
            this.radioButtonTakeOut.Text = "Take Out";
            this.radioButtonTakeOut.UseVisualStyleBackColor = true;
            this.radioButtonTakeOut.CheckedChanged += new System.EventHandler(this.radioButtonResetForm_CheckedChanged);
            // 
            // radioButtonEatIn
            // 
            this.radioButtonEatIn.AutoSize = true;
            this.radioButtonEatIn.Location = new System.Drawing.Point(35, 23);
            this.radioButtonEatIn.Name = "radioButtonEatIn";
            this.radioButtonEatIn.Size = new System.Drawing.Size(61, 20);
            this.radioButtonEatIn.TabIndex = 11;
            this.radioButtonEatIn.TabStop = true;
            this.radioButtonEatIn.Text = "Eat In";
            this.radioButtonEatIn.UseVisualStyleBackColor = true;
            this.radioButtonEatIn.CheckedChanged += new System.EventHandler(this.radioButtonEatIn_CheckedChanged);
            // 
            // buttonOrderPizza
            // 
            this.buttonOrderPizza.Location = new System.Drawing.Point(309, 398);
            this.buttonOrderPizza.Name = "buttonOrderPizza";
            this.buttonOrderPizza.Size = new System.Drawing.Size(101, 40);
            this.buttonOrderPizza.TabIndex = 12;
            this.buttonOrderPizza.Text = "Order Pizza";
            this.buttonOrderPizza.UseVisualStyleBackColor = true;
            this.buttonOrderPizza.Click += new System.EventHandler(this.buttonOrderPizza_Click);
            // 
            // buttonResetForm
            // 
            this.buttonResetForm.Location = new System.Drawing.Point(457, 398);
            this.buttonResetForm.Name = "buttonResetForm";
            this.buttonResetForm.Size = new System.Drawing.Size(101, 40);
            this.buttonResetForm.TabIndex = 13;
            this.buttonResetForm.Text = "Reset Form";
            this.buttonResetForm.UseVisualStyleBackColor = true;
            this.buttonResetForm.Click += new System.EventHandler(this.buttonResetForm_Click);
            // 
            // groupBoxToppings
            // 
            this.groupBoxToppings.Controls.Add(this.checkBoxGreenPeppers);
            this.groupBoxToppings.Controls.Add(this.checkBoxOlives);
            this.groupBoxToppings.Controls.Add(this.checkBoxOnion);
            this.groupBoxToppings.Controls.Add(this.checkBoxTomatoes);
            this.groupBoxToppings.Controls.Add(this.checkBoxMushrooms);
            this.groupBoxToppings.Controls.Add(this.checkBoxExtraCheese);
            this.groupBoxToppings.Location = new System.Drawing.Point(288, 119);
            this.groupBoxToppings.Name = "groupBoxToppings";
            this.groupBoxToppings.Size = new System.Drawing.Size(301, 136);
            this.groupBoxToppings.TabIndex = 20;
            this.groupBoxToppings.TabStop = false;
            this.groupBoxToppings.Text = "Toppings";
            // 
            // checkBoxGreenPeppers
            // 
            this.checkBoxGreenPeppers.AutoSize = true;
            this.checkBoxGreenPeppers.Location = new System.Drawing.Point(163, 110);
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
            this.checkBoxOlives.Location = new System.Drawing.Point(163, 72);
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
            this.checkBoxOnion.Location = new System.Drawing.Point(163, 35);
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
            this.checkBoxTomatoes.Location = new System.Drawing.Point(21, 110);
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
            this.checkBoxMushrooms.Location = new System.Drawing.Point(21, 72);
            this.checkBoxMushrooms.Name = "checkBoxMushrooms";
            this.checkBoxMushrooms.Size = new System.Drawing.Size(99, 20);
            this.checkBoxMushrooms.TabIndex = 21;
            this.checkBoxMushrooms.Text = "Mushrooms";
            this.checkBoxMushrooms.UseVisualStyleBackColor = true;
            this.checkBoxMushrooms.CheckedChanged += new System.EventHandler(this.checkBoxMushrooms_CheckedChanged);
            // 
            // checkBoxExtraCheese
            // 
            this.checkBoxExtraCheese.AutoSize = true;
            this.checkBoxExtraCheese.Location = new System.Drawing.Point(21, 35);
            this.checkBoxExtraCheese.Name = "checkBoxExtraCheese";
            this.checkBoxExtraCheese.Size = new System.Drawing.Size(106, 20);
            this.checkBoxExtraCheese.TabIndex = 20;
            this.checkBoxExtraCheese.Text = "ExtraCheese";
            this.checkBoxExtraCheese.UseVisualStyleBackColor = true;
            this.checkBoxExtraCheese.CheckedChanged += new System.EventHandler(this.checkBoxExtraCheese_CheckedChanged);
            // 
            // groupBoxOrderSummary
            // 
            this.groupBoxOrderSummary.Controls.Add(this.labelAnserTotalPrice);
            this.groupBoxOrderSummary.Controls.Add(this.labelAnswerForWhereToEatOnOrderSummary);
            this.groupBoxOrderSummary.Controls.Add(this.labelAnswerForCrustTypeOnOrderSummary);
            this.groupBoxOrderSummary.Controls.Add(this.labelAnswerForToppingsOnOrderSummary);
            this.groupBoxOrderSummary.Controls.Add(this.labelAnswerForSizeOnOrderSummary);
            this.groupBoxOrderSummary.Controls.Add(this.labelTotalPrice);
            this.groupBoxOrderSummary.Controls.Add(this.labelWhereToEat);
            this.groupBoxOrderSummary.Controls.Add(this.labelCrustType);
            this.groupBoxOrderSummary.Controls.Add(this.labelToppings);
            this.groupBoxOrderSummary.Controls.Add(this.labelSize);
            this.groupBoxOrderSummary.Location = new System.Drawing.Point(639, 101);
            this.groupBoxOrderSummary.Name = "groupBoxOrderSummary";
            this.groupBoxOrderSummary.Size = new System.Drawing.Size(565, 381);
            this.groupBoxOrderSummary.TabIndex = 31;
            this.groupBoxOrderSummary.TabStop = false;
            this.groupBoxOrderSummary.Text = "Order Summary";
            // 
            // labelAnserTotalPrice
            // 
            this.labelAnserTotalPrice.AutoSize = true;
            this.labelAnserTotalPrice.Font = new System.Drawing.Font("Ink Free", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAnserTotalPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelAnserTotalPrice.Location = new System.Drawing.Point(118, 257);
            this.labelAnserTotalPrice.Name = "labelAnserTotalPrice";
            this.labelAnserTotalPrice.Size = new System.Drawing.Size(66, 75);
            this.labelAnserTotalPrice.TabIndex = 40;
            this.labelAnserTotalPrice.Text = "$";
            // 
            // labelAnswerForWhereToEatOnOrderSummary
            // 
            this.labelAnswerForWhereToEatOnOrderSummary.AutoSize = true;
            this.labelAnswerForWhereToEatOnOrderSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAnswerForWhereToEatOnOrderSummary.Location = new System.Drawing.Point(76, 205);
            this.labelAnswerForWhereToEatOnOrderSummary.Name = "labelAnswerForWhereToEatOnOrderSummary";
            this.labelAnswerForWhereToEatOnOrderSummary.Size = new System.Drawing.Size(277, 16);
            this.labelAnswerForWhereToEatOnOrderSummary.TabIndex = 39;
            this.labelAnswerForWhereToEatOnOrderSummary.Text = "Answer For Where To Eat On Order Summary";
            // 
            // labelAnswerForCrustTypeOnOrderSummary
            // 
            this.labelAnswerForCrustTypeOnOrderSummary.AutoSize = true;
            this.labelAnswerForCrustTypeOnOrderSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAnswerForCrustTypeOnOrderSummary.Location = new System.Drawing.Point(76, 156);
            this.labelAnswerForCrustTypeOnOrderSummary.Name = "labelAnswerForCrustTypeOnOrderSummary";
            this.labelAnswerForCrustTypeOnOrderSummary.Size = new System.Drawing.Size(259, 16);
            this.labelAnswerForCrustTypeOnOrderSummary.TabIndex = 38;
            this.labelAnswerForCrustTypeOnOrderSummary.Text = "Answer For Crust Type On Order Summary";
            // 
            // labelAnswerForToppingsOnOrderSummary
            // 
            this.labelAnswerForToppingsOnOrderSummary.AutoSize = true;
            this.labelAnswerForToppingsOnOrderSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAnswerForToppingsOnOrderSummary.Location = new System.Drawing.Point(76, 98);
            this.labelAnswerForToppingsOnOrderSummary.Name = "labelAnswerForToppingsOnOrderSummary";
            this.labelAnswerForToppingsOnOrderSummary.Size = new System.Drawing.Size(252, 16);
            this.labelAnswerForToppingsOnOrderSummary.TabIndex = 37;
            this.labelAnswerForToppingsOnOrderSummary.Text = "Answer For Toppings On Order Summary";
            // 
            // labelAnswerForSizeOnOrderSummary
            // 
            this.labelAnswerForSizeOnOrderSummary.AutoSize = true;
            this.labelAnswerForSizeOnOrderSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAnswerForSizeOnOrderSummary.Location = new System.Drawing.Point(93, 49);
            this.labelAnswerForSizeOnOrderSummary.Name = "labelAnswerForSizeOnOrderSummary";
            this.labelAnswerForSizeOnOrderSummary.Size = new System.Drawing.Size(55, 16);
            this.labelAnswerForSizeOnOrderSummary.TabIndex = 36;
            this.labelAnswerForSizeOnOrderSummary.Text = "Meduim";
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.AutoSize = true;
            this.labelTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalPrice.Location = new System.Drawing.Point(48, 230);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.Size = new System.Drawing.Size(95, 16);
            this.labelTotalPrice.TabIndex = 35;
            this.labelTotalPrice.Text = "Total Price : ";
            // 
            // labelWhereToEat
            // 
            this.labelWhereToEat.AutoSize = true;
            this.labelWhereToEat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWhereToEat.Location = new System.Drawing.Point(48, 178);
            this.labelWhereToEat.Name = "labelWhereToEat";
            this.labelWhereToEat.Size = new System.Drawing.Size(114, 16);
            this.labelWhereToEat.TabIndex = 34;
            this.labelWhereToEat.Text = "Where To Eat : ";
            // 
            // labelCrustType
            // 
            this.labelCrustType.AutoSize = true;
            this.labelCrustType.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCrustType.Location = new System.Drawing.Point(48, 129);
            this.labelCrustType.Name = "labelCrustType";
            this.labelCrustType.Size = new System.Drawing.Size(94, 16);
            this.labelCrustType.TabIndex = 33;
            this.labelCrustType.Text = "Crust Type : ";
            // 
            // labelToppings
            // 
            this.labelToppings.AutoSize = true;
            this.labelToppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelToppings.Location = new System.Drawing.Point(48, 77);
            this.labelToppings.Name = "labelToppings";
            this.labelToppings.Size = new System.Drawing.Size(85, 16);
            this.labelToppings.TabIndex = 32;
            this.labelToppings.Text = "Toppings : ";
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSize.Location = new System.Drawing.Point(51, 30);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(49, 16);
            this.labelSize.TabIndex = 31;
            this.labelSize.Text = "Size : ";
            // 
            // MyPizzaOeder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 487);
            this.Controls.Add(this.groupBoxOrderSummary);
            this.Controls.Add(this.groupBoxToppings);
            this.Controls.Add(this.buttonResetForm);
            this.Controls.Add(this.buttonOrderPizza);
            this.Controls.Add(this.groupBoxWhereToEat);
            this.Controls.Add(this.groupBoxCrustType);
            this.Controls.Add(this.groupBoxSize);
            this.Controls.Add(this.lblTitle);
            this.Name = "MyPizzaOeder";
            this.Text = "My Pizza Order";
            this.groupBoxSize.ResumeLayout(false);
            this.groupBoxSize.PerformLayout();
            this.groupBoxCrustType.ResumeLayout(false);
            this.groupBoxCrustType.PerformLayout();
            this.groupBoxWhereToEat.ResumeLayout(false);
            this.groupBoxWhereToEat.PerformLayout();
            this.groupBoxToppings.ResumeLayout(false);
            this.groupBoxToppings.PerformLayout();
            this.groupBoxOrderSummary.ResumeLayout(false);
            this.groupBoxOrderSummary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox groupBoxSize;
        private System.Windows.Forms.RadioButton radioButtonLarge;
        private System.Windows.Forms.RadioButton radioButtonMeduim;
        private System.Windows.Forms.RadioButton radioButtonSmall;
        private System.Windows.Forms.GroupBox groupBoxCrustType;
        private System.Windows.Forms.RadioButton radioButtonThickCrust;
        private System.Windows.Forms.RadioButton radioButtonThinCrust;
        private System.Windows.Forms.GroupBox groupBoxWhereToEat;
        private System.Windows.Forms.RadioButton radioButtonTakeOut;
        private System.Windows.Forms.RadioButton radioButtonEatIn;
        private System.Windows.Forms.Button buttonOrderPizza;
        private System.Windows.Forms.Button buttonResetForm;
        private System.Windows.Forms.GroupBox groupBoxToppings;
        private System.Windows.Forms.CheckBox checkBoxGreenPeppers;
        private System.Windows.Forms.CheckBox checkBoxOlives;
        private System.Windows.Forms.CheckBox checkBoxOnion;
        private System.Windows.Forms.CheckBox checkBoxTomatoes;
        private System.Windows.Forms.CheckBox checkBoxMushrooms;
        private System.Windows.Forms.CheckBox checkBoxExtraCheese;
        private System.Windows.Forms.GroupBox groupBoxOrderSummary;
        private System.Windows.Forms.Label labelAnserTotalPrice;
        private System.Windows.Forms.Label labelAnswerForWhereToEatOnOrderSummary;
        private System.Windows.Forms.Label labelAnswerForCrustTypeOnOrderSummary;
        private System.Windows.Forms.Label labelAnswerForToppingsOnOrderSummary;
        private System.Windows.Forms.Label labelAnswerForSizeOnOrderSummary;
        private System.Windows.Forms.Label labelTotalPrice;
        private System.Windows.Forms.Label labelWhereToEat;
        private System.Windows.Forms.Label labelCrustType;
        private System.Windows.Forms.Label labelToppings;
        private System.Windows.Forms.Label labelSize;
    }
}