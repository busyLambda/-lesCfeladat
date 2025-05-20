namespace Inheritance
{


    internal class Werewolf : Character
    {
        private bool IsTamed { get; set; }

        public Werewolf(string name, int hp, int damage, bool isTamed) : base(name, hp, damage)
        {
            IsTamed = isTamed;
        }

        public override void Attack()
        {
            if (IsTamed)
                Console.WriteLine($"{Name} helps the player attack, dealing {Damage} damage!");
            else
                Console.WriteLine($"{Name} bites, dealing {Damage} damage!");
        }
    }
}
