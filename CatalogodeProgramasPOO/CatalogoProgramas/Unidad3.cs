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
    public partial class Unidad3 : Form
    {
        public Unidad3()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            frmCatalogoInicio inicio = new frmCatalogoInicio();
            inicio.Show();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            ExamenRecibo.Form1 programa2 = new ExamenRecibo.Form1();
            programa2.Show();
        }
        private void btnCalificacionGrupal_Click(object sender, EventArgs e)
        {
            CalificacionGrupal.frmCalificaciones programa1 = new CalificacionGrupal.frmCalificaciones();
            programa1.Show();
        }

        private void btnPersona_Click(object sender, EventArgs e)
        {
            Persona.frmPersona programa6 = new Persona.frmPersona();
            programa6.Show();
        }

        private void btnConcierto_Click(object sender, EventArgs e)
        {
            Concierto.frmAsistentes programa3 = new Concierto.frmAsistentes();
            programa3.Show();
        }

        private void btnCuadrado_Click(object sender, EventArgs e)
        {
            Cuadrado.frmCuadrado Programa4 = new Cuadrado.frmCuadrado();
            Programa4.Show();
        }

        private void btnEmbotelladora_Click(object sender, EventArgs e)
        {
            Embotelladora.frmEmbotelladora programa5 = new Embotelladora.frmEmbotelladora();
            programa5.Show();
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            Empleado.frmEmpleado prgrama5 = new Empleado.frmEmpleado();
            prgrama5.Show();
        }

        private void btnPersonas_Click(object sender, EventArgs e)
        {
            Personas.frmPersonas programa7 = new Personas.frmPersonas();
            programa7.Show();
        }

        private void btnRecibo_Click(object sender, EventArgs e)
        {
            Recibo.frmRecibo programa8 = new Recibo.frmRecibo();
            programa8.Show();
        }

        private void btnTemperatura_Click(object sender, EventArgs e)
        {
            Temperatura.frmTemperatura programa9 = new Temperatura.frmTemperatura();
            programa9.Show();
        }

        private void btnVehiculo_Click(object sender, EventArgs e)
        {
            Vehiculo.frmVehiculo programa10 = new Vehiculo.frmVehiculo();
            programa10.Show();
        }

        private void btnRegresar_Click_1(object sender, EventArgs e)
        {
            this.Close();
            frmCatalogoInicio inicio = new frmCatalogoInicio();
            inicio.Show();
        }

        private void Unidad3_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Si desea regresar al menú principal presione el boton regresar", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show("Cuando ejecute los programas cierre las pestañas para seguir en el programa", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
