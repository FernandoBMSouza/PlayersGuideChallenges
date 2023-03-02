using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFourSistersAndTheDuckbear
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Chocolate eggs gathered: ");
            int chocolateEggs = Convert.ToInt32(Console.ReadLine());
            int chocolateEggsPerSister = chocolateEggs / 4;
            int leftOver = chocolateEggs % 4;
            Console.WriteLine("Chocolate eggs per sister: " + chocolateEggsPerSister);
            Console.WriteLine("Left over: " + leftOver);
            Console.ReadKey();
        }
    }
}
