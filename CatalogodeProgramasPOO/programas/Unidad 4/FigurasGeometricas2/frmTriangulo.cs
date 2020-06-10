using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FigurasGeometricas2
{
    public partial class frmTriangulo : Form
    {
        Escaleno objEscaleno;
        Equilatero objEquilatero;
        Isoceles objIsoceles;
           
        public frmTriangulo()
        {
            InitializeComponent();
            lblLado3.Visible = false;
            txtLado3.Visible = false;
            gbxTiTriangulo.Visible = false;
            lblAltura.Visible = false;
            txtAltura.Visible = false;
            pbxEsquilatero.Visible = false;
            pbxEscaleno.Visible = false;
            pbxIsoceles.Visible = false;
            pbxFondo.Visible = true;
            cmbTipodeTriangulo.Items.Add("Equilatero");
            cmbTipodeTriangulo.Items.Add("Isoceles");
            cmbTipodeTriangulo.Items.Add("Escaleno");
        }

        private void btnPerimetro_Click(object sender, EventArgs e)
        {
            if (cmbTipodeTriangulo.Text == "Escaleno")
            {
                Escaleno objEscaleno = new Escaleno();
                objEscaleno.Lado = Convert.ToDouble(txtLado1.Text);
                objEscaleno.Lado2 = Convert.ToDouble(txtLado2.Text);
                objEscaleno.Lado3 = Convert.ToDouble(txtLado3.Text);
                objEscaleno.CalcularPerimetro();
                lblPerimetro.Text = objEscaleno.Perimetro.ToString();
            }
            else if (cmbTipodeTriangulo.Text == "Equilatero")
            {
                Equilatero objEquilatero = new Equilatero();
                objEquilatero.Lado = Convert.ToDouble(txtLado1.Text);
                objEquilatero.CalcularPerimetro();
                lblPerimetro.Text = objEquilatero.Perimetro.ToString();
            }
            else if (cmbTipodeTriangulo.Text == "Isoceles")
            {
                Isoceles objIsoceles = new Isoceles();
                objIsoceles.Lado = Convert.ToDouble(txtLado1.Text);
                objIsoceles.Lado2 = Convert.ToDouble(txtLado2.Text);
                objIsoceles.CalcularPerimetro();
                lblPerimetro.Text = objIsoceles.Perimetro.ToString();
            }
        }

        private void cmbTipodeTriangulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipodeTriangulo.Text == "Escaleno")
            {
                gbxTiTriangulo.Text = "Escaleno";
                gbxTiTriangulo.Visible = true;
                lblAltura.Visible = false;
                txtAltura.Visible = false;
                lblLado3.Visible = true;
                txtLado3.Visible = true;
                lblLado2.Visible = true;
                pbxEsquilatero.Visible = false;
                pbxIsoceles.Visible = false;
                pbxFondo.Visible = false;
                pbxEscaleno.Show();


            }
            else if (cmbTipodeTriangulo.Text == "Equilatero")
            {
                gbxTiTriangulo.Text = "Equilatero";
                lblAltura.Visible = true;
                txtAltura.Visible = true;
                lblLado2.Visible = false;
                txtLado2.Visible = false;
                lblLado3.Visible = false;
                txtLado3.Visible = false;
                gbxTiTriangulo.Visible = true;
                pbxEscaleno.Visible = false;
                pbxIsoceles.Visible = false;
                pbxFondo.Visible = false;
                pbxEsquilatero.Show();
            }
            else if (cmbTipodeTriangulo.Text == "Isoceles")
            {
                gbxTiTriangulo.Text = "Isoceles";
                gbxTiTriangulo.Visible = true;
                lblAltura.Visible = true;
                txtAltura.Visible = true;
                lblLado2.Visible = true;
                txtLado2.Visible = true;
                lblLado3.Visible = false;
                txtLado3.Visible = false;
                pbxEsquilatero.Visible = false;
                pbxEscaleno.Visible = false;
                pbxFondo.Visible = false;
                pbxIsoceles.Show();
            }
        }

        private void frmTriangulo_Load(object sender, EventArgs e)
        {

        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            
            
            if (cmbTipodeTriangulo.Text == "Escaleno")
            {
                Escaleno objEscaleno = new Escaleno();
                objEscaleno.TipoTri = cmbTipodeTriangulo.Text;
                objEscaleno.Lado = Convert.ToDouble(txtLado1.Text);
                objEscaleno.Lado2 = Convert.ToDouble(txtLado2.Text);
                objEscaleno.CalcularArea();
                lblArea.Text = objEscaleno.Area.ToString();
            }
            else if (cmbTipodeTriangulo.Text == "Equilatero")
            {
                Equilatero objEquilatero = new Equilatero();
                objEquilatero.TipoTri = cmbTipodeTriangulo.Text;
                objEquilatero.Lado = Convert.ToDouble(txtLado1.Text);
                objEquilatero.Altura = Convert.ToDouble(txtAltura.Text);
                objEquilatero.CalcularArea();
                lblArea.Text = objEquilatero.Area.ToString();
            }
            else if (cmbTipodeTriangulo.Text == "Isoceles")
            {
                Isoceles objIsoceles = new Isoceles();
                objIsoceles.TipoTri = cmbTipodeTriangulo.Text;
                objIsoceles.Lado = Convert.ToDouble(txtLado1.Text);
                objIsoceles.Altura = Convert.ToDouble(txtAltura.Text);
                objIsoceles.CalcularArea();
                lblArea.Text = objIsoceles.Area.ToString();
            }
        }
    }
}
