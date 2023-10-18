using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseAdelaida.Models
{
    internal class Vino : Bebida, IBebidaAlcoholica
    {
        public Vino(int cantidad, string nombre = "Vino tempranillo") : base(nombre, cantidad)
        {
        }

        public int Alcohol { get; set; }

        public void MaximoRecomendado()
        {
            Console.WriteLine("El número máximo recomendados son cuatro copas.");
        }

    }
}
