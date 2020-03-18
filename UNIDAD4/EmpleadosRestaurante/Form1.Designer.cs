namespace EmpleadosRestaurante
{
    partial class frmEmpleados
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
            this.lblSueldoMe = new System.Windows.Forms.Label();
            this.lblDiasTraMe = new System.Windows.Forms.Label();
            this.lblPropinaSemanalMe = new System.Windows.Forms.Label();
            this.txtCalSalarioMe = new System.Windows.Forms.TextBox();
            this.txtCalPropMe = new System.Windows.Forms.TextBox();
            this.txtCalSueldoCa = new System.Windows.Forms.TextBox();
            this.txtCalSueldoRe = new System.Windows.Forms.TextBox();
            this.cmbCaja = new System.Windows.Forms.ComboBox();
            this.cmbZona = new System.Windows.Forms.ComboBox();
            this.lblSueldoCa = new System.Windows.Forms.Label();
            this.lblDiasTraCa = new System.Windows.Forms.Label();
            this.lblNumCaja = new System.Windows.Forms.Label();
            this.lblSueldoRe = new System.Windows.Forms.Label();
            this.lblDiasTraRe = new System.Windows.Forms.Label();
            this.lblZona = new System.Windows.Forms.Label();
            this.gbxMesero = new System.Windows.Forms.GroupBox();
            this.dtpFechaDeNacimientoMe = new System.Windows.Forms.DateTimePicker();
            this.lblFechaDeNacimientoMe = new System.Windows.Forms.Label();
            this.txtNomMe = new System.Windows.Forms.TextBox();
            this.lblNomMe = new System.Windows.Forms.Label();
            this.cmbDiasTeMe = new System.Windows.Forms.ComboBox();
            this.btnCalcularSalarioMe = new System.Windows.Forms.Button();
            this.gpxCajero = new System.Windows.Forms.GroupBox();
            this.dtpFechaDeNacimientoCa = new System.Windows.Forms.DateTimePicker();
            this.blFechaDeNacimientoCa = new System.Windows.Forms.Label();
            this.txtNomCa = new System.Windows.Forms.TextBox();
            this.lblNomCa = new System.Windows.Forms.Label();
            this.cmbDiasTraCa = new System.Windows.Forms.ComboBox();
            this.btnCalCa = new System.Windows.Forms.Button();
            this.gbxRepartidor = new System.Windows.Forms.GroupBox();
            this.dtpFechaDeNacimientoRe = new System.Windows.Forms.DateTimePicker();
            this.lblFechaDeNacimientoRe = new System.Windows.Forms.Label();
            this.txtNomRe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPedidosRealizados = new System.Windows.Forms.TextBox();
            this.cmbDiasTraRe = new System.Windows.Forms.ComboBox();
            this.btnCalcularRe = new System.Windows.Forms.Button();
            this.lblTotalAbonos = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbxMesero.SuspendLayout();
            this.gpxCajero.SuspendLayout();
            this.gbxRepartidor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSueldoMe
            // 
            this.lblSueldoMe.AutoSize = true;
            this.lblSueldoMe.Location = new System.Drawing.Point(46, 98);
            this.lblSueldoMe.Name = "lblSueldoMe";
            this.lblSueldoMe.Size = new System.Drawing.Size(46, 13);
            this.lblSueldoMe.TabIndex = 0;
            this.lblSueldoMe.Text = "Sueldo :";
            // 
            // lblDiasTraMe
            // 
            this.lblDiasTraMe.AutoSize = true;
            this.lblDiasTraMe.Location = new System.Drawing.Point(8, 135);
            this.lblDiasTraMe.Name = "lblDiasTraMe";
            this.lblDiasTraMe.Size = new System.Drawing.Size(86, 13);
            this.lblDiasTraMe.TabIndex = 1;
            this.lblDiasTraMe.Text = "Dias trabajados :";
            // 
            // lblPropinaSemanalMe
            // 
            this.lblPropinaSemanalMe.AutoSize = true;
            this.lblPropinaSemanalMe.Location = new System.Drawing.Point(3, 175);
            this.lblPropinaSemanalMe.Name = "lblPropinaSemanalMe";
            this.lblPropinaSemanalMe.Size = new System.Drawing.Size(91, 13);
            this.lblPropinaSemanalMe.TabIndex = 2;
            this.lblPropinaSemanalMe.Text = "Propina semanal :";
            // 
            // txtCalSalarioMe
            // 
            this.txtCalSalarioMe.Location = new System.Drawing.Point(100, 94);
            this.txtCalSalarioMe.Name = "txtCalSalarioMe";
            this.txtCalSalarioMe.Size = new System.Drawing.Size(100, 20);
            this.txtCalSalarioMe.TabIndex = 3;
            // 
            // txtCalPropMe
            // 
            this.txtCalPropMe.Location = new System.Drawing.Point(100, 168);
            this.txtCalPropMe.Name = "txtCalPropMe";
            this.txtCalPropMe.Size = new System.Drawing.Size(100, 20);
            this.txtCalPropMe.TabIndex = 5;
            // 
            // txtCalSueldoCa
            // 
            this.txtCalSueldoCa.Location = new System.Drawing.Point(99, 87);
            this.txtCalSueldoCa.Name = "txtCalSueldoCa";
            this.txtCalSueldoCa.Size = new System.Drawing.Size(100, 20);
            this.txtCalSueldoCa.TabIndex = 6;
            this.txtCalSueldoCa.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtCalSueldoRe
            // 
            this.txtCalSueldoRe.Location = new System.Drawing.Point(102, 89);
            this.txtCalSueldoRe.Name = "txtCalSueldoRe";
            this.txtCalSueldoRe.Size = new System.Drawing.Size(100, 20);
            this.txtCalSueldoRe.TabIndex = 8;
            // 
            // cmbCaja
            // 
            this.cmbCaja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCaja.FormattingEnabled = true;
            this.cmbCaja.Location = new System.Drawing.Point(99, 161);
            this.cmbCaja.Name = "cmbCaja";
            this.cmbCaja.Size = new System.Drawing.Size(37, 21);
            this.cmbCaja.TabIndex = 10;
            this.cmbCaja.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cmbZona
            // 
            this.cmbZona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbZona.FormattingEnabled = true;
            this.cmbZona.Location = new System.Drawing.Point(102, 144);
            this.cmbZona.Name = "cmbZona";
            this.cmbZona.Size = new System.Drawing.Size(57, 21);
            this.cmbZona.TabIndex = 11;
            // 
            // lblSueldoCa
            // 
            this.lblSueldoCa.AutoSize = true;
            this.lblSueldoCa.Location = new System.Drawing.Point(47, 94);
            this.lblSueldoCa.Name = "lblSueldoCa";
            this.lblSueldoCa.Size = new System.Drawing.Size(46, 13);
            this.lblSueldoCa.TabIndex = 14;
            this.lblSueldoCa.Text = "Sueldo :";
            this.lblSueldoCa.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblDiasTraCa
            // 
            this.lblDiasTraCa.AutoSize = true;
            this.lblDiasTraCa.Location = new System.Drawing.Point(7, 126);
            this.lblDiasTraCa.Name = "lblDiasTraCa";
            this.lblDiasTraCa.Size = new System.Drawing.Size(86, 13);
            this.lblDiasTraCa.TabIndex = 15;
            this.lblDiasTraCa.Text = "Dias trabajados :";
            this.lblDiasTraCa.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblNumCaja
            // 
            this.lblNumCaja.AutoSize = true;
            this.lblNumCaja.Location = new System.Drawing.Point(59, 164);
            this.lblNumCaja.Name = "lblNumCaja";
            this.lblNumCaja.Size = new System.Drawing.Size(34, 13);
            this.lblNumCaja.TabIndex = 16;
            this.lblNumCaja.Text = "Caja :";
            this.lblNumCaja.Click += new System.EventHandler(this.label7_Click);
            // 
            // lblSueldoRe
            // 
            this.lblSueldoRe.AutoSize = true;
            this.lblSueldoRe.Location = new System.Drawing.Point(50, 92);
            this.lblSueldoRe.Name = "lblSueldoRe";
            this.lblSueldoRe.Size = new System.Drawing.Size(46, 13);
            this.lblSueldoRe.TabIndex = 17;
            this.lblSueldoRe.Text = "Sueldo :";
            // 
            // lblDiasTraRe
            // 
            this.lblDiasTraRe.AutoSize = true;
            this.lblDiasTraRe.Location = new System.Drawing.Point(6, 121);
            this.lblDiasTraRe.Name = "lblDiasTraRe";
            this.lblDiasTraRe.Size = new System.Drawing.Size(90, 13);
            this.lblDiasTraRe.TabIndex = 18;
            this.lblDiasTraRe.Text = "Dias Trabajados :";
            this.lblDiasTraRe.Click += new System.EventHandler(this.label9_Click);
            // 
            // lblZona
            // 
            this.lblZona.AutoSize = true;
            this.lblZona.Location = new System.Drawing.Point(58, 147);
            this.lblZona.Name = "lblZona";
            this.lblZona.Size = new System.Drawing.Size(38, 13);
            this.lblZona.TabIndex = 19;
            this.lblZona.Text = "Zona :";
            this.lblZona.Click += new System.EventHandler(this.label10_Click);
            // 
            // gbxMesero
            // 
            this.gbxMesero.Controls.Add(this.dtpFechaDeNacimientoMe);
            this.gbxMesero.Controls.Add(this.lblFechaDeNacimientoMe);
            this.gbxMesero.Controls.Add(this.txtNomMe);
            this.gbxMesero.Controls.Add(this.lblNomMe);
            this.gbxMesero.Controls.Add(this.cmbDiasTeMe);
            this.gbxMesero.Controls.Add(this.btnCalcularSalarioMe);
            this.gbxMesero.Controls.Add(this.txtCalPropMe);
            this.gbxMesero.Controls.Add(this.txtCalSalarioMe);
            this.gbxMesero.Controls.Add(this.lblPropinaSemanalMe);
            this.gbxMesero.Controls.Add(this.lblDiasTraMe);
            this.gbxMesero.Controls.Add(this.lblSueldoMe);
            this.gbxMesero.Location = new System.Drawing.Point(24, 28);
            this.gbxMesero.Name = "gbxMesero";
            this.gbxMesero.Size = new System.Drawing.Size(223, 273);
            this.gbxMesero.TabIndex = 21;
            this.gbxMesero.TabStop = false;
            this.gbxMesero.Text = "Mesero";
            this.gbxMesero.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dtpFechaDeNacimientoMe
            // 
            this.dtpFechaDeNacimientoMe.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDeNacimientoMe.Location = new System.Drawing.Point(120, 62);
            this.dtpFechaDeNacimientoMe.Name = "dtpFechaDeNacimientoMe";
            this.dtpFechaDeNacimientoMe.Size = new System.Drawing.Size(80, 20);
            this.dtpFechaDeNacimientoMe.TabIndex = 11;
            // 
            // lblFechaDeNacimientoMe
            // 
            this.lblFechaDeNacimientoMe.AutoSize = true;
            this.lblFechaDeNacimientoMe.Location = new System.Drawing.Point(8, 68);
            this.lblFechaDeNacimientoMe.Name = "lblFechaDeNacimientoMe";
            this.lblFechaDeNacimientoMe.Size = new System.Drawing.Size(112, 13);
            this.lblFechaDeNacimientoMe.TabIndex = 10;
            this.lblFechaDeNacimientoMe.Text = "Fecha de nacimiento :";
            // 
            // txtNomMe
            // 
            this.txtNomMe.Location = new System.Drawing.Point(100, 27);
            this.txtNomMe.Name = "txtNomMe";
            this.txtNomMe.Size = new System.Drawing.Size(100, 20);
            this.txtNomMe.TabIndex = 9;
            // 
            // lblNomMe
            // 
            this.lblNomMe.AutoSize = true;
            this.lblNomMe.Location = new System.Drawing.Point(46, 30);
            this.lblNomMe.Name = "lblNomMe";
            this.lblNomMe.Size = new System.Drawing.Size(50, 13);
            this.lblNomMe.TabIndex = 8;
            this.lblNomMe.Text = "Nombre :";
            // 
            // cmbDiasTeMe
            // 
            this.cmbDiasTeMe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDiasTeMe.FormattingEnabled = true;
            this.cmbDiasTeMe.Location = new System.Drawing.Point(100, 132);
            this.cmbDiasTeMe.Name = "cmbDiasTeMe";
            this.cmbDiasTeMe.Size = new System.Drawing.Size(100, 21);
            this.cmbDiasTeMe.TabIndex = 7;
            this.cmbDiasTeMe.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // btnCalcularSalarioMe
            // 
            this.btnCalcularSalarioMe.Location = new System.Drawing.Point(49, 230);
            this.btnCalcularSalarioMe.Name = "btnCalcularSalarioMe";
            this.btnCalcularSalarioMe.Size = new System.Drawing.Size(75, 23);
            this.btnCalcularSalarioMe.TabIndex = 6;
            this.btnCalcularSalarioMe.Text = "Calcular";
            this.btnCalcularSalarioMe.UseVisualStyleBackColor = true;
            this.btnCalcularSalarioMe.Click += new System.EventHandler(this.btnCalcularSalarioMe_Click);
            // 
            // gpxCajero
            // 
            this.gpxCajero.Controls.Add(this.dtpFechaDeNacimientoCa);
            this.gpxCajero.Controls.Add(this.blFechaDeNacimientoCa);
            this.gpxCajero.Controls.Add(this.txtNomCa);
            this.gpxCajero.Controls.Add(this.lblNomCa);
            this.gpxCajero.Controls.Add(this.cmbDiasTraCa);
            this.gpxCajero.Controls.Add(this.btnCalCa);
            this.gpxCajero.Controls.Add(this.lblDiasTraCa);
            this.gpxCajero.Controls.Add(this.txtCalSueldoCa);
            this.gpxCajero.Controls.Add(this.cmbCaja);
            this.gpxCajero.Controls.Add(this.lblSueldoCa);
            this.gpxCajero.Controls.Add(this.lblNumCaja);
            this.gpxCajero.Location = new System.Drawing.Point(253, 28);
            this.gpxCajero.Name = "gpxCajero";
            this.gpxCajero.Size = new System.Drawing.Size(225, 273);
            this.gpxCajero.TabIndex = 22;
            this.gpxCajero.TabStop = false;
            this.gpxCajero.Text = "Cajero";
            this.gpxCajero.Enter += new System.EventHandler(this.gpxCajero_Enter);
            // 
            // dtpFechaDeNacimientoCa
            // 
            this.dtpFechaDeNacimientoCa.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDeNacimientoCa.Location = new System.Drawing.Point(119, 62);
            this.dtpFechaDeNacimientoCa.Name = "dtpFechaDeNacimientoCa";
            this.dtpFechaDeNacimientoCa.Size = new System.Drawing.Size(80, 20);
            this.dtpFechaDeNacimientoCa.TabIndex = 22;
            // 
            // blFechaDeNacimientoCa
            // 
            this.blFechaDeNacimientoCa.AutoSize = true;
            this.blFechaDeNacimientoCa.Location = new System.Drawing.Point(7, 68);
            this.blFechaDeNacimientoCa.Name = "blFechaDeNacimientoCa";
            this.blFechaDeNacimientoCa.Size = new System.Drawing.Size(112, 13);
            this.blFechaDeNacimientoCa.TabIndex = 21;
            this.blFechaDeNacimientoCa.Text = "Fecha de nacimiento :";
            // 
            // txtNomCa
            // 
            this.txtNomCa.Location = new System.Drawing.Point(99, 30);
            this.txtNomCa.Name = "txtNomCa";
            this.txtNomCa.Size = new System.Drawing.Size(100, 20);
            this.txtNomCa.TabIndex = 20;
            // 
            // lblNomCa
            // 
            this.lblNomCa.AutoSize = true;
            this.lblNomCa.Location = new System.Drawing.Point(41, 33);
            this.lblNomCa.Name = "lblNomCa";
            this.lblNomCa.Size = new System.Drawing.Size(50, 13);
            this.lblNomCa.TabIndex = 19;
            this.lblNomCa.Text = "Nombre :";
            // 
            // cmbDiasTraCa
            // 
            this.cmbDiasTraCa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDiasTraCa.FormattingEnabled = true;
            this.cmbDiasTraCa.Location = new System.Drawing.Point(99, 123);
            this.cmbDiasTraCa.Name = "cmbDiasTraCa";
            this.cmbDiasTraCa.Size = new System.Drawing.Size(37, 21);
            this.cmbDiasTraCa.TabIndex = 18;
            // 
            // btnCalCa
            // 
            this.btnCalCa.Location = new System.Drawing.Point(76, 230);
            this.btnCalCa.Name = "btnCalCa";
            this.btnCalCa.Size = new System.Drawing.Size(75, 23);
            this.btnCalCa.TabIndex = 17;
            this.btnCalCa.Text = "Calcular";
            this.btnCalCa.UseVisualStyleBackColor = true;
            this.btnCalCa.Click += new System.EventHandler(this.btnCalCa_Click);
            // 
            // gbxRepartidor
            // 
            this.gbxRepartidor.Controls.Add(this.dtpFechaDeNacimientoRe);
            this.gbxRepartidor.Controls.Add(this.lblFechaDeNacimientoRe);
            this.gbxRepartidor.Controls.Add(this.txtNomRe);
            this.gbxRepartidor.Controls.Add(this.label1);
            this.gbxRepartidor.Controls.Add(this.txtPedidosRealizados);
            this.gbxRepartidor.Controls.Add(this.cmbDiasTraRe);
            this.gbxRepartidor.Controls.Add(this.btnCalcularRe);
            this.gbxRepartidor.Controls.Add(this.lblTotalAbonos);
            this.gbxRepartidor.Controls.Add(this.lblZona);
            this.gbxRepartidor.Controls.Add(this.lblDiasTraRe);
            this.gbxRepartidor.Controls.Add(this.lblSueldoRe);
            this.gbxRepartidor.Controls.Add(this.cmbZona);
            this.gbxRepartidor.Controls.Add(this.txtCalSueldoRe);
            this.gbxRepartidor.Location = new System.Drawing.Point(484, 28);
            this.gbxRepartidor.Name = "gbxRepartidor";
            this.gbxRepartidor.Size = new System.Drawing.Size(236, 273);
            this.gbxRepartidor.TabIndex = 23;
            this.gbxRepartidor.TabStop = false;
            this.gbxRepartidor.Text = "Repartidor";
            // 
            // dtpFechaDeNacimientoRe
            // 
            this.dtpFechaDeNacimientoRe.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDeNacimientoRe.Location = new System.Drawing.Point(120, 63);
            this.dtpFechaDeNacimientoRe.Name = "dtpFechaDeNacimientoRe";
            this.dtpFechaDeNacimientoRe.Size = new System.Drawing.Size(80, 20);
            this.dtpFechaDeNacimientoRe.TabIndex = 29;
            // 
            // lblFechaDeNacimientoRe
            // 
            this.lblFechaDeNacimientoRe.AutoSize = true;
            this.lblFechaDeNacimientoRe.Location = new System.Drawing.Point(8, 69);
            this.lblFechaDeNacimientoRe.Name = "lblFechaDeNacimientoRe";
            this.lblFechaDeNacimientoRe.Size = new System.Drawing.Size(112, 13);
            this.lblFechaDeNacimientoRe.TabIndex = 28;
            this.lblFechaDeNacimientoRe.Text = "Fecha de nacimiento :";
            // 
            // txtNomRe
            // 
            this.txtNomRe.Location = new System.Drawing.Point(102, 30);
            this.txtNomRe.Name = "txtNomRe";
            this.txtNomRe.Size = new System.Drawing.Size(100, 20);
            this.txtNomRe.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Nombre :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtPedidosRealizados
            // 
            this.txtPedidosRealizados.Location = new System.Drawing.Point(102, 176);
            this.txtPedidosRealizados.Name = "txtPedidosRealizados";
            this.txtPedidosRealizados.Size = new System.Drawing.Size(100, 20);
            this.txtPedidosRealizados.TabIndex = 23;
            // 
            // cmbDiasTraRe
            // 
            this.cmbDiasTraRe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDiasTraRe.FormattingEnabled = true;
            this.cmbDiasTraRe.Location = new System.Drawing.Point(102, 118);
            this.cmbDiasTraRe.Name = "cmbDiasTraRe";
            this.cmbDiasTraRe.Size = new System.Drawing.Size(57, 21);
            this.cmbDiasTraRe.TabIndex = 22;
            // 
            // btnCalcularRe
            // 
            this.btnCalcularRe.Location = new System.Drawing.Point(84, 223);
            this.btnCalcularRe.Name = "btnCalcularRe";
            this.btnCalcularRe.Size = new System.Drawing.Size(75, 23);
            this.btnCalcularRe.TabIndex = 21;
            this.btnCalcularRe.Text = "Calcular";
            this.btnCalcularRe.UseVisualStyleBackColor = true;
            this.btnCalcularRe.Click += new System.EventHandler(this.btnCalcularRe_Click);
            // 
            // lblTotalAbonos
            // 
            this.lblTotalAbonos.AutoSize = true;
            this.lblTotalAbonos.Location = new System.Drawing.Point(8, 179);
            this.lblTotalAbonos.Name = "lblTotalAbonos";
            this.lblTotalAbonos.Size = new System.Drawing.Size(91, 13);
            this.lblTotalAbonos.TabIndex = 20;
            this.lblTotalAbonos.Text = "Total de Abonos :";
            this.lblTotalAbonos.Click += new System.EventHandler(this.label11_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 356);
            this.Controls.Add(this.gbxRepartidor);
            this.Controls.Add(this.gpxCajero);
            this.Controls.Add(this.gbxMesero);
            this.Name = "frmEmpleados";
            this.Text = "Empleados del restaurante";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxMesero.ResumeLayout(false);
            this.gbxMesero.PerformLayout();
            this.gpxCajero.ResumeLayout(false);
            this.gpxCajero.PerformLayout();
            this.gbxRepartidor.ResumeLayout(false);
            this.gbxRepartidor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSueldoMe;
        private System.Windows.Forms.Label lblDiasTraMe;
        private System.Windows.Forms.Label lblPropinaSemanalMe;
        private System.Windows.Forms.TextBox txtCalSalarioMe;
        private System.Windows.Forms.TextBox txtCalPropMe;
        private System.Windows.Forms.TextBox txtCalSueldoCa;
        private System.Windows.Forms.TextBox txtCalSueldoRe;
        private System.Windows.Forms.ComboBox cmbCaja;
        private System.Windows.Forms.ComboBox cmbZona;
        private System.Windows.Forms.Label lblSueldoCa;
        private System.Windows.Forms.Label lblDiasTraCa;
        private System.Windows.Forms.Label lblNumCaja;
        private System.Windows.Forms.Label lblSueldoRe;
        private System.Windows.Forms.Label lblDiasTraRe;
        private System.Windows.Forms.Label lblZona;
        private System.Windows.Forms.GroupBox gbxMesero;
        private System.Windows.Forms.GroupBox gpxCajero;
        private System.Windows.Forms.Button btnCalcularSalarioMe;
        private System.Windows.Forms.Button btnCalCa;
        private System.Windows.Forms.GroupBox gbxRepartidor;
        private System.Windows.Forms.Button btnCalcularRe;
        private System.Windows.Forms.ComboBox cmbDiasTeMe;
        private System.Windows.Forms.ComboBox cmbDiasTraCa;
        private System.Windows.Forms.ComboBox cmbDiasTraRe;
        private System.Windows.Forms.TextBox txtPedidosRealizados;
        private System.Windows.Forms.Label lblTotalAbonos;
        private System.Windows.Forms.TextBox txtNomMe;
        private System.Windows.Forms.Label lblNomMe;
        private System.Windows.Forms.TextBox txtNomCa;
        private System.Windows.Forms.Label lblNomCa;
        private System.Windows.Forms.TextBox txtNomRe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaDeNacimientoMe;
        private System.Windows.Forms.Label lblFechaDeNacimientoMe;
        private System.Windows.Forms.DateTimePicker dtpFechaDeNacimientoCa;
        private System.Windows.Forms.Label blFechaDeNacimientoCa;
        private System.Windows.Forms.DateTimePicker dtpFechaDeNacimientoRe;
        private System.Windows.Forms.Label lblFechaDeNacimientoRe;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

