namespace Programa01_03
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
            this.lblA = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.lblB = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnSuma = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.btnDivi = new System.Windows.Forms.Button();
            this.btnMulti = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(96, 78);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(32, 25);
            this.lblA.TabIndex = 0;
            this.lblA.Text = "A:";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(134, 74);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 29);
            this.txtA.TabIndex = 1;
            this.txtA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(134, 133);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 29);
            this.txtB.TabIndex = 3;
            this.txtB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(96, 137);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(31, 25);
            this.lblB.TabIndex = 2;
            this.lblB.Text = "B:";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(170, 238);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(64, 25);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.Text = "label1";
            // 
            // btnSuma
            // 
            this.btnSuma.Location = new System.Drawing.Point(298, 72);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(34, 35);
            this.btnSuma.TabIndex = 5;
            this.btnSuma.Text = "+";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.BtnSuma_Click);
            // 
            // btnResta
            // 
            this.btnResta.Location = new System.Drawing.Point(338, 72);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(34, 35);
            this.btnResta.TabIndex = 6;
            this.btnResta.Text = "-";
            this.btnResta.UseVisualStyleBackColor = true;
            this.btnResta.Click += new System.EventHandler(this.BtnResta_Click);
            // 
            // btnDivi
            // 
            this.btnDivi.Location = new System.Drawing.Point(338, 127);
            this.btnDivi.Name = "btnDivi";
            this.btnDivi.Size = new System.Drawing.Size(34, 35);
            this.btnDivi.TabIndex = 8;
            this.btnDivi.Text = "/";
            this.btnDivi.UseVisualStyleBackColor = true;
            this.btnDivi.Click += new System.EventHandler(this.BtnDivi_Click);
            // 
            // btnMulti
            // 
            this.btnMulti.Location = new System.Drawing.Point(298, 127);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(34, 35);
            this.btnMulti.TabIndex = 7;
            this.btnMulti.Text = "*";
            this.btnMulti.UseVisualStyleBackColor = true;
            this.btnMulti.Click += new System.EventHandler(this.BtnMulti_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 341);
            this.Controls.Add(this.btnDivi);
            this.Controls.Add(this.btnMulti);
            this.Controls.Add(this.btnResta);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.lblA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.Button btnDivi;
        private System.Windows.Forms.Button btnMulti;
    }
}

