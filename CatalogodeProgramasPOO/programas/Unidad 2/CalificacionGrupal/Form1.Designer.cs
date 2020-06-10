namespace CalificacionGrupal
{
    partial class frmCalificaciones
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
            this.lblCalificacion = new System.Windows.Forms.Label();
            this.lblAprobados = new System.Windows.Forms.Label();
            this.lblReprobados = new System.Windows.Forms.Label();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.lblTotalAprobados = new System.Windows.Forms.Label();
            this.lblTotalReprobados = new System.Windows.Forms.Label();
            this.lblResultadoPromedioGrupal = new System.Windows.Forms.Label();
            this.txtCalificacion = new System.Windows.Forms.TextBox();
            this.btnCapturar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.error1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.error1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCalificacion
            // 
            this.lblCalificacion.AutoSize = true;
            this.lblCalificacion.Location = new System.Drawing.Point(8, 30);
            this.lblCalificacion.Name = "lblCalificacion";
            this.lblCalificacion.Size = new System.Drawing.Size(121, 13);
            this.lblCalificacion.TabIndex = 0;
            this.lblCalificacion.Text = "lntroduce la calificacion:";
            // 
            // lblAprobados
            // 
            this.lblAprobados.AutoSize = true;
            this.lblAprobados.Location = new System.Drawing.Point(12, 131);
            this.lblAprobados.Name = "lblAprobados";
            this.lblAprobados.Size = new System.Drawing.Size(61, 13);
            this.lblAprobados.TabIndex = 1;
            this.lblAprobados.Text = "Aprobados:";
            // 
            // lblReprobados
            // 
            this.lblReprobados.AutoSize = true;
            this.lblReprobados.Location = new System.Drawing.Point(8, 159);
            this.lblReprobados.Name = "lblReprobados";
            this.lblReprobados.Size = new System.Drawing.Size(68, 13);
            this.lblReprobados.TabIndex = 2;
            this.lblReprobados.Text = "Reprobados:";
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Location = new System.Drawing.Point(15, 189);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(54, 13);
            this.lblPromedio.TabIndex = 3;
            this.lblPromedio.Text = "Promedio:";
            // 
            // lblTotalAprobados
            // 
            this.lblTotalAprobados.AutoSize = true;
            this.lblTotalAprobados.Location = new System.Drawing.Point(85, 131);
            this.lblTotalAprobados.Name = "lblTotalAprobados";
            this.lblTotalAprobados.Size = new System.Drawing.Size(0, 13);
            this.lblTotalAprobados.TabIndex = 4;
            // 
            // lblTotalReprobados
            // 
            this.lblTotalReprobados.AutoSize = true;
            this.lblTotalReprobados.Location = new System.Drawing.Point(87, 159);
            this.lblTotalReprobados.Name = "lblTotalReprobados";
            this.lblTotalReprobados.Size = new System.Drawing.Size(0, 13);
            this.lblTotalReprobados.TabIndex = 5;
            // 
            // lblResultadoPromedioGrupal
            // 
            this.lblResultadoPromedioGrupal.AutoSize = true;
            this.lblResultadoPromedioGrupal.Location = new System.Drawing.Point(85, 189);
            this.lblResultadoPromedioGrupal.Name = "lblResultadoPromedioGrupal";
            this.lblResultadoPromedioGrupal.Size = new System.Drawing.Size(0, 13);
            this.lblResultadoPromedioGrupal.TabIndex = 6;
            // 
            // txtCalificacion
            // 
            this.txtCalificacion.Location = new System.Drawing.Point(135, 27);
            this.txtCalificacion.Name = "txtCalificacion";
            this.txtCalificacion.Size = new System.Drawing.Size(80, 20);
            this.txtCalificacion.TabIndex = 7;
            this.txtCalificacion.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnCapturar
            // 
            this.btnCapturar.Location = new System.Drawing.Point(150, 53);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Size = new System.Drawing.Size(65, 20);
            this.btnCapturar.TabIndex = 8;
            this.btnCapturar.Text = "Capturar";
            this.btnCapturar.UseVisualStyleBackColor = true;
            this.btnCapturar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(156, 227);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(59, 22);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(0, 108);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(73, 20);
            this.btnReporte.TabIndex = 10;
            this.btnReporte.Text = "Reporte";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.button3_Click);
            // 
            // error1
            // 
            this.error1.ContainerControl = this;
            // 
            // frmCalificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 261);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCapturar);
            this.Controls.Add(this.txtCalificacion);
            this.Controls.Add(this.lblResultadoPromedioGrupal);
            this.Controls.Add(this.lblTotalReprobados);
            this.Controls.Add(this.lblTotalAprobados);
            this.Controls.Add(this.lblPromedio);
            this.Controls.Add(this.lblReprobados);
            this.Controls.Add(this.lblAprobados);
            this.Controls.Add(this.lblCalificacion);
            this.Name = "frmCalificaciones";
            this.Text = "Calificaciones ";
            this.Load += new System.EventHandler(this.frmCalificaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.error1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCalificacion;
        private System.Windows.Forms.Label lblAprobados;
        private System.Windows.Forms.Label lblReprobados;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Label lblTotalAprobados;
        private System.Windows.Forms.Label lblTotalReprobados;
        private System.Windows.Forms.Label lblResultadoPromedioGrupal;
        private System.Windows.Forms.TextBox txtCalificacion;
        private System.Windows.Forms.Button btnCapturar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.ErrorProvider error1;
    }
}

