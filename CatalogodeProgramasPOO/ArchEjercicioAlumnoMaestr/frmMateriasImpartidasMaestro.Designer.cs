﻿namespace ArchEjercicioAlumnoMaestr
{
    partial class frmMateriasImpartidasMaestro
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
            this.dgvMateriasImp = new System.Windows.Forms.DataGridView();
            this.MateriaImparte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnListo = new System.Windows.Forms.Button();
            this.lblCantidadMaterias = new System.Windows.Forms.Label();
            this.txtCantidadMaterias = new System.Windows.Forms.TextBox();
            this.btnImprimr = new System.Windows.Forms.Button();
            this.gbxMaterias = new System.Windows.Forms.GroupBox();
            this.btnAgregarMaterias = new System.Windows.Forms.Button();
            this.lblMaterias = new System.Windows.Forms.Label();
            this.txtMateria = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriasImp)).BeginInit();
            this.gbxMaterias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMateriasImp
            // 
            this.dgvMateriasImp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMateriasImp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MateriaImparte});
            this.dgvMateriasImp.Location = new System.Drawing.Point(268, 84);
            this.dgvMateriasImp.Name = "dgvMateriasImp";
            this.dgvMateriasImp.Size = new System.Drawing.Size(143, 150);
            this.dgvMateriasImp.TabIndex = 34;
            // 
            // MateriaImparte
            // 
            this.MateriaImparte.HeaderText = "Materias que Imparte";
            this.MateriaImparte.Name = "MateriaImparte";
            // 
            // btnListo
            // 
            this.btnListo.Location = new System.Drawing.Point(213, 44);
            this.btnListo.Name = "btnListo";
            this.btnListo.Size = new System.Drawing.Size(55, 23);
            this.btnListo.TabIndex = 33;
            this.btnListo.Text = "Listo";
            this.btnListo.UseVisualStyleBackColor = true;
            this.btnListo.Click += new System.EventHandler(this.btnListo_Click);
            // 
            // lblCantidadMaterias
            // 
            this.lblCantidadMaterias.AutoSize = true;
            this.lblCantidadMaterias.Location = new System.Drawing.Point(37, 49);
            this.lblCantidadMaterias.Name = "lblCantidadMaterias";
            this.lblCantidadMaterias.Size = new System.Drawing.Size(112, 13);
            this.lblCantidadMaterias.TabIndex = 31;
            this.lblCantidadMaterias.Text = "Cantidad de materias :";
            // 
            // txtCantidadMaterias
            // 
            this.txtCantidadMaterias.Location = new System.Drawing.Point(155, 46);
            this.txtCantidadMaterias.Name = "txtCantidadMaterias";
            this.txtCantidadMaterias.Size = new System.Drawing.Size(37, 20);
            this.txtCantidadMaterias.TabIndex = 32;
            // 
            // btnImprimr
            // 
            this.btnImprimr.Location = new System.Drawing.Point(320, 44);
            this.btnImprimr.Name = "btnImprimr";
            this.btnImprimr.Size = new System.Drawing.Size(91, 23);
            this.btnImprimr.TabIndex = 30;
            this.btnImprimr.Text = "Imprimir Datos";
            this.btnImprimr.UseVisualStyleBackColor = true;
            this.btnImprimr.Click += new System.EventHandler(this.btnImprimr_Click);
            // 
            // gbxMaterias
            // 
            this.gbxMaterias.Controls.Add(this.btnAgregarMaterias);
            this.gbxMaterias.Controls.Add(this.lblMaterias);
            this.gbxMaterias.Controls.Add(this.txtMateria);
            this.gbxMaterias.Location = new System.Drawing.Point(37, 73);
            this.gbxMaterias.Name = "gbxMaterias";
            this.gbxMaterias.Size = new System.Drawing.Size(216, 87);
            this.gbxMaterias.TabIndex = 29;
            this.gbxMaterias.TabStop = false;
            this.gbxMaterias.Text = "Materias";
            // 
            // btnAgregarMaterias
            // 
            this.btnAgregarMaterias.Location = new System.Drawing.Point(118, 51);
            this.btnAgregarMaterias.Name = "btnAgregarMaterias";
            this.btnAgregarMaterias.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarMaterias.TabIndex = 14;
            this.btnAgregarMaterias.Text = "Agregar";
            this.btnAgregarMaterias.UseVisualStyleBackColor = true;
            this.btnAgregarMaterias.Click += new System.EventHandler(this.btnAgregarMaterias_Click);
            // 
            // lblMaterias
            // 
            this.lblMaterias.AutoSize = true;
            this.lblMaterias.Location = new System.Drawing.Point(20, 28);
            this.lblMaterias.Name = "lblMaterias";
            this.lblMaterias.Size = new System.Drawing.Size(48, 13);
            this.lblMaterias.TabIndex = 0;
            this.lblMaterias.Text = "Materia :";
            // 
            // txtMateria
            // 
            this.txtMateria.Location = new System.Drawing.Point(92, 25);
            this.txtMateria.Name = "txtMateria";
            this.txtMateria.Size = new System.Drawing.Size(100, 20);
            this.txtMateria.TabIndex = 1;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmMateriasImpartidasMaestro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 278);
            this.Controls.Add(this.dgvMateriasImp);
            this.Controls.Add(this.btnListo);
            this.Controls.Add(this.lblCantidadMaterias);
            this.Controls.Add(this.txtCantidadMaterias);
            this.Controls.Add(this.btnImprimr);
            this.Controls.Add(this.gbxMaterias);
            this.Name = "frmMateriasImpartidasMaestro";
            this.Text = "frmMateriasImpartidasMaestro";
            this.Load += new System.EventHandler(this.frmMateriasImpartidasMaestro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriasImp)).EndInit();
            this.gbxMaterias.ResumeLayout(false);
            this.gbxMaterias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMateriasImp;
        private System.Windows.Forms.DataGridViewTextBoxColumn MateriaImparte;
        private System.Windows.Forms.Button btnListo;
        private System.Windows.Forms.Label lblCantidadMaterias;
        private System.Windows.Forms.TextBox txtCantidadMaterias;
        private System.Windows.Forms.Button btnImprimr;
        private System.Windows.Forms.GroupBox gbxMaterias;
        private System.Windows.Forms.Button btnAgregarMaterias;
        private System.Windows.Forms.Label lblMaterias;
        private System.Windows.Forms.TextBox txtMateria;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}