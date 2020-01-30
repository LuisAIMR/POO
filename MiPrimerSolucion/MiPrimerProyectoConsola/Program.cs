using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimerProyectoConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("introduce un numero: ");
            a = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("introduce un numero: ");
            b = Convert.ToUInt32 (Console.ReadLine());

            c = a + b;
            Console.ReadKey();
        }
    }
}
