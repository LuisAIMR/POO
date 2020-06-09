namespace Pasteleria
{
    partial class frmPasteleria
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
            this.gbxBuscar = new System.Windows.Forms.GroupBox();
            this.gbxVender = new System.Windows.Forms.GroupBox();
            this.btnVender = new System.Windows.Forms.Button();
            this.txtVender = new System.Windows.Forms.TextBox();
            this.lblVender = new System.Windows.Forms.Label();
            this.lblPrecioPostre = new System.Windows.Forms.Label();
            this.lblResPrecioPostre = new System.Windows.Forms.Label();
            this.lblUnidadesDisponibles = new System.Windows.Forms.Label();
            this.lblReslUnidadesDisponibles = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscarPostre = new System.Windows.Forms.TextBox();
            this.blBuscarPostre = new System.Windows.Forms.Label();
            this.gbxInfresarDatos = new System.Windows.Forms.GroupBox();
            this.nudCantidadPostres = new System.Windows.Forms.NumericUpDown();
            this.btnCargarDatos = new System.Windows.Forms.Button();
            this.lblCantidadPostres = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.gbxBuscar.SuspendLayout();
            this.gbxVender.SuspendLayout();
            this.gbxInfresarDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadPostres)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxBuscar
            // 
            this.gbxBuscar.Controls.Add(this.gbxVender);
            this.gbxBuscar.Controls.Add(this.lblPrecioPostre);
            this.gbxBuscar.Controls.Add(this.lblResPrecioPostre);
            this.gbxBuscar.Controls.Add(this.lblUnidadesDisponibles);
            this.gbxBuscar.Controls.Add(this.lblReslUnidadesDisponibles);
            this.gbxBuscar.Controls.Add(this.btnBuscar);
            this.gbxBuscar.Controls.Add(this.txtBuscarPostre);
            this.gbxBuscar.Controls.Add(this.blBuscarPostre);
            this.gbxBuscar.Location = new System.Drawing.Point(75, 108);
            this.gbxBuscar.Name = "gbxBuscar";
            this.gbxBuscar.Size = new System.Drawing.Size(345, 245);
            this.gbxBuscar.TabIndex = 5;
            this.gbxBuscar.TabStop = false;
            this.gbxBuscar.Text = "BUSCAR POSTRE";
            // 
            // gbxVender
            // 
            this.gbxVender.Controls.Add(this.btnVender);
            this.gbxVender.Controls.Add(this.txtVender);
            this.gbxVender.Controls.Add(this.lblVender);
            this.gbxVender.Location = new System.Drawing.Point(22, 139);
            this.gbxVender.Name = "gbxVender";
            this.gbxVender.Size = new System.Drawing.Size(276, 100);
            this.gbxVender.TabIndex = 3;
            this.gbxVender.TabStop = false;
            this.gbxVender.Text = "VENTAS";
            // 
            // btnVender
            // 
            this.btnVender.Location = new System.Drawing.Point(195, 53);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(75, 23);
            this.btnVender.TabIndex = 0;
            this.btnVender.Text = "Vender";
            this.btnVender.UseVisualStyleBackColor = true;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // txtVender
            // 
            this.txtVender.Location = new System.Drawing.Point(66, 55);
            this.txtVender.Name = "txtVender";
            this.txtVender.Size = new System.Drawing.Size(100, 20);
            this.txtVender.TabIndex = 1;
            // 
            // lblVender
            // 
            this.lblVender.AutoSize = true;
            this.lblVender.Location = new System.Drawing.Point(6, 58);
            this.lblVender.Name = "lblVender";
            this.lblVender.Size = new System.Drawing.Size(58, 13);
            this.lblVender.TabIndex = 0;
            this.lblVender.Text = "Cantidad : ";
            // 
            // lblPrecioPostre
            // 
            this.lblPrecioPostre.AutoSize = true;
            this.lblPrecioPostre.Location = new System.Drawing.Point(108, 74);
            this.lblPrecioPostre.Name = "lblPrecioPostre";
            this.lblPrecioPostre.Size = new System.Drawing.Size(96, 13);
            this.lblPrecioPostre.TabIndex = 5;
            this.lblPrecioPostre.Text = "Precio del Postre : ";
            // 
            // lblResPrecioPostre
            // 
            this.lblResPrecioPostre.AutoSize = true;
            this.lblResPrecioPostre.Location = new System.Drawing.Point(210, 74);
            this.lblResPrecioPostre.Name = "lblResPrecioPostre";
            this.lblResPrecioPostre.Size = new System.Drawing.Size(0, 13);
            this.lblResPrecioPostre.TabIndex = 4;
            // 
            // lblUnidadesDisponibles
            // 
            this.lblUnidadesDisponibles.AutoSize = true;
            this.lblUnidadesDisponibles.Location = new System.Drawing.Point(19, 104);
            this.lblUnidadesDisponibles.Name = "lblUnidadesDisponibles";
            this.lblUnidadesDisponibles.Size = new System.Drawing.Size(176, 13);
            this.lblUnidadesDisponibles.TabIndex = 3;
            this.lblUnidadesDisponibles.Text = "Cantidad de Unidades disponibles : ";
            // 
            // lblReslUnidadesDisponibles
            // 
            this.lblReslUnidadesDisponibles.AutoSize = true;
            this.lblReslUnidadesDisponibles.Location = new System.Drawing.Point(201, 104);
            this.lblReslUnidadesDisponibles.Name = "lblReslUnidadesDisponibles";
            this.lblReslUnidadesDisponibles.Size = new System.Drawing.Size(0, 13);
            this.lblReslUnidadesDisponibles.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(204, 24);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscarPostre
            // 
            this.txtBuscarPostre.Location = new System.Drawing.Point(88, 27);
            this.txtBuscarPostre.Name = "txtBuscarPostre";
            this.txtBuscarPostre.Size = new System.Drawing.Size(100, 20);
            this.txtBuscarPostre.TabIndex = 1;
            // 
            // blBuscarPostre
            // 
            this.blBuscarPostre.AutoSize = true;
            this.blBuscarPostre.Location = new System.Drawing.Point(11, 29);
            this.blBuscarPostre.Name = "blBuscarPostre";
            this.blBuscarPostre.Size = new System.Drawing.Size(82, 13);
            this.blBuscarPostre.TabIndex = 0;
            this.blBuscarPostre.Text = "Buscar Postre : ";
            // 
            // gbxInfresarDatos
            // 
            this.gbxInfresarDatos.Controls.Add(this.nudCantidadPostres);
            this.gbxInfresarDatos.Controls.Add(this.btnCargarDatos);
            this.gbxInfresarDatos.Controls.Add(this.lblCantidadPostres);
            this.gbxInfresarDatos.Location = new System.Drawing.Point(75, 2);
            this.gbxInfresarDatos.Name = "gbxInfresarDatos";
            this.gbxInfresarDatos.Size = new System.Drawing.Size(345, 100);
            this.gbxInfresarDatos.TabIndex = 4;
            this.gbxInfresarDatos.TabStop = false;
            this.gbxInfresarDatos.Text = "INGRESAR DATOS";
            // 
            // nudCantidadPostres
            // 
            this.nudCantidadPostres.Location = new System.Drawing.Point(204, 44);
            this.nudCantidadPostres.Name = "nudCantidadPostres";
            this.nudCantidadPostres.Size = new System.Drawing.Size(38, 20);
            this.nudCantidadPostres.TabIndex = 1;
            // 
            // btnCargarDatos
            // 
            this.btnCargarDatos.Location = new System.Drawing.Point(264, 31);
            this.btnCargarDatos.Name = "btnCargarDatos";
            this.btnCargarDatos.Size = new System.Drawing.Size(75, 43);
            this.btnCargarDatos.TabIndex = 0;
            this.btnCargarDatos.Text = "Cargar Datos";
            this.btnCargarDatos.UseVisualStyleBackColor = true;
            this.btnCargarDatos.Click += new System.EventHandler(this.btnCargarDatos_Click);
            // 
            // lblCantidadPostres
            // 
            this.lblCantidadPostres.AutoSize = true;
            this.lblCantidadPostres.Location = new System.Drawing.Point(6, 46);
            this.lblCantidadPostres.Name = "lblCantidadPostres";
            this.lblCantidadPostres.Size = new System.Drawing.Size(198, 13);
            this.lblCantidadPostres.TabIndex = 0;
            this.lblCantidadPostres.Text = "Ingrese la cantidad de tipos de postres : ";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(292, 359);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(128, 23);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar datos del dia";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmPasteleria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 391);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.gbxBuscar);
            this.Controls.Add(this.gbxInfresarDatos);
            this.Name = "frmPasteleria";
            this.Text = ".: Pasteleria :.";
            this.Load += new System.EventHandler(this.frmPasteleria_Load);
            this.gbxBuscar.ResumeLayout(false);
            this.gbxBuscar.PerformLayout();
            this.gbxVender.ResumeLayout(false);
            this.gbxVender.PerformLayout();
            this.gbxInfresarDatos.ResumeLayout(false);
            this.gbxInfresarDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadPostres)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxBuscar;
        private System.Windows.Forms.GroupBox gbxVender;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.TextBox txtVender;
        private System.Windows.Forms.Label lblVender;
        private System.Windows.Forms.Label lblPrecioPostre;
        private System.Windows.Forms.Label lblResPrecioPostre;
        private System.Windows.Forms.Label lblUnidadesDisponibles;
        private System.Windows.Forms.Label lblReslUnidadesDisponibles;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscarPostre;
        private System.Windows.Forms.Label blBuscarPostre;
        private System.Windows.Forms.GroupBox gbxInfresarDatos;
        private System.Windows.Forms.NumericUpDown nudCantidadPostres;
        private System.Windows.Forms.Button btnCargarDatos;
        private System.Windows.Forms.Label lblCantidadPostres;
        private System.Windows.Forms.Button btnGuardar;
    }
}

