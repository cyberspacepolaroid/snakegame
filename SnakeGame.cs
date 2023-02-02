using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class SnakeGame : Game
    {
        public static int WIDTH = 40;
        public static int HEIGHT = 20;
        public override void init()
        {
            Console.WindowWidth = WIDTH;
            Console.WindowHeight = HEIGHT;
            Console.SetBufferSize(WIDTH, HEIGHT);
            Console.CursorVisible = false;
            Console.Clear();
            this.currentSpace = new Jungle();
            Snake snake = new Snake(this.currentSpace);
            FoodGenerator gen = new FoodGenerator();
            this.currentSpace.add("snake",snake);
            this.currentSpace.add("foodgen", gen );
            snake.setSpace(this.currentSpace);
            gen.setSpace(this.currentSpace);
            this.renderer = new ConsoleRenderer();
            this.input = new SnakeInput();

        }

        public override void start()
        {
            base.start();
        }

        public override void stop()
        {
            base.stop();
        }
    }
}
