namespace Figuras_Geometricas
{
    partial class frmCirculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCirculo));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblRadio = new System.Windows.Forms.Label();
            this.txtLado = new System.Windows.Forms.TextBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblPerimetro = new System.Windows.Forms.Label();
            this.btnArea = new System.Windows.Forms.Button();
            this.btnPerimetro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(100, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblRadio
            // 
            this.lblRadio.AutoSize = true;
            this.lblRadio.Location = new System.Drawing.Point(22, 103);
            this.lblRadio.Name = "lblRadio";
            this.lblRadio.Size = new System.Drawing.Size(41, 13);
            this.lblRadio.TabIndex = 1;
            this.lblRadio.Text = "Radio :";
            // 
            // txtLado
            // 
            this.txtLado.Location = new System.Drawing.Point(63, 100);
            this.txtLado.Name = "txtLado";
            this.txtLado.Size = new System.Drawing.Size(31, 20);
            this.txtLado.TabIndex = 2;
            this.txtLado.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(106, 231);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(0, 13);
            this.lblArea.TabIndex = 10;
            // 
            // lblPerimetro
            // 
            this.lblPerimetro.AutoSize = true;
            this.lblPerimetro.Location = new System.Drawing.Point(106, 202);
            this.lblPerimetro.Name = "lblPerimetro";
            this.lblPerimetro.Size = new System.Drawing.Size(0, 13);
            this.lblPerimetro.TabIndex = 9;
            // 
            // btnArea
            // 
            this.btnArea.Location = new System.Drawing.Point(25, 226);
            this.btnArea.Name = "btnArea";
            this.btnArea.Size = new System.Drawing.Size(75, 23);
            this.btnArea.TabIndex = 8;
            this.btnArea.Text = "Area";
            this.btnArea.UseVisualStyleBackColor = true;
            this.btnArea.Click += new System.EventHandler(this.btnArea_Click);
            // 
            // btnPerimetro
            // 
            this.btnPerimetro.Location = new System.Drawing.Point(25, 197);
            this.btnPerimetro.Name = "btnPerimetro";
            this.btnPerimetro.Size = new System.Drawing.Size(75, 23);
            this.btnPerimetro.TabIndex = 7;
            this.btnPerimetro.Text = "Perimetro";
            this.btnPerimetro.UseVisualStyleBackColor = true;
            this.btnPerimetro.Click += new System.EventHandler(this.btnPerimetro_Click);
            // 
            // frmCirculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblPerimetro);
            this.Controls.Add(this.btnArea);
            this.Controls.Add(this.btnPerimetro);
            this.Controls.Add(this.txtLado);
            this.Controls.Add(this.lblRadio);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmCirculo";
            this.Text = "Circulo";
            this.Load += new System.EventHandler(this.frmCirculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblRadio;
        private System.Windows.Forms.TextBox txtLado;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblPerimetro;
        private System.Windows.Forms.Button btnArea;
        private System.Windows.Forms.Button btnPerimetro;
    }
}