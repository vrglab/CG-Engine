using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Object;

namespace Engine.Level_Management
{
    public abstract class Level
    {
        public string Name { get; protected set; }

        private List<GameObject> RegisteredGameObjects = new List<GameObject>();

        public virtual void Load()
        {
            foreach (var obj in RegisteredGameObjects)
            {
                obj.Load();
            }
        }

        public virtual void Awake()
        {
            foreach (var obj in RegisteredGameObjects)
            {
                obj.Awake();
            }
        }

        public virtual void Update()
        {
            foreach (var obj in RegisteredGameObjects)
            {
                obj.Update();
            }
        }

        public virtual void Render()
        {
            foreach (var obj in RegisteredGameObjects)
            {
                obj.Render();
            }
        }

        public virtual void Unload()
        {
            
        }

        protected void RegisterGameObject(GameObject gameObject)
        {
            if (!RegisteredGameObjects.Contains(gameObject))
            {
                RegisteredGameObjects.Add(gameObject);
            }
        }
    }
}
