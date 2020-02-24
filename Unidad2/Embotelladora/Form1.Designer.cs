namespace Embotelladora
{
    partial class frmEmbotelladora
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.IbINivelLlenado = new System.Windows.Forms.Label();
            this.txtNivelLlenado = new System.Windows.Forms.TextBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // IbINivelLlenado
            // 
            this.IbINivelLlenado.AutoSize = true;
            this.IbINivelLlenado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.IbINivelLlenado.Location = new System.Drawing.Point(12, 37);
            this.IbINivelLlenado.Name = "IbINivelLlenado";
            this.IbINivelLlenado.Size = new System.Drawing.Size(143, 13);
            this.IbINivelLlenado.TabIndex = 2;
            this.IbINivelLlenado.Text = "Introduce el nivel de llenado:";
            this.IbINivelLlenado.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNivelLlenado
            // 
            this.txtNivelLlenado.Location = new System.Drawing.Point(160, 34);
            this.txtNivelLlenado.Name = "txtNivelLlenado";
            this.txtNivelLlenado.Size = new System.Drawing.Size(97, 20);
            this.txtNivelLlenado.TabIndex = 3;
            this.txtNivelLlenado.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // btnVerificar
            // 
            this.btnVerificar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVerificar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnVerificar.Location = new System.Drawing.Point(263, 32);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(75, 23);
            this.btnVerificar.TabIndex = 4;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = false;
            this.btnVerificar.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmEmbotelladora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 261);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.txtNivelLlenado);
            this.Controls.Add(this.IbINivelLlenado);
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Name = "frmEmbotelladora";
            this.Text = "Embotelladora  Santo Domingo - Verificador";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label IbINivelLlenado;
        private System.Windows.Forms.TextBox txtNivelLlenado;
        private System.Windows.Forms.Button btnVerificar;
    }
}

