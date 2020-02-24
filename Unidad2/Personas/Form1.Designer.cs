namespace Personas
{
    partial class frmPersonas
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApPaterno = new System.Windows.Forms.Label();
            this.lblApMaterno = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApPaterno = new System.Windows.Forms.TextBox();
            this.txtApMaterno = new System.Windows.Forms.TextBox();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.btnInforme = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnSalirPersonas = new System.Windows.Forms.Button();
            this.error1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.error1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(66, 30);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(50, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre :";
            this.lblNombre.Click += new System.EventHandler(this.lblNombre_Click);
            // 
            // lblApPaterno
            // 
            this.lblApPaterno.AutoSize = true;
            this.lblApPaterno.Location = new System.Drawing.Point(27, 53);
            this.lblApPaterno.Name = "lblApPaterno";
            this.lblApPaterno.Size = new System.Drawing.Size(89, 13);
            this.lblApPaterno.TabIndex = 1;
            this.lblApPaterno.Text = "Apellido paterno :";
            // 
            // lblApMaterno
            // 
            this.lblApMaterno.AutoSize = true;
            this.lblApMaterno.Location = new System.Drawing.Point(25, 80);
            this.lblApMaterno.Name = "lblApMaterno";
            this.lblApMaterno.Size = new System.Drawing.Size(91, 13);
            this.lblApMaterno.TabIndex = 2;
            this.lblApMaterno.Text = "Apellido materno :";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(4, 106);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(112, 13);
            this.lblFechaNacimiento.TabIndex = 3;
            this.lblFechaNacimiento.Text = "Fecha de nacimiento :";
            this.lblFechaNacimiento.Click += new System.EventHandler(this.lblFechaNacimiento_Click);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(70, 133);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(46, 13);
            this.lblEstado.TabIndex = 4;
            this.lblEstado.Text = "Estado :";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(82, 170);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(34, 13);
            this.lblTipo.TabIndex = 5;
            this.lblTipo.Text = "Tipo :";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(61, 222);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(55, 13);
            this.lblTelefono.TabIndex = 6;
            this.lblTelefono.Text = "Telefono :";
            this.lblTelefono.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(122, 23);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 7;
            this.txtNombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtApPaterno
            // 
            this.txtApPaterno.Location = new System.Drawing.Point(122, 46);
            this.txtApPaterno.Name = "txtApPaterno";
            this.txtApPaterno.Size = new System.Drawing.Size(100, 20);
            this.txtApPaterno.TabIndex = 8;
            // 
            // txtApMaterno
            // 
            this.txtApMaterno.Location = new System.Drawing.Point(122, 73);
            this.txtApMaterno.Name = "txtApMaterno";
            this.txtApMaterno.Size = new System.Drawing.Size(100, 20);
            this.txtApMaterno.TabIndex = 9;
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(122, 99);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(100, 20);
            this.dtpFechaNacimiento.TabIndex = 10;
            this.dtpFechaNacimiento.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            this.dtpFechaNacimiento.VisibleChanged += new System.EventHandler(this.dtpFechaNacimiento_VisibleChanged);
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(122, 125);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(100, 21);
            this.cmbEstado.TabIndex = 11;
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(122, 162);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(99, 21);
            this.cmbTipo.TabIndex = 12;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(122, 215);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(99, 20);
            this.txtTelefono.TabIndex = 13;
            // 
            // btnInforme
            // 
            this.btnInforme.Location = new System.Drawing.Point(284, 21);
            this.btnInforme.Name = "btnInforme";
            this.btnInforme.Size = new System.Drawing.Size(75, 23);
            this.btnInforme.TabIndex = 14;
            this.btnInforme.Text = "Informe";
            this.btnInforme.UseVisualStyleBackColor = true;
            this.btnInforme.Click += new System.EventHandler(this.btnInforme_Click);
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(146, 255);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(75, 23);
            this.btnReporte.TabIndex = 15;
            this.btnReporte.Text = "Reporte";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // btnSalirPersonas
            // 
            this.btnSalirPersonas.Location = new System.Drawing.Point(305, 314);
            this.btnSalirPersonas.Name = "btnSalirPersonas";
            this.btnSalirPersonas.Size = new System.Drawing.Size(43, 23);
            this.btnSalirPersonas.TabIndex = 16;
            this.btnSalirPersonas.Text = "Salir";
            this.btnSalirPersonas.UseVisualStyleBackColor = true;
            this.btnSalirPersonas.Click += new System.EventHandler(this.btnSalirPersonas_Click);
            // 
            // error1
            // 
            this.error1.ContainerControl = this;
            // 
            // frmPersonas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 349);
            this.Controls.Add(this.btnSalirPersonas);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.btnInforme);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.txtApMaterno);
            this.Controls.Add(this.txtApPaterno);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblFechaNacimiento);
            this.Controls.Add(this.lblApMaterno);
            this.Controls.Add(this.lblApPaterno);
            this.Controls.Add(this.lblNombre);
            this.Name = "frmPersonas";
            this.Text = "Personas";
            this.Load += new System.EventHandler(this.frmPersonas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.error1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApPaterno;
        private System.Windows.Forms.Label lblApMaterno;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApPaterno;
        private System.Windows.Forms.TextBox txtApMaterno;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Button btnInforme;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Button btnSalirPersonas;
        private System.Windows.Forms.ErrorProvider error1;
    }
}

