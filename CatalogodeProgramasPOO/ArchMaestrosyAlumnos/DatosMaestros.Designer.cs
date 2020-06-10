namespace ArchMaestrosyAlumnos
{
    partial class DatosMaestros
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtCurp = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblCurp = new System.Windows.Forms.Label();
            this.lblFechaNac = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.dgvDatosMaestros = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaNac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Curp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroDocente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sueldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MateriasImparte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMateriasImp = new System.Windows.Forms.TextBox();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.txtNumDoc = new System.Windows.Forms.TextBox();
            this.lblMateriasImp = new System.Windows.Forms.Label();
            this.lblSueldo = new System.Windows.Forms.Label();
            this.lblNumMaestro = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnAgregarDatos = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosMaestros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCurp
            // 
            this.txtCurp.Location = new System.Drawing.Point(151, 100);
            this.txtCurp.Name = "txtCurp";
            this.txtCurp.Size = new System.Drawing.Size(230, 20);
            this.txtCurp.TabIndex = 81;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(151, 125);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(230, 20);
            this.txtTelefono.TabIndex = 80;
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNac.Location = new System.Drawing.Point(205, 66);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(176, 20);
            this.dtpFechaNac.TabIndex = 79;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(205, 38);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(176, 20);
            this.txtNombre.TabIndex = 78;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(151, 151);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(230, 20);
            this.txtEmail.TabIndex = 77;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(95, 131);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(54, 14);
            this.lblTelefono.TabIndex = 76;
            this.lblTelefono.Text = "Teléfono: ";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.Location = new System.Drawing.Point(95, 154);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(37, 14);
            this.lblemail.TabIndex = 75;
            this.lblemail.Text = "email: ";
            // 
            // lblCurp
            // 
            this.lblCurp.AutoSize = true;
            this.lblCurp.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurp.Location = new System.Drawing.Point(95, 106);
            this.lblCurp.Name = "lblCurp";
            this.lblCurp.Size = new System.Drawing.Size(36, 14);
            this.lblCurp.TabIndex = 74;
            this.lblCurp.Text = "Curp: ";
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.AutoSize = true;
            this.lblFechaNac.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNac.Location = new System.Drawing.Point(86, 66);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(113, 14);
            this.lblFechaNac.TabIndex = 73;
            this.lblFechaNac.Text = "Fecha de Nacimiento: ";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(95, 41);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(53, 14);
            this.lblNombre.TabIndex = 72;
            this.lblNombre.Text = "Nombre : ";
            // 
            // dgvDatosMaestros
            // 
            this.dgvDatosMaestros.AllowUserToAddRows = false;
            this.dgvDatosMaestros.AllowUserToDeleteRows = false;
            this.dgvDatosMaestros.AllowUserToOrderColumns = true;
            this.dgvDatosMaestros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDatosMaestros.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvDatosMaestros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosMaestros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.FechaNac,
            this.Curp,
            this.Telefono,
            this.Email,
            this.NumeroDocente,
            this.Sueldo,
            this.MateriasImparte});
            this.dgvDatosMaestros.Location = new System.Drawing.Point(93, 302);
            this.dgvDatosMaestros.Name = "dgvDatosMaestros";
            this.dgvDatosMaestros.ReadOnly = true;
            this.dgvDatosMaestros.Size = new System.Drawing.Size(838, 221);
            this.dgvDatosMaestros.TabIndex = 71;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // FechaNac
            // 
            this.FechaNac.HeaderText = "Fecha de Nacimiento";
            this.FechaNac.Name = "FechaNac";
            this.FechaNac.ReadOnly = true;
            // 
            // Curp
            // 
            this.Curp.HeaderText = "Curp";
            this.Curp.Name = "Curp";
            this.Curp.ReadOnly = true;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Teléfono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // NumeroDocente
            // 
            this.NumeroDocente.HeaderText = "Número de Docente";
            this.NumeroDocente.Name = "NumeroDocente";
            this.NumeroDocente.ReadOnly = true;
            // 
            // Sueldo
            // 
            this.Sueldo.HeaderText = "Sueldo";
            this.Sueldo.Name = "Sueldo";
            this.Sueldo.ReadOnly = true;
            // 
            // MateriasImparte
            // 
            this.MateriasImparte.HeaderText = "Materias que Imparte";
            this.MateriasImparte.Name = "MateriasImparte";
            this.MateriasImparte.ReadOnly = true;
            // 
            // txtMateriasImp
            // 
            this.txtMateriasImp.Location = new System.Drawing.Point(205, 227);
            this.txtMateriasImp.Name = "txtMateriasImp";
            this.txtMateriasImp.Size = new System.Drawing.Size(176, 20);
            this.txtMateriasImp.TabIndex = 70;
            // 
            // txtSueldo
            // 
            this.txtSueldo.Location = new System.Drawing.Point(205, 203);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(176, 20);
            this.txtSueldo.TabIndex = 69;
            // 
            // txtNumDoc
            // 
            this.txtNumDoc.Location = new System.Drawing.Point(205, 177);
            this.txtNumDoc.Name = "txtNumDoc";
            this.txtNumDoc.Size = new System.Drawing.Size(176, 20);
            this.txtNumDoc.TabIndex = 68;
            // 
            // lblMateriasImp
            // 
            this.lblMateriasImp.AutoSize = true;
            this.lblMateriasImp.Location = new System.Drawing.Point(91, 230);
            this.lblMateriasImp.Name = "lblMateriasImp";
            this.lblMateriasImp.Size = new System.Drawing.Size(117, 13);
            this.lblMateriasImp.TabIndex = 67;
            this.lblMateriasImp.Text = "Materia (s) que imparte:";
            // 
            // lblSueldo
            // 
            this.lblSueldo.AutoSize = true;
            this.lblSueldo.Location = new System.Drawing.Point(154, 208);
            this.lblSueldo.Name = "lblSueldo";
            this.lblSueldo.Size = new System.Drawing.Size(46, 13);
            this.lblSueldo.TabIndex = 66;
            this.lblSueldo.Text = "Sueldo: ";
            // 
            // lblNumMaestro
            // 
            this.lblNumMaestro.AutoSize = true;
            this.lblNumMaestro.Location = new System.Drawing.Point(95, 184);
            this.lblNumMaestro.Name = "lblNumMaestro";
            this.lblNumMaestro.Size = new System.Drawing.Size(105, 13);
            this.lblNumMaestro.TabIndex = 65;
            this.lblNumMaestro.Text = "Número de maestro: ";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(276, 273);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(105, 23);
            this.btnImprimir.TabIndex = 64;
            this.btnImprimir.Text = "Imprimir datos";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnAgregarDatos
            // 
            this.btnAgregarDatos.Location = new System.Drawing.Point(98, 273);
            this.btnAgregarDatos.Name = "btnAgregarDatos";
            this.btnAgregarDatos.Size = new System.Drawing.Size(121, 23);
            this.btnAgregarDatos.TabIndex = 63;
            this.btnAgregarDatos.Text = "Agregar datos";
            this.btnAgregarDatos.UseVisualStyleBackColor = true;
            this.btnAgregarDatos.Click += new System.EventHandler(this.btnAgregarDatos_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // DatosMaestros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 561);
            this.Controls.Add(this.txtCurp);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.dtpFechaNac);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lblCurp);
            this.Controls.Add(this.lblFechaNac);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.dgvDatosMaestros);
            this.Controls.Add(this.txtMateriasImp);
            this.Controls.Add(this.txtSueldo);
            this.Controls.Add(this.txtNumDoc);
            this.Controls.Add(this.lblMateriasImp);
            this.Controls.Add(this.lblSueldo);
            this.Controls.Add(this.lblNumMaestro);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnAgregarDatos);
            this.Name = "DatosMaestros";
            this.Text = "DatosMaestros";
            this.Load += new System.EventHandler(this.DatosMaestros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosMaestros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCurp;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblCurp;
        private System.Windows.Forms.Label lblFechaNac;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.DataGridView dgvDatosMaestros;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNac;
        private System.Windows.Forms.DataGridViewTextBoxColumn Curp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroDocente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sueldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn MateriasImparte;
        public System.Windows.Forms.TextBox txtMateriasImp;
        public System.Windows.Forms.TextBox txtSueldo;
        public System.Windows.Forms.TextBox txtNumDoc;
        private System.Windows.Forms.Label lblMateriasImp;
        private System.Windows.Forms.Label lblSueldo;
        private System.Windows.Forms.Label lblNumMaestro;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnAgregarDatos;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}