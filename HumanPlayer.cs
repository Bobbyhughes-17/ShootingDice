using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A player the prompts the user to enter a number for a roll
    public class HumanPlayer : Player
    {
        public override int Roll()
        {
            Console.Write($"{Name}, enter roll: ");
            string input = Console.ReadLine();
            int roll;
            while (!int.TryParse(input, out roll))
            {
                Console.WriteLine("Invalid input.");
                Console.Write($"{Name}, entere your roll: ");
                input = Console.ReadLine();
            }
            return roll;
        }
    }
}