using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatalogoProgramas
{
    public partial class Unidad4 : Form
    {
        public Unidad4()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            frmCatalogoInicio inicio = new frmCatalogoInicio();
            inicio.Show();
        }

        private void btnEmpleadosRestaurante_Click(object sender, EventArgs e)
        {
            EmpleadosRestaurante.frmEmpleados programa1 = new EmpleadosRestaurante.frmEmpleados();
            programa1.Show();
        }

        private void btnFigurasGeometricas_Click(object sender, EventArgs e)
        {
            Figuras_Geometricas.FrmFiguras programa2 = new Figuras_Geometricas.FrmFiguras();
            programa2.Show();
        }

        private void btnFigurasGeometricas2_Click(object sender, EventArgs e)
        {
            FigurasGeometricas2.FrmFigurasGeo programa3 = new FigurasGeometricas2.FrmFigurasGeo();
            programa3.Show();
        }

        private void btnInterfacesEjercicio1_Click(object sender, EventArgs e)
        {
            InterfacesEjercicio1.frmUnidadesMedida programa4 = new InterfacesEjercicio1.frmUnidadesMedida();
            programa4.Show();
        }

        private void btnOperacion_Click(object sender, EventArgs e)
        {
            Operacion.Form1 programa5= new Operacion.Form1();
            programa5.Show();
        }

        private void btnJuegoPiedraPapelyTijeras_Click(object sender, EventArgs e)
        {
            JuegoPiedraPapelyTijeras.frmMenu programa6 = new JuegoPiedraPapelyTijeras.frmMenu();
            programa6.Show();
        }

        private void btnVehiculos_Click(object sender, EventArgs e)
        {
            Vehiculos.frmVehiculo programa7 = new Vehiculos.frmVehiculo();
            programa7.Show();
        }

        private void btnRegresar_Click_1(object sender, EventArgs e)
        {
            this.Close();
            frmCatalogoInicio inicio = new frmCatalogoInicio();
            inicio.Show();
        }

        private void Unidad4_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Si desea regresar al menú principal presione el boton regresar", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show("Cuando ejecute los programas cierre las pestañas para seguir en el programa", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
