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
    public partial class frmCuadrado : Form
    {
        Cuadrado objCuadrado;
        public frmCuadrado()
        {
            InitializeComponent();
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            Cuadrado objCuadrado = new Cuadrado();
            objCuadrado.Lado = Convert.ToDouble(txtLado.Text);
            objCuadrado.CalcularArea();
            lblArea.Text = objCuadrado.Area.ToString();
        }

        private void btnPerimetro_Click(object sender, EventArgs e)
        {
            Cuadrado objCuadrado = new Cuadrado();
            objCuadrado.Lado = Convert.ToDouble(txtLado.Text);
            objCuadrado.CalcularPerimetro();
            lblPerimetro.Text = objCuadrado.Perimetro.ToString();
        }
    }
}
