using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    abstract class GameRenderer
    {
        public abstract void render(GameSpace space);
    }
}
