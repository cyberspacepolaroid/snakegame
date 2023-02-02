using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class FoodGenerator : GameObject
    {
        public FoodGenerator()
        {
            this.isVisible = false;
        }
        public override void update()
        {
            if(this.countFood() < 3)
            {
                for(int i = this.countFood(); i <3; i++)
                {
                    Food food = new Food();
                    food.setSpace(this.gameSpace);
                    Random random = new Random();
                    Position position = new Position();
                    position.x = random.Next(1, SnakeGame.WIDTH);
                    position.y = random.Next(1, SnakeGame.HEIGHT);
                    food.position = position;
                    food.id = random.Next(1, 100000).ToString();
                    this.gameSpace.add(food.id,food);
                }
            }
        }

        private int countFood()
        {
            int count = 0;
            foreach (GameObject o in this.gameSpace.getObjects())
            {
                if (o is Food)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
