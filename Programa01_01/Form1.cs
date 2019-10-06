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
        public static System.Drawing.Point b;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSaludo_Click(object sender, EventArgs e)
        {
            lblSaludo.Text = "**********Hola mundo**********";
        }

        private void BtnSaludo_MouseLeave(object sender, EventArgs e)
        {
            lblSaludo.Text = "";
        }

        private void BtnSaludo_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                if (lblSaludo.Text != "")
                {
                    if (e.X > b.X && lblSaludo.Text.Substring(lblSaludo.Text.Length - 1, 1) == "*")
                        lblSaludo.Text = "*" + lblSaludo.Text.Substring(0, lblSaludo.Text.Length - 1);
                    else if (e.X < b.X && lblSaludo.Text.Substring(0, 1) == "*")
                        lblSaludo.Text = lblSaludo.Text.Substring(1, lblSaludo.Text.Length - 1) + "*";

                    b.X = e.X;
                }
            }
            catch { }
        }
    }
}
