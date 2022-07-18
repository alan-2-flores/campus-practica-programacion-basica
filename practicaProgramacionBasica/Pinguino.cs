using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaProgramacionBasica
{
    internal abstract class Pinguino
    {
        public abstract string Nombre(string nombre);
        public abstract string Especie(string especie);

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
        public override string Nombre(string nombre)
        {
            return nombre;
        }

        public override string Especie(string especie)
        {
            return especie;
        }
    }
}
