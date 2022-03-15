using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class PerfectNumber
    {

        public void Perfect()
        {
            int sum = 0;
            Console.WriteLine("enter number");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    sum += i;
                }
            }

            if (sum == num)
            {
                Console.WriteLine("{0} is perfect number", num);
            }
            else
            {
                Console.WriteLine("{0} is not perfect number", num);
            }
        }
    }
}
