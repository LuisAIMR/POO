using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesProg101
{
    class Program
    {
        static void Main(string[] args)
        {

            int Eleccion=0;
            Console.WriteLine("Eleige una opcion: Coloca un numero 1 para leer un archivo");
            Console.WriteLine("Coloca un numero 1 para leer un archivo");
            Console.WriteLine("Coloca un numero 2 para crear un archivo");
            Eleccion = Convert.ToInt16(Console.ReadLine());
            if (Eleccion==1)
            {
                LeerArchivo ObjLeer = new LeerArchivo();
                int EleccionTipoLectura = 0;
                Console.WriteLine("Elige el tipo de lectura");
                Console.WriteLine("Coloca el numero 1 para elegir el primer tipo de lectura");
                Console.WriteLine("Coloca el numero 2 para elegir el segundo tipo de lectura");
                EleccionTipoLectura = Convert.ToInt16(Console.ReadLine());
                if (EleccionTipoLectura == 1)
                {
                    
                    ObjLeer.Leer1();
                }
                else if (EleccionTipoLectura == 2)
                {
                    ObjLeer.Leer2();
                }
                    
               
            }
            else if(Eleccion==2)
            {
                CrearArchivo ObjCrear = new CrearArchivo();
                ObjCrear.Crear();
            }

            Console.ReadKey();
        }
    }
}
