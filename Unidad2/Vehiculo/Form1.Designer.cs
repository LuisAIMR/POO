namespace Vehiculo
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
            this.lblTipoVehiculo = new System.Windows.Forms.Label();
            this.lblCantidadAcobrar = new System.Windows.Forms.Label();
            this.btnCobrar = new System.Windows.Forms.Button();
            this.btnNueVehiculo = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.cmbTipoVehiculo = new System.Windows.Forms.ComboBox();
            this.error1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.error1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTipoVehiculo
            // 
            this.lblTipoVehiculo.AutoSize = true;
            this.lblTipoVehiculo.Location = new System.Drawing.Point(12, 39);
            this.lblTipoVehiculo.Name = "lblTipoVehiculo";
            this.lblTipoVehiculo.Size = new System.Drawing.Size(92, 13);
            this.lblTipoVehiculo.TabIndex = 0;
            this.lblTipoVehiculo.Text = "Tipo de vehiculo :";
            this.lblTipoVehiculo.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblCantidadAcobrar
            // 
            this.lblCantidadAcobrar.AutoSize = true;
            this.lblCantidadAcobrar.Location = new System.Drawing.Point(123, 78);
            this.lblCantidadAcobrar.Name = "lblCantidadAcobrar";
            this.lblCantidadAcobrar.Size = new System.Drawing.Size(0, 13);
            this.lblCantidadAcobrar.TabIndex = 1;
            // 
            // btnCobrar
            // 
            this.btnCobrar.Location = new System.Drawing.Point(12, 73);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Size = new System.Drawing.Size(105, 23);
            this.btnCobrar.TabIndex = 2;
            this.btnCobrar.Text = "Cantidad a cobrar :";
            this.btnCobrar.UseVisualStyleBackColor = true;
            this.btnCobrar.Click += new System.EventHandler(this.btnCobrar_Click);
            // 
            // btnNueVehiculo
            // 
            this.btnNueVehiculo.Location = new System.Drawing.Point(15, 130);
            this.btnNueVehiculo.Name = "btnNueVehiculo";
            this.btnNueVehiculo.Size = new System.Drawing.Size(75, 23);
            this.btnNueVehiculo.TabIndex = 3;
            this.btnNueVehiculo.Text = "Nuevo Vehiculo";
            this.btnNueVehiculo.UseVisualStyleBackColor = true;
            this.btnNueVehiculo.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(167, 191);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // cmbTipoVehiculo
            // 
            this.cmbTipoVehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoVehiculo.FormattingEnabled = true;
            this.cmbTipoVehiculo.Location = new System.Drawing.Point(110, 36);
            this.cmbTipoVehiculo.Name = "cmbTipoVehiculo";
            this.cmbTipoVehiculo.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoVehiculo.TabIndex = 5;
            this.cmbTipoVehiculo.SelectedIndexChanged += new System.EventHandler(this.cmbTipoVehiculo_SelectedIndexChanged);
            // 
            // error1
            // 
            this.error1.ContainerControl = this;
            // 
            // frmVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 218);
            this.Controls.Add(this.cmbTipoVehiculo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnNueVehiculo);
            this.Controls.Add(this.btnCobrar);
            this.Controls.Add(this.lblCantidadAcobrar);
            this.Controls.Add(this.lblTipoVehiculo);
            this.Name = "frmVehiculo";
            this.Text = "Caseta de cobro";
            this.Load += new System.EventHandler(this.frmVehiculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.error1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTipoVehiculo;
        private System.Windows.Forms.Label lblCantidadAcobrar;
        private System.Windows.Forms.Button btnCobrar;
        private System.Windows.Forms.Button btnNueVehiculo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ComboBox cmbTipoVehiculo;
        private System.Windows.Forms.ErrorProvider error1;
    }
}

