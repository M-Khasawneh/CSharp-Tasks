using System;


namespace AdventureGame
{
    internal abstract class GameCharacter
    {
        private string _name;
        protected decimal _health;



        public GameCharacter(string name, decimal health)
        {
            Name = name;
            Health = health;
        }
        public decimal Health
        {
            get
            {
                return _health;

            }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new Exception("Health must be between 0 - 100");
                }
                _health = value;

            }
            
        }
        public string Name 
        {
            get 
            {
                return _name;
            }
            set 
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Name Cannot be Null!");
                }
                _name = value;
            }
        }

        public abstract void UseSpecialAbility();
        public virtual void TakeDamage(int amount)
        {
            if (amount < 0)
            {
                 throw new ArgumentException("Damage cannot be negative.");
            }
            if (amount >= Health)
            {
                Health = 0;
            }
            else
            {
            Health -= amount;

            }
        }
        public void Heal()
        {
            if (Health + 10 > 100)
            {
                Health = 100;
            }
            else
            {
                Health += 10;
            }
            Console.WriteLine($"The New Health = {Health}");

        }
        public void Heal(int amount)
        {
            if (amount < 0)
            {
                throw new Exception("amout cannot be Negative");
            }
            if (Health + amount > 100)
            {
                Health = 100;
            }
            else
            {
                Health += amount;
            }
            Console.WriteLine($"The New Health = {Health}");
        }


         
    }
}

