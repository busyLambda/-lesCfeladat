namespace Inheritance
{
    internal class Skeleton : Character
    {
        public Skeleton(string name, int hp, int damage) : base(name, hp, damage)
        {

        }

        public override void Attack()
        {
            Console.WriteLine($"{Name} attacks with a bow, dealing {Damage} damage!");
        }
    }
}
