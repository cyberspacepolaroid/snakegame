using System.Collections.Generic;

namespace Game
{
    abstract class GameObject
    {
        public string id;
        protected GameView view;
        protected GameObject parent;
        protected List<GameObject> childs = new List<GameObject>();
        public Position position;
        protected GameSpace gameSpace;
        public bool isVisible = true;
        public abstract void update();

        public GameView getView()
        {
            return this.view;
        }

        public void setView(GameView view) {
            this.view = view;
        }

        public void addChild(GameObject obj)
        {
            this.childs.Add(obj);
        }

        public List<GameObject> getChild()
        {
            return this.childs;
        }

        public void setSpace(GameSpace space)
        {
            this.gameSpace = space;
        }

        public void setParent(GameObject obj)
        {
            this.parent = obj;
        }

        public GameObject getParent()
        {
            return this.parent;
        }
    }
}
