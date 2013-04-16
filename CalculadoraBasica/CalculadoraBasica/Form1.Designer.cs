namespace Calculadora_Sencilla
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btSuma = new System.Windows.Forms.Button();
            this.btResta = new System.Windows.Forms.Button();
            this.btMulti = new System.Windows.Forms.Button();
            this.btDiv = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbNumero2 = new System.Windows.Forms.TextBox();
            this.tbNumero1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbResultado = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btSuma
            // 
            this.btSuma.Location = new System.Drawing.Point(179, 6);
            this.btSuma.Name = "btSuma";
            this.btSuma.Size = new System.Drawing.Size(83, 23);
            this.btSuma.TabIndex = 0;
            this.btSuma.Text = "Suma";
            this.btSuma.UseVisualStyleBackColor = true;
            this.btSuma.Click += new System.EventHandler(this.btSuma_Click);
            // 
            // btResta
            // 
            this.btResta.Location = new System.Drawing.Point(268, 6);
            this.btResta.Name = "btResta";
            this.btResta.Size = new System.Drawing.Size(75, 23);
            this.btResta.TabIndex = 1;
            this.btResta.Text = "Resta";
            this.btResta.UseVisualStyleBackColor = true;
            this.btResta.Click += new System.EventHandler(this.btResta_Click);
            // 
            // btMulti
            // 
            this.btMulti.Location = new System.Drawing.Point(179, 35);
            this.btMulti.Name = "btMulti";
            this.btMulti.Size = new System.Drawing.Size(83, 23);
            this.btMulti.TabIndex = 2;
            this.btMulti.Text = "Multiplicacion";
            this.btMulti.UseVisualStyleBackColor = true;
            this.btMulti.Click += new System.EventHandler(this.btMulti_Click);
            // 
            // btDiv
            // 
            this.btDiv.Location = new System.Drawing.Point(268, 35);
            this.btDiv.Name = "btDiv";
            this.btDiv.Size = new System.Drawing.Size(75, 23);
            this.btDiv.TabIndex = 3;
            this.btDiv.Text = "Division";
            this.btDiv.UseVisualStyleBackColor = true;
            this.btDiv.Click += new System.EventHandler(this.btDiv_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.lbResultado);
            this.panel1.Controls.Add(this.tbNumero2);
            this.panel1.Controls.Add(this.tbNumero1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btSuma);
            this.panel1.Controls.Add(this.btDiv);
            this.panel1.Controls.Add(this.btResta);
            this.panel1.Controls.Add(this.btMulti);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 122);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // tbNumero2
            // 
            this.tbNumero2.Location = new System.Drawing.Point(62, 29);
            this.tbNumero2.Name = "tbNumero2";
            this.tbNumero2.Size = new System.Drawing.Size(100, 20);
            this.tbNumero2.TabIndex = 9;
            // 
            // tbNumero1
            // 
            this.tbNumero1.Location = new System.Drawing.Point(62, 3);
            this.tbNumero1.Name = "tbNumero1";
            this.tbNumero1.Size = new System.Drawing.Size(100, 20);
            this.tbNumero1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Resultado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Numero 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Numero 1";
            // 
            // lbResultado
            // 
            this.lbResultado.AutoSize = true;
            this.lbResultado.Location = new System.Drawing.Point(64, 58);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(0, 13);
            this.lbResultado.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 147);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btSuma;
        private System.Windows.Forms.Button btResta;
        private System.Windows.Forms.Button btMulti;
        private System.Windows.Forms.Button btDiv;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbNumero2;
        private System.Windows.Forms.TextBox tbNumero1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbResultado;

    }
}

