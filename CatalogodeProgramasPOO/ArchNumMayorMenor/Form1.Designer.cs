namespace ArchNumMayorMenor
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
            this.components = new System.ComponentModel.Container();
            this.btnResultado = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblCantidadNumeros = new System.Windows.Forms.Label();
            this.txtCantidadNumeros = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnResultado
            // 
            this.btnResultado.Location = new System.Drawing.Point(250, 218);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(75, 23);
            this.btnResultado.TabIndex = 7;
            this.btnResultado.Text = "Resultado";
            this.btnResultado.UseVisualStyleBackColor = true;
            this.btnResultado.Click += new System.EventHandler(this.btnResultado_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(250, 52);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblCantidadNumeros
            // 
            this.lblCantidadNumeros.AutoSize = true;
            this.lblCantidadNumeros.Location = new System.Drawing.Point(22, 55);
            this.lblCantidadNumeros.Name = "lblCantidadNumeros";
            this.lblCantidadNumeros.Size = new System.Drawing.Size(113, 13);
            this.lblCantidadNumeros.TabIndex = 5;
            this.lblCantidadNumeros.Text = "Cantidad de numeros :";
            // 
            // txtCantidadNumeros
            // 
            this.txtCantidadNumeros.Location = new System.Drawing.Point(135, 52);
            this.txtCantidadNumeros.Name = "txtCantidadNumeros";
            this.txtCantidadNumeros.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadNumeros.TabIndex = 4;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 292);
            this.Controls.Add(this.btnResultado);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblCantidadNumeros);
            this.Controls.Add(this.txtCantidadNumeros);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnResultado;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblCantidadNumeros;
        private System.Windows.Forms.TextBox txtCantidadNumeros;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

