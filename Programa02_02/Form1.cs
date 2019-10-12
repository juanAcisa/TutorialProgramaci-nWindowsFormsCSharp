using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Tutorial programación Windows Forms C# 9 --Múltiples formas
/// 20191012S1358 juan.acisa@gmail.com
/// </summary>
/// <autor>
/// nicosired
/// </autor>
/// <url>
/// https://www.youtube.com/watch?v=boBmvGWTWJ8&list=PLM-p96nOrGcZezSAPW08ulofVcEZRpYfH&index=9
/// </url>
namespace Programa02_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAbrir_Click(object sender, EventArgs e)
        {
            Form2 miFormulario2=new Form2();

            miFormulario2.ShowDialog();
}
    }
}
