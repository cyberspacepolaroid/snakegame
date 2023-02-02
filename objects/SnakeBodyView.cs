using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class SnakeBodyView : GameView
    {
        private string body = "#";

        public SnakeBodyView()
        {
        }

        public override string ToString()
        {
            return this.body;
        }
    }
}
