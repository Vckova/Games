using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pyramid
{
    internal class Pyramid
    {
        public void DrawPyramid()
        {
            int row, column, NoRows;

            Console.Write("\n\n");
            Console.Write("Display the pattern like pyramid containing odd number of asterisks:\n");
            Console.Write("----------------------------------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input number of rows for this pattern :");
            NoRows = Convert.ToInt32(Console.ReadLine());
            for (row = 1; row < NoRows; row++)
            {
                for (column = 1; column <= NoRows - row; column++)
                    Console.Write(" ");
                for (column = 1; column <= 2 * row - 1; column++)
                    Console.Write("*");
                Console.Write("\n");
            }
        }
    }
}
