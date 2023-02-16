using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.LevelManagement;
using Engine.Mathmatics;
using Console = Engine.ConsoleManager.Console;

namespace Game
{
    public class TestLevel : Level
    {

        public TestLevel()
        {
            var obj = new TestGameObject();
            obj.transform.Position = new Vector2(6, 8);
            AddGameObject(obj);
        }
    }
}
