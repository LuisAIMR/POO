using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuegoPiedraPapelyTijeras
{
    public partial class frmJuego : Form
    {
        public frmJuego()
        {
            InitializeComponent();
            // se agregan items al comboBox para posteriormente usarlos
            cmbElegirTipoPoPoTo.Items.Add("Piedra");
            cmbElegirTipoPoPoTo.Items.Add("Papel");
            cmbElegirTipoPoPoTo.Items.Add("Tijera");
            /*se dictamina la visibilidad algunos controles para que
            se muestren cuando el usuario ejecute alguna accion*/
            pbxJuPiedra.Visible = false;
            pbxJuPapel.Visible = false;
            pbxJuTijera.Visible = false;
            pbxComPiedra.Visible = false;
            pbxComPapel.Visible = false;
            pbxComTijeras.Visible = false;
        }

        

        private void cmbElegirTipoPoPoTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            JuegoPPT objJuego = new JuegoPPT();
            //se crea un random para que la computadora de resultados al azar
            Random RaComputadora = new Random();
            objJuego.Computadora = RaComputadora.Next(1, 3);
            
            //se evalua cual dato salio del random para poner visibles algunos controles
            if (objJuego.Computadora == 1)
            {
                pbxComPiedra.Visible = true;
                pbxComPapel.Visible = false;
                pbxComTijeras.Visible = false;
            }
            else if (objJuego.Computadora == 2)
            {
                pbxComPiedra.Visible = false;
                pbxComPapel.Visible = true;
                pbxComTijeras.Visible = false;
            }
            else if (objJuego.Computadora == 3)
            {
                pbxComPiedra.Visible = false;
                pbxComPapel.Visible = false;
                pbxComTijeras.Visible = true;
            }
            //indicar y formzar al usuario que elija alguna opcion del comboBox
            if (cmbElegirTipoPoPoTo.Text == "")
            {
                error2.SetError(cmbElegirTipoPoPoTo, "Usted no ha introducido su opcion");
                cmbElegirTipoPoPoTo.Focus();
                return;
            }
            error2.SetError(cmbElegirTipoPoPoTo, "");
            //se evalua que dato elige el usuario para poner visibles algunos controles
            if (cmbElegirTipoPoPoTo.Text == "Piedra")
            {
                objJuego.Jugador = 1;
                pbxJuPiedra.Visible = true;
                pbxJuPapel.Visible = false;
                pbxJuTijera.Visible = false;

            }
            else if (cmbElegirTipoPoPoTo.Text == "Papel")
            {
                objJuego.Jugador = 2;
                pbxJuPiedra.Visible = false;
                pbxJuPapel.Visible = true;
                pbxJuTijera.Visible = false;

            }
            else if (cmbElegirTipoPoPoTo.Text == "Tijera")
            {
                objJuego.Jugador = 3;
                pbxJuPiedra.Visible = false;
                pbxJuPapel.Visible = false;
                pbxJuTijera.Visible = true;

            }
            //se calcula el resultado para para posteriormente mostrar un mensaje
            objJuego.CalcularResultado();
            MessageBox.Show(objJuego.Mensaje, "RESULTADO",MessageBoxButtons.OK);
        }

        private void frmJuego_Load(object sender, EventArgs e)
        {
            
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void pbxComPapel_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }

}
