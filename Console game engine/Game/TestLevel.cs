using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Level_Management;

namespace Game
{
    public class TestLevel : Level
    {
        public override void Load()
        {
            base.Load();
            Console.WriteLine("Testing level");
        }
    }
}
