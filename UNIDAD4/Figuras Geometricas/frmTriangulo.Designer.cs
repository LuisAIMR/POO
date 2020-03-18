namespace Figuras_Geometricas
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
            this.cmbTipodeTriangulo = new System.Windows.Forms.ComboBox();
            this.pbxEsquilatero = new System.Windows.Forms.PictureBox();
            this.lblLado2 = new System.Windows.Forms.Label();
            this.lbllLado1 = new System.Windows.Forms.Label();
            this.lblLado3 = new System.Windows.Forms.Label();
            this.btnPerimetro = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pbxEscaleno = new System.Windows.Forms.PictureBox();
            this.pbxIsoceles = new System.Windows.Forms.PictureBox();
            this.txtLado2 = new System.Windows.Forms.TextBox();
            this.txtLado3 = new System.Windows.Forms.TextBox();
            this.txtLado1 = new System.Windows.Forms.TextBox();
            this.pbxFondo = new System.Windows.Forms.PictureBox();
            this.gbxTiTriangulo = new System.Windows.Forms.GroupBox();
            this.lblTiTri = new System.Windows.Forms.Label();
            this.btnArea = new System.Windows.Forms.Button();
            this.lblPerimetro = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEsquilatero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEscaleno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIsoceles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFondo)).BeginInit();
            this.gbxTiTriangulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbTipodeTriangulo
            // 
            this.cmbTipodeTriangulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipodeTriangulo.FormattingEnabled = true;
            this.cmbTipodeTriangulo.Location = new System.Drawing.Point(98, 28);
            this.cmbTipodeTriangulo.Name = "cmbTipodeTriangulo";
            this.cmbTipodeTriangulo.Size = new System.Drawing.Size(121, 21);
            this.cmbTipodeTriangulo.TabIndex = 0;
            this.cmbTipodeTriangulo.SelectedIndexChanged += new System.EventHandler(this.cmbTipodeTriangulo_SelectedIndexChanged);
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
            // btnPerimetro
            // 
            this.btnPerimetro.Location = new System.Drawing.Point(12, 206);
            this.btnPerimetro.Name = "btnPerimetro";
            this.btnPerimetro.Size = new System.Drawing.Size(75, 23);
            this.btnPerimetro.TabIndex = 5;
            this.btnPerimetro.Text = "Perimetro ";
            this.btnPerimetro.UseVisualStyleBackColor = true;
            this.btnPerimetro.Click += new System.EventHandler(this.btnPerimetro_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
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
            // txtLado2
            // 
            this.txtLado2.Location = new System.Drawing.Point(81, 62);
            this.txtLado2.Name = "txtLado2";
            this.txtLado2.Size = new System.Drawing.Size(33, 20);
            this.txtLado2.TabIndex = 8;
            // 
            // txtLado3
            // 
            this.txtLado3.Location = new System.Drawing.Point(197, 62);
            this.txtLado3.Name = "txtLado3";
            this.txtLado3.Size = new System.Drawing.Size(33, 20);
            this.txtLado3.TabIndex = 9;
            // 
            // txtLado1
            // 
            this.txtLado1.Location = new System.Drawing.Point(140, 107);
            this.txtLado1.Name = "txtLado1";
            this.txtLado1.Size = new System.Drawing.Size(33, 20);
            this.txtLado1.TabIndex = 10;
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
            this.pbxFondo.Click += new System.EventHandler(this.pictureBox4_Click);
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
            this.gbxTiTriangulo.Location = new System.Drawing.Point(12, 55);
            this.gbxTiTriangulo.Name = "gbxTiTriangulo";
            this.gbxTiTriangulo.Size = new System.Drawing.Size(304, 132);
            this.gbxTiTriangulo.TabIndex = 12;
            this.gbxTiTriangulo.TabStop = false;
            this.gbxTiTriangulo.Enter += new System.EventHandler(this.gbxTiTriangulo_Enter);
            // 
            // lblTiTri
            // 
            this.lblTiTri.AutoSize = true;
            this.lblTiTri.Location = new System.Drawing.Point(0, 31);
            this.lblTiTri.Name = "lblTiTri";
            this.lblTiTri.Size = new System.Drawing.Size(92, 13);
            this.lblTiTri.TabIndex = 13;
            this.lblTiTri.Text = "Tipo de triangulo :";
            // 
            // btnArea
            // 
            this.btnArea.Location = new System.Drawing.Point(12, 249);
            this.btnArea.Name = "btnArea";
            this.btnArea.Size = new System.Drawing.Size(75, 23);
            this.btnArea.TabIndex = 14;
            this.btnArea.Text = "Area";
            this.btnArea.UseVisualStyleBackColor = true;
            this.btnArea.Click += new System.EventHandler(this.btnArea_Click);
            // 
            // lblPerimetro
            // 
            this.lblPerimetro.AutoSize = true;
            this.lblPerimetro.Location = new System.Drawing.Point(95, 211);
            this.lblPerimetro.Name = "lblPerimetro";
            this.lblPerimetro.Size = new System.Drawing.Size(0, 13);
            this.lblPerimetro.TabIndex = 15;
            this.lblPerimetro.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(95, 254);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(0, 13);
            this.lblArea.TabIndex = 16;
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
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(81, 36);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(35, 20);
            this.txtAltura.TabIndex = 13;
            // 
            // frmTriangulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(328, 299);
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
            ((System.ComponentModel.ISupportInitialize)(this.pbxEsquilatero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEscaleno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIsoceles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFondo)).EndInit();
            this.gbxTiTriangulo.ResumeLayout(false);
            this.gbxTiTriangulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbTipodeTriangulo;
        private System.Windows.Forms.PictureBox pbxEsquilatero;
        private System.Windows.Forms.Label lblLado2;
        private System.Windows.Forms.Label lbllLado1;
        private System.Windows.Forms.Label lblLado3;
        private System.Windows.Forms.Button btnPerimetro;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pbxEscaleno;
        private System.Windows.Forms.PictureBox pbxIsoceles;
        private System.Windows.Forms.TextBox txtLado2;
        private System.Windows.Forms.TextBox txtLado3;
        private System.Windows.Forms.TextBox txtLado1;
        private System.Windows.Forms.PictureBox pbxFondo;
        private System.Windows.Forms.GroupBox gbxTiTriangulo;
        private System.Windows.Forms.Label lblTiTri;
        private System.Windows.Forms.Button btnArea;
        private System.Windows.Forms.Label lblPerimetro;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Label lblAltura;
    }
}