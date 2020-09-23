using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
namespace DAL
{
    public class Personarepository
    {

        private string fileName = "Persona.txt";
        public void Guardar(Persona persona)
        {

            FileStream file = new FileStream(fileName, FileMode.Append);

            StreamWriter writer = new StreamWriter(file);


            writer.WriteLine($";{persona.Nombre};{persona.Edad};{persona.Masa}");

            writer.Close();


            file.Close();

        }
    }
}
