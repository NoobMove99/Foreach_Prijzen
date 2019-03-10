using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foreach_Prijzen
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] prijzen = new double[20];
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine($"Geef 20 prijzen in. {prijzen[i]}/20");
                double prijs = Convert.ToDouble(Console.ReadLine());
                prijzen[i] = prijs;
            }
            foreach (double prize in prijzen)
            {
                if (prize >= 5.00)
                {
                    Console.WriteLine(prize);
                }
            }
            double average = prijzen.Average();
            Console.WriteLine("Het gemiddelde van alle prijzen is: " + average);
            Console.ReadLine();
        }
    }
}
