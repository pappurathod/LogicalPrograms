using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class PrimeNumber
    {

        public void Prime()
        {
            int flag = 0;
            Console.WriteLine("enter number");
            int num = int.Parse(Console.ReadLine());
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine("{0} is not prime number", num);
                    flag = 1;
                    break;
                }

            }
            if (flag == 0)
            {
                Console.WriteLine("{0} is prime number", num);

            }
        }
    }
}
