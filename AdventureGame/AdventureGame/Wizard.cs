using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureGame
{
    internal class Wizard : GameCharacter
    {
        public Wizard(string name, decimal health) : base(name, health)
        {
        }

        public override void UseSpecialAbility()
        {
            Console.WriteLine("The Wizard uses magic!");
        }
        public override void TakeDamage(int amount)
        {
            Health -= amount;
        }
    }
}
