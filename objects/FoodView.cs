using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class FoodView : GameView
    {
        private string food = "*";
        public override string ToString()
        {
            return this.food;
        }
    }
}
