using Course14.Properties;
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
    public partial class PictureBoxExerxise : Form
    {
        public PictureBoxExerxise()
        {
            InitializeComponent();
        }

        private void radioButtonBoy_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.Boy;
          //  UpdateTitle();
          labelTitle.Text=((RadioButton)sender).Tag.ToString();
        }

        private void radioButtonGirl_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.Girl;
            //UpdateTitle();
            labelTitle.Text = ((RadioButton)sender).Tag.ToString();
        }

        private void radioButtonBook_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.Book;
            // UpdateTitle();
            labelTitle.Text = ((RadioButton)sender).Tag.ToString();
        }

        private void radioButtonPen_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.Pen;
            // UpdateTitle();
            labelTitle.Text = ((RadioButton)sender).Tag.ToString();
        }

       
        private void UpdateTitle()
        {
            if (radioButtonBoy.Checked)
            {
                labelTitle.Text = radioButtonBoy.Text;
            }
            if (radioButtonGirl.Checked)
            {
                labelTitle.Text = radioButtonGirl.Text;
            }
            if (radioButtonBook.Checked)
            {
                labelTitle.Text = radioButtonBook.Text;
            }
            if (radioButtonPen.Checked)
            {
                labelTitle.Text = radioButtonPen.Text;
            }
        }

    }
}
