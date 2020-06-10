using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Concierto
{
    public partial class frmAsistentes : Form
    {
        ClassAsistente objAsistente = new ClassAsistente();
        public frmAsistentes()
        {
            InitializeComponent();
            cmbAsistente.Items.Add("Bebes");
            cmbAsistente.Items.Add("Niños");
            cmbAsistente.Items.Add("Adultos");
            cmbAsistente.Items.Add("Adultos mayores");
            cmbCantidad.Items.Add("1");
            cmbCantidad.Items.Add("2");
            cmbCantidad.Items.Add("3");
            cmbCantidad.Items.Add("4");
            cmbCantidad.Items.Add("5");
            cmbCantidad.Items.Add("6");
            cmbCantidad.Items.Add("7");
            cmbCantidad.Items.Add("8");
            cmbCantidad.Items.Add("9");
            cmbCantidad.Items.Add("10");

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblCantidadBebes.Text = objAsistente.bebesN.ToString();
            lblCantidadNiños.Text = objAsistente.niñosN.ToString();
            lblCantidadAdultos.Text = objAsistente.adultosN.ToString();
            lblCantidadAdultosMayores.Text = objAsistente.adultosMayoresN.ToString();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void cmbAsistente_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbCantidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnContabilizar_Click(object sender, EventArgs e)
        {
            if(cmbAsistente.Text=="")
            {
                error1.SetError(cmbAsistente, "Debe elegir el tipo de asistente");
                cmbAsistente.Focus();
                return;
            }
            error1.SetError(cmbAsistente, "");

            if (cmbCantidad.Text == "")
            {
                error1.SetError(cmbCantidad, "Debe colocar la cantidad de asistentes");
                cmbCantidad.Focus();
                return;
            }
            error1.SetError(cmbCantidad, "");

            objAsistente.asistente = (cmbAsistente.Text);
            objAsistente.cantidad =int.Parse(cmbCantidad.Text.ToString());
            objAsistente.ContabilizarAsistentes();
            MessageBox.Show("Los datos se contabilizaron con exito");
            cmbAsistente.Text=("");
            cmbCantidad.Text = ("");
        }
    }
}
