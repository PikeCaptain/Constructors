namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game myGame = new Game("Forza Horizon 5", "E for everyone");

            Console.WriteLine($"My favorite game is {myGame.title} and it is rated {myGame.genre}!");

            Game myOtherGame = new Game();

            Console.WriteLine($"My other favorite game is {myOtherGame.title} and it is rated {myOtherGame.genre} game!");
        }
    }
}