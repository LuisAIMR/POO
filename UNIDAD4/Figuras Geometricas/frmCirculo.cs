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
    public partial class frmCirculo : Form
    {
        Circulo objCirculo;
        public frmCirculo()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmCirculo_Load(object sender, EventArgs e)
        {

        }

        private void btnPerimetro_Click(object sender, EventArgs e)
        {
            Circulo objCirculo = new Circulo();
            objCirculo.Lado =Convert.ToDouble( txtLado.Text);
            objCirculo.CalcularPerimetro();
            lblPerimetro.Text = objCirculo.Perimetro.ToString();
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            Circulo objCirculo = new Circulo();
            objCirculo.Lado = Convert.ToDouble(txtLado.Text);
            objCirculo.CalcularArea();
            lblArea.Text = objCirculo.Area.ToString();
        }
    }
}
