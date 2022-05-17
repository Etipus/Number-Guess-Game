using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number_guess_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            game();
        }
        static void game()
        {
            bool dogrumu = false;

            Random rnd = new Random();
            int randomnumber = rnd.Next(1, 11);

            Console.WriteLine("Welcome to the number guessing game!");

            while (!dogrumu)
            {
                Console.WriteLine("Guess a number between 1 and 10:");
                int tahmin = Convert.ToInt32(Console.ReadLine());

                if (tahmin < randomnumber)
                    Console.WriteLine("Try a higher number");
                else if (tahmin > randomnumber)
                    Console.WriteLine("Try a lower number");
                else
                {
                    Console.WriteLine("Correct!");
                    Console.WriteLine("Conqratulations, you have won the game!\nIf you wanna play the game again you can press 't' if you wanna quit from the game you can press anything except 't'");
                    char secim = Convert.ToChar(Console.ReadLine());
                    if (secim == 't')
                        game();
                    else
                        Environment.Exit(0);
                }
    }
}
    }
}




