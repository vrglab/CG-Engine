using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Object;
using Console = Engine.ConsoleManager.Console;

namespace Engine.LevelManagement
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
            Application.LayerManager.Render();
        }

        public virtual void Unload()
        {
            
        }

        public t AddGameObject<t>() where t : GameObject, new()
        {
            var Refrenace = new t();
            Refrenace.Load();
            RegisteredGameObjects.Add(Refrenace);
            Refrenace.Awake();
            return Refrenace;
        }

        public t AddGameObject<t>(t Refrenace) where t : GameObject
        {
            Refrenace.Load();
            RegisteredGameObjects.Add(Refrenace);
            Refrenace.Awake();
            return Refrenace;
        }

        public t? GetGameObject<t>() where t : GameObject
        {
            foreach (var item in RegisteredGameObjects)
            {
                if (item is t)
                {
                    return item as t;
                }
            }
            return default;
        }

        public t[] GetAllGameObject<t>() where t : GameObject
        {
            List<t> list = new List<t>();
            foreach (var item in RegisteredGameObjects)
            {
                if (item is t)
                {
                    list.Add(item as t);
                }
            }
            return list.ToArray();
        }

        public void RemoveGameObject<t>() where t : GameObject
        {
            GameObject removed = null;
            foreach (var item in RegisteredGameObjects)
            {
                if (item is t)
                {
                    removed = item;
                }
            }
            RegisteredGameObjects.Remove(removed);
        }
    }
}

