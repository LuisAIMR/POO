namespace InterfacesEjercicio1
{
    partial class frmUnidadesMedida
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
            this.lblDato = new System.Windows.Forms.Label();
            this.lblConvertir = new System.Windows.Forms.Label();
            this.txtDato = new System.Windows.Forms.TextBox();
            this.cmbTipoUnidad = new System.Windows.Forms.ComboBox();
            this.cmbConvertirA = new System.Windows.Forms.ComboBox();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDato
            // 
            this.lblDato.AutoSize = true;
            this.lblDato.Location = new System.Drawing.Point(38, 61);
            this.lblDato.Name = "lblDato";
            this.lblDato.Size = new System.Drawing.Size(30, 13);
            this.lblDato.TabIndex = 0;
            this.lblDato.Text = "Dato";
            this.lblDato.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblConvertir
            // 
            this.lblConvertir.AutoSize = true;
            this.lblConvertir.Location = new System.Drawing.Point(215, 60);
            this.lblConvertir.Name = "lblConvertir";
            this.lblConvertir.Size = new System.Drawing.Size(58, 13);
            this.lblConvertir.TabIndex = 1;
            this.lblConvertir.Text = "Convertir a";
            this.lblConvertir.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtDato
            // 
            this.txtDato.Location = new System.Drawing.Point(25, 79);
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(59, 20);
            this.txtDato.TabIndex = 2;
            // 
            // cmbTipoUnidad
            // 
            this.cmbTipoUnidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoUnidad.FormattingEnabled = true;
            this.cmbTipoUnidad.Location = new System.Drawing.Point(90, 78);
            this.cmbTipoUnidad.Name = "cmbTipoUnidad";
            this.cmbTipoUnidad.Size = new System.Drawing.Size(85, 21);
            this.cmbTipoUnidad.TabIndex = 4;
            this.cmbTipoUnidad.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cmbConvertirA
            // 
            this.cmbConvertirA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConvertirA.FormattingEnabled = true;
            this.cmbConvertirA.Location = new System.Drawing.Point(202, 77);
            this.cmbConvertirA.Name = "cmbConvertirA";
            this.cmbConvertirA.Size = new System.Drawing.Size(83, 21);
            this.cmbConvertirA.TabIndex = 5;
            this.cmbConvertirA.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(291, 78);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(75, 23);
            this.btnConvertir.TabIndex = 6;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(372, 82);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 13);
            this.lblResultado.TabIndex = 7;
            this.lblResultado.Click += new System.EventHandler(this.label3_Click);
            // 
            // frmUnidadesMedida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 171);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.cmbConvertirA);
            this.Controls.Add(this.cmbTipoUnidad);
            this.Controls.Add(this.txtDato);
            this.Controls.Add(this.lblConvertir);
            this.Controls.Add(this.lblDato);
            this.Name = "frmUnidadesMedida";
            this.Text = "Unidades de Medida";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDato;
        private System.Windows.Forms.Label lblConvertir;
        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.ComboBox cmbTipoUnidad;
        private System.Windows.Forms.ComboBox cmbConvertirA;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.Label lblResultado;
    }
}

