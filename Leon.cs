using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInterfaces
{
    class Leon : IAnimal
    {
        public string Especie { get; set; }
        public string Habitat { get; set; }
        public string Dieta { get; set; }

        public void Comer()
        {
            Console.WriteLine("El león está comiendo.");
        }

        public void Dormir()
        {
            Console.WriteLine("El león está durmiendo.");
        }

        public void EmitirSonido()
        {
            Console.WriteLine("El león ruge.");
        }
    }

}
