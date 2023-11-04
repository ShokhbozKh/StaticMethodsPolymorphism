namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator results = new Calculator();
            Console.WriteLine(Calculator.Add(1,2));
            Console.WriteLine(Calculator.Sub(12.21m,32));
            Console.WriteLine(Calculator.Multiply(21,12.2m));
            Console.WriteLine(Calculator.Div(12,5));
            Console.WriteLine(Calculator.Abs(-343.3m));
            Console.WriteLine(Calculator.Pow(12));

        }
    }
    class Calculator
    {
        public static decimal Add(decimal a, decimal b)
        {
            return a + b;
        }
        public static decimal Sub(decimal a, decimal b)
        {
            return a - b;
        }
        public static decimal Multiply(decimal a, decimal b)
        {
            return a * b;
        }
        public static decimal Div(decimal a, decimal b)
        {
            return a / b;
        }
        public static decimal Abs(decimal a)//
        {
            if(a < 0)
            {
                return -a;
            }
            else
            {
                return a;
            }
        }
        public static decimal Pow(decimal a)
        {
            return a * a;
        }
    }
}