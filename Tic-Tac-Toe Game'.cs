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
    public partial class Tic_Tac_Toe_Game_ : Form
    {
        public Tic_Tac_Toe_Game_()
        {
            InitializeComponent();
        }

        private void Tic_Tac_Toe_Game_Paint(object sender, PaintEventArgs e)
        {
            }

        private void Tic_Tac_Toe_Game__Paint(object sender, PaintEventArgs e)
        {
            Color White = Color.FromArgb(255, 255, 255, 255);

            Pen pen = new Pen(White);
            pen.Width = 5;

            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            e.Graphics.DrawLine(pen, 200, 100, 200, 450);
            e.Graphics.DrawLine(pen, 100, 200, 450, 200);
            e.Graphics.DrawLine(pen, 100, 350, 450, 350);
            e.Graphics.DrawLine(pen, 350, 100, 350, 450);
        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {

        }
       

       
    }
}
