using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDominionOfKings
{
    class Program
    {
        static void Main(string[] args)
        {
            int provinces, duchies, estates, points;
            Console.Write("Provinces: ");
            provinces = Convert.ToInt32(Console.ReadLine());
            Console.Write("Duchies: ");
            duchies = Convert.ToInt32(Console.ReadLine());
            Console.Write("Estates: ");
            estates = Convert.ToInt32(Console.ReadLine());
            points = provinces * 6 + duchies * 3 + estates;
            Console.WriteLine("Points: " + points);
            Console.ReadKey();
        }
    }
}
