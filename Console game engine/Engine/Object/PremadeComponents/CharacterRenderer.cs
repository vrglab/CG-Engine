using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Mathmatics;
using Console = Engine.ConsoleManager.Console;

namespace Engine.Object.PremadeComponents
{
    public class CharacterRenderer : Component
    {
        public int Charachter { get; set; } = 65533;
        public ConsoleColor Color { get; set; } = ConsoleColor.White;

        private Vector2 lastpos = new Vector2(0, 0);
        private Vector2 Latelastpos;

        private bool render;

        public override void Load()
        {
            
        }

        public override void Awake()
        {
            Console.Write(Charachter, Color, Vector2.Zero);
        }

        public override void Update()
        {
            if (gameobject.transform.Position != lastpos)
            {
                Latelastpos = lastpos;
                render = true;
            }
            else
            {
                render = false;
            }
            lastpos = gameobject.transform.Position;
        }

        public override void Render()
        {
            if (render)
            {
                Console.Replace(Charachter, Color, Latelastpos, lastpos);
            }
        }
    }
}
