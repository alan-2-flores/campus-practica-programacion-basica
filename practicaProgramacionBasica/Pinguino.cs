using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaProgramacionBasica
{
    internal abstract class Pinguino
    {
        public abstract string Name();
        public abstract string Specie();

        public void Volar() {
            Console.WriteLine("No puedo volar (en pinguino)");
        }

        public void Hablar()
        {
            Console.WriteLine("Noot Noot");
        }

    }

    sealed internal class Emperador : Pinguino
    {
        string Nombre, Especie;

        public Emperador(string nombre, string especie) {
            Nombre = nombre;
            Especie= especie;
        }

        public override string Name()
        {
            return Nombre;
        }

        public override string Specie()
        {
            return Especie;
        }
    }
}
