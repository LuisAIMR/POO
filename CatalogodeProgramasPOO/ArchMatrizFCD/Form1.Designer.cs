namespace ArchMatrizFCD
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
            this.btnGuardarRes = new System.Windows.Forms.Button();
            this.lblResSumFil = new System.Windows.Forms.Label();
            this.rtbResSumFil = new System.Windows.Forms.RichTextBox();
            this.btnSumSumFilas = new System.Windows.Forms.Button();
            this.lblResSumCol = new System.Windows.Forms.Label();
            this.rtbResSumcol = new System.Windows.Forms.RichTextBox();
            this.btnSumSumcolumnas = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblSumaDiagonal = new System.Windows.Forms.Label();
            this.rtbSumaDiagonal = new System.Windows.Forms.RichTextBox();
            this.btnSumaDiagonales = new System.Windows.Forms.Button();
            this.btnSumaColumnas = new System.Windows.Forms.Button();
            this.btnSumaFilas = new System.Windows.Forms.Button();
            this.btnElementosDiagonal = new System.Windows.Forms.Button();
            this.nudTamanoMatriz = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSumasColumnas = new System.Windows.Forms.Label();
            this.lblSumasDiagonales = new System.Windows.Forms.Label();
            this.rtbElementosDiagonal = new System.Windows.Forms.RichTextBox();
            this.rtbSumaColumnas = new System.Windows.Forms.RichTextBox();
            this.rtbSumaFilas = new System.Windows.Forms.RichTextBox();
            this.rtbMatrizNM = new System.Windows.Forms.RichTextBox();
            this.btnAgregarElementos = new System.Windows.Forms.Button();
            this.lblExtensionMatriz = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudTamanoMatriz)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardarRes
            // 
            this.btnGuardarRes.Location = new System.Drawing.Point(494, 373);
            this.btnGuardarRes.Name = "btnGuardarRes";
            this.btnGuardarRes.Size = new System.Drawing.Size(85, 34);
            this.btnGuardarRes.TabIndex = 50;
            this.btnGuardarRes.Text = "Guardar Resultados";
            this.btnGuardarRes.UseVisualStyleBackColor = true;
            this.btnGuardarRes.Click += new System.EventHandler(this.btnGuardarRes_Click);
            // 
            // lblResSumFil
            // 
            this.lblResSumFil.AutoSize = true;
            this.lblResSumFil.Location = new System.Drawing.Point(167, 343);
            this.lblResSumFil.Name = "lblResSumFil";
            this.lblResSumFil.Size = new System.Drawing.Size(219, 13);
            this.lblResSumFil.TabIndex = 49;
            this.lblResSumFil.Text = "Suma del resultado de las sumas de las filas :";
            // 
            // rtbResSumFil
            // 
            this.rtbResSumFil.Location = new System.Drawing.Point(388, 337);
            this.rtbResSumFil.Name = "rtbResSumFil";
            this.rtbResSumFil.Size = new System.Drawing.Size(100, 23);
            this.rtbResSumFil.TabIndex = 48;
            this.rtbResSumFil.Text = "";
            // 
            // btnSumSumFilas
            // 
            this.btnSumSumFilas.Location = new System.Drawing.Point(494, 332);
            this.btnSumSumFilas.Name = "btnSumSumFilas";
            this.btnSumSumFilas.Size = new System.Drawing.Size(85, 35);
            this.btnSumSumFilas.TabIndex = 47;
            this.btnSumSumFilas.Text = "Suma de suma Filas";
            this.btnSumSumFilas.UseVisualStyleBackColor = true;
            this.btnSumSumFilas.Click += new System.EventHandler(this.btnSumSumFilas_Click);
            // 
            // lblResSumCol
            // 
            this.lblResSumCol.AutoSize = true;
            this.lblResSumCol.Location = new System.Drawing.Point(135, 297);
            this.lblResSumCol.Name = "lblResSumCol";
            this.lblResSumCol.Size = new System.Drawing.Size(247, 13);
            this.lblResSumCol.TabIndex = 46;
            this.lblResSumCol.Text = "Suma del resultado de las sumas de las Columnas :";
            // 
            // rtbResSumcol
            // 
            this.rtbResSumcol.Location = new System.Drawing.Point(388, 294);
            this.rtbResSumcol.Name = "rtbResSumcol";
            this.rtbResSumcol.Size = new System.Drawing.Size(100, 23);
            this.rtbResSumcol.TabIndex = 45;
            this.rtbResSumcol.Text = "";
            // 
            // btnSumSumcolumnas
            // 
            this.btnSumSumcolumnas.Location = new System.Drawing.Point(494, 286);
            this.btnSumSumcolumnas.Name = "btnSumSumcolumnas";
            this.btnSumSumcolumnas.Size = new System.Drawing.Size(85, 35);
            this.btnSumSumcolumnas.TabIndex = 44;
            this.btnSumSumcolumnas.Text = "Suma de suma Columnas";
            this.btnSumSumcolumnas.UseVisualStyleBackColor = true;
            this.btnSumSumcolumnas.Click += new System.EventHandler(this.btnSumSumcolumnas_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(635, 379);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(85, 23);
            this.btnSalir.TabIndex = 43;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // lblSumaDiagonal
            // 
            this.lblSumaDiagonal.AutoSize = true;
            this.lblSumaDiagonal.Location = new System.Drawing.Point(195, 253);
            this.lblSumaDiagonal.Name = "lblSumaDiagonal";
            this.lblSumaDiagonal.Size = new System.Drawing.Size(191, 13);
            this.lblSumaDiagonal.TabIndex = 42;
            this.lblSumaDiagonal.Text = "Suma de los elementos de la diagonal :";
            // 
            // rtbSumaDiagonal
            // 
            this.rtbSumaDiagonal.Location = new System.Drawing.Point(388, 250);
            this.rtbSumaDiagonal.Name = "rtbSumaDiagonal";
            this.rtbSumaDiagonal.Size = new System.Drawing.Size(100, 23);
            this.rtbSumaDiagonal.TabIndex = 41;
            this.rtbSumaDiagonal.Text = "";
            // 
            // btnSumaDiagonales
            // 
            this.btnSumaDiagonales.Location = new System.Drawing.Point(494, 223);
            this.btnSumaDiagonales.Name = "btnSumaDiagonales";
            this.btnSumaDiagonales.Size = new System.Drawing.Size(85, 54);
            this.btnSumaDiagonales.TabIndex = 40;
            this.btnSumaDiagonales.Text = "Suma elementos de la Diagonal";
            this.btnSumaDiagonales.UseVisualStyleBackColor = true;
            this.btnSumaDiagonales.Click += new System.EventHandler(this.btnSumaDiagonales_Click);
            // 
            // btnSumaColumnas
            // 
            this.btnSumaColumnas.Location = new System.Drawing.Point(559, 65);
            this.btnSumaColumnas.Name = "btnSumaColumnas";
            this.btnSumaColumnas.Size = new System.Drawing.Size(75, 39);
            this.btnSumaColumnas.TabIndex = 39;
            this.btnSumaColumnas.Text = "Suma Columnas";
            this.btnSumaColumnas.UseVisualStyleBackColor = true;
            this.btnSumaColumnas.Click += new System.EventHandler(this.btnSumaColumnas_Click);
            // 
            // btnSumaFilas
            // 
            this.btnSumaFilas.Location = new System.Drawing.Point(247, 127);
            this.btnSumaFilas.Name = "btnSumaFilas";
            this.btnSumaFilas.Size = new System.Drawing.Size(60, 37);
            this.btnSumaFilas.TabIndex = 38;
            this.btnSumaFilas.Text = "Suma Filas";
            this.btnSumaFilas.UseVisualStyleBackColor = true;
            this.btnSumaFilas.Click += new System.EventHandler(this.btnSumaFilas_Click);
            // 
            // btnElementosDiagonal
            // 
            this.btnElementosDiagonal.Location = new System.Drawing.Point(494, 166);
            this.btnElementosDiagonal.Name = "btnElementosDiagonal";
            this.btnElementosDiagonal.Size = new System.Drawing.Size(85, 51);
            this.btnElementosDiagonal.TabIndex = 37;
            this.btnElementosDiagonal.Text = "Elementos de la diagonal";
            this.btnElementosDiagonal.UseVisualStyleBackColor = true;
            this.btnElementosDiagonal.Click += new System.EventHandler(this.btnElementosDiagonal_Click);
            // 
            // nudTamanoMatriz
            // 
            this.nudTamanoMatriz.Location = new System.Drawing.Point(198, 37);
            this.nudTamanoMatriz.Name = "nudTamanoMatriz";
            this.nudTamanoMatriz.Size = new System.Drawing.Size(52, 20);
            this.nudTamanoMatriz.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(313, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Sumas Filas :";
            // 
            // lblSumasColumnas
            // 
            this.lblSumasColumnas.AutoSize = true;
            this.lblSumasColumnas.Location = new System.Drawing.Point(540, 37);
            this.lblSumasColumnas.Name = "lblSumasColumnas";
            this.lblSumasColumnas.Size = new System.Drawing.Size(94, 13);
            this.lblSumasColumnas.TabIndex = 34;
            this.lblSumasColumnas.Text = ": Sumas Columnas";
            // 
            // lblSumasDiagonales
            // 
            this.lblSumasDiagonales.AutoSize = true;
            this.lblSumasDiagonales.Location = new System.Drawing.Point(195, 185);
            this.lblSumasDiagonales.Name = "lblSumasDiagonales";
            this.lblSumasDiagonales.Size = new System.Drawing.Size(187, 13);
            this.lblSumasDiagonales.TabIndex = 33;
            this.lblSumasDiagonales.Text = "Elementos de la diagonal Diagonales :";
            // 
            // rtbElementosDiagonal
            // 
            this.rtbElementosDiagonal.Location = new System.Drawing.Point(388, 182);
            this.rtbElementosDiagonal.Name = "rtbElementosDiagonal";
            this.rtbElementosDiagonal.Size = new System.Drawing.Size(100, 23);
            this.rtbElementosDiagonal.TabIndex = 32;
            this.rtbElementosDiagonal.Text = "";
            // 
            // rtbSumaColumnas
            // 
            this.rtbSumaColumnas.Location = new System.Drawing.Point(494, 34);
            this.rtbSumaColumnas.Name = "rtbSumaColumnas";
            this.rtbSumaColumnas.Size = new System.Drawing.Size(40, 96);
            this.rtbSumaColumnas.TabIndex = 31;
            this.rtbSumaColumnas.Text = "";
            // 
            // rtbSumaFilas
            // 
            this.rtbSumaFilas.Location = new System.Drawing.Point(388, 136);
            this.rtbSumaFilas.Name = "rtbSumaFilas";
            this.rtbSumaFilas.Size = new System.Drawing.Size(100, 23);
            this.rtbSumaFilas.TabIndex = 30;
            this.rtbSumaFilas.Text = "";
            // 
            // rtbMatrizNM
            // 
            this.rtbMatrizNM.Location = new System.Drawing.Point(388, 34);
            this.rtbMatrizNM.Name = "rtbMatrizNM";
            this.rtbMatrizNM.Size = new System.Drawing.Size(100, 96);
            this.rtbMatrizNM.TabIndex = 29;
            this.rtbMatrizNM.Text = "";
            // 
            // btnAgregarElementos
            // 
            this.btnAgregarElementos.Location = new System.Drawing.Point(256, 23);
            this.btnAgregarElementos.Name = "btnAgregarElementos";
            this.btnAgregarElementos.Size = new System.Drawing.Size(75, 48);
            this.btnAgregarElementos.TabIndex = 28;
            this.btnAgregarElementos.Text = "Agregar Elementos";
            this.btnAgregarElementos.UseVisualStyleBackColor = true;
            this.btnAgregarElementos.Click += new System.EventHandler(this.btnAgregarElementos_Click);
            // 
            // lblExtensionMatriz
            // 
            this.lblExtensionMatriz.AutoSize = true;
            this.lblExtensionMatriz.Location = new System.Drawing.Point(80, 37);
            this.lblExtensionMatriz.Name = "lblExtensionMatriz";
            this.lblExtensionMatriz.Size = new System.Drawing.Size(111, 13);
            this.lblExtensionMatriz.TabIndex = 27;
            this.lblExtensionMatriz.Text = "Tamaño de la matriz  :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 431);
            this.Controls.Add(this.btnGuardarRes);
            this.Controls.Add(this.lblResSumFil);
            this.Controls.Add(this.rtbResSumFil);
            this.Controls.Add(this.btnSumSumFilas);
            this.Controls.Add(this.lblResSumCol);
            this.Controls.Add(this.rtbResSumcol);
            this.Controls.Add(this.btnSumSumcolumnas);
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
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudTamanoMatriz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardarRes;
        private System.Windows.Forms.Label lblResSumFil;
        private System.Windows.Forms.RichTextBox rtbResSumFil;
        private System.Windows.Forms.Button btnSumSumFilas;
        private System.Windows.Forms.Label lblResSumCol;
        private System.Windows.Forms.RichTextBox rtbResSumcol;
        private System.Windows.Forms.Button btnSumSumcolumnas;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblSumaDiagonal;
        private System.Windows.Forms.RichTextBox rtbSumaDiagonal;
        private System.Windows.Forms.Button btnSumaDiagonales;
        private System.Windows.Forms.Button btnSumaColumnas;
        private System.Windows.Forms.Button btnSumaFilas;
        private System.Windows.Forms.Button btnElementosDiagonal;
        private System.Windows.Forms.NumericUpDown nudTamanoMatriz;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSumasColumnas;
        private System.Windows.Forms.Label lblSumasDiagonales;
        private System.Windows.Forms.RichTextBox rtbElementosDiagonal;
        private System.Windows.Forms.RichTextBox rtbSumaColumnas;
        private System.Windows.Forms.RichTextBox rtbSumaFilas;
        private System.Windows.Forms.RichTextBox rtbMatrizNM;
        private System.Windows.Forms.Button btnAgregarElementos;
        private System.Windows.Forms.Label lblExtensionMatriz;
    }
}

