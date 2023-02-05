using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pyramid
{
    internal class Calendar
    {
        public void DrawCalendar()
        {

            Console.Write("Input initial value:");
            int z = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input end value:");
            int k = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input increase number of a vertical array:");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input increase number of a horizontal array:");
            int x = Convert.ToInt32(Console.ReadLine());


            for (int i = z; i <= k; i = i + y)

            {
                for (int j = z; j <= k; j = j + x)
                {
                    Console.Write("\t" + (j + i));
                }
                Console.WriteLine();
            }
        }
    }
}
