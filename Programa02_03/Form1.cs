using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa02_03
{
    /// <summary>
    /// Tutorial Programación Windows Forms C# 10 --- Comunicación entre formas I
    /// 20191013D1033 juan.acisa@gmail.com
    ///     autor: nicosired
    ///     url: https://www.youtube.com/watch?v=wXBzurp47C0&list=PLM-p96nOrGcZezSAPW08ulofVcEZRpYfH&index=10
    /// </summary>
    public partial class Form1 : Form
    {
        // Creamos la instancia del formulario 2
        // y asignamos valor con constructor
        Form2 miFormulario2 = new Form2("Saludos");

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnEnvio1_Click(object sender, EventArgs e)
        {
            // En este caso asignamos valor con la propiedad
            miFormulario2.Comentario = "nos vemos";

            // Mostramos el formulario 2
            miFormulario2.Show();

            // 
        }

        private void BtnEnvio2_Click(object sender, EventArgs e)
        {
            miFormulario2.Comentario = txtMensaje.Text;
        }
    }
}
