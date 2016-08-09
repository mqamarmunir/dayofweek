using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(dow(18, 4, 2));
            Console.ReadLine();

        }
        static int dow(int y, int m, int d)
        {
            int[] t = { 0, 3, 2, 5, 0, 3, 5, 1, 4, 6, 2, 4 };
            y -= (m < 3 ? 1 : 0);
            return (y + y / 4 - y / 100 + y / 400 + t[m - 1] + d) % 7;
        }

    }
}
