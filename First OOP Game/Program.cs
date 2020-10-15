using System;

namespace First_OOP_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            // Name Health Atk Block
            Warrior maximus = new Warrior("Maximus", 1000, 200, 20);
            Warrior bob = new Warrior("Bob", 1000, 200, 20);

            Battle.StartFight(maximus, bob);

            Console.ReadLine();
        }
    }
}
