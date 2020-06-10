namespace Vehiculos
{
    partial class frmVehiculo
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
            this.lblTipoCombustible = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblNumeroLlantas = new System.Windows.Forms.Label();
            this.lblNumeroPuertas = new System.Windows.Forms.Label();
            this.lblNumeroVentanas = new System.Windows.Forms.Label();
            this.txtIntTipoCom = new System.Windows.Forms.TextBox();
            this.txtIntColor = new System.Windows.Forms.TextBox();
            this.txtIntNumeroLlantas = new System.Windows.Forms.TextBox();
            this.txtIntNumeroPuertas = new System.Windows.Forms.TextBox();
            this.txtIntNumeroVentanas = new System.Windows.Forms.TextBox();
            this.lblNumAlas = new System.Windows.Forms.Label();
            this.lblNumTurbinas = new System.Windows.Forms.Label();
            this.lblNumHelices = new System.Windows.Forms.Label();
            this.lblTiVeAereo = new System.Windows.Forms.Label();
            this.cmbIntTiVeAereo = new System.Windows.Forms.ComboBox();
            this.txtIntNumAlas = new System.Windows.Forms.TextBox();
            this.txtIntNumTurbinas = new System.Windows.Forms.TextBox();
            this.txtIntNumHelices = new System.Windows.Forms.TextBox();
            this.gbxDatosGeneralesDelVehiculo = new System.Windows.Forms.GroupBox();
            this.gbxDatosEspecificosDelVehiculoAereo = new System.Windows.Forms.GroupBox();
            this.btnEncenderMotor = new System.Windows.Forms.Button();
            this.btnApagarMotor = new System.Windows.Forms.Button();
            this.error1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnEstadoDeVehiculoAereo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.gbxDatosGeneralesDelVehiculo.SuspendLayout();
            this.gbxDatosEspecificosDelVehiculoAereo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTipoCombustible
            // 
            this.lblTipoCombustible.AutoSize = true;
            this.lblTipoCombustible.Location = new System.Drawing.Point(30, 29);
            this.lblTipoCombustible.Name = "lblTipoCombustible";
            this.lblTipoCombustible.Size = new System.Drawing.Size(109, 13);
            this.lblTipoCombustible.TabIndex = 0;
            this.lblTipoCombustible.Text = "Tipo de Combustible :";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(99, 57);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(40, 13);
            this.lblColor.TabIndex = 1;
            this.lblColor.Text = "Color  :";
            // 
            // lblNumeroLlantas
            // 
            this.lblNumeroLlantas.AutoSize = true;
            this.lblNumeroLlantas.Location = new System.Drawing.Point(41, 86);
            this.lblNumeroLlantas.Name = "lblNumeroLlantas";
            this.lblNumeroLlantas.Size = new System.Drawing.Size(98, 13);
            this.lblNumeroLlantas.TabIndex = 2;
            this.lblNumeroLlantas.Text = "Numero de llantas :";
            // 
            // lblNumeroPuertas
            // 
            this.lblNumeroPuertas.AutoSize = true;
            this.lblNumeroPuertas.Location = new System.Drawing.Point(36, 116);
            this.lblNumeroPuertas.Name = "lblNumeroPuertas";
            this.lblNumeroPuertas.Size = new System.Drawing.Size(103, 13);
            this.lblNumeroPuertas.TabIndex = 3;
            this.lblNumeroPuertas.Text = "Numero de puertas :";
            // 
            // lblNumeroVentanas
            // 
            this.lblNumeroVentanas.AutoSize = true;
            this.lblNumeroVentanas.Location = new System.Drawing.Point(27, 145);
            this.lblNumeroVentanas.Name = "lblNumeroVentanas";
            this.lblNumeroVentanas.Size = new System.Drawing.Size(112, 13);
            this.lblNumeroVentanas.TabIndex = 4;
            this.lblNumeroVentanas.Text = "Numero de ventanas :";
            // 
            // txtIntTipoCom
            // 
            this.txtIntTipoCom.Location = new System.Drawing.Point(145, 26);
            this.txtIntTipoCom.Name = "txtIntTipoCom";
            this.txtIntTipoCom.Size = new System.Drawing.Size(100, 20);
            this.txtIntTipoCom.TabIndex = 5;
            // 
            // txtIntColor
            // 
            this.txtIntColor.Location = new System.Drawing.Point(145, 54);
            this.txtIntColor.Name = "txtIntColor";
            this.txtIntColor.Size = new System.Drawing.Size(100, 20);
            this.txtIntColor.TabIndex = 6;
            // 
            // txtIntNumeroLlantas
            // 
            this.txtIntNumeroLlantas.Location = new System.Drawing.Point(145, 83);
            this.txtIntNumeroLlantas.Name = "txtIntNumeroLlantas";
            this.txtIntNumeroLlantas.Size = new System.Drawing.Size(100, 20);
            this.txtIntNumeroLlantas.TabIndex = 7;
            // 
            // txtIntNumeroPuertas
            // 
            this.txtIntNumeroPuertas.Location = new System.Drawing.Point(145, 113);
            this.txtIntNumeroPuertas.Name = "txtIntNumeroPuertas";
            this.txtIntNumeroPuertas.Size = new System.Drawing.Size(100, 20);
            this.txtIntNumeroPuertas.TabIndex = 8;
            // 
            // txtIntNumeroVentanas
            // 
            this.txtIntNumeroVentanas.Location = new System.Drawing.Point(145, 142);
            this.txtIntNumeroVentanas.Name = "txtIntNumeroVentanas";
            this.txtIntNumeroVentanas.Size = new System.Drawing.Size(100, 20);
            this.txtIntNumeroVentanas.TabIndex = 9;
            // 
            // lblNumAlas
            // 
            this.lblNumAlas.AutoSize = true;
            this.lblNumAlas.Location = new System.Drawing.Point(61, 22);
            this.lblNumAlas.Name = "lblNumAlas";
            this.lblNumAlas.Size = new System.Drawing.Size(88, 13);
            this.lblNumAlas.TabIndex = 10;
            this.lblNumAlas.Text = "Numero de Alas :";
            // 
            // lblNumTurbinas
            // 
            this.lblNumTurbinas.AutoSize = true;
            this.lblNumTurbinas.Location = new System.Drawing.Point(44, 60);
            this.lblNumTurbinas.Name = "lblNumTurbinas";
            this.lblNumTurbinas.Size = new System.Drawing.Size(105, 13);
            this.lblNumTurbinas.TabIndex = 11;
            this.lblNumTurbinas.Text = "Numero de turbinas :";
            // 
            // lblNumHelices
            // 
            this.lblNumHelices.AutoSize = true;
            this.lblNumHelices.Location = new System.Drawing.Point(48, 105);
            this.lblNumHelices.Name = "lblNumHelices";
            this.lblNumHelices.Size = new System.Drawing.Size(101, 13);
            this.lblNumHelices.TabIndex = 12;
            this.lblNumHelices.Text = "Numero de helices :";
            // 
            // lblTiVeAereo
            // 
            this.lblTiVeAereo.AutoSize = true;
            this.lblTiVeAereo.Location = new System.Drawing.Point(25, 152);
            this.lblTiVeAereo.Name = "lblTiVeAereo";
            this.lblTiVeAereo.Size = new System.Drawing.Size(124, 13);
            this.lblTiVeAereo.TabIndex = 13;
            this.lblTiVeAereo.Text = "Tipo de Vehiculo Aereo :";
            // 
            // cmbIntTiVeAereo
            // 
            this.cmbIntTiVeAereo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIntTiVeAereo.FormattingEnabled = true;
            this.cmbIntTiVeAereo.Location = new System.Drawing.Point(156, 152);
            this.cmbIntTiVeAereo.Name = "cmbIntTiVeAereo";
            this.cmbIntTiVeAereo.Size = new System.Drawing.Size(86, 21);
            this.cmbIntTiVeAereo.TabIndex = 14;
            // 
            // txtIntNumAlas
            // 
            this.txtIntNumAlas.Location = new System.Drawing.Point(155, 19);
            this.txtIntNumAlas.Name = "txtIntNumAlas";
            this.txtIntNumAlas.Size = new System.Drawing.Size(100, 20);
            this.txtIntNumAlas.TabIndex = 15;
            // 
            // txtIntNumTurbinas
            // 
            this.txtIntNumTurbinas.Location = new System.Drawing.Point(155, 57);
            this.txtIntNumTurbinas.Name = "txtIntNumTurbinas";
            this.txtIntNumTurbinas.Size = new System.Drawing.Size(100, 20);
            this.txtIntNumTurbinas.TabIndex = 16;
            // 
            // txtIntNumHelices
            // 
            this.txtIntNumHelices.Location = new System.Drawing.Point(155, 102);
            this.txtIntNumHelices.Name = "txtIntNumHelices";
            this.txtIntNumHelices.Size = new System.Drawing.Size(100, 20);
            this.txtIntNumHelices.TabIndex = 17;
            // 
            // gbxDatosGeneralesDelVehiculo
            // 
            this.gbxDatosGeneralesDelVehiculo.Controls.Add(this.lblTipoCombustible);
            this.gbxDatosGeneralesDelVehiculo.Controls.Add(this.lblColor);
            this.gbxDatosGeneralesDelVehiculo.Controls.Add(this.lblNumeroLlantas);
            this.gbxDatosGeneralesDelVehiculo.Controls.Add(this.lblNumeroPuertas);
            this.gbxDatosGeneralesDelVehiculo.Controls.Add(this.lblNumeroVentanas);
            this.gbxDatosGeneralesDelVehiculo.Controls.Add(this.txtIntTipoCom);
            this.gbxDatosGeneralesDelVehiculo.Controls.Add(this.txtIntColor);
            this.gbxDatosGeneralesDelVehiculo.Controls.Add(this.txtIntNumeroLlantas);
            this.gbxDatosGeneralesDelVehiculo.Controls.Add(this.txtIntNumeroPuertas);
            this.gbxDatosGeneralesDelVehiculo.Controls.Add(this.txtIntNumeroVentanas);
            this.gbxDatosGeneralesDelVehiculo.Location = new System.Drawing.Point(12, 12);
            this.gbxDatosGeneralesDelVehiculo.Name = "gbxDatosGeneralesDelVehiculo";
            this.gbxDatosGeneralesDelVehiculo.Size = new System.Drawing.Size(284, 194);
            this.gbxDatosGeneralesDelVehiculo.TabIndex = 18;
            this.gbxDatosGeneralesDelVehiculo.TabStop = false;
            this.gbxDatosGeneralesDelVehiculo.Text = "Datos generales del Vehiculo";
            // 
            // gbxDatosEspecificosDelVehiculoAereo
            // 
            this.gbxDatosEspecificosDelVehiculoAereo.Controls.Add(this.lblTiVeAereo);
            this.gbxDatosEspecificosDelVehiculoAereo.Controls.Add(this.lblNumAlas);
            this.gbxDatosEspecificosDelVehiculoAereo.Controls.Add(this.txtIntNumHelices);
            this.gbxDatosEspecificosDelVehiculoAereo.Controls.Add(this.lblNumTurbinas);
            this.gbxDatosEspecificosDelVehiculoAereo.Controls.Add(this.txtIntNumTurbinas);
            this.gbxDatosEspecificosDelVehiculoAereo.Controls.Add(this.lblNumHelices);
            this.gbxDatosEspecificosDelVehiculoAereo.Controls.Add(this.txtIntNumAlas);
            this.gbxDatosEspecificosDelVehiculoAereo.Controls.Add(this.cmbIntTiVeAereo);
            this.gbxDatosEspecificosDelVehiculoAereo.Location = new System.Drawing.Point(311, 12);
            this.gbxDatosEspecificosDelVehiculoAereo.Name = "gbxDatosEspecificosDelVehiculoAereo";
            this.gbxDatosEspecificosDelVehiculoAereo.Size = new System.Drawing.Size(284, 194);
            this.gbxDatosEspecificosDelVehiculoAereo.TabIndex = 19;
            this.gbxDatosEspecificosDelVehiculoAereo.TabStop = false;
            this.gbxDatosEspecificosDelVehiculoAereo.Tag = "";
            this.gbxDatosEspecificosDelVehiculoAereo.Text = "Datos especificos del Vehiculo Aereo";
            // 
            // btnEncenderMotor
            // 
            this.btnEncenderMotor.Location = new System.Drawing.Point(342, 254);
            this.btnEncenderMotor.Name = "btnEncenderMotor";
            this.btnEncenderMotor.Size = new System.Drawing.Size(75, 48);
            this.btnEncenderMotor.TabIndex = 20;
            this.btnEncenderMotor.Text = "Encender Motor";
            this.btnEncenderMotor.UseVisualStyleBackColor = true;
            this.btnEncenderMotor.Click += new System.EventHandler(this.btnEncenderMotor_Click);
            // 
            // btnApagarMotor
            // 
            this.btnApagarMotor.Location = new System.Drawing.Point(180, 254);
            this.btnApagarMotor.Name = "btnApagarMotor";
            this.btnApagarMotor.Size = new System.Drawing.Size(75, 48);
            this.btnApagarMotor.TabIndex = 21;
            this.btnApagarMotor.Text = "Apagar Motor";
            this.btnApagarMotor.UseVisualStyleBackColor = true;
            this.btnApagarMotor.Click += new System.EventHandler(this.btnApagarMotor_Click);
            // 
            // error1
            // 
            this.error1.ContainerControl = this;
            // 
            // btnEstadoDeVehiculoAereo
            // 
            this.btnEstadoDeVehiculoAereo.Location = new System.Drawing.Point(261, 275);
            this.btnEstadoDeVehiculoAereo.Name = "btnEstadoDeVehiculoAereo";
            this.btnEstadoDeVehiculoAereo.Size = new System.Drawing.Size(75, 58);
            this.btnEstadoDeVehiculoAereo.TabIndex = 22;
            this.btnEstadoDeVehiculoAereo.Text = "Estado del Vehiculo Aereo";
            this.btnEstadoDeVehiculoAereo.UseVisualStyleBackColor = true;
            this.btnEstadoDeVehiculoAereo.Click += new System.EventHandler(this.btnEstadoDeVehiculoAereo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(261, 212);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 23;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(535, 310);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 24;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 345);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEstadoDeVehiculoAereo);
            this.Controls.Add(this.btnApagarMotor);
            this.Controls.Add(this.btnEncenderMotor);
            this.Controls.Add(this.gbxDatosEspecificosDelVehiculoAereo);
            this.Controls.Add(this.gbxDatosGeneralesDelVehiculo);
            this.Name = "frmVehiculo";
            this.Text = "Vehiculo Aereo";
            this.Load += new System.EventHandler(this.frmVehiculo_Load);
            this.gbxDatosGeneralesDelVehiculo.ResumeLayout(false);
            this.gbxDatosGeneralesDelVehiculo.PerformLayout();
            this.gbxDatosEspecificosDelVehiculoAereo.ResumeLayout(false);
            this.gbxDatosEspecificosDelVehiculoAereo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTipoCombustible;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblNumeroLlantas;
        private System.Windows.Forms.Label lblNumeroPuertas;
        private System.Windows.Forms.Label lblNumeroVentanas;
        private System.Windows.Forms.TextBox txtIntTipoCom;
        private System.Windows.Forms.TextBox txtIntColor;
        private System.Windows.Forms.TextBox txtIntNumeroLlantas;
        private System.Windows.Forms.TextBox txtIntNumeroPuertas;
        private System.Windows.Forms.TextBox txtIntNumeroVentanas;
        private System.Windows.Forms.Label lblNumAlas;
        private System.Windows.Forms.Label lblNumTurbinas;
        private System.Windows.Forms.Label lblNumHelices;
        private System.Windows.Forms.Label lblTiVeAereo;
        private System.Windows.Forms.ComboBox cmbIntTiVeAereo;
        private System.Windows.Forms.TextBox txtIntNumAlas;
        private System.Windows.Forms.TextBox txtIntNumTurbinas;
        private System.Windows.Forms.TextBox txtIntNumHelices;
        private System.Windows.Forms.GroupBox gbxDatosGeneralesDelVehiculo;
        private System.Windows.Forms.GroupBox gbxDatosEspecificosDelVehiculoAereo;
        private System.Windows.Forms.Button btnEncenderMotor;
        private System.Windows.Forms.Button btnApagarMotor;
        private System.Windows.Forms.ErrorProvider error1;
        private System.Windows.Forms.Button btnEstadoDeVehiculoAereo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnSalir;
    }
}

