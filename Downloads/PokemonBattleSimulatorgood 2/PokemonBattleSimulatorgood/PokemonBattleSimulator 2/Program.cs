using System.Security.Cryptography.X509Certificates;

namespace PokemonBattleSimulator
{
    internal class Program
    {
        public static string? firstTrainer;
        public static string? secondTrainer;

        public static int MAX_SIZE = 6;

        static void Main(string[] args)
        {
            bool running = true;
            while (running)
            {
                try
                {
                    Console.WriteLine("Enter name first trainer:");
                    firstTrainer = Console.ReadLine();
                    Console.WriteLine("Enter name second trainer:");
                    secondTrainer = Console.ReadLine();

                    List<Pokeball> beltOfAsh = new List<Pokeball>();
                    beltOfAsh.Add(new Pokeball(new Charmander("Sparky")));
                    beltOfAsh.Add(new Pokeball(new Squirtle("Blah")));
                    beltOfAsh.Add(new Pokeball(new Bulbasaur("Blagtegegg")));
                    beltOfAsh.Add(new Pokeball(new Bulbasaur("Blajjjjjjgtegegg")));

                    Trainer ash = new Trainer(firstTrainer, beltOfAsh);

                    List<Pokeball> beltOfGary = new List<Pokeball>();
                    beltOfGary.Add(new Pokeball(new Squirtle("Firestarter")));
                    beltOfGary.Add(new Pokeball(new Charmander("Testy")));
                    beltOfGary.Add(new Pokeball(new Squirtle("Firestarfffter")));
                    beltOfGary.Add(new Pokeball(new Squirtle("Blah")));

                    Trainer gary = new Trainer(secondTrainer, beltOfGary);

                    Arena arena = new Arena();

                    if (beltOfAsh.Count > MAX_SIZE && beltOfAsh.Count < 1)
                    {
                        throw new ArithmeticException("Critical exception: You must not have more than six pokeballs on your belt or no less than one pokeball");
                    }

                    for (int i = 0; i < beltOfAsh.Count; i++)
                    {
                        arena.round = i;

                        Console.WriteLine(arena.returnRound());
                        Console.WriteLine(arena.returnWon());

                        ash.throwPokeball(Arena.AshNew);
                        gary.throwPokeball(Arena.GaryNew);

                        arena.AddToBattle(beltOfAsh[Arena.AshNew], beltOfGary[Arena.GaryNew]);

                        Console.WriteLine(arena.won());
                        Console.WriteLine("");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                
            }
        }
    }
}