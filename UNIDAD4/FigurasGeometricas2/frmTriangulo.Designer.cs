namespace FigurasGeometricas2
{
    partial class frmTriangulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTriangulo));
            this.lblArea = new System.Windows.Forms.Label();
            this.lblPerimetro = new System.Windows.Forms.Label();
            this.btnArea = new System.Windows.Forms.Button();
            this.lblTiTri = new System.Windows.Forms.Label();
            this.btnPerimetro = new System.Windows.Forms.Button();
            this.cmbTipodeTriangulo = new System.Windows.Forms.ComboBox();
            this.gbxTiTriangulo = new System.Windows.Forms.GroupBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.lblAltura = new System.Windows.Forms.Label();
            this.pbxFondo = new System.Windows.Forms.PictureBox();
            this.lblLado2 = new System.Windows.Forms.Label();
            this.txtLado1 = new System.Windows.Forms.TextBox();
            this.pbxIsoceles = new System.Windows.Forms.PictureBox();
            this.txtLado3 = new System.Windows.Forms.TextBox();
            this.pbxEscaleno = new System.Windows.Forms.PictureBox();
            this.txtLado2 = new System.Windows.Forms.TextBox();
            this.pbxEsquilatero = new System.Windows.Forms.PictureBox();
            this.lbllLado1 = new System.Windows.Forms.Label();
            this.lblLado3 = new System.Windows.Forms.Label();
            this.gbxTiTriangulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFondo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIsoceles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEscaleno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEsquilatero)).BeginInit();
            this.SuspendLayout();
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(121, 264);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(0, 13);
            this.lblArea.TabIndex = 23;
            // 
            // lblPerimetro
            // 
            this.lblPerimetro.AutoSize = true;
            this.lblPerimetro.Location = new System.Drawing.Point(121, 221);
            this.lblPerimetro.Name = "lblPerimetro";
            this.lblPerimetro.Size = new System.Drawing.Size(0, 13);
            this.lblPerimetro.TabIndex = 22;
            // 
            // btnArea
            // 
            this.btnArea.Location = new System.Drawing.Point(38, 259);
            this.btnArea.Name = "btnArea";
            this.btnArea.Size = new System.Drawing.Size(75, 23);
            this.btnArea.TabIndex = 21;
            this.btnArea.Text = "Area";
            this.btnArea.UseVisualStyleBackColor = true;
            this.btnArea.Click += new System.EventHandler(this.btnArea_Click);
            // 
            // lblTiTri
            // 
            this.lblTiTri.AutoSize = true;
            this.lblTiTri.Location = new System.Drawing.Point(26, 41);
            this.lblTiTri.Name = "lblTiTri";
            this.lblTiTri.Size = new System.Drawing.Size(92, 13);
            this.lblTiTri.TabIndex = 20;
            this.lblTiTri.Text = "Tipo de triangulo :";
            // 
            // btnPerimetro
            // 
            this.btnPerimetro.Location = new System.Drawing.Point(38, 216);
            this.btnPerimetro.Name = "btnPerimetro";
            this.btnPerimetro.Size = new System.Drawing.Size(75, 23);
            this.btnPerimetro.TabIndex = 18;
            this.btnPerimetro.Text = "Perimetro ";
            this.btnPerimetro.UseVisualStyleBackColor = true;
            this.btnPerimetro.Click += new System.EventHandler(this.btnPerimetro_Click);
            // 
            // cmbTipodeTriangulo
            // 
            this.cmbTipodeTriangulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipodeTriangulo.FormattingEnabled = true;
            this.cmbTipodeTriangulo.Location = new System.Drawing.Point(124, 38);
            this.cmbTipodeTriangulo.Name = "cmbTipodeTriangulo";
            this.cmbTipodeTriangulo.Size = new System.Drawing.Size(121, 21);
            this.cmbTipodeTriangulo.TabIndex = 17;
            this.cmbTipodeTriangulo.SelectedIndexChanged += new System.EventHandler(this.cmbTipodeTriangulo_SelectedIndexChanged);
            // 
            // gbxTiTriangulo
            // 
            this.gbxTiTriangulo.BackColor = System.Drawing.Color.White;
            this.gbxTiTriangulo.Controls.Add(this.txtAltura);
            this.gbxTiTriangulo.Controls.Add(this.lblAltura);
            this.gbxTiTriangulo.Controls.Add(this.pbxFondo);
            this.gbxTiTriangulo.Controls.Add(this.lblLado2);
            this.gbxTiTriangulo.Controls.Add(this.txtLado1);
            this.gbxTiTriangulo.Controls.Add(this.pbxIsoceles);
            this.gbxTiTriangulo.Controls.Add(this.txtLado3);
            this.gbxTiTriangulo.Controls.Add(this.pbxEscaleno);
            this.gbxTiTriangulo.Controls.Add(this.txtLado2);
            this.gbxTiTriangulo.Controls.Add(this.pbxEsquilatero);
            this.gbxTiTriangulo.Controls.Add(this.lbllLado1);
            this.gbxTiTriangulo.Controls.Add(this.lblLado3);
            this.gbxTiTriangulo.Location = new System.Drawing.Point(38, 65);
            this.gbxTiTriangulo.Name = "gbxTiTriangulo";
            this.gbxTiTriangulo.Size = new System.Drawing.Size(304, 132);
            this.gbxTiTriangulo.TabIndex = 19;
            this.gbxTiTriangulo.TabStop = false;
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(81, 36);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(35, 20);
            this.txtAltura.TabIndex = 13;
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(35, 39);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(40, 13);
            this.lblAltura.TabIndex = 12;
            this.lblAltura.Text = "Altura :";
            // 
            // pbxFondo
            // 
            this.pbxFondo.BackColor = System.Drawing.Color.White;
            this.pbxFondo.Image = ((System.Drawing.Image)(resources.GetObject("pbxFondo.Image")));
            this.pbxFondo.Location = new System.Drawing.Point(120, 34);
            this.pbxFondo.Name = "pbxFondo";
            this.pbxFondo.Size = new System.Drawing.Size(71, 67);
            this.pbxFondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxFondo.TabIndex = 11;
            this.pbxFondo.TabStop = false;
            // 
            // lblLado2
            // 
            this.lblLado2.AutoSize = true;
            this.lblLado2.BackColor = System.Drawing.Color.White;
            this.lblLado2.Location = new System.Drawing.Point(29, 66);
            this.lblLado2.Name = "lblLado2";
            this.lblLado2.Size = new System.Drawing.Size(46, 13);
            this.lblLado2.TabIndex = 2;
            this.lblLado2.Text = "Lado 2 :";
            // 
            // txtLado1
            // 
            this.txtLado1.Location = new System.Drawing.Point(140, 107);
            this.txtLado1.Name = "txtLado1";
            this.txtLado1.Size = new System.Drawing.Size(33, 20);
            this.txtLado1.TabIndex = 10;
            // 
            // pbxIsoceles
            // 
            this.pbxIsoceles.Image = ((System.Drawing.Image)(resources.GetObject("pbxIsoceles.Image")));
            this.pbxIsoceles.Location = new System.Drawing.Point(120, 34);
            this.pbxIsoceles.Name = "pbxIsoceles";
            this.pbxIsoceles.Size = new System.Drawing.Size(71, 67);
            this.pbxIsoceles.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxIsoceles.TabIndex = 7;
            this.pbxIsoceles.TabStop = false;
            // 
            // txtLado3
            // 
            this.txtLado3.Location = new System.Drawing.Point(197, 62);
            this.txtLado3.Name = "txtLado3";
            this.txtLado3.Size = new System.Drawing.Size(33, 20);
            this.txtLado3.TabIndex = 9;
            // 
            // pbxEscaleno
            // 
            this.pbxEscaleno.Image = ((System.Drawing.Image)(resources.GetObject("pbxEscaleno.Image")));
            this.pbxEscaleno.Location = new System.Drawing.Point(120, 34);
            this.pbxEscaleno.Name = "pbxEscaleno";
            this.pbxEscaleno.Size = new System.Drawing.Size(71, 67);
            this.pbxEscaleno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxEscaleno.TabIndex = 6;
            this.pbxEscaleno.TabStop = false;
            // 
            // txtLado2
            // 
            this.txtLado2.Location = new System.Drawing.Point(81, 62);
            this.txtLado2.Name = "txtLado2";
            this.txtLado2.Size = new System.Drawing.Size(33, 20);
            this.txtLado2.TabIndex = 8;
            // 
            // pbxEsquilatero
            // 
            this.pbxEsquilatero.Enabled = false;
            this.pbxEsquilatero.Image = ((System.Drawing.Image)(resources.GetObject("pbxEsquilatero.Image")));
            this.pbxEsquilatero.Location = new System.Drawing.Point(120, 34);
            this.pbxEsquilatero.Name = "pbxEsquilatero";
            this.pbxEsquilatero.Size = new System.Drawing.Size(71, 67);
            this.pbxEsquilatero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxEsquilatero.TabIndex = 1;
            this.pbxEsquilatero.TabStop = false;
            // 
            // lbllLado1
            // 
            this.lbllLado1.AutoSize = true;
            this.lbllLado1.BackColor = System.Drawing.Color.White;
            this.lbllLado1.Location = new System.Drawing.Point(59, 110);
            this.lbllLado1.Name = "lbllLado1";
            this.lbllLado1.Size = new System.Drawing.Size(75, 13);
            this.lbllLado1.TabIndex = 3;
            this.lbllLado1.Text = "Lado 1/Base :";
            // 
            // lblLado3
            // 
            this.lblLado3.AutoSize = true;
            this.lblLado3.BackColor = System.Drawing.Color.White;
            this.lblLado3.Location = new System.Drawing.Point(236, 66);
            this.lblLado3.Name = "lblLado3";
            this.lblLado3.Size = new System.Drawing.Size(46, 13);
            this.lblLado3.TabIndex = 4;
            this.lblLado3.Text = ": Lado 3";
            // 
            // frmTriangulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(368, 320);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblPerimetro);
            this.Controls.Add(this.btnArea);
            this.Controls.Add(this.lblTiTri);
            this.Controls.Add(this.btnPerimetro);
            this.Controls.Add(this.cmbTipodeTriangulo);
            this.Controls.Add(this.gbxTiTriangulo);
            this.Name = "frmTriangulo";
            this.Text = "Triangulo";
            this.Load += new System.EventHandler(this.frmTriangulo_Load);
            this.gbxTiTriangulo.ResumeLayout(false);
            this.gbxTiTriangulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFondo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIsoceles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEscaleno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEsquilatero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblPerimetro;
        private System.Windows.Forms.Button btnArea;
        private System.Windows.Forms.Label lblTiTri;
        private System.Windows.Forms.Button btnPerimetro;
        private System.Windows.Forms.ComboBox cmbTipodeTriangulo;
        private System.Windows.Forms.GroupBox gbxTiTriangulo;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.PictureBox pbxFondo;
        private System.Windows.Forms.Label lblLado2;
        private System.Windows.Forms.TextBox txtLado1;
        private System.Windows.Forms.PictureBox pbxIsoceles;
        private System.Windows.Forms.TextBox txtLado3;
        private System.Windows.Forms.PictureBox pbxEscaleno;
        private System.Windows.Forms.TextBox txtLado2;
        private System.Windows.Forms.PictureBox pbxEsquilatero;
        private System.Windows.Forms.Label lbllLado1;
        private System.Windows.Forms.Label lblLado3;
    }
}