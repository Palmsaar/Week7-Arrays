using System;

namespace HeroFight
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Heros = new string[6] {"Batman", "Homer Simpson", "Tarzan", "The Grinch", "Ironman", "Winnie-the-Pooh" };
            string[] Weapons = new string[6] {"spoon", "plastic fork", "pen", "gun", "table", "glasses"};
            string[] Sizes = new string[4] { "Large", "small", "tiny", "comically large"};
            Random rnd1 = new Random();
            Random rnd2 = new Random();
            Random rnd3 = new Random();
            Random rnd4 = new Random();
            int Herornd1 = rnd1.Next(0, 6);
            int Herornd2 = rnd1.Next(0, 6);
            int Weaponrnd = rnd2.Next(0, 6);
            int Weaponrnd2 = rnd2.Next(0, 6);
            int Sizesrnd = rnd3.Next(0, 4);
            int Sizesrnd2 = rnd3.Next(0, 4);
            int Winrnd = rnd4.Next(0, 2);
            if(Winrnd == 1)
            {
                Console.WriteLine($"{Heros[Herornd1]} won with {Sizes[Sizesrnd]} {Weapons[Weaponrnd]} against {Heros[Herornd2]} with a {Sizes[Sizesrnd2]} {Weapons[Weaponrnd2]}");
            }
            else if (Winrnd == 0)
            {
                Console.WriteLine($"{Heros[Herornd1]} lost with {Sizes[Sizesrnd]} {Weapons[Weaponrnd]} against {Heros[Herornd2]} with a {Sizes[Sizesrnd2]} {Weapons[Weaponrnd2]}");
            }

        }
    }
}
