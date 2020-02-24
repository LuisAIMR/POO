namespace Temperatura
{
    partial class frmTemperatura
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
            this.lblGrados = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.txtGrados = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.lblResConvertir = new System.Windows.Forms.Label();
            this.error1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.error1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGrados
            // 
            this.lblGrados.AutoSize = true;
            this.lblGrados.Location = new System.Drawing.Point(21, 27);
            this.lblGrados.Name = "lblGrados";
            this.lblGrados.Size = new System.Drawing.Size(47, 13);
            this.lblGrados.TabIndex = 0;
            this.lblGrados.Text = "Grados :";
            this.lblGrados.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(143, 23);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(43, 21);
            this.cmbTipo.TabIndex = 1;
            this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.cmbTipo_SelectedIndexChanged);
            // 
            // txtGrados
            // 
            this.txtGrados.Location = new System.Drawing.Point(74, 24);
            this.txtGrados.Name = "txtGrados";
            this.txtGrados.Size = new System.Drawing.Size(53, 20);
            this.txtGrados.TabIndex = 2;
            this.txtGrados.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(111, 121);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(7, 62);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(61, 25);
            this.btnConvertir.TabIndex = 6;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.button4_Click);
            // 
            // lblResConvertir
            // 
            this.lblResConvertir.AutoSize = true;
            this.lblResConvertir.Location = new System.Drawing.Point(74, 68);
            this.lblResConvertir.Name = "lblResConvertir";
            this.lblResConvertir.Size = new System.Drawing.Size(0, 13);
            this.lblResConvertir.TabIndex = 7;
            this.lblResConvertir.Click += new System.EventHandler(this.label2_Click);
            // 
            // error1
            // 
            this.error1.ContainerControl = this;
            // 
            // frmTemperatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 156);
            this.Controls.Add(this.lblResConvertir);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtGrados);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.lblGrados);
            this.Name = "frmTemperatura";
            this.Text = "Temperatura";
            ((System.ComponentModel.ISupportInitialize)(this.error1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGrados;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.TextBox txtGrados;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.Label lblResConvertir;
        private System.Windows.Forms.ErrorProvider error1;
    }
}

