namespace SimpleSnake
{
    using SimpleSnake.Core;
    using SimpleSnake.GameObjects;
    using System.Threading;
    using Utilities;

    public class StartUp
    {
        public static void Main()
        {
            ConsoleWindow.CustomizeConsole();

            Wall wall = new Wall(100, 20);
            Snake snake = new Snake(wall);

            Engine engine = new Engine(snake);
            engine.Run();
        }
    }
}
