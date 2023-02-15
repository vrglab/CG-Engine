using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Object
{
    public abstract class Component : Object
    {
        public GameObject gameObject { get; private set; }

        protected Component(GameObject parentOBJ)
        {
            gameObject = parentOBJ;
        }

        public abstract void Load();
        public abstract void Awake();
        public abstract void Update();
        public abstract void Render();
    }
}
