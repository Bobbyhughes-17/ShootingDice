using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player whose roll will always be in the upper half of their possible rolls
    public class UpperHalfPlayer : Player
    {
      public int UpperHalfRoll()
        {
            int halfMax = DiceSize/2;
            return new Random().Next(halfMax) + halfMax;
        }
        public override void Play(Player other)
        {
            // Call roll for "this" object and for the "other" object
            int myRoll = UpperHalfRoll();
            int otherRoll = other.Roll();

            Console.WriteLine($"{Name} rolls a {myRoll}");
            Console.WriteLine($"{other.Name} rolls a {otherRoll}");
            if (myRoll > otherRoll)
            {
                Console.WriteLine($"{Name} Wins!");
            }
            else if (myRoll < otherRoll)
            {
                Console.WriteLine($"{other.Name} Wins!");
            }
            else
            {
                // if the rolls are equal it's a tie
                Console.WriteLine("It's a tie");
            }
        }
    }
}