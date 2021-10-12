using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] predictions = new string[4] {"win a million", "fall in love", "buy youtube premium", "join the darkside for cookies" };
            Console.WriteLine("enter a number form 0 to 3");
            int Num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Today you will {predictions[Num]}");
        }
    }
}
