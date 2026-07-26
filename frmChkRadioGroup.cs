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
    public partial class frmChkRadioGroup : Form
    {
        public frmChkRadioGroup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(chkRecieveEmails.Checked.ToString());
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = chkRecieveEmails.Checked;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rbSmall.Checked.ToString());
        }
    }
}
