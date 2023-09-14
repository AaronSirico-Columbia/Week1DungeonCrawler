namespace CaveOfEnviorments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();

            game.welcome();
            game.OutputName();
            game.GameLoop();
        }
    }
}