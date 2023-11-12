using System;

namespace EjercicioInterfaces
{
    class Program
    {
        static void Main()
        {
            var leon = new Leon
            {
                Especie = "Panthera leo",
                Habitat = "Savannah",
                Dieta = "Carnívora"
            };

            var pinguino = new Pinguino
            {
                Especie = "Spheniscidae",
                Habitat = "Antártida",
                Dieta = "Pescado"
            };

            leon.Comer();
            leon.Dormir();
            leon.EmitirSonido();

            pinguino.Comer();
            pinguino.Dormir();
            pinguino.EmitirSonido();

          
        }
    }
}
