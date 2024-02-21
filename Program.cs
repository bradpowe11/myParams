using System.Globalization;

namespace myParams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            Console.WriteLine("How many random interger numbers would you like to generate?");
            int size = int.Parse(Console.ReadLine());
            int[]numbers = new int[size];
            Console.WriteLine("Here are your random numbers");
            for (int i = 0; i < size; i++)
            {
                numbers[i] = r.Next(1, 10);
                Console.WriteLine(numbers[i]);
            }
            Console.WriteLine($"Total of the numbers array={Add(numbers)}");
            Console.WriteLine($"Total of the Multiply array={Multiply(numbers)}");
        }
        static int Add(params int[] numbers)
        {
            int total = 0;
            foreach (int number in numbers)
            {
                total += number;
            }
            return total;
        }
        static int Multiply(params int[] numbers)
        {
            int total = 1;
            foreach (int number in numbers)
            {
                total *= number;
            }
            return total;
        }
    }
}
