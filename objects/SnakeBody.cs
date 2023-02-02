using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class SnakeBody : GameObject
    {
        public SnakeBody() {
            this.view = new SnakeBodyView();
        }
        public override void update()
        {
            Snake snake = (Snake)this.gameSpace.get("snake");
            if(snake.head.position == this.position)
            {
                ((Jungle)this.gameSpace).direction = new Position(0, 0);
            }
        }
    }
}
