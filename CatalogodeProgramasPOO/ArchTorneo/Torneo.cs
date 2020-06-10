using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchTorneo
{
    class Torneo
    {
        //Atributos de la clase Torneo
        public string NombreTorneo { get; set; }
        public int NumeroEquipos { get; set; }
        public int NumPartidos { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFIn { get; set; }
        public int PunGanado { get; set; }
        public int PunPerdido { get; set; }
        public int PunEmpate { get; set; }
        //Arreglos de atributos de la clase Torneo
        public string[,] PunPartido { get; set; }
        public int[] PunFinal { get; set; }

        //Metodo para sumar el los puntajes de cada equipo independientemente
        public void CalculcarPunObtenido()
        {
            //variable para introducir el indice en el que va el arreglo unidimensional
            int p = 0;
            for (int i = 0; i < PunPartido.GetLength(0); i++)
            {
                //variable para sumar las columnas de cada fila
                int suma = 0;
                //variable para acumular el resultdo de la suma
                int acum = 0;
                //Espacio para acumular el resultado obtenido de la suma de las columnas de cada fila
                for (int j = 1; j < PunPartido.GetLength(1); j++)
                {
                    suma = Convert.ToInt32(PunPartido[i, j]);
                    acum += suma;
                }
                //asignar lo obtenido al indice correspondiente del arreglo de la suma de los puntajes
                PunFinal[p] = acum;
                //contador para P
                p++;
            }


        }
        //Metodo para determinar el ganador
        public string CalcularGanador()
        {

            //Variables para asginar al ganador
            int NumeroGanador = 0;
            int f = 0;
            int Mayor = 0;
            string Ganador = "";
            //ciclo para evualar cada indice del arreglo de las sumas        
            for (int i = 0; i < PunFinal.Length; i++)
            {
                //si el indice es mayor sus datos se le asignaran a las variables que determinan quien gana
                if (PunFinal[i] > Mayor)
                {
                    Mayor = PunFinal[i];
                    NumeroGanador = f;
                }
                //contador para f
                f++;
            }
            //Despues del ciclo crea el mensaje correspondiente, con el nombre del equipo ganador y sus puntos
            Ganador = "El equipo Ganador es " + PunPartido[NumeroGanador, 0] + " Con " + Mayor + " puntos";
            //retorna el ganador
            return Ganador;
        }
    }
}
