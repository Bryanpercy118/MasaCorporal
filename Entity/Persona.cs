using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Persona
    {
        public Persona(string nombre, int edad, decimal peso, decimal estatura)
        {
            Nombre = nombre;
            Edad = edad;
            Peso = peso;
            Estatura = estatura;
        }

        public  string Nombre { get; set; }
        public int Edad { get; set; }

        public decimal Peso { get; set; }
        public decimal Estatura { get; set; }
        public  decimal Masa { get; set; }






    }


}
