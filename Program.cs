using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KD_Gokart
{
    internal class Program
        {
            static void Main(string[] args)
        {
            string filePath = "vezeteknevek.txt"; // A fájl elérési útja

            try
            {
                // Teljes fájl beolvasása
                string content = File.ReadAllText(filePath);
                Console.WriteLine("A fájl tartalma:");
                Console.WriteLine(content);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hiba történt a fájl beolvasása során:");
                Console.WriteLine(ex.Message);
            }

            
        }
    }
}
