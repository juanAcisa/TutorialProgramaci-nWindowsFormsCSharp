namespace Programa01_05
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.gboxOperaciones = new System.Windows.Forms.GroupBox();
            this.rbDividir = new System.Windows.Forms.RadioButton();
            this.rbMultiplicar = new System.Windows.Forms.RadioButton();
            this.rbResta = new System.Windows.Forms.RadioButton();
            this.rbSuma = new System.Windows.Forms.RadioButton();
            this.lblResultado = new System.Windows.Forms.Label();
            this.gboxOperaciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(61, 41);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 29);
            this.txtA.TabIndex = 0;
            this.txtA.Text = "0";
            this.txtA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(61, 91);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 29);
            this.txtB.TabIndex = 1;
            this.txtB.Text = "0";
            this.txtB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(313, 47);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(121, 54);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // gboxOperaciones
            // 
            this.gboxOperaciones.Controls.Add(this.rbDividir);
            this.gboxOperaciones.Controls.Add(this.rbMultiplicar);
            this.gboxOperaciones.Controls.Add(this.rbResta);
            this.gboxOperaciones.Controls.Add(this.rbSuma);
            this.gboxOperaciones.Location = new System.Drawing.Point(61, 188);
            this.gboxOperaciones.Name = "gboxOperaciones";
            this.gboxOperaciones.Size = new System.Drawing.Size(252, 184);
            this.gboxOperaciones.TabIndex = 3;
            this.gboxOperaciones.TabStop = false;
            this.gboxOperaciones.Text = "Operaciones";
            // 
            // rbDividir
            // 
            this.rbDividir.AutoSize = true;
            this.rbDividir.Location = new System.Drawing.Point(24, 134);
            this.rbDividir.Name = "rbDividir";
            this.rbDividir.Size = new System.Drawing.Size(90, 29);
            this.rbDividir.TabIndex = 3;
            this.rbDividir.Text = "Dividir";
            this.rbDividir.UseVisualStyleBackColor = true;
            // 
            // rbMultiplicar
            // 
            this.rbMultiplicar.AutoSize = true;
            this.rbMultiplicar.Location = new System.Drawing.Point(24, 99);
            this.rbMultiplicar.Name = "rbMultiplicar";
            this.rbMultiplicar.Size = new System.Drawing.Size(124, 29);
            this.rbMultiplicar.TabIndex = 2;
            this.rbMultiplicar.Text = "Multiplicar";
            this.rbMultiplicar.UseVisualStyleBackColor = true;
            // 
            // rbResta
            // 
            this.rbResta.AutoSize = true;
            this.rbResta.Location = new System.Drawing.Point(24, 64);
            this.rbResta.Name = "rbResta";
            this.rbResta.Size = new System.Drawing.Size(87, 29);
            this.rbResta.TabIndex = 1;
            this.rbResta.Text = "Resta";
            this.rbResta.UseVisualStyleBackColor = true;
            // 
            // rbSuma
            // 
            this.rbSuma.AutoSize = true;
            this.rbSuma.Checked = true;
            this.rbSuma.Location = new System.Drawing.Point(24, 29);
            this.rbSuma.Name = "rbSuma";
            this.rbSuma.Size = new System.Drawing.Size(89, 29);
            this.rbSuma.TabIndex = 0;
            this.rbSuma.TabStop = true;
            this.rbSuma.Text = "Suma";
            this.rbSuma.UseVisualStyleBackColor = true;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(56, 141);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 25);
            this.lblResultado.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 408);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.gboxOperaciones);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.gboxOperaciones.ResumeLayout(false);
            this.gboxOperaciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.GroupBox gboxOperaciones;
        private System.Windows.Forms.RadioButton rbDividir;
        private System.Windows.Forms.RadioButton rbMultiplicar;
        private System.Windows.Forms.RadioButton rbResta;
        private System.Windows.Forms.RadioButton rbSuma;
        private System.Windows.Forms.Label lblResultado;
    }
}

