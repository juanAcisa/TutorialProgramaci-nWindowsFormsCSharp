﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa02_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Hola a todos");

            //MessageBox.Show("Hola a todos", "Mi MessageBox");
            DialogResult r = MessageBox.Show("Probando botones", "Diferentes botones", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Information);

            if (r == DialogResult.Abort)
                lblMensaje.Text = "Se ha Anulado";
            if (r == DialogResult.Retry)
                lblMensaje.Text = "Se ha Reintentado";
            if (r == DialogResult.Ignore)
                lblMensaje.Text = "Se ha Omitido";

        }
    }
}
