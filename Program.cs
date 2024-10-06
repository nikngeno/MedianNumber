namespace MedianNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MedianNumber(2, 1, 3));
            Console.WriteLine(MedianNumber(2, 1, 2));
            Console.WriteLine(MedianNumber(2, 2, 1));
            Console.WriteLine(MedianNumber(1, 2, 2));
        }
        static int MedianNumber(int a, int b, int c)
        {
            if ((a > b && a < c) || (a > c && a < b))
            {
                return a;
            }
            else if ((b > a && b < c) || (b > c && b < a))
            {
                return b;
            }
            else
            {
                return c;
            }
        }
    }
}
