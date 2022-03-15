namespace LogicalPrograms
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Choice");
            Console.WriteLine("1 = Fibonacci Series");
            Console.WriteLine("2 = Perfect Number");
            Console.WriteLine("3 = Prime Number");
            Console.WriteLine("4 = Reverse Number");
            int ch = int.Parse(Console.ReadLine());

            switch (ch)
            {
                case 1:
                    FibonacciSeries fiboseries = new FibonacciSeries();
                    fiboseries.Fibo();
                    break;

                case 2:
                    PerfectNumber perfectnum = new PerfectNumber();
                    perfectnum.Perfect();
                    break;
                case 3:
                    PrimeNumber primenum = new PrimeNumber();
                    primenum.Prime();
                    break;
                case 4:
                    ReverseNumber revnum = new ReverseNumber();
                    revnum.Reverse();
                    break;
            }
        }
    }
}