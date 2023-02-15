using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Object
{
    public abstract class Component : Object
    {
        public GameObject? gameobject { get; init; }

        public abstract void Load();
        public abstract void Awake();
        public abstract void Update();
        public abstract void Render();
    }
}
