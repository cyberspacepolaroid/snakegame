using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Snake : GameObject
    {
        public SnakeHead head;
        public Snake(GameSpace space) {
            this.gameSpace = space;
            this.isVisible = false;
            Position p = new Position(-1, 0);
            Position position = new Position(5, 5);
            this.position = position;
            SnakeHead head = new SnakeHead();   
            head.position = position;
            head.setView(new SnakeHeadView());
            this.head = head;
            SnakeBody body1 = new SnakeBody();
            body1.position = position + p;
            body1.setSpace(this.gameSpace);
            body1.setView(new SnakeBodyView());
            SnakeBody body2 = new SnakeBody();
            body2.position = body1.position + p;
            body2.setSpace(this.gameSpace);
            body2.setView(new SnakeBodyView());
            this.childs.Add(head);
            this.childs.Add(body1);
            this.childs.Add(body2);

        }
        public override void update()
        {
            GameObject obj = this.childs.Last();
            obj.position = head.position;
            head.position += ((Jungle)this.gameSpace).direction;
            this.childs.Remove(obj);
            this.childs.Insert(1, obj);
        }

        public void grow() {
            SnakeBody obj = new SnakeBody();
            obj.setSpace(this.gameSpace);
            obj.position = head.position;
            head.position += ((Jungle)this.gameSpace).direction;
            this.childs.Insert(1, obj);
        }
    }
}
