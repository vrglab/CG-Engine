using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.ConsoleManager
{
    public class Console
    {
        public static bool GetInput(ConsoleKey key)
        {
            return (System.Console.KeyAvailable && System.Console.ReadKey(true).Key == key);
        } 

        //TODO: implement proper unicode drawing to the console
        public static void Write(int code)
        {
            char charcater = (char)code;
            System.Console.Write(charcater);
        }

        public static void Write(int code, ConsoleColor color)
        {
            char charcater = (char)code;
            System.Console.ForegroundColor = color;
            System.Console.Write(charcater);
            System.Console.ForegroundColor = Application.DefaultColor;
        }
    }
}
