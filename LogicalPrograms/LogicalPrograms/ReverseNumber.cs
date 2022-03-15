using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class ReverseNumber
    {
        public void Reverse()
        {
            int rem, reverse = 0;
            Console.WriteLine("Enter the Number");
            int num = int.Parse(Console.ReadLine());
            while (num != 0)
            {
                rem=num % 10;
                reverse = reverse * 10 + rem;
                num /= 10;
            }
            Console.WriteLine("Reverse Number is " + reverse);

        }

    }
}
