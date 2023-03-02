using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheTriangleFarmer
{
    class Program
    {
        static void Main(string[] args)
        {
            float _height, _base, _area;
            Console.Write("Base: ");
            _base = Convert.ToSingle(Console.ReadLine());
            Console.Write("Height: ");
            _height = Convert.ToSingle(Console.ReadLine());
            _area = _base * _height / 2;
            Console.WriteLine($"Area: {_area}");
            Console.ReadKey();
        }
    }
}
