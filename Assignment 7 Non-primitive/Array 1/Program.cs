using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[3];
            numbers[0] = 1;

            Console.WriteLine(numbers[0]);

            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);
            Console.ReadLine();
            var flags = new bool[3];
            flags[0] = true;
            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);
            Console.WriteLine(flags[2]);
            Console.ReadLine();
            var names = new string[3] { "Jack", "John", "Marry" };
            Console.ReadLine();
        }
    }
}
