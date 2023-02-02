using SFML.Window;
using System;

namespace Game
{
    class Program
    {
        const int WIDTH = 800;
        const int HEIGHT = 400;
        public static void Main(string[] args) {

            Game game = new SnakeGame();
            game.init();
            game.start();
        }
    }
}
