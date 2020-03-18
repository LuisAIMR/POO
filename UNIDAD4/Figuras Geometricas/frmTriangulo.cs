using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras_Geometricas
{
    public partial class frmTriangulo : Form
    {
        Triangulo objTriangulo;
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

        private void frmTriangulo_Load(object sender, EventArgs e)
        {
            
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
            else if (cmbTipodeTriangulo.Text=="Equilatero")
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

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gbxTiTriangulo_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnPerimetro_Click(object sender, EventArgs e)
        {
            Triangulo objTriangulo = new Triangulo();
            objTriangulo.TipoTri = cmbTipodeTriangulo.Text;
            if (cmbTipodeTriangulo.Text == "Escaleno")
            {
                objTriangulo.Lado = Convert.ToDouble(txtLado1.Text);
                objTriangulo.Lado2 = Convert.ToDouble(txtLado2.Text);
                objTriangulo.Lado3 = Convert.ToDouble(txtLado3.Text);
                objTriangulo.CalcularPerimetro();
                lblPerimetro.Text = objTriangulo.Perimetro.ToString();
            }
            else if (cmbTipodeTriangulo.Text == "Equilatero")
            {
                objTriangulo.Lado = Convert.ToDouble(txtLado1.Text);
                objTriangulo.CalcularPerimetro();
                lblPerimetro.Text = objTriangulo.Perimetro.ToString();
            }
            else if (cmbTipodeTriangulo.Text == "Isoceles")
            {
                objTriangulo.Lado = Convert.ToDouble(txtLado1.Text);
                objTriangulo.Lado2 = Convert.ToDouble(txtLado2.Text);
                objTriangulo.CalcularPerimetro();
                lblPerimetro.Text = objTriangulo.Perimetro.ToString();
            }
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            Triangulo objTriangulo = new Triangulo();
            objTriangulo.TipoTri = cmbTipodeTriangulo.Text;
            if (cmbTipodeTriangulo.Text == "Escaleno")
            {
                objTriangulo.Lado = Convert.ToDouble(txtLado1.Text);
                objTriangulo.Lado2= Convert.ToDouble(txtLado2.Text);                
                objTriangulo.CalcularArea();
                lblArea.Text = objTriangulo.Area.ToString();
            }
            else if (cmbTipodeTriangulo.Text == "Equilatero")
            {
                objTriangulo.Lado = Convert.ToDouble(txtLado1.Text);
                objTriangulo.Altura = Convert.ToDouble(txtAltura.Text);
                objTriangulo.CalcularArea();
                lblArea.Text = objTriangulo.Area.ToString();
            }
            else if (cmbTipodeTriangulo.Text == "Isoceles")
            {
                objTriangulo.Lado = Convert.ToDouble(txtLado1.Text);                
                objTriangulo.Altura = Convert.ToDouble(txtAltura.Text);
                objTriangulo.CalcularArea();
                lblArea.Text = objTriangulo.Area.ToString();
            }
        }
    }
}
