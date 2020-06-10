using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatalogoProgramas
{
    public partial class Unidad5 : Form
    {
        public Unidad5()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            frmCatalogoInicio inicio = new frmCatalogoInicio();
            inicio.Show();
        }

        private void btnBidimensional2_Click(object sender, EventArgs e)
        {
            Bidimensional2.frmBidimensional programa2 = new Bidimensional2.frmBidimensional();
            programa2.Show();
        }

        private void btnEjercicio4DatosAlumnosMaestros_Click(object sender, EventArgs e)
        {
            Ejercicio4DatosAlumnosMaestros.Form1 programa2 = new Ejercicio4DatosAlumnosMaestros.Form1();
            programa2.Show();
        }

        private void btnNumerosMayorMenor_Click(object sender, EventArgs e)
        {
            NumerosMayorMenor.frmNumeros programa3 = new NumerosMayorMenor.frmNumeros();
            programa3.Show();
        }

        private void btnBidimensional1_Click(object sender, EventArgs e)
        {

            String Nombreprograma;
            String ruta;

            Nombreprograma = "Bidimensional1.exe";
            ruta = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
            ruta = ruta.Substring(6);
            ruta = String.Concat("\"", ruta, "\\", Nombreprograma, "\"");

            string cmdexeruta = @"C:\Windows\System32\cmd.exe";
            string cmdArguments2 = String.Format("/K {0}", ruta);
            System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo(cmdexeruta, cmdArguments2);
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo = psi;
            p.Start();
        }

        private void btnEjemplo1Propuesto_Click(object sender, EventArgs e)
        {
            String Nombreprograma;
            String ruta;

            Nombreprograma = "Ejemplo1Propuesto.exe";
            ruta = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
            ruta = ruta.Substring(6);
            ruta = String.Concat("\"", ruta, "\\", Nombreprograma, "\"");

            string cmdexeruta = @"C:\Windows\System32\cmd.exe";
            string cmdArguments2 = String.Format("/K {0}", ruta);
            System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo(cmdexeruta, cmdArguments2);
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo = psi;
            p.Start();
        }

        private void btnEjercicio1ColoresDePaises_Click(object sender, EventArgs e)
        {
            Ejercicio1ColoresDePaises.Form1 programa6 = new Ejercicio1ColoresDePaises.Form1();
            programa6.Show();
        }

        private void btnEjercicio2ArregloObjetosPaisesYColores_Click(object sender, EventArgs e)
        {
            Ejercicio2ArregloObjetosPaisesYColores.frmDatosPaises programa7 = new Ejercicio2ArregloObjetosPaisesYColores.frmDatosPaises();
            programa7.Show();
        }

        private void btnTorneo_Click(object sender, EventArgs e)
        {
            Torneo.Form1 programa8 = new Torneo.Form1();
            programa8.Show();
        }

        private void btnEjercicio3DatoAlumnoMaestro_Click(object sender, EventArgs e)
        {
            Ejercicio3DatoAlumnoMaestro.Form1 programa9 = new Ejercicio3DatoAlumnoMaestro.Form1();
            programa9.Show();
        }

        private void btnMiPrimeraClase_Click(object sender, EventArgs e)
        {
            MiPrimeraClase.Form1 programa10 = new MiPrimeraClase.Form1();
            programa10.Show();
        }

        private void btnMatrizSumaFCD_Click(object sender, EventArgs e)
        {
            MatrizSumaFCD.frmMatrizSumaFCD programa11 = new MatrizSumaFCD.frmMatrizSumaFCD();
            programa11.Show();
        }

        private void btnPasteleria_Click(object sender, EventArgs e)
        {
            Pasteleria.frmPasteleria programa12 = new Pasteleria.frmPasteleria();
            programa12.Show();
        }

        private void btnRegresar_Click_1(object sender, EventArgs e)
        {
            this.Close();
            frmCatalogoInicio inicio = new frmCatalogoInicio();
            inicio.Show();
        }

        private void Unidad5_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Si desea regresar al menú principal presione el boton regresar", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show("Cuando ejecute los programas cierre las pestañas para seguir en el programa", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
