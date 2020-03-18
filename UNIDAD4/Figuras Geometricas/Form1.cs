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
    public partial class FrmFiguras : Form
    {
        
        
        public FrmFiguras()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           if(cxbCuadrado.Checked==true)  {frmCuadrado cuadrado = new frmCuadrado(); cuadrado.Show();}
           if (cxbCirculo.Checked == true) { frmCirculo circulo = new frmCirculo(); circulo.Show(); }
           if (cxbTriangulo.Checked==true) { frmTriangulo triangulo = new frmTriangulo(); triangulo.Show(); }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void FrmFiguras_Load(object sender, EventArgs e)
        {

        }
    }
}
