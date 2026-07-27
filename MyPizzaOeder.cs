using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Course14
{
    public partial class MyPizzaOeder : Form
    {
        public MyPizzaOeder()
        {
            InitializeComponent();
        }

        private void radioButtonSmall_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonSmall.Checked) {

                labelAnswerForSizeOnOrderSummary.Text = radioButtonSmall.Text;
                CalculateTotalPrice();
            }
        }

        private void radioButtonMeduim_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonMeduim.Checked)
            {
                labelAnswerForSizeOnOrderSummary.Text = radioButtonMeduim.Text;
                CalculateTotalPrice();
            }
        }

        private void radioButtonLarge_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonLarge.Checked) {
                labelAnswerForSizeOnOrderSummary.Text = radioButtonLarge.Text;
                CalculateTotalPrice();
            }
        }

        private void radioButtonThinCrust_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonThinCrust.Checked) {
                labelAnswerForCrustTypeOnOrderSummary.Text = radioButtonThinCrust.Text;
                CalculateTotalPrice();
            }
        }
        private void radioButtonThinkCrust_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonThickCrust.Checked)
            {
                labelAnswerForCrustTypeOnOrderSummary.Text = radioButtonThickCrust.Text;
                CalculateTotalPrice();
            }

        }


        private void UpdateToppings()
        {
            string toppings = "";

            if (checkBoxExtraCheese.Checked)
            {
                toppings += checkBoxExtraCheese.Text + " , ";
            }

            if (checkBoxOnion.Checked)
            {
                toppings += checkBoxOnion.Text + " , ";
            }

            if (checkBoxMushrooms.Checked)
            {
                toppings += checkBoxMushrooms.Text + " , ";
            }

            if (checkBoxOlives.Checked)
            {
                toppings += checkBoxOlives.Text + " , ";
            }

            if (checkBoxTomatoes.Checked)
            {
                toppings += checkBoxTomatoes.Text + " , ";
            }

            if (checkBoxGreenPeppers.Checked)
            {
                toppings += checkBoxGreenPeppers.Text;
            }

            labelAnswerForToppingsOnOrderSummary.Text = toppings;
        }
    



        private void checkBoxExtraCheese_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
            CalculateTotalPrice();
;        }

        private void checkBoxOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
            CalculateTotalPrice();
        }

        private void checkBoxMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
            CalculateTotalPrice();
        }

        private void checkBoxOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
            CalculateTotalPrice();
        }

        private void checkBoxTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
            CalculateTotalPrice();
        }

        private void checkBoxGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
            CalculateTotalPrice();
        }

        private void radioButtonEatIn_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonEatIn.Checked) {
                labelAnswerForWhereToEatOnOrderSummary.Text = radioButtonEatIn.Text;
            }
        }

        private void radioButtonResetForm_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonTakeOut.Checked) {
                labelAnswerForWhereToEatOnOrderSummary.Text = radioButtonTakeOut.Text;
            }
        }


        private void CalculateTotalPrice()
        {
            int price = 0;

            if (radioButtonSmall.Checked)
            {
                price += 10;
            }

            else if (radioButtonMeduim.Checked)
            {
                price += 20;
            }

            else if (radioButtonLarge.Checked)
            {
                price += 30;
            }


            
            if (radioButtonThinCrust.Checked)
            {
                price += 5;
            }

             else if (radioButtonThickCrust.Checked)
            {
                price += 10;
            }




             if (checkBoxExtraCheese.Checked)
            {
                price += 5;
            }

             if (checkBoxOnion.Checked)
            {
                price += 5;
            }

             if (checkBoxMushrooms.Checked)
            {
                price += 5;
            }

             if (checkBoxOlives.Checked)
            {
                price += 5;
            }

             if (checkBoxTomatoes.Checked)
            {
                price += 5;
            }

             if (checkBoxGreenPeppers.Checked)
            {
                price += 5;
            }

            labelAnserTotalPrice.Text = "$" + price.ToString();
        }

        private void buttonOrderPizza_Click(object sender, EventArgs e)
        {
         if(   MessageBox.Show("Confirm Order", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                MessageBox.Show("Order Placed Successfully","Success",MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                groupBoxSize.Enabled = false;
                groupBoxCrustType.Enabled = false;
                groupBoxToppings.Enabled = false;
                groupBoxWhereToEat.Enabled = false;
                buttonOrderPizza.Enabled = false;
            }

        }

        private void buttonResetForm_Click(object sender, EventArgs e)
        {
            groupBoxSize.Enabled = true;
            groupBoxCrustType.Enabled = true;
            groupBoxToppings.Enabled = true;
            groupBoxWhereToEat.Enabled = true;
            buttonOrderPizza.Enabled = true;
        }
    }
}
