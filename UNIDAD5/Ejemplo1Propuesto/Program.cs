using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1Propuesto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Suma de 2 arreglos Multidimensionales/matrices 2x3";
            //Declarando primero declaramos los arreglos multidimencionales que les pondremos como nombre matriz
            int[,] Matriz1 = new int[2, 3];
            int[,] Matriz2 = new int[2, 3];
            int[,] Matriz3 = new int[2, 3];

            //introducimos los datos del primer arreglo
            Console.Write("Introduce los datos del primer arreglo multidimencional/matriz [1]");
            Console.Write("\n");
            for (int a = 0; a < 2; a++)
            {// for externo para filas de datos
                for (int m = 0; m < 3; m++)
                {// for interno para columnas de datos
                    Console.Write("Ingrese el elemento [" + a + "," + m + "]: ");
                    Matriz1[a, m] = int.Parse(Console.ReadLine());
                }
            }
            Console.Write("\n");
            //introducimos los datos del primer arreglo
            Console.Write("Introduce los datos del segundo arreglo multidimencional/matriz [2]");
            Console.Write("\n");
            for (int i = 0; i < 2; i++)
            {// for externo para filas de datos
                for (int j = 0; j < 3; j++)
                {// for interno para columnas de datos
                    Console.Write("Ingrese el elemento [" + i + "," + j + "]: ");
                    Matriz2[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.Write("\n");
            //Realizamos el calculo de la suma de las dos primeras matrices 
            Console.Write("Sumando las 2 matrices anteriores");
            Console.Write("\n");
            for (int i = 0; i < 2; i++)
            {// for externo para filas de daos
                for (int j = 0; j < 3; j++)
                {// for interno para columnas de datos
                    Matriz3[i, j] = Matriz1[i, j] + Matriz2[i, j];
                }
            }
            //Llamamos a un procedimiento para visualizar el resultado de las sumas realizadas
            Mostrar(Matriz3);
            Console.ReadKey();
        }
        static void Mostrar(int[,] Matriz3)
        {
            for (int i = 0; i < 2; i++)
            {
                Console.Write("\n");
                for (int j = 0; j < 3; j++)

                {
                    Console.Write("\t" + Matriz3[i, j] + "\t");
                }
            }
        }
    }
}
