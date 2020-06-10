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
    public partial class Unidad6 : Form
    {
        public Unidad6()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            frmCatalogoInicio inicio = new frmCatalogoInicio();
            inicio.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnBidimensional2_Click(object sender, EventArgs e)
        {
            ArchBidimensional2.Form1 programa1 = new ArchBidimensional2.Form1();
            programa1.Show();
        }

        private void btnBidimensional1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnTorneo_Click(object sender, EventArgs e)
        {

        }

        private void btnEjercicio1ColoresDePaises_Click(object sender, EventArgs e)
        {

        }

        private void btnEjemplo1Propuesto_Click(object sender, EventArgs e)
        {
            String Nombreprograma;
            String ruta;

            Nombreprograma = "EjemploPropuestoArchivos.exe";
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

        private void btnEjercicio4DatosAlumnosMaestros_Click(object sender, EventArgs e)
        {

        }

        private void btnEjercicio3DatoAlumnoMaestro_Click(object sender, EventArgs e)
        {

        }

        private void btnEjercicio2ArregloObjetosPaisesYColores_Click(object sender, EventArgs e)
        {
            
        }

        private void btnMiPrimeraClase_Click(object sender, EventArgs e)
        {

        }

        private void btnClasesProg101_Click(object sender, EventArgs e)
        {
            String Nombreprograma;
            String ruta;

            Nombreprograma = "ClasesProg101.exe";
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

        private void btnNumerosMayorMenor_Click(object sender, EventArgs e)
        {

        }

        private void btnMatrizSumaFCD_Click(object sender, EventArgs e)
        {

        }

        private void btnPasteleria_Click(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click_1(object sender, EventArgs e)
        {
            this.Close();
            frmCatalogoInicio inicio = new frmCatalogoInicio();
            inicio.Show();
        }

        private void btnBidimensional1_Click_1(object sender, EventArgs e)
        {
            String Nombreprograma;
            String ruta;

            Nombreprograma = "ABidimensional1.exe";
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

        private void btnEjemplo1Propuesto_Click_1(object sender, EventArgs e)
        {
            String Nombreprograma;
            String ruta;

            Nombreprograma = "ArchEjemplo1Propuesto.exe";
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

        private void btnClasesProg101_Click_1(object sender, EventArgs e)
        {
            String Nombreprograma;
            String ruta;

            Nombreprograma = "ClasesProg101.exe";
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

        private void btnTorneo_Click_1(object sender, EventArgs e)
        {
            ArchTorneo.Form1 programa2 = new ArchTorneo.Form1();
            programa2.Show();
        }

        private void btnEjercicio1ColoresDePaises_Click_1(object sender, EventArgs e)
        {
            ArcColoresPais.Form1 programa2 = new ArcColoresPais.Form1();
            programa2.Show();
        }

        private void btnEjercicio2ArregloObjetosPaisesYColores_Click_1(object sender, EventArgs e)
        {
            ArchNpaises.Form1 programa = new ArchNpaises.Form1();
            programa.Show();
        }

        private void btnNumerosMayorMenor_Click_1(object sender, EventArgs e)
        {
            ArchNumMayorMenor.Form1 programa = new ArchNumMayorMenor.Form1();
            programa.Show();
        }

        private void btnPasteleria_Click_1(object sender, EventArgs e)
        {
            ArchPasteleria.Form1 programa = new ArchPasteleria.Form1();
            programa.Show();
        }

        private void btnMiPrimeraClase_Click_1(object sender, EventArgs e)
        {
            ArchMiPrimeraClase.Form1 programa = new ArchMiPrimeraClase.Form1();
            programa.Show();
        }

        private void btnMatrizSumaFCD_Click_1(object sender, EventArgs e)
        {
            ArchMatrizFCD.Form1 programa = new ArchMatrizFCD.Form1();
            programa.Show();
        }

        private void btnEjercicio3DatoAlumnoMaestro_Click_1(object sender, EventArgs e)
        {
            ArchEjercicioAlumnoMaestr.Form1 programa = new ArchEjercicioAlumnoMaestr.Form1();
            programa.Show();
        }

        private void btnEjercicio4DatosAlumnosMaestros_Click_1(object sender, EventArgs e)
        {
            ArchMaestrosyAlumnos.Form1 programa = new ArchMaestrosyAlumnos.Form1();
            programa.Show();
        }

        private void Unidad6_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Si desea regresar al menú principal presione el boton regresar","Informacion",MessageBoxButtons.OK,MessageBoxIcon.Information);
            MessageBox.Show("Cuando ejecute los programas cierre las pestañas para seguir en el programa", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
