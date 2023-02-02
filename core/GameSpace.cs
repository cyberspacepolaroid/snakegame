using System.Collections.Generic;

namespace Game
{
    abstract class GameSpace
    {
        protected Dictionary<string,GameObject> gameObjects = new Dictionary<string, GameObject>();
        protected Position spaceVolume;
        protected GameKeys input;
        public GameSpace() { }

        public abstract GameSpace update();

        public virtual void init() { }

        public virtual void destroy() { }

        public void add(string key,GameObject gameObject)
        {
            this.gameObjects.Add(key,gameObject);
        }

        public GameObject get(string key)
        {
            GameObject obj;
            this.gameObjects.TryGetValue(key, out obj);
            return obj;
        }

        public void remove(string key)
        {
            this.gameObjects.Remove(key);
        }

        public Dictionary<string, GameObject>.ValueCollection getObjects()
        {
            Dictionary<string, GameObject>.ValueCollection o = gameObjects.Values;
            return o;
        }

        public virtual void setInput(GameKeys key)
        {
            this.input = key;
        }

        public virtual GameKeys getInput()
        {
            return this.input;
        }
    }
}
