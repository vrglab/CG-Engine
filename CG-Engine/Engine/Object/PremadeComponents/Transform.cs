using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Mathmatics;

namespace Engine.Object.PremadeComponents
{
    public class Transform : Component
    {
        public Vector2 Position { get; set; }

        public Transform()
        {
            Position = Vector2.Zero;
        }

        public override void Load()
        {
        }

        public override void Awake()
        {
        }

        public override void Update()
        {
        }

        public override void Render()
        {
        }
    }
}
