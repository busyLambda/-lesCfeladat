using Inheritance;

public class Program
{
    public static void Main(string[] args)
    {
        List<Character> characters = new List<Character>();
        characters.Add(new Player("Jeff", 1892, 252, 55024));
        characters.Add(new Zombie("Zombie", 524, 122));
        characters.Add(new Werewolf("Nick", 2508, 315, true));
        characters.Add(new Werewolf("Donald", 1978, 229, false));

        characters[0].Fight(characters[3]);
    }
}
