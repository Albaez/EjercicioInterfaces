using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInterfaces
{
    class Pinguino : IAnimal
    {
        public string Especie { get; set; }
        public string Habitat { get; set; }
        public string Dieta { get; set; }

        public void Comer()
        {
            Console.WriteLine("El pingüino está comiendo pescado.");
        }

        public void Dormir()
        {
            Console.WriteLine("El pingüino está durmiendo en su nido.");
        }

        public void EmitirSonido()
        {
            Console.WriteLine("El pingüino emite un sonido de exhibicion extatica.");
        }
    }
}
