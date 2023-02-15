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

        private Vector2 lastpos = new Vector2(1245677889, 1245677889);
        private Vector2 Latelastpos;

        private bool render;

        public override void Load()
        {
            Console.Write(Charachter, Color, gameobject.transform.Position);
        }

        public override void Awake()
        {
        }

        public override void Update()
        {
            if (gameobject.transform.Position != lastpos)
            {
                Latelastpos = gameobject.transform.Position;
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
                Console.Replace(Charachter, Color, Latelastpos -1, lastpos);
            }
        }
    }
}
