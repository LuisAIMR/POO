namespace Recibo
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
            this.lblInWatts = new System.Windows.Forms.Label();
            this.txtCaWatts = new System.Windows.Forms.TextBox();
            this.lblCantidadPagar = new System.Windows.Forms.Label();
            this.lblResultCaPagar = new System.Windows.Forms.Label();
            this.lblTipoContrato = new System.Windows.Forms.Label();
            this.lblResultTiContrato = new System.Windows.Forms.Label();
            this.btnCalCaPagar = new System.Windows.Forms.Button();
            this.cmbTipoContrato = new System.Windows.Forms.ComboBox();
            this.lblTipoCo = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInWatts
            // 
            this.lblInWatts.AutoSize = true;
            this.lblInWatts.Location = new System.Drawing.Point(12, 22);
            this.lblInWatts.Name = "lblInWatts";
            this.lblInWatts.Size = new System.Drawing.Size(173, 13);
            this.lblInWatts.TabIndex = 0;
            this.lblInWatts.Text = "Introduce la cantidad de Kilowatts :";
            // 
            // txtCaWatts
            // 
            this.txtCaWatts.Location = new System.Drawing.Point(192, 22);
            this.txtCaWatts.Name = "txtCaWatts";
            this.txtCaWatts.Size = new System.Drawing.Size(100, 20);
            this.txtCaWatts.TabIndex = 1;
            // 
            // lblCantidadPagar
            // 
            this.lblCantidadPagar.AutoSize = true;
            this.lblCantidadPagar.Location = new System.Drawing.Point(12, 163);
            this.lblCantidadPagar.Name = "lblCantidadPagar";
            this.lblCantidadPagar.Size = new System.Drawing.Size(118, 13);
            this.lblCantidadPagar.TabIndex = 2;
            this.lblCantidadPagar.Text = "la cantidad a pagar es :";
            this.lblCantidadPagar.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblResultCaPagar
            // 
            this.lblResultCaPagar.AutoSize = true;
            this.lblResultCaPagar.Location = new System.Drawing.Point(136, 163);
            this.lblResultCaPagar.Name = "lblResultCaPagar";
            this.lblResultCaPagar.Size = new System.Drawing.Size(0, 13);
            this.lblResultCaPagar.TabIndex = 3;
            // 
            // lblTipoContrato
            // 
            this.lblTipoContrato.AutoSize = true;
            this.lblTipoContrato.Location = new System.Drawing.Point(12, 198);
            this.lblTipoContrato.Name = "lblTipoContrato";
            this.lblTipoContrato.Size = new System.Drawing.Size(113, 13);
            this.lblTipoContrato.TabIndex = 4;
            this.lblTipoContrato.Text = "El tipo de contrato es :";
            // 
            // lblResultTiContrato
            // 
            this.lblResultTiContrato.AutoSize = true;
            this.lblResultTiContrato.Location = new System.Drawing.Point(131, 198);
            this.lblResultTiContrato.Name = "lblResultTiContrato";
            this.lblResultTiContrato.Size = new System.Drawing.Size(0, 13);
            this.lblResultTiContrato.TabIndex = 5;
            // 
            // btnCalCaPagar
            // 
            this.btnCalCaPagar.Location = new System.Drawing.Point(71, 121);
            this.btnCalCaPagar.Name = "btnCalCaPagar";
            this.btnCalCaPagar.Size = new System.Drawing.Size(153, 39);
            this.btnCalCaPagar.TabIndex = 6;
            this.btnCalCaPagar.Text = "Calcular cantidad a pagar";
            this.btnCalCaPagar.UseVisualStyleBackColor = true;
            this.btnCalCaPagar.Click += new System.EventHandler(this.btnCalCaPagar_Click);
            // 
            // cmbTipoContrato
            // 
            this.cmbTipoContrato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoContrato.FormattingEnabled = true;
            this.cmbTipoContrato.Location = new System.Drawing.Point(192, 58);
            this.cmbTipoContrato.Name = "cmbTipoContrato";
            this.cmbTipoContrato.Size = new System.Drawing.Size(100, 21);
            this.cmbTipoContrato.TabIndex = 7;
            // 
            // lblTipoCo
            // 
            this.lblTipoCo.AutoSize = true;
            this.lblTipoCo.Location = new System.Drawing.Point(30, 65);
            this.lblTipoCo.Name = "lblTipoCo";
            this.lblTipoCo.Size = new System.Drawing.Size(91, 13);
            this.lblTipoCo.TabIndex = 8;
            this.lblTipoCo.Text = "Tipo de contrato :";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(250, 226);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(75, 23);
            this.Salir.TabIndex = 9;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 261);
            this.Controls.Add(this.Salir);
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

        private System.Windows.Forms.Label lblInWatts;
        private System.Windows.Forms.TextBox txtCaWatts;
        private System.Windows.Forms.Label lblCantidadPagar;
        private System.Windows.Forms.Label lblResultCaPagar;
        private System.Windows.Forms.Label lblTipoContrato;
        private System.Windows.Forms.Label lblResultTiContrato;
        private System.Windows.Forms.Button btnCalCaPagar;
        private System.Windows.Forms.ComboBox cmbTipoContrato;
        private System.Windows.Forms.Label lblTipoCo;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button Salir;
    }
}

