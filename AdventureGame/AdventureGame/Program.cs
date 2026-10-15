
using System;
using System.Collections.Generic;

namespace AdventureGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var warrior = new Warrior("Alex", 80);
            var wizard = new Wizard("Luna", 70);

            List<GameCharacter> characters = new List<GameCharacter>
            {
                warrior,
                wizard
            };

            foreach (GameCharacter character in characters)
            {
                character.UseSpecialAbility();
                character.TakeDamage(10);
                Console.WriteLine($"{character.Name} : {character.Health}");
            }

            Console.WriteLine("\n--- Healing ---");

            warrior.Heal();
            wizard.Heal(15);

            Console.WriteLine("\n--- Health Potion ---");

            HealthPotion potion = new HealthPotion();

                potion.PotionName = "Health Potion";
            

            potion.Collect();

            Console.Write("Enter healing amount: ");
            string amountText = Console.ReadLine();

            potion.Use(warrior, amountText);

            Console.WriteLine($"\n{warrior.Name} : {warrior.Health}");
            Console.WriteLine($"{wizard.Name} : {wizard.Health}");
        }
    }
}
