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
    public class TestGameObject2 : GameObject
    {
        public override void Load()
        {
            base.Load();
            CharacterRenderer cr = new CharacterRenderer
            {
                gameobject = this
            };
            cr.Charachter = 1244;
            cr.Color = ConsoleColor.DarkBlue;
            cr.Layer= 0;
            cr.OrderInLayer = 0;
            cr.IsStationaryObject = true;
            AddComponent(cr);
         }
    }
}
