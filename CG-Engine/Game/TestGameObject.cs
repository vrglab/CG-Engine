using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Mathmatics;
using Engine.Object;
using Engine.Object.PremadeComponents;
using Console = Engine.ConsoleManager.Console;

namespace Game
{
    public class TestGameObject : GameObject
    {
        public override void Load()
        {
            base.Load();
            CharacterRenderer cr = new CharacterRenderer
            {
                gameobject = this
            };
            cr.Layer = 0;
            cr.OrderInLayer = 1;
            AddComponent(cr);

            /*AddComponent(new AudioPlayer("Audio file")
            {
                this gameobject line is required when initiating a component like this
                gameobject = this
            });*/
        }

        public override void Update()
        {
            base.Update();
            if (Console.GetInput(ConsoleKey.D))
            {
                transform.Position = new Vector2(transform.Position.x + 1, transform.Position.y);
            }
            if (Console.GetInput(ConsoleKey.A))
            {
                transform.Position = new Vector2(transform.Position.x - 1, transform.Position.y);
            }

            if (Console.GetInput(ConsoleKey.W))
            {
                transform.Position = new Vector2(transform.Position.x, transform.Position.y - 1);
            }
            if (Console.GetInput(ConsoleKey.S))
            {
                transform.Position = new Vector2(transform.Position.x, transform.Position.y + 1);
            }
        }
    }
}
