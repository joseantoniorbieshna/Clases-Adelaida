using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPersona
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona();
            persona.Nombre = "Pepito";
            persona.Nif = "0005554F";
            persona.Pais = "España";
            Console.WriteLine(persona);

        }
    }
}
