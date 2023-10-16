using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPersona
{
    internal class Persona
    {
        public string Nombre { set; get; }
        private string nif;
        public string Pais { set; get; }

        public string Nif
        {
            get { return "El NIF es: " + nif; }
            set { nif = value; }
        }

        public Persona(string nombre, string nif, string pais)
        {
            Nombre = nombre;
            Nif = nif;
            Pais = pais;
        }
        public Persona() { }

         public override string ToString()
         {
             return "El nombre: " + Nombre + "\n"+ Nif+"\nPais: "+Pais;
         }
    }
}
