
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Game
{
    abstract class Game
    {
        protected GameSpace currentSpace;
        protected List<GameSpace> spaces;
        protected GameRenderer renderer;
        protected GameInput input;
        protected bool isStarted = false;
        
        public Game() { }

        public abstract void init();

        public virtual void start() {
            this.isStarted = true;
            Task<GameKeys> task = this.input.listen();
            while (this.isStarted)
            {
                this.currentSpace.setInput(input.getInput());
                this.currentSpace =  this.currentSpace.update();
                this.renderer.render(this.currentSpace);
            }
        }

        public virtual void stop() {
            this.isStarted = false;
        }
    }
}
