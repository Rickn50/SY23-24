using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your number");
            int num = 0;
            int.TryParse(Console.ReadLine(),out num);
            Console.WriteLine(num * 2);
            Console.ReadLine();
            /*for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();*/
        }
    }
}
