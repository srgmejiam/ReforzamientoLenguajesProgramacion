using EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Reforzamineto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instancia de la clase Persona
            EL.Persona Persona = new EL.Persona();
            Persona.IdPersona = 1;
            Persona.Name = "Luis";
            Persona.Genero = "Masculino";
            Persona.Edad = 20;
        }
    }
}
