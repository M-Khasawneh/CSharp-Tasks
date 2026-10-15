using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureGame
{
    internal class HealthPotion : ICollectible
    {
        public string PotionName { get; set; }

        
        public void Collect()
        {
            Console.WriteLine($"{PotionName} Collected!");
        }

        public void Use(GameCharacter character, string amountText)
        {
            try
            {
                int amount = int.Parse(amountText);
                if (amount < 0)
                {
                    Console.WriteLine("amount cannot be negative!");
                }
                else 
                {
                    character.Heal(amount);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Invalid amount: {ex.Message}");

            }

        }
    }
}
