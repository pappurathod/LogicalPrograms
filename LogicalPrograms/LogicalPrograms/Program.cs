namespace LogicalPrograms
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Choice");
            Console.WriteLine("1 = Fibonacci Series");
            Console.WriteLine("2 = Perfect Number");
            int ch = int.Parse(Console.ReadLine());

            switch (ch)
            {
                case 0:
                    FibonacciSeries fiboseries = new FibonacciSeries();
                    fiboseries.Fibo();
                    break;

                case 1:
                    PerfectNumber perfectnum = new PerfectNumber();
                    perfectnum.Perfect();
                    break;

            }
        }
    }
}