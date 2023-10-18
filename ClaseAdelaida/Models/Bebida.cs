using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseAdelaida.Models
{
    internal class Bebida
    {
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public Bebida(string nombre, int cantidad)
        {
            Cantidad = cantidad;
            this.Nombre = nombre;
        }

        public void Beberse(int cuantoBebio)
        {
            this.Cantidad -= cuantoBebio;
        }
    }
}
