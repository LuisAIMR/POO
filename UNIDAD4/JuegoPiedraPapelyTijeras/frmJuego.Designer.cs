namespace JuegoPiedraPapelyTijeras
{
    partial class frmJuego
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
            this.components = new System.ComponentModel.Container();
            this.cmbElegirTipoPoPoTo = new System.Windows.Forms.ComboBox();
            this.pbxComTijeras = new System.Windows.Forms.PictureBox();
            this.pbxComPapel = new System.Windows.Forms.PictureBox();
            this.pbxComPiedra = new System.Windows.Forms.PictureBox();
            this.gbxComputadora = new System.Windows.Forms.GroupBox();
            this.gbxJugador = new System.Windows.Forms.GroupBox();
            this.pbxJuTijera = new System.Windows.Forms.PictureBox();
            this.pbxJuPiedra = new System.Windows.Forms.PictureBox();
            this.pbxJuPapel = new System.Windows.Forms.PictureBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.error2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbxComTijeras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxComPapel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxComPiedra)).BeginInit();
            this.gbxComputadora.SuspendLayout();
            this.gbxJugador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxJuTijera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxJuPiedra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxJuPapel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error2)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbElegirTipoPoPoTo
            // 
            this.cmbElegirTipoPoPoTo.BackColor = System.Drawing.Color.Orange;
            this.cmbElegirTipoPoPoTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbElegirTipoPoPoTo.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cmbElegirTipoPoPoTo.FormattingEnabled = true;
            this.cmbElegirTipoPoPoTo.Location = new System.Drawing.Point(39, 184);
            this.cmbElegirTipoPoPoTo.Name = "cmbElegirTipoPoPoTo";
            this.cmbElegirTipoPoPoTo.Size = new System.Drawing.Size(121, 33);
            this.cmbElegirTipoPoPoTo.TabIndex = 0;
            this.cmbElegirTipoPoPoTo.SelectedIndexChanged += new System.EventHandler(this.cmbElegirTipoPoPoTo_SelectedIndexChanged);
            // 
            // pbxComTijeras
            // 
            this.pbxComTijeras.Image = global::JuegoPiedraPapelyTijeras.Properties.Resources.ManoTijera;
            this.pbxComTijeras.Location = new System.Drawing.Point(39, 42);
            this.pbxComTijeras.Name = "pbxComTijeras";
            this.pbxComTijeras.Size = new System.Drawing.Size(123, 122);
            this.pbxComTijeras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxComTijeras.TabIndex = 6;
            this.pbxComTijeras.TabStop = false;
            // 
            // pbxComPapel
            // 
            this.pbxComPapel.Image = global::JuegoPiedraPapelyTijeras.Properties.Resources.ManoPapel;
            this.pbxComPapel.Location = new System.Drawing.Point(39, 42);
            this.pbxComPapel.Name = "pbxComPapel";
            this.pbxComPapel.Size = new System.Drawing.Size(123, 122);
            this.pbxComPapel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxComPapel.TabIndex = 5;
            this.pbxComPapel.TabStop = false;
            this.pbxComPapel.Click += new System.EventHandler(this.pbxComPapel_Click);
            // 
            // pbxComPiedra
            // 
            this.pbxComPiedra.Image = global::JuegoPiedraPapelyTijeras.Properties.Resources.ManoPiedra;
            this.pbxComPiedra.Location = new System.Drawing.Point(39, 42);
            this.pbxComPiedra.Name = "pbxComPiedra";
            this.pbxComPiedra.Size = new System.Drawing.Size(123, 120);
            this.pbxComPiedra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxComPiedra.TabIndex = 4;
            this.pbxComPiedra.TabStop = false;
            // 
            // gbxComputadora
            // 
            this.gbxComputadora.BackColor = System.Drawing.Color.Black;
            this.gbxComputadora.Controls.Add(this.pbxComTijeras);
            this.gbxComputadora.Controls.Add(this.pbxComPiedra);
            this.gbxComputadora.Controls.Add(this.pbxComPapel);
            this.gbxComputadora.Font = new System.Drawing.Font("Snap ITC", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxComputadora.ForeColor = System.Drawing.Color.Orange;
            this.gbxComputadora.Location = new System.Drawing.Point(35, 42);
            this.gbxComputadora.Name = "gbxComputadora";
            this.gbxComputadora.Size = new System.Drawing.Size(200, 223);
            this.gbxComputadora.TabIndex = 7;
            this.gbxComputadora.TabStop = false;
            this.gbxComputadora.Text = "Computadora";
            this.gbxComputadora.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // gbxJugador
            // 
            this.gbxJugador.BackColor = System.Drawing.Color.Black;
            this.gbxJugador.Controls.Add(this.pbxJuTijera);
            this.gbxJugador.Controls.Add(this.pbxJuPiedra);
            this.gbxJugador.Controls.Add(this.cmbElegirTipoPoPoTo);
            this.gbxJugador.Controls.Add(this.pbxJuPapel);
            this.gbxJugador.Font = new System.Drawing.Font("Snap ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxJugador.ForeColor = System.Drawing.Color.Orange;
            this.gbxJugador.Location = new System.Drawing.Point(281, 42);
            this.gbxJugador.Name = "gbxJugador";
            this.gbxJugador.Size = new System.Drawing.Size(200, 223);
            this.gbxJugador.TabIndex = 8;
            this.gbxJugador.TabStop = false;
            this.gbxJugador.Text = "Jugador";
            this.gbxJugador.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // pbxJuTijera
            // 
            this.pbxJuTijera.Image = global::JuegoPiedraPapelyTijeras.Properties.Resources.ManoTijera;
            this.pbxJuTijera.Location = new System.Drawing.Point(39, 42);
            this.pbxJuTijera.Name = "pbxJuTijera";
            this.pbxJuTijera.Size = new System.Drawing.Size(123, 122);
            this.pbxJuTijera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxJuTijera.TabIndex = 6;
            this.pbxJuTijera.TabStop = false;
            // 
            // pbxJuPiedra
            // 
            this.pbxJuPiedra.Image = global::JuegoPiedraPapelyTijeras.Properties.Resources.ManoPiedra;
            this.pbxJuPiedra.Location = new System.Drawing.Point(39, 40);
            this.pbxJuPiedra.Name = "pbxJuPiedra";
            this.pbxJuPiedra.Size = new System.Drawing.Size(123, 120);
            this.pbxJuPiedra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxJuPiedra.TabIndex = 4;
            this.pbxJuPiedra.TabStop = false;
            // 
            // pbxJuPapel
            // 
            this.pbxJuPapel.Image = global::JuegoPiedraPapelyTijeras.Properties.Resources.ManoPapel;
            this.pbxJuPapel.Location = new System.Drawing.Point(39, 40);
            this.pbxJuPapel.Name = "pbxJuPapel";
            this.pbxJuPapel.Size = new System.Drawing.Size(123, 122);
            this.pbxJuPapel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxJuPapel.TabIndex = 5;
            this.pbxJuPapel.TabStop = false;
            this.pbxJuPapel.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Black;
            this.lblNombre.Font = new System.Drawing.Font("Snap ITC", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.Orange;
            this.lblNombre.Location = new System.Drawing.Point(278, 24);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(140, 15);
            this.lblNombre.TabIndex = 9;
            this.lblNombre.Text = "Nombre del Jugador :";
            // 
            // error2
            // 
            this.error2.ContainerControl = this;
            // 
            // frmJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JuegoPiedraPapelyTijeras.Properties.Resources.images__18_;
            this.ClientSize = new System.Drawing.Size(509, 288);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.gbxJugador);
            this.Controls.Add(this.gbxComputadora);
            this.Name = "frmJuego";
            this.Text = "Juego - Piedra, Papel y Tijeras";
            this.Load += new System.EventHandler(this.frmJuego_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxComTijeras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxComPapel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxComPiedra)).EndInit();
            this.gbxComputadora.ResumeLayout(false);
            this.gbxComputadora.PerformLayout();
            this.gbxJugador.ResumeLayout(false);
            this.gbxJugador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxJuTijera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxJuPiedra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxJuPapel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbElegirTipoPoPoTo;
        private System.Windows.Forms.PictureBox pbxComTijeras;
        private System.Windows.Forms.PictureBox pbxComPapel;
        private System.Windows.Forms.PictureBox pbxComPiedra;
        private System.Windows.Forms.GroupBox gbxComputadora;
        private System.Windows.Forms.GroupBox gbxJugador;
        private System.Windows.Forms.PictureBox pbxJuTijera;
        private System.Windows.Forms.PictureBox pbxJuPiedra;
        private System.Windows.Forms.PictureBox pbxJuPapel;
        public System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ErrorProvider error2;
    }
}