using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class SnakeInput : GameInput
    {
        public override  Task<GameKeys> listen()
        {
            Task<GameKeys> task = new Task<GameKeys>(() => {
                while (true)
                {
                    ConsoleKeyInfo key = default;
                    key = Console.ReadKey();
                    switch (key.Key)
                    {
                        case ConsoleKey.UpArrow:
                            this.key = GameKeys.UP;
                            break;
                        case ConsoleKey.DownArrow:
                            this.key =  GameKeys.DOWN;
                            break;
                        case ConsoleKey.LeftArrow:
                            this.key =  GameKeys.LEFT;
                            break;
                        case ConsoleKey.RightArrow:
                            this.key =  GameKeys.RIGHT;
                            break;
                        case ConsoleKey.Enter:
                            this.key = GameKeys.ENTER;
                            break;
                        default:
                            this.key = GameKeys.NOTHING;
                            break;
                    }
                }
            });
            task.Start();
            return task;
        }
    }
}
