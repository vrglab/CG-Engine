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

        private Vector2 lastpos;
        private Vector2 Latelastpos;

        private bool render;

        public override void Load()
        {
            
        }

        public override void Awake()
        {
            lastpos = gameobject.transform.Position;
            Console.Write(Charachter, Color, lastpos);
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

            if (lastpos.x >= 0 && lastpos.x > System.Console.BufferWidth)
            {
                gameobject.transform.Position = new Vector2(0, gameobject.transform.Position.y);
                lastpos = gameobject.transform.Position;
            } else if (lastpos.y >= 0 && lastpos.y > System.Console.BufferHeight)
            {
                gameobject.transform.Position = new Vector2(gameobject.transform.Position.x, System.Console.BufferHeight);
                lastpos = gameobject.transform.Position;
            }

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
