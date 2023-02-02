using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Game
{
    class ConsoleRenderer : GameRenderer
    {
        public override void render(GameSpace space)
        {
            Console.Clear();
            foreach(GameObject obj in space.getObjects())
            {
                this.render(obj);
            }
            Thread.Sleep(400);
        }

        private void render(GameObject obj)
        {
            if (obj.isVisible)
            {
                Position pos = obj.position;
                
                Console.SetCursorPosition(pos.x, pos.y);
                Console.Write(obj.getView().ToString());
            }
            List<GameObject> child = obj.getChild();
            foreach(GameObject o in child)
            {
                render(o);
            }
        }
    }
}
