using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArchTorneo
{
    public partial class Form1 : Form
    {
        Torneo ObjTorneo = new Torneo();
        int Mayor;
        StreamWriter DocTorneo;
        string almacenador;
        string ResultadoEncuentro;
        public Form1()
        {
            InitializeComponent();
            btnDeterminarGanador.Enabled = false;
            btnAgregarDatosEquipos.Enabled = false;
        }

        private void btnAgregarDatosTorneo_Click(object sender, EventArgs e)
        {
            //validar que se introdujo el nombre del torneo
            if (txtNombreTornero.Text == "")
            {

                errorProvider1.SetError(txtNombreTornero, "Introduce el nombre del torneo ");
                txtNombreTornero.Focus();
                return;
            }
            errorProvider1.SetError(txtNombreTornero, "");
            //Introducir los datos generales del torneo
            ObjTorneo.NombreTorneo = txtNombreTornero.Text;
            almacenador += "Nombre del torneo: " + ObjTorneo.NombreTorneo + "\n";
            ObjTorneo.NumeroEquipos = (int)nudNumEquipos.Value;
            ObjTorneo.FechaInicio = dtpFechaIncio.Value;
            ObjTorneo.FechaFIn = dtpFechaFin.Value;
            ObjTorneo.PunGanado = (int)nudGanado.Value;
            ObjTorneo.PunEmpate = (int)nudEmpate.Value;
            ObjTorneo.PunPerdido = (int)nudPerdido.Value;
            btnAgregarDatosTorneo.Enabled = false;
            btnAgregarDatosEquipos.Enabled = true;
            //MessageBox para mostrar al usuario que introdujo los datos del torneo
            MessageBox.Show("Se Guardaron los Datos del Torneo" + " \n" + "Inicia el Torneo" + " \n" + ObjTorneo.FechaInicio, "Torneo " + ObjTorneo.NombreTorneo, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAgregarDatosEquipos_Click(object sender, EventArgs e)
        {
            //Determinar la magnitud del arreglo bidimensional donde de introduciran los datos de los equipos; su nombre y su puntaje
            ObjTorneo.PunPartido = new string[ObjTorneo.NumeroEquipos, ObjTorneo.NumeroEquipos];
            for (int f = 0; f < ObjTorneo.PunPartido.GetLength(0); f++)
            {
                //Espacio para introducir el nombre del equipo
                ObjTorneo.PunPartido[f, 0] = Interaction.InputBox("Introduce el Nombre del equipo Numero :" + (f + 1));
                almacenador += "Nombre del equipo numero [" + (f + 1) + "]:" + ObjTorneo.PunPartido[f, 0] + "\n";
                for (int c = 1; c < ObjTorneo.PunPartido.GetLength(1); c++)
                {
                    //Espacio  para introducir la cantidad de puntos obtenidos por cada partido
                    ResultadoEncuentro = Interaction.InputBox("Introduce el resultado del Encuentro numero : " + c + " \n" + " | gano, empato ó perdio | (Solo usar minusculas)");
                    almacenador += "En el partido [" + c + "]" + "\n";
                    if (ResultadoEncuentro == "gano")
                    {
                        ObjTorneo.PunPartido[f, c] = Convert.ToString(ObjTorneo.PunGanado);
                        almacenador += "gano obtuvo: " + ObjTorneo.PunGanado + " Puntos" + "\n";
                    }
                    else if (ResultadoEncuentro == "empato")
                    {
                        ObjTorneo.PunPartido[f, c] = Convert.ToString(ObjTorneo.PunEmpate);
                        almacenador += "empato obtuvo: " + ObjTorneo.PunEmpate + " Puntos" + "\n";

                    }
                    else if (ResultadoEncuentro == "perdio")
                    {
                        ObjTorneo.PunPartido[f, c] = Convert.ToString(ObjTorneo.PunPerdido);
                        almacenador += "perdio obtuvo: " + ObjTorneo.PunPerdido + " Puntos" + "\n";
                    }

                }
            }
            //Determinar la magnitud del arreglo unidimensional       
            ObjTorneo.PunFinal = new int[ObjTorneo.NumeroEquipos];
            //usar el metodo para calcular la suma del los puntajes obtenidos de cada equipo           
            ObjTorneo.CalculcarPunObtenido();
            btnAgregarDatosEquipos.Enabled = false;
            btnDeterminarGanador.Enabled = true;
        }

        private void btnDeterminarGanador_Click(object sender, EventArgs e)
        {
            //mensaje que muestra el ganador del torneo         
            MessageBox.Show("¡Felicidades!" + "\n" + ObjTorneo.CalcularGanador() + " \n" + "Torneo Concluido",
                           "Torneo " + ObjTorneo.NombreTorneo + " " + ObjTorneo.FechaFIn, MessageBoxButtons.OK, MessageBoxIcon.Information);
            almacenador += "\n" + "Torneo " + ObjTorneo.NombreTorneo + " " + ObjTorneo.FechaFIn + "\n" + "¡Felicidades!" + "\n" + ObjTorneo.CalcularGanador() + " \n" + "Torneo Concluido";

            DocTorneo = new StreamWriter("Datos del torneo.txt");
            DocTorneo.Write(almacenador);
            DocTorneo.Close();
            btnAgregarDatosTorneo.Enabled = true;
            btnDeterminarGanador.Enabled = false;
        }
    }
}
