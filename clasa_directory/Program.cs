using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clasa_directory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // unos putanje mape
            Console.WriteLine("Unesi putanju mape");
            string putanja = Console.ReadLine();
            // Provjera dali mapa postoji
            if (Directory.Exists(putanja))
            {
                Console.WriteLine("Mapa postoji!");



                // ako postoji ispisuje sve datoteke
                foreach (string datoteka in Directory.GetFiles(putanja))
                {
                    Console.WriteLine(datoteka);
                }

                
            }
            else
            {
                Directory.CreateDirectory(putanja);
                Console.WriteLine("Mapa" + putanja + "je napravljen");
            }

            string putanjaPodmape = putanja + "\\bla";

            if (!Directory.Exists(putanjaPodmape))
            {
                Directory.CreateDirectory(putanjaPodmape);
                Console.WriteLine("Mapa" + putanjaPodmape + "je napravljen");
            }
            Console.WriteLine("Ispis Podmapa:");
            foreach(string podmapa in Directory.GetDirectories(putanja))
            {
                Console.WriteLine(podmapa);
            }
            
            Directory.Delete(putanjaPodmape);
            Console.WriteLine("Ispis podmapa nakon brisanja:");

            foreach (string poddirektorij in Directory.GetDirectories(putanja))
            {
                Console.WriteLine(poddirektorij);
            }


           
            Console.ReadKey();
        }
    }
}
