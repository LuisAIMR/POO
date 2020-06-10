using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrizSumaFCD
{
    class MatrizFCD
    {
        public int[,] MatrizNM { get; set; }
        public int[] SumaFilas { get; set; }
        public int[] SumaColumnas { get; set; }
        public int[] Diagonal { get; set; }
       
        
        public void MSumaColumnas()
        {
            //variable para introducir el indice en el que va el arreglo unidimensional
            int p = 0;
            for (int i = 0; i < MatrizNM.GetLength(0); i++)
            {
                //variable para sumar las columnas de cada fila
                int suma = 0;
                //variable para acumular el resultdo de la suma
                int acum = 0;
                //Espacio para acumular el resultado obtenido de la suma de las columnas de cada fila
                for (int j = 0; j < MatrizNM.GetLength(1); j++)
                {
                    suma = Convert.ToInt32(MatrizNM[i, j]);
                    acum += suma;
                }
                //asignar lo obtenido al indice correspondiente del arreglo de la suma de los puntajes
                SumaColumnas[p] = acum;
                //contador para P
                p++;
            }

        }

        public void MSumaFilas()
        {
            //variable para introducir el indice en el que va el arreglo unidimensional
            int p = 0;
            for (int i = 0; i < MatrizNM.GetLength(1); i++)
            {
                //variable para sumar las columnas de cada fila
                int suma = 0;
                //variable para acumular el resultdo de la suma
                int acum = 0;
                //Espacio para acumular el resultado obtenido de la suma de las columnas de cada fila
                for (int j = 0; j < MatrizNM.GetLength(1); j++)
                {
                    suma = Convert.ToInt32(MatrizNM[j,i]);
                    acum += suma;
                }
                //asignar lo obtenido al indice correspondiente del arreglo de la suma de los puntajes
                SumaFilas[p] = acum;
                //contador para P
                p++;
            }
        }
        public string MSumaDiagonales()
        {
            string SumaDiagonales = "";
            int acum=0;
            //variable para introducir el indice en el que va el arreglo unidimensional

            for (int i = 0; i < MatrizNM.GetLength(0); i++)
            {
                //variable para sumar las columnas de cada fila
                int suma = 0;
                //variable para acumular el resultdo de la suma
                
                //Espacio para acumular el resultado obtenido de la suma de las columnas de cada fila
                for (int j = 0; j < MatrizNM.GetLength(1); j++)
                {
                    if(i==j)
                    {
                        suma = Convert.ToInt32(MatrizNM[i, j]);
                        acum += suma;
                    }
                   
                }                              
            }
            //asignar lo obtenido al indice correspondiente del arreglo de la suma de los puntajes
            SumaDiagonales = Convert.ToString(acum);
            return SumaDiagonales;       

        }
       
        public string MSumaDeSumaColumnas ()
        {
            string SumColumnas = "";
            int Acum = 0;
            int Suma = 0;
            for (int i = 0; i < SumaColumnas.Length; i++)
            {
                Suma = Convert.ToInt32(SumaColumnas[i]);
                Acum += Suma;
            }
            SumColumnas = Convert.ToString(Acum);
            return SumColumnas;
        }
        public string MSumaDeSumaFilas()
        {
            string SumFilas = "";
            int Acum = 0;
            int Suma =0;
            for(int i=0;i<SumaFilas.Length;i++)
            {
                Suma = Convert.ToInt32(SumaFilas[i]);
                Acum += Suma;
            }
            SumFilas = Convert.ToString( Acum);
            return SumFilas;
        }

    }
}
