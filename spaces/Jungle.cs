using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Jungle : GameSpace
    {
        public Position direction = new Position(1, 0);
        public override void destroy()
        {
            base.destroy();
        }

        public override void init()
        {
            base.init();
        }

        public override GameSpace update()
        {
            GameObject snake;
            GameObject gen;
            switch (this.input)
            {
                case GameKeys.UP:
                    this.direction = new Position(0, -1);
                    break;
                case GameKeys.DOWN:
                    this.direction = new Position(0, 1);
                    break;
                case GameKeys.LEFT:
                    this.direction = new Position(-1, 0);
                    break;
                case GameKeys.RIGHT:
                    this.direction = new Position(1, 0);
                    break;
            }
            this.gameObjects.TryGetValue("snake", out snake);
            this.gameObjects.TryGetValue("foodgen", out gen);
            GameObject[] obj = new GameObject[this.getObjects().Count];
            this.getObjects().CopyTo(obj,0);
            foreach(GameObject o in obj)
            {
                this.updateRecursive(o);
            }
            return this;
        }

        public void updateRecursive(GameObject o)
        {
            o.update();
            foreach(GameObject obj in o.getChild())
            {
                this.updateRecursive(obj);
            }

        }
        public override void setInput(GameKeys key)
        {
            if (this.input == GameKeys.UP && key != GameKeys.DOWN) {
                this.input = key;
            }

            else if (this.input == GameKeys.DOWN && key != GameKeys.UP)
            {
                this.input = key;
            }

            else if (this.input == GameKeys.LEFT && key != GameKeys.RIGHT)
            {
                this.input = key;
            }

            else if (this.input == GameKeys.RIGHT && key != GameKeys.LEFT)
            {
                this.input = key;
            }
        }

        public override GameKeys getInput()
        {
            return this.input;
        }

    }
}
