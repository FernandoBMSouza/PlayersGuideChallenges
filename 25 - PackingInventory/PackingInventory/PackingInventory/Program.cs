using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackingInventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pack pack = new Pack(10, 10, 10);

            while (true)
            {
                Console.WriteLine(pack.ToString()); 
                Console.WriteLine("1 - Arrow");
                Console.WriteLine("2 - Bow");
                Console.WriteLine("3 - Rope");
                Console.WriteLine("4 - Water");
                Console.WriteLine("5 - Food");
                Console.WriteLine("6 - Sword");
                Console.Write("Choose an item to add: ");

                switch (int.Parse(Console.ReadLine()))
                {
                    case 1: pack.Add(new Arrow()); break;
                    case 2: pack.Add(new Bow()); break;
                    case 3: pack.Add(new Rope()); break;
                    case 4: pack.Add(new Water()); break;
                    case 5: pack.Add(new Food()); break;
                    case 6: pack.Add(new Sword()); break;
                }
                Console.WriteLine("=============================");
            }
        }
    }
}
