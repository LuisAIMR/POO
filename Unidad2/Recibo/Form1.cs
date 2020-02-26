using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recibo
{
    public partial class frmRecibo : Form
    {
        ClassRecibo ObjRecibo = new ClassRecibo();
        public frmRecibo()
        {
            InitializeComponent();
            cmbTipo.Items.Add("Hogar");
            cmbTipo.Items.Add("Negocio");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCantidadPagar_Click(object sender, EventArgs e)
        {
            ObjRecibo.kilowatts = Convert.ToDouble(txtIntCanWatts.Text);
            ObjRecibo.tipoContrato = (cmbTipo.Text.ToString());
            ObjRecibo.CantidadPagar();
            lblResultadoPagar.Text = ObjRecibo.CanPagar.ToString();
            lblRestuladoTipo.Text = ObjRecibo.tipoContrato.ToString();

        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtIntCanWatts.Text = "";
            lblResultadoPagar.Text = "";
            lblRestuladoTipo.Text = "";

        }
    }
}
