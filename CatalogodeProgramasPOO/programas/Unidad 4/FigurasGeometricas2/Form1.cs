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
    public partial class FrmFigurasGeo : Form
    {
        public FrmFigurasGeo()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnListo_Click(object sender, EventArgs e)
        {
            if (cxbCuadrado.Checked == true) { frmCuadrado cuadrado = new frmCuadrado(); cuadrado.Show(); }
            if (cxbCirculo.Checked == true) { frmCirculo circulo = new frmCirculo(); circulo.Show(); }
            if (cxbTriangulo.Checked == true) { frmTriangulo triangulo = new frmTriangulo(); triangulo.Show(); }
        }
    }
}
