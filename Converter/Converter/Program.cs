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
            Console.WriteLine("enter the number of meters");
            int meters = 0;
            int.TryParse(Console.ReadLine(), out meters);

            Console.WriteLine("1) for feet \n2) for yards \n3) for Fluid Ounce \n4) for Teaspoon \n5) for Pint \n6) for Quart \n7) for Gallon/ \n8) for Tablespoon \n9) for Gill \n10) for Cup ");
            int num = 0;
            int.TryParse(Console.ReadLine(),out num);

            /*if (num == 1)
              {
                Console.WriteLine(meters * 3.28084 + "feet");
              }
            if (num == 2)
            {
                Console.WriteLine(meters * 1.09361 + "yards");
            } */
            switch (num)
            {
                case 1:
                    Console.Write("\t" + meters * 3.28084 + "feet");
                    break;
                case 2:
                    Console.Write("\t" + meters * 39 + "inches");
                    break;
                case 3:
                    Console.Write("\t" + meters * 35195.1 + "Fluid Ounce");
                    break;
                case 4:
                    Console.Write("\t" + meters * 168936 + "Teaspoon");
                    break;
                case 5:
                    Console.Write("\t" + meters * 1759.75 + "Pint");
                    break;
                case 6:
                    Console.Write("\t" + meters * 879.877 + "Quart");
                    break;
                case 7:
                    Console.Write("\t" + meters * 219.969 + "Gallon");
                    break;
                case 8:
                    Console.Write("\t" + meters * 56312.1 + "Tablespoon");
                    break;
                case 9:
                    Console.Write("\t" + meters * 8453.51 + "Gill");
                    break;
                case 10:
                    Console.Write("\t" + meters * 3519.51 + "Cup");
                    break;
                default:
                    Console.WriteLine("Invalid Units");
                    break;
            }
            Console.ReadLine();
        }
    }
}
