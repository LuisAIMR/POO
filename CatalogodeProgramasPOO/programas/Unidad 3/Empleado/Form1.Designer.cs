namespace Empleado
{
    partial class frmEmpleado
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
            this.lblAñosTrabajo = new System.Windows.Forms.Label();
            this.txtAniosTrabajados = new System.Windows.Forms.TextBox();
            this.lblVacasiones = new System.Windows.Forms.Label();
            this.lblResVacasiones = new System.Windows.Forms.Label();
            this.btnEvaluar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.error1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.error1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAñosTrabajo
            // 
            this.lblAñosTrabajo.AutoSize = true;
            this.lblAñosTrabajo.Location = new System.Drawing.Point(1, 38);
            this.lblAñosTrabajo.Name = "lblAñosTrabajo";
            this.lblAñosTrabajo.Size = new System.Drawing.Size(156, 13);
            this.lblAñosTrabajo.TabIndex = 0;
            this.lblAñosTrabajo.Text = "Años de trabajo en la empresa :";
            // 
            // txtAniosTrabajados
            // 
            this.txtAniosTrabajados.Location = new System.Drawing.Point(160, 35);
            this.txtAniosTrabajados.Name = "txtAniosTrabajados";
            this.txtAniosTrabajados.Size = new System.Drawing.Size(100, 20);
            this.txtAniosTrabajados.TabIndex = 1;
            // 
            // lblVacasiones
            // 
            this.lblVacasiones.AutoSize = true;
            this.lblVacasiones.Location = new System.Drawing.Point(1, 113);
            this.lblVacasiones.Name = "lblVacasiones";
            this.lblVacasiones.Size = new System.Drawing.Size(229, 13);
            this.lblVacasiones.TabIndex = 2;
            this.lblVacasiones.Text = "Los dias Correspondientes de vacasiones son :";
            // 
            // lblResVacasiones
            // 
            this.lblResVacasiones.AutoSize = true;
            this.lblResVacasiones.Location = new System.Drawing.Point(236, 113);
            this.lblResVacasiones.Name = "lblResVacasiones";
            this.lblResVacasiones.Size = new System.Drawing.Size(0, 13);
            this.lblResVacasiones.TabIndex = 3;
            // 
            // btnEvaluar
            // 
            this.btnEvaluar.Location = new System.Drawing.Point(185, 61);
            this.btnEvaluar.Name = "btnEvaluar";
            this.btnEvaluar.Size = new System.Drawing.Size(75, 23);
            this.btnEvaluar.TabIndex = 4;
            this.btnEvaluar.Text = "Evaluar";
            this.btnEvaluar.UseVisualStyleBackColor = true;
            this.btnEvaluar.Click += new System.EventHandler(this.btnEvaluar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(12, 226);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 5;
            this.btnNuevo.Text = "Nuevo ";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
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
            // error1
            // 
            this.error1.ContainerControl = this;
            // 
            // frmEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnEvaluar);
            this.Controls.Add(this.lblResVacasiones);
            this.Controls.Add(this.lblVacasiones);
            this.Controls.Add(this.txtAniosTrabajados);
            this.Controls.Add(this.lblAñosTrabajo);
            this.Name = "frmEmpleado";
            this.Text = "Empleado";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.error1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAñosTrabajo;
        private System.Windows.Forms.TextBox txtAniosTrabajados;
        private System.Windows.Forms.Label lblVacasiones;
        private System.Windows.Forms.Label lblResVacasiones;
        private System.Windows.Forms.Button btnEvaluar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ErrorProvider error1;
    }
}

