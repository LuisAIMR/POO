namespace CatalogoProgramas
{
    partial class Unidad1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblElige = new System.Windows.Forms.Label();
            this.btnMiPrimerProyectoWindowsForms = new System.Windows.Forms.Button();
            this.btnMiPrimerProyectoConsola = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::CatalogoProgramas.Properties.Resources.unnamed;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(411, 261);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblElige
            // 
            this.lblElige.AutoSize = true;
            this.lblElige.BackColor = System.Drawing.Color.Transparent;
            this.lblElige.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElige.Location = new System.Drawing.Point(55, 91);
            this.lblElige.Name = "lblElige";
            this.lblElige.Size = new System.Drawing.Size(330, 20);
            this.lblElige.TabIndex = 7;
            this.lblElige.Text = "Elija el programa que desea ejecutar";
            // 
            // btnMiPrimerProyectoWindowsForms
            // 
            this.btnMiPrimerProyectoWindowsForms.Location = new System.Drawing.Point(128, 203);
            this.btnMiPrimerProyectoWindowsForms.Name = "btnMiPrimerProyectoWindowsForms";
            this.btnMiPrimerProyectoWindowsForms.Size = new System.Drawing.Size(175, 23);
            this.btnMiPrimerProyectoWindowsForms.TabIndex = 6;
            this.btnMiPrimerProyectoWindowsForms.Text = "MiPrimerProyectoWindowsForms";
            this.btnMiPrimerProyectoWindowsForms.UseVisualStyleBackColor = true;
            this.btnMiPrimerProyectoWindowsForms.Click += new System.EventHandler(this.btnMiPrimerProyectoWindowsForms_Click);
            // 
            // btnMiPrimerProyectoConsola
            // 
            this.btnMiPrimerProyectoConsola.Location = new System.Drawing.Point(138, 143);
            this.btnMiPrimerProyectoConsola.Name = "btnMiPrimerProyectoConsola";
            this.btnMiPrimerProyectoConsola.Size = new System.Drawing.Size(145, 23);
            this.btnMiPrimerProyectoConsola.TabIndex = 5;
            this.btnMiPrimerProyectoConsola.Text = "MiPrimerProyectoConsola";
            this.btnMiPrimerProyectoConsola.UseVisualStyleBackColor = true;
            this.btnMiPrimerProyectoConsola.Click += new System.EventHandler(this.btnMiPrimerProyectoConsola_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Location = new System.Drawing.Point(12, 12);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(97, 23);
            this.btnRegresar.TabIndex = 4;
            this.btnRegresar.Text = "←Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click_1);
            // 
            // Unidad1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(411, 261);
            this.Controls.Add(this.lblElige);
            this.Controls.Add(this.btnMiPrimerProyectoWindowsForms);
            this.Controls.Add(this.btnMiPrimerProyectoConsola);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Unidad1";
            this.Text = "Unidad1";
            this.Load += new System.EventHandler(this.Unidad1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblElige;
        private System.Windows.Forms.Button btnMiPrimerProyectoWindowsForms;
        private System.Windows.Forms.Button btnMiPrimerProyectoConsola;
        private System.Windows.Forms.Button btnRegresar;
    }
}