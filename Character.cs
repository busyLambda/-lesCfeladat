namespace Inheritance
{
    public class Character
    {
        protected string Name { get; set; }
        protected int Hp { get; set; }
        protected int Damage { get; set; }

        public Character(string name, int hp, int damage)
        {
            Name = name;
            Hp = hp;
            Damage = damage;
        }

        public virtual void Attack()
        {
            Console.WriteLine($"{Name} attacks!");
        }

        public void Fight(Character other)
        {
            while (true)
            {
                Hp -= other.Damage;
                Attack();

                other.Hp -= Damage;
                other.Attack();

                if (Hp < 0 && other.Hp < 0)
                {
                    Console.WriteLine($"{Name} and {other.Name} both die from each other's attacks, it's a tie.");
                    break;
                }
                else if (Hp < 0)
                {
                    Console.WriteLine($"{Name} dies, {other.Name} is crowned victor, {other.Hp} HP remaining.");
                    break;
                }
                else if (other.Hp < 0)
                {
                    Console.WriteLine($"{other.Name} dies, {Name} is crowned victor, {Hp} HP remaining.");
                    break;
                }
                else
                {
                    Console.WriteLine($"{Name} and {other.Name} trade blows leaving {Name} with {Hp} HP and {other.Name} with {other.Hp} HP.");
                }
            }
        }
    }
}
