using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Food : GameObject
    {
        public Food()
        {
            this.view = new FoodView();
        }

        public override void update()
        {
            Snake snake = (Snake) this.gameSpace.get("snake");
            if(snake.head.position == this.position)
            {
                snake.grow();
                this.gameSpace.remove(this.id);
            }
        }
    }
}
