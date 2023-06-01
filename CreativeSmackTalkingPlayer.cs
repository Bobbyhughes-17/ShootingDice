using System;
using System.Collections.Generic;


namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : Player
    {
        private List<string> taunts;

        public CreativeSmackTalkingPlayer()
        {
            taunts = new List<string>
            {
                "TAUNT 1",
                "TAUNT 2",
                "TAUNT 3",
                "TAUNT 4"
            };
        }

        public override void Play(Player other)
        {
            base.Play(other);

            Random random = new Random();
            int index = random.Next(taunts.Count);
            string selectedTaunt = taunts[index];
            Console.WriteLine($"{Name} says {selectedTaunt}");
        }
    }
}