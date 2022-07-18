using System;
using System.IO;

namespace practicaProgramacionBasica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fail check = new Fail();
            DateTime fechaActual = DateTime.Now;
            string path = @"C:\Users\a875541\Downloads\";
            string inputFile = path + "Countries.txt";
            string outputFile = path + "Countries" + fechaActual.ToString("yyyy-MMM-dd")+".txt";
            if (check.comprobacion(inputFile))
                GreetCountries(inputFile, outputFile);
            else {
                Console.WriteLine("No se pudo leer el archivo");
            }

            Emperador PruebaClases = new Emperador("Patrick", "Emperador");
            Console.WriteLine(PruebaClases.Name());
            Console.WriteLine(PruebaClases.Specie());
            PruebaClases.Volar();
            PruebaClases.Hablar();
            Console.ReadKey();
        }

        static void GreetCountries(string inputFile, string outputFile) {
            string pais;
            using (StreamReader reader = new StreamReader(inputFile))
            using (StreamWriter writer = new StreamWriter(outputFile))
            {
                while ((pais = reader.ReadLine()) != null) //Leemos línea por línea
                {
                    writer.WriteLine("Saludos hasta " + pais);
                }
                Console.WriteLine("Archivo escrito correctamente");
            }
        }
    }
}
