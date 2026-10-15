using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureGame
{
    internal class Warrior : GameCharacter
    {

        public Warrior(string name, decimal health) : base(name, health)
        {
        }

        public override void UseSpecialAbility()
        {
            Console.WriteLine("The Warrior attacks with a sword!"); ;
        }
        public override void TakeDamage(int amount)
        {
            amount = amount - 2;
            Health -= amount;
        }
    }
}
