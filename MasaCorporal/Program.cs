using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using BLL;
namespace MasaCorporal
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            int edad;
            decimal peso;
            decimal estatura;
            decimal masa;

            Console.WriteLine("****************************");
            Console.WriteLine("*        Bienvenido        *");
            Console.WriteLine("****************************");
            Console.WriteLine("                            ");
            Console.WriteLine("Digite su nombre");
            nombre = Console.ReadLine(); // se digita el nombre
            Console.WriteLine("Digite su edad");
            edad = int.Parse(Console.ReadLine()); // Se transforma por medio del parse para leer numero entero
            Console.WriteLine("Digite su peso");
            peso = decimal.Parse(Console.ReadLine());// Se transforma por medio del parse para leer numero decimal
            Console.WriteLine("Digite su estatura");
            estatura = decimal.Parse(Console.ReadLine());

            //Se crea el objeto y se instancia con los valores recibidos

            Persona persona = new Persona(nombre, edad,peso,estatura);
            
            //Creamos un objeto persona service para poder acceder a sus funciones
            
            Personaservice personaservice = new Personaservice();
            
            //luego de tener nuestro objeto persona se hace el llamado a la funcion logica 

            persona.Masa = personaservice.CalcularMasa(peso, estatura); //se sobrecarga la funcion para que cumpla el requerimiento


            //Queremos tener en pantalla la masa coporal hacemos lo siguiente
            Console.WriteLine($"La masa corporal de {nombre} es igual a {persona.Masa}");

            //ahora guardamos todo los datos en archivos, por medio del service

            Console.WriteLine(personaservice.Guardar(persona));

            // detenemos la pantalla para que el programa no salte al finalizar nuestro procesos

            Console.ReadKey();


            //Calcular Masa corporal de la persona//


        }
    }
}
