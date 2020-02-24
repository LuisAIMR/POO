namespace Cuadrado
{
    partial class frmCuadrado
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
            this.lblLado = new System.Windows.Forms.Label();
            this.lblResArea = new System.Windows.Forms.Label();
            this.lblResPerimetro = new System.Windows.Forms.Label();
            this.txtLado = new System.Windows.Forms.TextBox();
            this.btnPerimetro = new System.Windows.Forms.Button();
            this.btnArea = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblCuadrado = new System.Windows.Forms.Label();
            this.btnNuevoCuadrado = new System.Windows.Forms.Button();
            this.error1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.error1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLado
            // 
            this.lblLado.AutoSize = true;
            this.lblLado.Location = new System.Drawing.Point(53, 42);
            this.lblLado.Name = "lblLado";
            this.lblLado.Size = new System.Drawing.Size(37, 13);
            this.lblLado.TabIndex = 0;
            this.lblLado.Text = "Lado :";
            // 
            // lblResArea
            // 
            this.lblResArea.AutoSize = true;
            this.lblResArea.Location = new System.Drawing.Point(177, 101);
            this.lblResArea.Name = "lblResArea";
            this.lblResArea.Size = new System.Drawing.Size(0, 13);
            this.lblResArea.TabIndex = 2;
            // 
            // lblResPerimetro
            // 
            this.lblResPerimetro.AutoSize = true;
            this.lblResPerimetro.Location = new System.Drawing.Point(177, 70);
            this.lblResPerimetro.Name = "lblResPerimetro";
            this.lblResPerimetro.Size = new System.Drawing.Size(0, 13);
            this.lblResPerimetro.TabIndex = 1;
            // 
            // txtLado
            // 
            this.txtLado.Location = new System.Drawing.Point(96, 39);
            this.txtLado.Name = "txtLado";
            this.txtLado.Size = new System.Drawing.Size(120, 20);
            this.txtLado.TabIndex = 3;
            // 
            // btnPerimetro
            // 
            this.btnPerimetro.Location = new System.Drawing.Point(96, 65);
            this.btnPerimetro.Name = "btnPerimetro";
            this.btnPerimetro.Size = new System.Drawing.Size(75, 23);
            this.btnPerimetro.TabIndex = 4;
            this.btnPerimetro.Text = "Perimetro";
            this.btnPerimetro.UseVisualStyleBackColor = true;
            this.btnPerimetro.Click += new System.EventHandler(this.btnPerimetro_Click);
            // 
            // btnArea
            // 
            this.btnArea.Location = new System.Drawing.Point(96, 94);
            this.btnArea.Name = "btnArea";
            this.btnArea.Size = new System.Drawing.Size(75, 23);
            this.btnArea.TabIndex = 5;
            this.btnArea.Text = "Area";
            this.btnArea.UseVisualStyleBackColor = true;
            this.btnArea.Click += new System.EventHandler(this.btnArea_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(197, 226);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblCuadrado
            // 
            this.lblCuadrado.AutoSize = true;
            this.lblCuadrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuadrado.Location = new System.Drawing.Point(91, 9);
            this.lblCuadrado.Name = "lblCuadrado";
            this.lblCuadrado.Size = new System.Drawing.Size(106, 25);
            this.lblCuadrado.TabIndex = 7;
            this.lblCuadrado.Text = "Cuadrado";
            this.lblCuadrado.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnNuevoCuadrado
            // 
            this.btnNuevoCuadrado.Location = new System.Drawing.Point(12, 226);
            this.btnNuevoCuadrado.Name = "btnNuevoCuadrado";
            this.btnNuevoCuadrado.Size = new System.Drawing.Size(81, 23);
            this.btnNuevoCuadrado.TabIndex = 8;
            this.btnNuevoCuadrado.Text = "Nuevos datos";
            this.btnNuevoCuadrado.UseVisualStyleBackColor = true;
            this.btnNuevoCuadrado.Click += new System.EventHandler(this.btnNuevoCuadrado_Click);
            // 
            // error1
            // 
            this.error1.ContainerControl = this;
            // 
            // frmCuadrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnNuevoCuadrado);
            this.Controls.Add(this.lblCuadrado);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnArea);
            this.Controls.Add(this.btnPerimetro);
            this.Controls.Add(this.txtLado);
            this.Controls.Add(this.lblResArea);
            this.Controls.Add(this.lblResPerimetro);
            this.Controls.Add(this.lblLado);
            this.Name = "frmCuadrado";
            this.Text = "Cuadrado";
            ((System.ComponentModel.ISupportInitialize)(this.error1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLado;
        private System.Windows.Forms.Label lblResArea;
        private System.Windows.Forms.Label lblResPerimetro;
        private System.Windows.Forms.TextBox txtLado;
        private System.Windows.Forms.Button btnPerimetro;
        private System.Windows.Forms.Button btnArea;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblCuadrado;
        private System.Windows.Forms.Button btnNuevoCuadrado;
        private System.Windows.Forms.ErrorProvider error1;
    }
}

