namespace FigurasGeometricas2
{
    partial class FrmFigurasGeo
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
            this.lblElegir = new System.Windows.Forms.Label();
            this.btnListo = new System.Windows.Forms.Button();
            this.cxbCirculo = new System.Windows.Forms.CheckBox();
            this.cxbCuadrado = new System.Windows.Forms.CheckBox();
            this.cxbTriangulo = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblElegir
            // 
            this.lblElegir.AutoSize = true;
            this.lblElegir.Font = new System.Drawing.Font("Arial Narrow", 18F);
            this.lblElegir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblElegir.Location = new System.Drawing.Point(36, 64);
            this.lblElegir.Name = "lblElegir";
            this.lblElegir.Size = new System.Drawing.Size(277, 29);
            this.lblElegir.TabIndex = 9;
            this.lblElegir.Text = "Elige las figuras que requieres";
            // 
            // btnListo
            // 
            this.btnListo.Location = new System.Drawing.Point(137, 220);
            this.btnListo.Name = "btnListo";
            this.btnListo.Size = new System.Drawing.Size(70, 23);
            this.btnListo.TabIndex = 8;
            this.btnListo.Text = "Listo";
            this.btnListo.UseVisualStyleBackColor = true;
            this.btnListo.Click += new System.EventHandler(this.btnListo_Click);
            // 
            // cxbCirculo
            // 
            this.cxbCirculo.AutoSize = true;
            this.cxbCirculo.Location = new System.Drawing.Point(240, 130);
            this.cxbCirculo.Name = "cxbCirculo";
            this.cxbCirculo.Size = new System.Drawing.Size(58, 17);
            this.cxbCirculo.TabIndex = 7;
            this.cxbCirculo.Text = "Circulo";
            this.cxbCirculo.UseVisualStyleBackColor = true;
            // 
            // cxbCuadrado
            // 
            this.cxbCuadrado.AutoSize = true;
            this.cxbCuadrado.Location = new System.Drawing.Point(41, 130);
            this.cxbCuadrado.Name = "cxbCuadrado";
            this.cxbCuadrado.Size = new System.Drawing.Size(72, 17);
            this.cxbCuadrado.TabIndex = 6;
            this.cxbCuadrado.Text = "Cuadrado";
            this.cxbCuadrado.UseVisualStyleBackColor = true;
            // 
            // cxbTriangulo
            // 
            this.cxbTriangulo.AutoSize = true;
            this.cxbTriangulo.Location = new System.Drawing.Point(137, 130);
            this.cxbTriangulo.Name = "cxbTriangulo";
            this.cxbTriangulo.Size = new System.Drawing.Size(70, 17);
            this.cxbTriangulo.TabIndex = 5;
            this.cxbTriangulo.Text = "Triangulo";
            this.cxbTriangulo.UseVisualStyleBackColor = true;
            // 
            // FrmFigurasGeo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 317);
            this.Controls.Add(this.lblElegir);
            this.Controls.Add(this.btnListo);
            this.Controls.Add(this.cxbCirculo);
            this.Controls.Add(this.cxbCuadrado);
            this.Controls.Add(this.cxbTriangulo);
            this.Name = "FrmFigurasGeo";
            this.Text = "Figuras Geometricas 2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblElegir;
        private System.Windows.Forms.Button btnListo;
        private System.Windows.Forms.CheckBox cxbCirculo;
        private System.Windows.Forms.CheckBox cxbCuadrado;
        private System.Windows.Forms.CheckBox cxbTriangulo;
    }
}

