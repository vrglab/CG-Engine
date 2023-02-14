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

        //TODO: implement proper unicode drawing to the console
        public static void Write(int code)
        {
            char charcater = (char)code;
            Console.Write(charcater);
        }

        public static void Write(int code, ConsoleColor color)
        {
            char charcater = (char)code;
            Console.ForegroundColor = color;
            Console.Write(charcater);
            Console.ForegroundColor = Application.DefaultColor;
        }
    }
}
