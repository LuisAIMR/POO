namespace ArchTorneo
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
            this.btnAgregarDatosEquipos = new System.Windows.Forms.Button();
            this.btnDeterminarGanador = new System.Windows.Forms.Button();
            this.gbxDatosTorneo = new System.Windows.Forms.GroupBox();
            this.gbxPuntosPartido = new System.Windows.Forms.GroupBox();
            this.nudGanado = new System.Windows.Forms.NumericUpDown();
            this.nudEmpate = new System.Windows.Forms.NumericUpDown();
            this.nudPerdido = new System.Windows.Forms.NumericUpDown();
            this.lblPuntosGanados = new System.Windows.Forms.Label();
            this.lblPuntosEmpate = new System.Windows.Forms.Label();
            this.lblPuntosPerdido = new System.Windows.Forms.Label();
            this.lblNombreTorneo = new System.Windows.Forms.Label();
            this.btnAgregarDatosTorneo = new System.Windows.Forms.Button();
            this.txtNombreTornero = new System.Windows.Forms.TextBox();
            this.nudNumEquipos = new System.Windows.Forms.NumericUpDown();
            this.dtpFechaIncio = new System.Windows.Forms.DateTimePicker();
            this.lblNumeroEquipos = new System.Windows.Forms.Label();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbxDatosTorneo.SuspendLayout();
            this.gbxPuntosPartido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGanado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEmpate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPerdido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumEquipos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarDatosEquipos
            // 
            this.btnAgregarDatosEquipos.Location = new System.Drawing.Point(57, 283);
            this.btnAgregarDatosEquipos.Name = "btnAgregarDatosEquipos";
            this.btnAgregarDatosEquipos.Size = new System.Drawing.Size(172, 23);
            this.btnAgregarDatosEquipos.TabIndex = 20;
            this.btnAgregarDatosEquipos.Text = "Agregar Datos de los Esquipos";
            this.btnAgregarDatosEquipos.UseVisualStyleBackColor = true;
            this.btnAgregarDatosEquipos.Click += new System.EventHandler(this.btnAgregarDatosEquipos_Click);
            // 
            // btnDeterminarGanador
            // 
            this.btnDeterminarGanador.Location = new System.Drawing.Point(352, 283);
            this.btnDeterminarGanador.Name = "btnDeterminarGanador";
            this.btnDeterminarGanador.Size = new System.Drawing.Size(118, 23);
            this.btnDeterminarGanador.TabIndex = 19;
            this.btnDeterminarGanador.Text = "Determinar Ganador";
            this.btnDeterminarGanador.UseVisualStyleBackColor = true;
            this.btnDeterminarGanador.Click += new System.EventHandler(this.btnDeterminarGanador_Click);
            // 
            // gbxDatosTorneo
            // 
            this.gbxDatosTorneo.Controls.Add(this.gbxPuntosPartido);
            this.gbxDatosTorneo.Controls.Add(this.lblNombreTorneo);
            this.gbxDatosTorneo.Controls.Add(this.btnAgregarDatosTorneo);
            this.gbxDatosTorneo.Controls.Add(this.txtNombreTornero);
            this.gbxDatosTorneo.Controls.Add(this.nudNumEquipos);
            this.gbxDatosTorneo.Controls.Add(this.dtpFechaIncio);
            this.gbxDatosTorneo.Controls.Add(this.lblNumeroEquipos);
            this.gbxDatosTorneo.Controls.Add(this.lblFechaInicio);
            this.gbxDatosTorneo.Controls.Add(this.dtpFechaFin);
            this.gbxDatosTorneo.Controls.Add(this.lblFechaFin);
            this.gbxDatosTorneo.Location = new System.Drawing.Point(57, 49);
            this.gbxDatosTorneo.Name = "gbxDatosTorneo";
            this.gbxDatosTorneo.Size = new System.Drawing.Size(413, 205);
            this.gbxDatosTorneo.TabIndex = 18;
            this.gbxDatosTorneo.TabStop = false;
            this.gbxDatosTorneo.Text = "Datos del Torneo";
            // 
            // gbxPuntosPartido
            // 
            this.gbxPuntosPartido.Controls.Add(this.nudGanado);
            this.gbxPuntosPartido.Controls.Add(this.nudEmpate);
            this.gbxPuntosPartido.Controls.Add(this.nudPerdido);
            this.gbxPuntosPartido.Controls.Add(this.lblPuntosGanados);
            this.gbxPuntosPartido.Controls.Add(this.lblPuntosEmpate);
            this.gbxPuntosPartido.Controls.Add(this.lblPuntosPerdido);
            this.gbxPuntosPartido.Location = new System.Drawing.Point(236, 23);
            this.gbxPuntosPartido.Name = "gbxPuntosPartido";
            this.gbxPuntosPartido.Size = new System.Drawing.Size(157, 140);
            this.gbxPuntosPartido.TabIndex = 16;
            this.gbxPuntosPartido.TabStop = false;
            this.gbxPuntosPartido.Text = "Puntos por Partido";
            // 
            // nudGanado
            // 
            this.nudGanado.Location = new System.Drawing.Point(99, 23);
            this.nudGanado.Name = "nudGanado";
            this.nudGanado.Size = new System.Drawing.Size(37, 20);
            this.nudGanado.TabIndex = 17;
            // 
            // nudEmpate
            // 
            this.nudEmpate.Location = new System.Drawing.Point(99, 54);
            this.nudEmpate.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.nudEmpate.Name = "nudEmpate";
            this.nudEmpate.Size = new System.Drawing.Size(37, 20);
            this.nudEmpate.TabIndex = 18;
            // 
            // nudPerdido
            // 
            this.nudPerdido.Location = new System.Drawing.Point(99, 85);
            this.nudPerdido.Maximum = new decimal(new int[] {
            98,
            0,
            0,
            0});
            this.nudPerdido.Name = "nudPerdido";
            this.nudPerdido.Size = new System.Drawing.Size(37, 20);
            this.nudPerdido.TabIndex = 19;
            // 
            // lblPuntosGanados
            // 
            this.lblPuntosGanados.AutoSize = true;
            this.lblPuntosGanados.Location = new System.Drawing.Point(42, 25);
            this.lblPuntosGanados.Name = "lblPuntosGanados";
            this.lblPuntosGanados.Size = new System.Drawing.Size(51, 13);
            this.lblPuntosGanados.TabIndex = 8;
            this.lblPuntosGanados.Text = "Ganado :";
            // 
            // lblPuntosEmpate
            // 
            this.lblPuntosEmpate.AutoSize = true;
            this.lblPuntosEmpate.Location = new System.Drawing.Point(44, 56);
            this.lblPuntosEmpate.Name = "lblPuntosEmpate";
            this.lblPuntosEmpate.Size = new System.Drawing.Size(49, 13);
            this.lblPuntosEmpate.TabIndex = 10;
            this.lblPuntosEmpate.Text = "Empate :";
            // 
            // lblPuntosPerdido
            // 
            this.lblPuntosPerdido.AutoSize = true;
            this.lblPuntosPerdido.Location = new System.Drawing.Point(44, 87);
            this.lblPuntosPerdido.Name = "lblPuntosPerdido";
            this.lblPuntosPerdido.Size = new System.Drawing.Size(49, 13);
            this.lblPuntosPerdido.TabIndex = 12;
            this.lblPuntosPerdido.Text = "Perdido :";
            // 
            // lblNombreTorneo
            // 
            this.lblNombreTorneo.AutoSize = true;
            this.lblNombreTorneo.Location = new System.Drawing.Point(23, 28);
            this.lblNombreTorneo.Name = "lblNombreTorneo";
            this.lblNombreTorneo.Size = new System.Drawing.Size(104, 13);
            this.lblNombreTorneo.TabIndex = 0;
            this.lblNombreTorneo.Text = "Nombre del Torneo :";
            // 
            // btnAgregarDatosTorneo
            // 
            this.btnAgregarDatosTorneo.Location = new System.Drawing.Point(249, 176);
            this.btnAgregarDatosTorneo.Name = "btnAgregarDatosTorneo";
            this.btnAgregarDatosTorneo.Size = new System.Drawing.Size(144, 23);
            this.btnAgregarDatosTorneo.TabIndex = 16;
            this.btnAgregarDatosTorneo.Text = "Agregar Datos del Tornero ";
            this.btnAgregarDatosTorneo.UseVisualStyleBackColor = true;
            this.btnAgregarDatosTorneo.Click += new System.EventHandler(this.btnAgregarDatosTorneo_Click);
            // 
            // txtNombreTornero
            // 
            this.txtNombreTornero.Location = new System.Drawing.Point(131, 25);
            this.txtNombreTornero.Name = "txtNombreTornero";
            this.txtNombreTornero.Size = new System.Drawing.Size(100, 20);
            this.txtNombreTornero.TabIndex = 1;
            // 
            // nudNumEquipos
            // 
            this.nudNumEquipos.Location = new System.Drawing.Point(193, 51);
            this.nudNumEquipos.Name = "nudNumEquipos";
            this.nudNumEquipos.Size = new System.Drawing.Size(37, 20);
            this.nudNumEquipos.TabIndex = 2;
            // 
            // dtpFechaIncio
            // 
            this.dtpFechaIncio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaIncio.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dtpFechaIncio.Location = new System.Drawing.Point(148, 78);
            this.dtpFechaIncio.Name = "dtpFechaIncio";
            this.dtpFechaIncio.Size = new System.Drawing.Size(83, 20);
            this.dtpFechaIncio.TabIndex = 3;
            // 
            // lblNumeroEquipos
            // 
            this.lblNumeroEquipos.AutoSize = true;
            this.lblNumeroEquipos.Location = new System.Drawing.Point(23, 53);
            this.lblNumeroEquipos.Name = "lblNumeroEquipos";
            this.lblNumeroEquipos.Size = new System.Drawing.Size(106, 13);
            this.lblNumeroEquipos.TabIndex = 4;
            this.lblNumeroEquipos.Text = "Numero de Equipos :";
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Location = new System.Drawing.Point(22, 84);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(86, 13);
            this.lblFechaInicio.TabIndex = 5;
            this.lblFechaInicio.Text = "Fecha de Inicio :";
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFin.Location = new System.Drawing.Point(148, 104);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(82, 20);
            this.dtpFechaFin.TabIndex = 6;
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Location = new System.Drawing.Point(22, 110);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(129, 13);
            this.lblFechaFin.TabIndex = 7;
            this.lblFechaFin.Text = "Fecha de Fin del Torneo :";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 355);
            this.Controls.Add(this.btnAgregarDatosEquipos);
            this.Controls.Add(this.btnDeterminarGanador);
            this.Controls.Add(this.gbxDatosTorneo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbxDatosTorneo.ResumeLayout(false);
            this.gbxDatosTorneo.PerformLayout();
            this.gbxPuntosPartido.ResumeLayout(false);
            this.gbxPuntosPartido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGanado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEmpate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPerdido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumEquipos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarDatosEquipos;
        private System.Windows.Forms.Button btnDeterminarGanador;
        private System.Windows.Forms.GroupBox gbxDatosTorneo;
        private System.Windows.Forms.GroupBox gbxPuntosPartido;
        private System.Windows.Forms.NumericUpDown nudGanado;
        private System.Windows.Forms.NumericUpDown nudEmpate;
        private System.Windows.Forms.NumericUpDown nudPerdido;
        private System.Windows.Forms.Label lblPuntosGanados;
        private System.Windows.Forms.Label lblPuntosEmpate;
        private System.Windows.Forms.Label lblPuntosPerdido;
        private System.Windows.Forms.Label lblNombreTorneo;
        private System.Windows.Forms.Button btnAgregarDatosTorneo;
        private System.Windows.Forms.TextBox txtNombreTornero;
        private System.Windows.Forms.NumericUpDown nudNumEquipos;
        private System.Windows.Forms.DateTimePicker dtpFechaIncio;
        private System.Windows.Forms.Label lblNumeroEquipos;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

