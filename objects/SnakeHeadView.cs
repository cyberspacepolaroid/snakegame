using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class SnakeHeadView : GameView
    {
        private string head = "$";

        public override string ToString()
        {
            return this.head;
        }
    }
}
