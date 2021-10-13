using System;

namespace BreakfastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Food = { "võileib juustuga", "jogurt", "banaan", "peekon", "muna" };

            Food[3] = "viinerid";
            Food[1] = "keefir";
            Console.WriteLine("Menüüs:");
            for (int i = 0; i < Food.Length; i++)
            {

                Console.WriteLine(Food[i]);
            }

            Console.WriteLine("Please choose a food item (1-5)");
            int userChoise = Convert.ToInt32(Console.ReadLine()) -1;

            Console.WriteLine($"You chouse {Food[userChoise]}");

        }
    }
}
