namespace ExamenRecibo
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
            this.lblTipoCo = new System.Windows.Forms.Label();
            this.cmbTipoContrato = new System.Windows.Forms.ComboBox();
            this.btnCalCaPagar = new System.Windows.Forms.Button();
            this.lblResultTiContrato = new System.Windows.Forms.Label();
            this.lblTipoContrato = new System.Windows.Forms.Label();
            this.lblResultCaPagar = new System.Windows.Forms.Label();
            this.lblCantidadPagar = new System.Windows.Forms.Label();
            this.txtCaWatts = new System.Windows.Forms.TextBox();
            this.lblInWatts = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTipoCo
            // 
            this.lblTipoCo.AutoSize = true;
            this.lblTipoCo.Location = new System.Drawing.Point(46, 71);
            this.lblTipoCo.Name = "lblTipoCo";
            this.lblTipoCo.Size = new System.Drawing.Size(91, 13);
            this.lblTipoCo.TabIndex = 18;
            this.lblTipoCo.Text = "Tipo de contrato :";
            // 
            // cmbTipoContrato
            // 
            this.cmbTipoContrato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoContrato.FormattingEnabled = true;
            this.cmbTipoContrato.Location = new System.Drawing.Point(208, 64);
            this.cmbTipoContrato.Name = "cmbTipoContrato";
            this.cmbTipoContrato.Size = new System.Drawing.Size(100, 21);
            this.cmbTipoContrato.TabIndex = 17;
            // 
            // btnCalCaPagar
            // 
            this.btnCalCaPagar.Location = new System.Drawing.Point(87, 127);
            this.btnCalCaPagar.Name = "btnCalCaPagar";
            this.btnCalCaPagar.Size = new System.Drawing.Size(153, 39);
            this.btnCalCaPagar.TabIndex = 16;
            this.btnCalCaPagar.Text = "Calcular cantidad a pagar";
            this.btnCalCaPagar.UseVisualStyleBackColor = true;
            this.btnCalCaPagar.Click += new System.EventHandler(this.btnCalCaPagar_Click);
            // 
            // lblResultTiContrato
            // 
            this.lblResultTiContrato.AutoSize = true;
            this.lblResultTiContrato.Location = new System.Drawing.Point(147, 204);
            this.lblResultTiContrato.Name = "lblResultTiContrato";
            this.lblResultTiContrato.Size = new System.Drawing.Size(0, 13);
            this.lblResultTiContrato.TabIndex = 15;
            // 
            // lblTipoContrato
            // 
            this.lblTipoContrato.AutoSize = true;
            this.lblTipoContrato.Location = new System.Drawing.Point(28, 204);
            this.lblTipoContrato.Name = "lblTipoContrato";
            this.lblTipoContrato.Size = new System.Drawing.Size(113, 13);
            this.lblTipoContrato.TabIndex = 14;
            this.lblTipoContrato.Text = "El tipo de contrato es :";
            // 
            // lblResultCaPagar
            // 
            this.lblResultCaPagar.AutoSize = true;
            this.lblResultCaPagar.Location = new System.Drawing.Point(152, 169);
            this.lblResultCaPagar.Name = "lblResultCaPagar";
            this.lblResultCaPagar.Size = new System.Drawing.Size(0, 13);
            this.lblResultCaPagar.TabIndex = 13;
            // 
            // lblCantidadPagar
            // 
            this.lblCantidadPagar.AutoSize = true;
            this.lblCantidadPagar.Location = new System.Drawing.Point(28, 169);
            this.lblCantidadPagar.Name = "lblCantidadPagar";
            this.lblCantidadPagar.Size = new System.Drawing.Size(118, 13);
            this.lblCantidadPagar.TabIndex = 12;
            this.lblCantidadPagar.Text = "la cantidad a pagar es :";
            // 
            // txtCaWatts
            // 
            this.txtCaWatts.Location = new System.Drawing.Point(208, 28);
            this.txtCaWatts.Name = "txtCaWatts";
            this.txtCaWatts.Size = new System.Drawing.Size(100, 20);
            this.txtCaWatts.TabIndex = 11;
            // 
            // lblInWatts
            // 
            this.lblInWatts.AutoSize = true;
            this.lblInWatts.Location = new System.Drawing.Point(28, 28);
            this.lblInWatts.Name = "lblInWatts";
            this.lblInWatts.Size = new System.Drawing.Size(173, 13);
            this.lblInWatts.TabIndex = 10;
            this.lblInWatts.Text = "Introduce la cantidad de Kilowatts :";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 283);
            this.Controls.Add(this.lblTipoCo);
            this.Controls.Add(this.cmbTipoContrato);
            this.Controls.Add(this.btnCalCaPagar);
            this.Controls.Add(this.lblResultTiContrato);
            this.Controls.Add(this.lblTipoContrato);
            this.Controls.Add(this.lblResultCaPagar);
            this.Controls.Add(this.lblCantidadPagar);
            this.Controls.Add(this.txtCaWatts);
            this.Controls.Add(this.lblInWatts);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTipoCo;
        private System.Windows.Forms.ComboBox cmbTipoContrato;
        private System.Windows.Forms.Button btnCalCaPagar;
        private System.Windows.Forms.Label lblResultTiContrato;
        private System.Windows.Forms.Label lblTipoContrato;
        private System.Windows.Forms.Label lblResultCaPagar;
        private System.Windows.Forms.Label lblCantidadPagar;
        private System.Windows.Forms.TextBox txtCaWatts;
        private System.Windows.Forms.Label lblInWatts;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

