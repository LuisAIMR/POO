namespace MatrizSumaFCD
{
    partial class frmMatrizSumaFCD
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
            this.lblExtensionMatriz = new System.Windows.Forms.Label();
            this.btnAgregarElementos = new System.Windows.Forms.Button();
            this.rtbMatrizNM = new System.Windows.Forms.RichTextBox();
            this.rtbSumaFilas = new System.Windows.Forms.RichTextBox();
            this.rtbSumaColumnas = new System.Windows.Forms.RichTextBox();
            this.rtbElementosDiagonal = new System.Windows.Forms.RichTextBox();
            this.lblSumasDiagonales = new System.Windows.Forms.Label();
            this.lblSumasColumnas = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudTamanoMatriz = new System.Windows.Forms.NumericUpDown();
            this.btnElementosDiagonal = new System.Windows.Forms.Button();
            this.btnSumaFilas = new System.Windows.Forms.Button();
            this.btnSumaColumnas = new System.Windows.Forms.Button();
            this.btnSumaDiagonales = new System.Windows.Forms.Button();
            this.rtbSumaDiagonal = new System.Windows.Forms.RichTextBox();
            this.lblSumaDiagonal = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudTamanoMatriz)).BeginInit();
            this.SuspendLayout();
            // 
            // lblExtensionMatriz
            // 
            this.lblExtensionMatriz.AutoSize = true;
            this.lblExtensionMatriz.Location = new System.Drawing.Point(14, 26);
            this.lblExtensionMatriz.Name = "lblExtensionMatriz";
            this.lblExtensionMatriz.Size = new System.Drawing.Size(111, 13);
            this.lblExtensionMatriz.TabIndex = 0;
            this.lblExtensionMatriz.Text = "Tamaño de la matriz  :";
            // 
            // btnAgregarElementos
            // 
            this.btnAgregarElementos.Location = new System.Drawing.Point(190, 12);
            this.btnAgregarElementos.Name = "btnAgregarElementos";
            this.btnAgregarElementos.Size = new System.Drawing.Size(75, 48);
            this.btnAgregarElementos.TabIndex = 4;
            this.btnAgregarElementos.Text = "Agregar Elementos";
            this.btnAgregarElementos.UseVisualStyleBackColor = true;
            this.btnAgregarElementos.Click += new System.EventHandler(this.btnAgregarElementos_Click);
            // 
            // rtbMatrizNM
            // 
            this.rtbMatrizNM.Location = new System.Drawing.Point(322, 23);
            this.rtbMatrizNM.Name = "rtbMatrizNM";
            this.rtbMatrizNM.Size = new System.Drawing.Size(100, 96);
            this.rtbMatrizNM.TabIndex = 5;
            this.rtbMatrizNM.Text = "";
            // 
            // rtbSumaFilas
            // 
            this.rtbSumaFilas.Location = new System.Drawing.Point(322, 125);
            this.rtbSumaFilas.Name = "rtbSumaFilas";
            this.rtbSumaFilas.Size = new System.Drawing.Size(100, 23);
            this.rtbSumaFilas.TabIndex = 6;
            this.rtbSumaFilas.Text = "";
            this.rtbSumaFilas.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // rtbSumaColumnas
            // 
            this.rtbSumaColumnas.Location = new System.Drawing.Point(428, 23);
            this.rtbSumaColumnas.Name = "rtbSumaColumnas";
            this.rtbSumaColumnas.Size = new System.Drawing.Size(29, 96);
            this.rtbSumaColumnas.TabIndex = 7;
            this.rtbSumaColumnas.Text = "";
            // 
            // rtbElementosDiagonal
            // 
            this.rtbElementosDiagonal.Location = new System.Drawing.Point(322, 171);
            this.rtbElementosDiagonal.Name = "rtbElementosDiagonal";
            this.rtbElementosDiagonal.Size = new System.Drawing.Size(100, 23);
            this.rtbElementosDiagonal.TabIndex = 8;
            this.rtbElementosDiagonal.Text = "";
            // 
            // lblSumasDiagonales
            // 
            this.lblSumasDiagonales.AutoSize = true;
            this.lblSumasDiagonales.Location = new System.Drawing.Point(129, 174);
            this.lblSumasDiagonales.Name = "lblSumasDiagonales";
            this.lblSumasDiagonales.Size = new System.Drawing.Size(187, 13);
            this.lblSumasDiagonales.TabIndex = 9;
            this.lblSumasDiagonales.Text = "Elementos de la diagonal Diagonales :";
            // 
            // lblSumasColumnas
            // 
            this.lblSumasColumnas.AutoSize = true;
            this.lblSumasColumnas.Location = new System.Drawing.Point(463, 26);
            this.lblSumasColumnas.Name = "lblSumasColumnas";
            this.lblSumasColumnas.Size = new System.Drawing.Size(94, 13);
            this.lblSumasColumnas.TabIndex = 10;
            this.lblSumasColumnas.Text = ": Sumas Columnas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(247, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Sumas Filas :";
            // 
            // nudTamanoMatriz
            // 
            this.nudTamanoMatriz.Location = new System.Drawing.Point(132, 26);
            this.nudTamanoMatriz.Name = "nudTamanoMatriz";
            this.nudTamanoMatriz.Size = new System.Drawing.Size(52, 20);
            this.nudTamanoMatriz.TabIndex = 12;
            // 
            // btnElementosDiagonal
            // 
            this.btnElementosDiagonal.Location = new System.Drawing.Point(428, 155);
            this.btnElementosDiagonal.Name = "btnElementosDiagonal";
            this.btnElementosDiagonal.Size = new System.Drawing.Size(75, 51);
            this.btnElementosDiagonal.TabIndex = 13;
            this.btnElementosDiagonal.Text = "Elementos de la diagonal";
            this.btnElementosDiagonal.UseVisualStyleBackColor = true;
            this.btnElementosDiagonal.Click += new System.EventHandler(this.btnResultado_Click);
            // 
            // btnSumaFilas
            // 
            this.btnSumaFilas.Location = new System.Drawing.Point(181, 116);
            this.btnSumaFilas.Name = "btnSumaFilas";
            this.btnSumaFilas.Size = new System.Drawing.Size(60, 37);
            this.btnSumaFilas.TabIndex = 14;
            this.btnSumaFilas.Text = "Suma Filas";
            this.btnSumaFilas.UseVisualStyleBackColor = true;
            this.btnSumaFilas.Click += new System.EventHandler(this.btnSumaFilas_Click);
            // 
            // btnSumaColumnas
            // 
            this.btnSumaColumnas.Location = new System.Drawing.Point(482, 54);
            this.btnSumaColumnas.Name = "btnSumaColumnas";
            this.btnSumaColumnas.Size = new System.Drawing.Size(75, 39);
            this.btnSumaColumnas.TabIndex = 15;
            this.btnSumaColumnas.Text = "Suma Columnas";
            this.btnSumaColumnas.UseVisualStyleBackColor = true;
            this.btnSumaColumnas.Click += new System.EventHandler(this.btnSumaColumnas_Click);
            // 
            // btnSumaDiagonales
            // 
            this.btnSumaDiagonales.Location = new System.Drawing.Point(428, 231);
            this.btnSumaDiagonales.Name = "btnSumaDiagonales";
            this.btnSumaDiagonales.Size = new System.Drawing.Size(75, 35);
            this.btnSumaDiagonales.TabIndex = 16;
            this.btnSumaDiagonales.Text = "Suma Diagonales";
            this.btnSumaDiagonales.UseVisualStyleBackColor = true;
            this.btnSumaDiagonales.Click += new System.EventHandler(this.btnSumaDiagonales_Click);
            // 
            // rtbSumaDiagonal
            // 
            this.rtbSumaDiagonal.Location = new System.Drawing.Point(322, 239);
            this.rtbSumaDiagonal.Name = "rtbSumaDiagonal";
            this.rtbSumaDiagonal.Size = new System.Drawing.Size(100, 23);
            this.rtbSumaDiagonal.TabIndex = 17;
            this.rtbSumaDiagonal.Text = "";
            // 
            // lblSumaDiagonal
            // 
            this.lblSumaDiagonal.AutoSize = true;
            this.lblSumaDiagonal.Location = new System.Drawing.Point(129, 242);
            this.lblSumaDiagonal.Name = "lblSumaDiagonal";
            this.lblSumaDiagonal.Size = new System.Drawing.Size(191, 13);
            this.lblSumaDiagonal.TabIndex = 18;
            this.lblSumaDiagonal.Text = "Suma de los elementos de la diagonal :";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(557, 243);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 19;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmMatrizSumaFCD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 278);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblSumaDiagonal);
            this.Controls.Add(this.rtbSumaDiagonal);
            this.Controls.Add(this.btnSumaDiagonales);
            this.Controls.Add(this.btnSumaColumnas);
            this.Controls.Add(this.btnSumaFilas);
            this.Controls.Add(this.btnElementosDiagonal);
            this.Controls.Add(this.nudTamanoMatriz);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblSumasColumnas);
            this.Controls.Add(this.lblSumasDiagonales);
            this.Controls.Add(this.rtbElementosDiagonal);
            this.Controls.Add(this.rtbSumaColumnas);
            this.Controls.Add(this.rtbSumaFilas);
            this.Controls.Add(this.rtbMatrizNM);
            this.Controls.Add(this.btnAgregarElementos);
            this.Controls.Add(this.lblExtensionMatriz);
            this.Name = "frmMatrizSumaFCD";
            this.Text = "MatrizSumaFCD";
            this.Load += new System.EventHandler(this.frmMatrizSumaFCD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudTamanoMatriz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblExtensionMatriz;
        private System.Windows.Forms.Button btnAgregarElementos;
        private System.Windows.Forms.RichTextBox rtbMatrizNM;
        private System.Windows.Forms.RichTextBox rtbSumaFilas;
        private System.Windows.Forms.RichTextBox rtbSumaColumnas;
        private System.Windows.Forms.RichTextBox rtbElementosDiagonal;
        private System.Windows.Forms.Label lblSumasDiagonales;
        private System.Windows.Forms.Label lblSumasColumnas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudTamanoMatriz;
        private System.Windows.Forms.Button btnElementosDiagonal;
        private System.Windows.Forms.Button btnSumaFilas;
        private System.Windows.Forms.Button btnSumaColumnas;
        private System.Windows.Forms.Button btnSumaDiagonales;
        private System.Windows.Forms.RichTextBox rtbSumaDiagonal;
        private System.Windows.Forms.Label lblSumaDiagonal;
        private System.Windows.Forms.Button btnSalir;
    }
}

