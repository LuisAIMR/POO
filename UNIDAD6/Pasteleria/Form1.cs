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

namespace Pasteleria
{
    public partial class frmPasteleria : Form
    {
        Pasteleria ObjPasteleria = new Pasteleria();
        int Encontrar=0;
        int Indicador;
        StreamWriter DatosPasteleria;
        string almacenador;
        string datosventas;
        int cantidadventas = 0;
        public frmPasteleria()
        {
            InitializeComponent();
            gbxBuscar.Enabled = false;
            gbxVender.Enabled = false;
            btnGuardar.Enabled=false;
        }

        private void frmPasteleria_Load(object sender, EventArgs e)
        {

        }

        private void btnCargarDatos_Click(object sender, EventArgs e)
        {
            //Introducir los datos
            ObjPasteleria.CaPostres = (int)nudCantidadPostres.Value;
            //Inicializar el arreglo multidimencional/matriz
            ObjPasteleria.mPostres = new string[ObjPasteleria.CaPostres, 3];
            //Ingresaremos la cantidad de datos del arreglo Multidimencional/Matriz
            
            for (int i = 0; i < ObjPasteleria.CaPostres; i++)
            {
                //debemos agregar una referencia de visual basic para utilizar un componente de este que requerimos
                ObjPasteleria.mPostres[i, 0] = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el nombre del postre" + (i + 1), "Pasteleria");
                almacenador += "\n"+"Nombre del postre numero [" + (i + 1) + "]: " + ObjPasteleria.mPostres[i, 0]+"\n";
                ObjPasteleria.mPostres[i, 1] = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el precio del postre" + (i + 1), "Pasteleria");
                almacenador += "Precio del postre numero [" + (i + 1) + "]: " + ObjPasteleria.mPostres[i, 1]+"\n";
                ObjPasteleria.mPostres[i, 2] = Microsoft.VisualBasic.Interaction.InputBox("Ingrese la cantidad de unidades disponibles del postre" + (i + 1), "Pasteleria");
                almacenador += "Cantidad del postre numero [" + (i + 1) + "]: " + ObjPasteleria.mPostres[i, 2]+"\n";

            }
            btnGuardar.Enabled = true;
            gbxBuscar.Enabled = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
            //Declaracion de variables
            string postre;
            //Entrada de datos 
            postre = txtBuscarPostre.Text;
            //buscamos si el postre existe
            if(Encontrar==0)
            {
                for (int i = 0; i < ObjPasteleria.CaPostres; i++)
                {
                    //Determinamos que hara el programa si el postre existe
                    if (ObjPasteleria.mPostres[i, 0].Equals(postre))
                    {
                        lblResPrecioPostre.Text = "$" + ObjPasteleria.mPostres[i, 1];
                        lblReslUnidadesDisponibles.Text = ObjPasteleria.mPostres[i, 2];
                        Indicador = i;
                        btnVender.Enabled = true;
                        Encontrar = 1;
                        gbxVender.Enabled = true;
                    }
                }
                
           
            }
            //Determinamos que hara el programa si el postre no existe
            if (Encontrar == 0)
            {
                MessageBox.Show("El postre no existe", "Pasteleria", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnVender.Enabled = false;
                lblResPrecioPostre.Text = "Inexistente";
                lblReslUnidadesDisponibles.Text = "Inexistente";
            }
            Encontrar = 0;
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            //entrada de datos
            ObjPasteleria.Cantidad = int.Parse(txtVender.Text);
            ObjPasteleria.UnidadDis = int.Parse(lblReslUnidadesDisponibles.Text);
            //Evaluamos existen la cantidad de unidades que requiere el usuario
            if (ObjPasteleria.Cantidad <= ObjPasteleria.UnidadDis)
            {
                //Disminuimos la cantidad de Unidades disponibles
                ObjPasteleria.mPostres[Indicador, 2] = Convert.ToString(ObjPasteleria.UnidadDis - ObjPasteleria.Cantidad);
                MessageBox.Show("Usted compro " + ObjPasteleria.Cantidad + " Unidades del producto." + "\n"
                                + " La cantidad de dinero que debe pagar es : " + "$" 
                                + ObjPasteleria.Cantidad * Convert.ToInt32(ObjPasteleria.mPostres[Indicador, 1]),".: Pasteleria :.",MessageBoxButtons.OK,MessageBoxIcon.Information);
                cantidadventas++;
                datosventas +="\n"+ "Venta numero [" + cantidadventas + "]:" + ObjPasteleria.Cantidad + " Unidades del producto." + "\n"
                                + " La cantidad de dinero que debe pagar es : " + "$"
                                + ObjPasteleria.Cantidad * Convert.ToInt32(ObjPasteleria.mPostres[Indicador, 1] + "\n");
            }
            else
            {
                //muestra un mensaje que indica que no hay cantidad suficiente de unidades de producto
                MessageBox.Show("No hay sucificiente cantidad de postres que requiere", "Pasteleria", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DatosPasteleria = new StreamWriter("DatosPasteleria.txt");
            DatosPasteleria.Write(almacenador);
            DatosPasteleria.Close();
            DatosPasteleria = new StreamWriter("VentasDelDia.txt");
            DatosPasteleria.Write(datosventas);
            DatosPasteleria.Close();
            MessageBox.Show("Datos guardados con exito","Pasteleria",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
