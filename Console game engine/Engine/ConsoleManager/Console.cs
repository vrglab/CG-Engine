using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Mathmatics;

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
            System.Console.ResetColor();
        }


        public static void Write(int code, Vector2 writAt)
        {
            char charcater = (char)code;
            System.Console.SetCursorPosition(writAt.x, writAt.y);
            System.Console.Write(charcater);
        }

        public static void Write(int code, ConsoleColor color, Vector2 writAt)
        {
            char charcater = (char)code;
            System.Console.SetCursorPosition(writAt.x, writAt.y);
            System.Console.ForegroundColor = color;
            System.Console.Write(charcater);
            System.Console.ResetColor();
        }


        public static void WriteLine(int code)
        {
            char charcater = (char)code;
            System.Console.WriteLine(charcater);
        }

        public static void WriteLine(int code, ConsoleColor color)
        {
            char charcater = (char)code;
            System.Console.ForegroundColor = color;
            System.Console.WriteLine(charcater);
            System.Console.ResetColor();
        }

        public static void WriteLine(int code, Vector2 writAt)
        {
            char charcater = (char)code;
            System.Console.SetCursorPosition(writAt.x, writAt.y);
            System.Console.WriteLine(charcater);
        }

        public static void WriteLine(int code, ConsoleColor color, Vector2 writAt)
        {
            char charcater = (char)code;
            System.Console.SetCursorPosition(writAt.x, writAt.y);
            System.Console.ForegroundColor = color;
            System.Console.WriteLine(charcater);
            System.Console.ResetColor();
        }

        public static void Remove(Vector2 charAt)
        {
            System.Console.SetCursorPosition(charAt.x, charAt.y);
            System.Console.WriteLine(" ");
        }
    }
}
