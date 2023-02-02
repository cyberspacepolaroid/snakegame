using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    abstract class GameInput 
    {
        protected GameKeys key;
        public abstract Task<GameKeys> listen();

        public GameKeys getInput() {
            return this.key;
        }
    }
}
