namespace NumerosMayorMenor
{
    partial class frmNumeros
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
            this.components = new System.ComponentModel.Container();
            this.txtCantidadNumeros = new System.Windows.Forms.TextBox();
            this.lblCantidadNumeros = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnResultado = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCantidadNumeros
            // 
            this.txtCantidadNumeros.Location = new System.Drawing.Point(125, 60);
            this.txtCantidadNumeros.Name = "txtCantidadNumeros";
            this.txtCantidadNumeros.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadNumeros.TabIndex = 0;
            // 
            // lblCantidadNumeros
            // 
            this.lblCantidadNumeros.AutoSize = true;
            this.lblCantidadNumeros.Location = new System.Drawing.Point(12, 63);
            this.lblCantidadNumeros.Name = "lblCantidadNumeros";
            this.lblCantidadNumeros.Size = new System.Drawing.Size(113, 13);
            this.lblCantidadNumeros.TabIndex = 1;
            this.lblCantidadNumeros.Text = "Cantidad de numeros :";
            this.lblCantidadNumeros.Click += new System.EventHandler(this.lblCantidadNumeros_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(240, 60);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnResultado
            // 
            this.btnResultado.Location = new System.Drawing.Point(240, 226);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(75, 23);
            this.btnResultado.TabIndex = 3;
            this.btnResultado.Text = "Resultado";
            this.btnResultado.UseVisualStyleBackColor = true;
            this.btnResultado.Click += new System.EventHandler(this.btnResultado_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmNumeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 261);
            this.Controls.Add(this.btnResultado);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblCantidadNumeros);
            this.Controls.Add(this.txtCantidadNumeros);
            this.Name = "frmNumeros";
            this.Text = "Numeros";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCantidadNumeros;
        private System.Windows.Forms.Label lblCantidadNumeros;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnResultado;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

