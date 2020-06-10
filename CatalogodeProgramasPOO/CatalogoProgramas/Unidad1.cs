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
    public partial class Unidad1 : Form
    {
        public Unidad1()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();

            frmCatalogoInicio inicio = new frmCatalogoInicio();
            inicio.Show();
        }

        private void btnMiPrimerProyectoConsola_Click(object sender, EventArgs e)
        {
            String Nombreprograma;
            String ruta;

            Nombreprograma = "MiPrimerProyectoConsola.exe";
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

        private void btnMiPrimerProyectoWindowsForms_Click(object sender, EventArgs e)
        {
            MiPrimerProyectoWindowsForms.Form1 programa2 = new MiPrimerProyectoWindowsForms.Form1();
            programa2.Show();
        }

        private void Unidad1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Si desea regresar al menú principal presione el boton regresar", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show("Cuando ejecute los programas cierre las pestañas para seguir en el programa", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRegresar_Click_1(object sender, EventArgs e)
        {
            this.Close();
            frmCatalogoInicio inicio = new frmCatalogoInicio();
            inicio.Show();
        }
    }
}
