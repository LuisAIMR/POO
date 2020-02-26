namespace Recibo
{
    partial class frmRecibo
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
            this.lblWatts = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.btnCantidadPagar = new System.Windows.Forms.Button();
            this.lblCantidadPagar = new System.Windows.Forms.Label();
            this.lblResultadoPagar = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblTipContrato = new System.Windows.Forms.Label();
            this.lblRestuladoTipo = new System.Windows.Forms.Label();
            this.txtIntCanWatts = new System.Windows.Forms.TextBox();
            this.lblTipoContrato = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWatts
            // 
            this.lblWatts.AutoSize = true;
            this.lblWatts.Location = new System.Drawing.Point(18, 21);
            this.lblWatts.Name = "lblWatts";
            this.lblWatts.Size = new System.Drawing.Size(114, 13);
            this.lblWatts.TabIndex = 0;
            this.lblWatts.Text = "Cantidad de kilowatts :";
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(135, 44);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(96, 21);
            this.cmbTipo.TabIndex = 1;
            this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.cmbTipo_SelectedIndexChanged);
            // 
            // btnCantidadPagar
            // 
            this.btnCantidadPagar.Location = new System.Drawing.Point(70, 106);
            this.btnCantidadPagar.Name = "btnCantidadPagar";
            this.btnCantidadPagar.Size = new System.Drawing.Size(118, 23);
            this.btnCantidadPagar.TabIndex = 2;
            this.btnCantidadPagar.Text = "Cantidad a pagar";
            this.btnCantidadPagar.UseVisualStyleBackColor = true;
            this.btnCantidadPagar.Click += new System.EventHandler(this.btnCantidadPagar_Click);
            // 
            // lblCantidadPagar
            // 
            this.lblCantidadPagar.AutoSize = true;
            this.lblCantidadPagar.Location = new System.Drawing.Point(38, 142);
            this.lblCantidadPagar.Name = "lblCantidadPagar";
            this.lblCantidadPagar.Size = new System.Drawing.Size(94, 13);
            this.lblCantidadPagar.TabIndex = 3;
            this.lblCantidadPagar.Text = "Cantidad a pagar :";
            // 
            // lblResultadoPagar
            // 
            this.lblResultadoPagar.AutoSize = true;
            this.lblResultadoPagar.Location = new System.Drawing.Point(132, 142);
            this.lblResultadoPagar.Name = "lblResultadoPagar";
            this.lblResultadoPagar.Size = new System.Drawing.Size(0, 13);
            this.lblResultadoPagar.TabIndex = 4;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(12, 226);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 5;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(180, 226);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblTipContrato
            // 
            this.lblTipContrato.AutoSize = true;
            this.lblTipContrato.Location = new System.Drawing.Point(38, 171);
            this.lblTipContrato.Name = "lblTipContrato";
            this.lblTipContrato.Size = new System.Drawing.Size(91, 13);
            this.lblTipContrato.TabIndex = 7;
            this.lblTipContrato.Text = "Tipo de contrato :";
            // 
            // lblRestuladoTipo
            // 
            this.lblRestuladoTipo.AutoSize = true;
            this.lblRestuladoTipo.Location = new System.Drawing.Point(132, 171);
            this.lblRestuladoTipo.Name = "lblRestuladoTipo";
            this.lblRestuladoTipo.Size = new System.Drawing.Size(0, 13);
            this.lblRestuladoTipo.TabIndex = 8;
            // 
            // txtIntCanWatts
            // 
            this.txtIntCanWatts.Location = new System.Drawing.Point(135, 18);
            this.txtIntCanWatts.Name = "txtIntCanWatts";
            this.txtIntCanWatts.Size = new System.Drawing.Size(96, 20);
            this.txtIntCanWatts.TabIndex = 9;
            this.txtIntCanWatts.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblTipoContrato
            // 
            this.lblTipoContrato.AutoSize = true;
            this.lblTipoContrato.Location = new System.Drawing.Point(38, 47);
            this.lblTipoContrato.Name = "lblTipoContrato";
            this.lblTipoContrato.Size = new System.Drawing.Size(91, 13);
            this.lblTipoContrato.TabIndex = 10;
            this.lblTipoContrato.Text = "Tipo de contrato :";
            // 
            // frmRecibo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 261);
            this.Controls.Add(this.lblTipoContrato);
            this.Controls.Add(this.txtIntCanWatts);
            this.Controls.Add(this.lblRestuladoTipo);
            this.Controls.Add(this.lblTipContrato);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.lblResultadoPagar);
            this.Controls.Add(this.lblCantidadPagar);
            this.Controls.Add(this.btnCantidadPagar);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.lblWatts);
            this.Name = "frmRecibo";
            this.Text = "Recibo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWatts;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Button btnCantidadPagar;
        private System.Windows.Forms.Label lblCantidadPagar;
        private System.Windows.Forms.Label lblResultadoPagar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblTipContrato;
        private System.Windows.Forms.Label lblRestuladoTipo;
        private System.Windows.Forms.TextBox txtIntCanWatts;
        private System.Windows.Forms.Label lblTipoContrato;
    }
}

