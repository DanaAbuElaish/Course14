using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course14
{
    public partial class Pizza_Order : Form
    {

        

        public Pizza_Order()
        {
            InitializeComponent();
        }

        private void groupBoxOrderSummary_Enter(object sender, EventArgs e)
        {

        }

        private void btnOrderPizza_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Confirm Order", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {
                //do something
                MessageBox.Show("Order Placed Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                groupBoxSize.Enabled = false;
                groupBoxCrustType.Enabled = false;
                groupBoxToppings.Enabled = false;
                groupBoxWhereToEat.Enabled = false;
            }
        }

        private void btnEsetForm_Click(object sender, EventArgs e)
        {
            groupBoxSize.Enabled = true;
            groupBoxCrustType.Enabled = true;
            groupBoxToppings.Enabled = true;
            groupBoxWhereToEat.Enabled = true;


        }

        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSmall.Checked)
            {
                lblSizeOnOrderSummary.Text = rbSmall.Text;
                CalculatePrice();
            }
        }

        private void rbMeduim_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMeduim.Checked)
            {
                lblSizeOnOrderSummary.Text = rbMeduim.Text;
                CalculatePrice();
            }
        }

        private void rbLarge_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLarge.Checked)
            {
                lblSizeOnOrderSummary.Text = rbLarge.Text;
                CalculatePrice();
            }
        }

        private void rbThinCrust_CheckedChanged(object sender, EventArgs e)
        {
            if (rbThinCrust.Checked)
            {
                lblCrustTypeOnOrderSummary.Text = rbThinCrust.Text;
                CalculatePrice();
            }
        }

        private void rbThinkCrust_CheckedChanged(object sender, EventArgs e)
        {
            if (rbThinkCrust.Checked)
            {
                lblCrustTypeOnOrderSummary.Text = rbThinkCrust.Text;
                CalculatePrice();
            }
        }

        private void radioButtonEatIn_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonEatIn.Checked)
            {
                lblWhereToEatOnOrderSummary.Text = radioButtonEatIn.Text;
            }
        }

        private void radioButtonResetForm_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonResetForm.Checked)
            {
                lblWhereToEatOnOrderSummary.Text = radioButtonResetForm.Text;
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
            if (toppings == "")
            {
                toppings = "No Toppings";
            }

            lblToppingsOnOrderSummary.Text = toppings;
        }


        private void CalculatePrice()
        {
           int price = 0;

            if (rbSmall.Checked)
            {
                price += 10;
            }else if (rbMeduim.Checked)
            {
                price += 20;
            }else if (rbLarge.Checked)
            {
                price += 30;
            }

            if (rbThinCrust.Checked)
            {
                price += 5;
            }else if (rbThinkCrust.Checked)
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

            lblTotalPriceOnOrderSummary.Text = price.ToString() + "$";
        }

        private void checkBoxExtraCheese_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
            CalculatePrice();

        }

        private void checkBoxOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
            CalculatePrice();
        }

        private void checkBoxMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
            CalculatePrice();

        }

        private void checkBoxOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
            CalculatePrice();

        }

        private void checkBoxTomatoes_CheckedChanged(object sender, EventArgs e)
        {

            UpdateToppings();
            CalculatePrice();
           
        }

        private void checkBoxGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {

            UpdateToppings();
            CalculatePrice();
           
        }

       
    }
}
