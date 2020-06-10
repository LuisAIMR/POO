using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temperatura
{
    public partial class frmTemperatura : Form
    {
        ClassTemperatura ObjTemperatura = new ClassTemperatura();
        public frmTemperatura()
        {
            InitializeComponent();
            cmbTipo.Items.Add("°F");
            cmbTipo.Items.Add("°C");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
        
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtGrados.Text == "")
            {
                error1.SetError(txtGrados, "Coloque los grados");
                txtGrados.Focus();
                return;
            }
            error1.SetError(txtGrados, "");

            if (cmbTipo.Text == "")
            {
                error1.SetError(txtGrados, "Debe de colocar el tipo de grado");
                cmbTipo.Focus();
                return;
            }
            error1.SetError(cmbTipo, "");

            ObjTemperatura.grado =Convert.ToDouble( (txtGrados.Text));
            ObjTemperatura.tipo =(cmbTipo.Text.ToString());
            ObjTemperatura.ConvCelsius();
            ObjTemperatura.convFahrenheit();
            lblResConvertir.Text = ObjTemperatura.grado.ToString()+ObjTemperatura.tipoResultado.ToString();
            txtGrados.Text = ("");
            cmbTipo.Text = ("");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void frmTemperatura_Load(object sender, EventArgs e)
        {

        }
    }
}
