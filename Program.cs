using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            getIntegerInput();
        }

        static int getIntegerInput()
        {
            int output;

            bool isInteger;

            Console.Write("Enter an int : ");
            string input = Console.ReadLine();

            isInteger = int.TryParse(input, out output);

            while (!isInteger)
            {
                Console.WriteLine();
                input = Console.ReadLine();
                isInteger = int.TryParse(input, out output);
            }

            return output;
        }
    }
}
