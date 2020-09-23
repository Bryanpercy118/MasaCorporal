using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;
namespace BLL
{
    public class Personaservice
    {
        private Personarepository personarepository;
        public Personaservice()
        {
            personarepository = new Personarepository();
        }


        public decimal CalcularMasa(decimal peso, decimal estatura) {
        
            decimal masa=0;

            masa = peso / estatura * estatura;


            return masa;
        }

        //Se crea la sig funcion para guardar informacion
        public string Guardar(Persona persona)
        {
            try
            {
                personarepository.Guardar(persona);
                return "Se guardó la Informarción satisfactoriamente";
            }
            catch (Exception e)
            {

                return "Error de Aplicacion:" + e.Message;
            }
        }




    }
}
