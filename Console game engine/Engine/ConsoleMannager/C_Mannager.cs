using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.ConsoleMannager
{
    public class C_Mannager
    {

        public static bool GetInput(ConsoleKey key)
        {
            return (Console.KeyAvailable && Console.ReadKey(true).Key == key);
        } 
    }
}
