using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class FibonacciSeries
    {

        public void Fibo()
        {
            Console.WriteLine("enter number");
            int num = int.Parse(Console.ReadLine());
            int num1 = 0, num2 = 1;
            Console.Write(num1 + " " + num2);
            for (int i = 2; i < num; i++)
            {
                int num3 = num1 + num2;
                num1 = num2;
                num2 = num3;

                Console.Write(" " + num3);

            }
        }
    }
}
