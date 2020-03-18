namespace Figuras_Geometricas
{
    partial class frmCuadrado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCuadrado));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblLado = new System.Windows.Forms.Label();
            this.txtLado = new System.Windows.Forms.TextBox();
            this.btnPerimetro = new System.Windows.Forms.Button();
            this.btnArea = new System.Windows.Forms.Button();
            this.lblPerimetro = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(83, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblLado
            // 
            this.lblLado.AutoSize = true;
            this.lblLado.BackColor = System.Drawing.Color.White;
            this.lblLado.Location = new System.Drawing.Point(80, 170);
            this.lblLado.Name = "lblLado";
            this.lblLado.Size = new System.Drawing.Size(37, 13);
            this.lblLado.TabIndex = 1;
            this.lblLado.Text = "Lado :";
            // 
            // txtLado
            // 
            this.txtLado.Location = new System.Drawing.Point(121, 167);
            this.txtLado.Name = "txtLado";
            this.txtLado.Size = new System.Drawing.Size(55, 20);
            this.txtLado.TabIndex = 2;
            // 
            // btnPerimetro
            // 
            this.btnPerimetro.Location = new System.Drawing.Point(42, 217);
            this.btnPerimetro.Name = "btnPerimetro";
            this.btnPerimetro.Size = new System.Drawing.Size(75, 23);
            this.btnPerimetro.TabIndex = 3;
            this.btnPerimetro.Text = "Perimetro";
            this.btnPerimetro.UseVisualStyleBackColor = true;
            this.btnPerimetro.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnArea
            // 
            this.btnArea.Location = new System.Drawing.Point(42, 246);
            this.btnArea.Name = "btnArea";
            this.btnArea.Size = new System.Drawing.Size(75, 23);
            this.btnArea.TabIndex = 4;
            this.btnArea.Text = "Area";
            this.btnArea.UseVisualStyleBackColor = true;
            this.btnArea.Click += new System.EventHandler(this.btnArea_Click);
            // 
            // lblPerimetro
            // 
            this.lblPerimetro.AutoSize = true;
            this.lblPerimetro.Location = new System.Drawing.Point(123, 222);
            this.lblPerimetro.Name = "lblPerimetro";
            this.lblPerimetro.Size = new System.Drawing.Size(0, 13);
            this.lblPerimetro.TabIndex = 5;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(123, 251);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(0, 13);
            this.lblArea.TabIndex = 6;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(320, 320);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // frmCuadrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 288);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblPerimetro);
            this.Controls.Add(this.btnArea);
            this.Controls.Add(this.btnPerimetro);
            this.Controls.Add(this.txtLado);
            this.Controls.Add(this.lblLado);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "frmCuadrado";
            this.Text = "Cuadrado";
            this.Load += new System.EventHandler(this.frmCuadrado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblLado;
        private System.Windows.Forms.TextBox txtLado;
        private System.Windows.Forms.Button btnPerimetro;
        private System.Windows.Forms.Button btnArea;
        private System.Windows.Forms.Label lblPerimetro;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}