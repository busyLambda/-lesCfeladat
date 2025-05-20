namespace Inheritance
{

    internal class Zombie : Character
    {
        public Zombie(string name, int hp, int damage) : base(name, hp, damage)
        {

        }

        public override void Attack()
        {
            Console.WriteLine($"{Name} attacks while groaning, dealing {Damage} damage!");
        }
    }
}
