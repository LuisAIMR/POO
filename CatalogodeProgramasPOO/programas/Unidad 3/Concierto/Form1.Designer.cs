namespace Concierto
{
    partial class frmAsistentes
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
            this.lblAsistente = new System.Windows.Forms.Label();
            this.cmbAsistente = new System.Windows.Forms.ComboBox();
            this.cmbCantidad = new System.Windows.Forms.ComboBox();
            this.btnContabilizar = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.lblBebes = new System.Windows.Forms.Label();
            this.lblNiños = new System.Windows.Forms.Label();
            this.lblAdultos = new System.Windows.Forms.Label();
            this.lblAdultosMayores = new System.Windows.Forms.Label();
            this.lblCantidadBebes = new System.Windows.Forms.Label();
            this.lblCantidadNiños = new System.Windows.Forms.Label();
            this.lblCantidadAdultos = new System.Windows.Forms.Label();
            this.lblCantidadAdultosMayores = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.error1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.error1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAsistente
            // 
            this.lblAsistente.AutoSize = true;
            this.lblAsistente.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsistente.Location = new System.Drawing.Point(12, 23);
            this.lblAsistente.Name = "lblAsistente";
            this.lblAsistente.Size = new System.Drawing.Size(72, 23);
            this.lblAsistente.TabIndex = 0;
            this.lblAsistente.Text = "Asistente";
            this.lblAsistente.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbAsistente
            // 
            this.cmbAsistente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAsistente.FormattingEnabled = true;
            this.cmbAsistente.Location = new System.Drawing.Point(88, 25);
            this.cmbAsistente.Name = "cmbAsistente";
            this.cmbAsistente.Size = new System.Drawing.Size(161, 21);
            this.cmbAsistente.TabIndex = 1;
            this.cmbAsistente.SelectedIndexChanged += new System.EventHandler(this.cmbAsistente_SelectedIndexChanged);
            // 
            // cmbCantidad
            // 
            this.cmbCantidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCantidad.FormattingEnabled = true;
            this.cmbCantidad.Location = new System.Drawing.Point(195, 52);
            this.cmbCantidad.Name = "cmbCantidad";
            this.cmbCantidad.Size = new System.Drawing.Size(54, 21);
            this.cmbCantidad.TabIndex = 2;
            this.cmbCantidad.SelectedIndexChanged += new System.EventHandler(this.cmbCantidad_SelectedIndexChanged);
            // 
            // btnContabilizar
            // 
            this.btnContabilizar.Location = new System.Drawing.Point(177, 88);
            this.btnContabilizar.Name = "btnContabilizar";
            this.btnContabilizar.Size = new System.Drawing.Size(72, 25);
            this.btnContabilizar.TabIndex = 3;
            this.btnContabilizar.Text = "Contabilizar";
            this.btnContabilizar.UseVisualStyleBackColor = true;
            this.btnContabilizar.Click += new System.EventHandler(this.btnContabilizar_Click);
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(93, 152);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(72, 23);
            this.btnReporte.TabIndex = 4;
            this.btnReporte.Text = "Reporte";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblBebes
            // 
            this.lblBebes.AutoSize = true;
            this.lblBebes.Location = new System.Drawing.Point(90, 178);
            this.lblBebes.Name = "lblBebes";
            this.lblBebes.Size = new System.Drawing.Size(40, 13);
            this.lblBebes.TabIndex = 5;
            this.lblBebes.Text = "Bebes:";
            this.lblBebes.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblNiños
            // 
            this.lblNiños.AutoSize = true;
            this.lblNiños.Location = new System.Drawing.Point(93, 205);
            this.lblNiños.Name = "lblNiños";
            this.lblNiños.Size = new System.Drawing.Size(37, 13);
            this.lblNiños.TabIndex = 6;
            this.lblNiños.Text = "Niños:";
            // 
            // lblAdultos
            // 
            this.lblAdultos.AutoSize = true;
            this.lblAdultos.Location = new System.Drawing.Point(85, 232);
            this.lblAdultos.Name = "lblAdultos";
            this.lblAdultos.Size = new System.Drawing.Size(45, 13);
            this.lblAdultos.TabIndex = 7;
            this.lblAdultos.Text = "Adultos:";
            // 
            // lblAdultosMayores
            // 
            this.lblAdultosMayores.AutoSize = true;
            this.lblAdultosMayores.Location = new System.Drawing.Point(43, 258);
            this.lblAdultosMayores.Name = "lblAdultosMayores";
            this.lblAdultosMayores.Size = new System.Drawing.Size(87, 13);
            this.lblAdultosMayores.TabIndex = 8;
            this.lblAdultosMayores.Text = "Adultos mayores:";
            this.lblAdultosMayores.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblCantidadBebes
            // 
            this.lblCantidadBebes.AutoSize = true;
            this.lblCantidadBebes.Location = new System.Drawing.Point(145, 178);
            this.lblCantidadBebes.Name = "lblCantidadBebes";
            this.lblCantidadBebes.Size = new System.Drawing.Size(0, 13);
            this.lblCantidadBebes.TabIndex = 9;
            // 
            // lblCantidadNiños
            // 
            this.lblCantidadNiños.AutoSize = true;
            this.lblCantidadNiños.Location = new System.Drawing.Point(145, 205);
            this.lblCantidadNiños.Name = "lblCantidadNiños";
            this.lblCantidadNiños.Size = new System.Drawing.Size(0, 13);
            this.lblCantidadNiños.TabIndex = 10;
            // 
            // lblCantidadAdultos
            // 
            this.lblCantidadAdultos.AutoSize = true;
            this.lblCantidadAdultos.Location = new System.Drawing.Point(145, 232);
            this.lblCantidadAdultos.Name = "lblCantidadAdultos";
            this.lblCantidadAdultos.Size = new System.Drawing.Size(0, 13);
            this.lblCantidadAdultos.TabIndex = 11;
            // 
            // lblCantidadAdultosMayores
            // 
            this.lblCantidadAdultosMayores.AutoSize = true;
            this.lblCantidadAdultosMayores.Location = new System.Drawing.Point(145, 258);
            this.lblCantidadAdultosMayores.Name = "lblCantidadAdultosMayores";
            this.lblCantidadAdultosMayores.Size = new System.Drawing.Size(0, 13);
            this.lblCantidadAdultosMayores.TabIndex = 12;
            this.lblCantidadAdultosMayores.Click += new System.EventHandler(this.label8_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(234, 274);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(45, 23);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // error1
            // 
            this.error1.ContainerControl = this;
            // 
            // frmAsistentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 309);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblCantidadAdultosMayores);
            this.Controls.Add(this.lblCantidadAdultos);
            this.Controls.Add(this.lblCantidadNiños);
            this.Controls.Add(this.lblCantidadBebes);
            this.Controls.Add(this.lblAdultosMayores);
            this.Controls.Add(this.lblAdultos);
            this.Controls.Add(this.lblNiños);
            this.Controls.Add(this.lblBebes);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.btnContabilizar);
            this.Controls.Add(this.cmbCantidad);
            this.Controls.Add(this.cmbAsistente);
            this.Controls.Add(this.lblAsistente);
            this.Name = "frmAsistentes";
            this.Text = "Asistentes a un concierto";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.error1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAsistente;
        private System.Windows.Forms.ComboBox cmbAsistente;
        private System.Windows.Forms.ComboBox cmbCantidad;
        private System.Windows.Forms.Button btnContabilizar;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Label lblBebes;
        private System.Windows.Forms.Label lblNiños;
        private System.Windows.Forms.Label lblAdultos;
        private System.Windows.Forms.Label lblAdultosMayores;
        private System.Windows.Forms.Label lblCantidadBebes;
        private System.Windows.Forms.Label lblCantidadNiños;
        private System.Windows.Forms.Label lblCantidadAdultos;
        private System.Windows.Forms.Label lblCantidadAdultosMayores;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ErrorProvider error1;
    }
}

