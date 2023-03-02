using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine;

namespace Game
{
    internal class Main_Class
    {

        public static void Main(string[] args)
        {
            Application.Start("Testing app", new TestLevel(),3);
        }
    }
}
