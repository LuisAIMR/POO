using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesProg101
{
    class CrearArchivo
    {
        //Este metodo crea un archivo llamado escribirarchivo en formato .txt y se le asgina un contenido predeterminado
        public void Crear()
        {
            using (Stream fs1 = new FileStream("./escribirarchivo.txt", FileMode.Create, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs1))
                {
                    //Esto es lo que contendra el archivo
                    sw.WriteLine("Hola, este es un archivo escrito desde C#");
                }
            }            
        }
    }
}
