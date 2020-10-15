using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsteriskTrianglesTask
{
    class Program
    {
        static void Main(string[] args)
        {            
            int number = 0;
            bool flag = true;
            do
            {
                Console.Write("Enter a number of triangles (from 1 to 6): ");
                string input = Console.ReadLine();

                bool result = Int32.TryParse(input, out number);
                if (result == true && number > 0 && number < 7)
                    flag = false;

            } while (flag);

            DisplayTriangles(number);            

            Console.Write("\nPress any key to exit...");
            Console.ReadKey();
        }



        static void DisplayTriangles(int number)
        {
            if (number == 1)    // O(1) complexity instead O(n^2)
            {
                Console.WriteLine("*");
                return;
            }

            string[] levels = { "*","***","*****","*******", "*********", "***********"};
            
            for (int i = 1; i < number + 1; i++)
            {
                string spaces = new string(' ', number - i);
                string output = spaces + levels[i - 1] + spaces;                

                for (int n = 0; n < number; n++)
                    Console.Write(output + ' ');
                Console.WriteLine();
            }
        }
    }
}
