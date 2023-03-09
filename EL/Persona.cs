using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public class Persona
    {
        //Atributos
        //Indicador de Acceso - tipo dato - Nombre - metodos Get and Set
        public int IdPersona { get; set; }
        public string Name { get; set; }
        public string Genero { get; set; }
        public int Edad { get; set; }

        public static void Caminar()
        {
            Console.WriteLine("Caminando");
        }
        public static string Saludar(string Nombre)
        {
            return "Hola " + Nombre;
        }
    }
}
