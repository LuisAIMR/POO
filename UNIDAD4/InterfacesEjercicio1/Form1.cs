using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfacesEjercicio1
{
    public partial class frmUnidadesMedida : Form
    {
        Centimetros objCentimetros;
        Metros objMetros;
        Milimetros objMilimetros;
        public frmUnidadesMedida()
        {
            InitializeComponent();
            cmbTipoUnidad.Items.Add("Metros");
            cmbTipoUnidad.Items.Add("Centimetros");
            cmbTipoUnidad.Items.Add("Milimetros");
            cmbConvertirA.Items.Add("Metros");
            cmbConvertirA.Items.Add("Centimetros");
            cmbConvertirA.Items.Add("Milimetros");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(cmbTipoUnidad.Text=="Metros")
            {
                Metros objMetros = new Metros();
                objMetros.Unidad = Convert.ToDouble(txtDato.Text);
                objMetros.ConvertirNuevo = cmbConvertirA.Text;
                objMetros.ConvertirNuevoTipo();
                lblResultado.Text = objMetros.ResConversion+" "+ objMetros.ConvertirNuevo;
            }
             else if (cmbTipoUnidad.Text == "Centimetros")
            {
                Centimetros objCentimetros=new Centimetros();
                objCentimetros.Unidad = Convert.ToDouble(txtDato.Text);
                objCentimetros.ConvertirNuevo = cmbConvertirA.Text;
                objCentimetros.ConvertirNuevoTipo();
                lblResultado.Text = objCentimetros.ResConversion + " " + objCentimetros.ConvertirNuevo;
            }
            else if (cmbTipoUnidad.Text == "Milimetros")
            {
                Milimetros objMilimetros = new Milimetros();
                objMilimetros.Unidad = Convert.ToDouble(txtDato.Text);
                objMilimetros.ConvertirNuevo = cmbConvertirA.Text;
                objMilimetros.ConvertirNuevoTipo();
                lblResultado.Text = objMilimetros.ResConversion+" "+ objMilimetros.ConvertirNuevo;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
