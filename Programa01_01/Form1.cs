using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa01_01
{
    public partial class Form1 : Form
    {
        static Point x;

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSaludo_Click(object sender, EventArgs e)
        {
            lblSaludo.Text = "     Hola mundo     ";
        }

        private void BtnSaludo_MouseLeave(object sender, EventArgs e)
        {
            lblSaludo.Text = "";
        }

        private void BtnSaludo_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                if (btnSaludo.PointToScreen(Form1.x) > x)
                    lblSaludo.Text = " " + lblSaludo.Text.Substring(0, lblSaludo.Text.Length - 1);
                if (btnSaludo.PointToScreen < x)
                    lblSaludo.Text = lblSaludo.Text.Substring(1, lblSaludo.Text.Length - 1) + " ";

                x = btnSaludo.PointToScreen;
            }
            catch { }
        }
    }
}
