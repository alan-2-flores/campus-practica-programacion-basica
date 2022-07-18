using System;
using System.IO;

namespace practicaProgramacionBasica
{
    public class Fail
    {
        public bool comprobacion(string inputFile)
        {
            try {
                using (StreamReader CountriesInput = new StreamReader(inputFile));
                return true;
			}
			catch (FileNotFoundException e){
				Console.WriteLine(e.Message);
                return false;
			}
        }
    }
}
