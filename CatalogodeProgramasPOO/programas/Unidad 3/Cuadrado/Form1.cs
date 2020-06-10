using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cuadrado
{
    public partial class frmCuadrado : Form
    {
        ClassCuadrado ObjLado = new ClassCuadrado();
        public frmCuadrado()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnPerimetro_Click(object sender, EventArgs e)
        {
            if (txtLado.Text == "")
            {
                error1.SetError(txtLado, "No ha introducido ningun dato");
                txtLado.Focus();
                return;
            }
            error1.SetError(txtLado, "");

            ObjLado.lado = Convert.ToDouble(txtLado.Text);
            ObjLado.CalPerimetro();
            lblResPerimetro.Text = ObjLado.perimetro.ToString();
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            if (txtLado.Text =="")
            {
                error1.SetError(txtLado, "No ha introducido ningun dato");
                txtLado.Focus();
                return;
            }
            error1.SetError(txtLado, "");

            ObjLado.lado = Convert.ToDouble(txtLado.Text);
            ObjLado.CalArea();
            lblResArea.Text = ObjLado.area.ToString();
        }

        private void btnNuevoCuadrado_Click(object sender, EventArgs e)
        {
            txtLado.Clear();
            lblResPerimetro.Text = " ";
            lblResArea.Text = " ";
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
