using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesProg101
{
    class LeerArchivo
    {


        public void Leer1()
        {
            Stream fs = new FileStream("./archivo.txt", FileMode.Open, FileAccess.Read);

            long Quality = fs.Length;
            Console.WriteLine($"El archivo tiene una longitud de {Quality} Bytes");

            for (long count=0; count< Quality; count++)
            {
                fs.Seek(count, SeekOrigin.Begin);
                int valor = fs.ReadByte();
                Console.WriteLine($"Posicion {count} : {(char)valor}");
            }            
            fs.Close();
        }
        public void Leer2()
        {
            Stream fs = new FileStream("./archivo.txt", FileMode.Open, FileAccess.Read);

            long Quality = fs.Length;
            Console.WriteLine($"El archivo tiene una longitud de {Quality} Bytes");

            fs.Seek(0, SeekOrigin.Begin);

            StreamReader sr = new StreamReader(fs);
            string todo = sr.ReadToEnd();
            Console.WriteLine(todo);


            sr.Close();
            fs.Close();
        }
        
    }
}
