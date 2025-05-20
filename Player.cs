namespace Inheritance
{
    internal class Player : Character
    {
        public int Experience { get; set; }

        public Player(string name, int hp, int damage, int experience)
            : base(name, hp, damage)
        {
            Experience = experience;
        }

        public override void Attack()
        {
            Console.WriteLine($"{Name} attacks, delaing {Damage} damage!");
            Console.WriteLine($"{Experience} experience");
        }
    }
}
