using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Engine.Mathmatics;

namespace Engine.ConsoleManager
{
    public class Console
    {

        //UTF-16 based char writers
        
        public static void Write(int code)
        {
            char charcater = (char)code;
            SetCursorPos(Vector2.Zero);
            System.Console.Write(charcater);
           
        }

        public static void Write(int code, ConsoleColor color)
        {
            char charcater = (char)code;
            SetCursorPos(Vector2.Zero);
            System.Console.ForegroundColor = color;
            System.Console.Write(charcater);
            System.Console.ResetColor();
            
        }

        public static void Write(int code, Vector2 writAt)
        {
            char charcater = (char)code;
            SetCursorPos(writAt);
            System.Console.Write(charcater);
           
        }

        public static void Write(int code, ConsoleColor color, Vector2 writAt)
        {
            char charcater = (char)code;
            SetCursorPos(writAt);
            System.Console.ForegroundColor = color;
            System.Console.Write(charcater);
            System.Console.ResetColor();
            
        }
        
        public static void WriteLine(int code)
        {
            char charcater = (char)code;
            SetCursorPos(Vector2.Zero);
            System.Console.WriteLine(charcater);
        }

        public static void WriteLine(int code, ConsoleColor color)
        {
            char charcater = (char)code;
            SetCursorPos(Vector2.Zero);
            System.Console.ForegroundColor = color;
            System.Console.WriteLine(charcater);
            System.Console.ResetColor();
        }

        public static void WriteLine(int code, Vector2 writAt)
        {
            char charcater = (char)code;
            SetCursorPos(writAt);
            System.Console.WriteLine(charcater);
        }

        public static void WriteLine(int code, ConsoleColor color, Vector2 writAt)
        {
            char charcater = (char)code;
            SetCursorPos(writAt);
            System.Console.ForegroundColor = color;
            System.Console.WriteLine(charcater);
            System.Console.ResetColor();
        }


        public static void Write(int code, int layer)
        {
            char charcater = (char)code;
            SetCursorPos(Vector2.Zero);
            System.Console.Write(charcater);
        }

        public static void Write(int code, ConsoleColor color, int layer)
        {
            char charcater = (char)code;
            SetCursorPos(Vector2.Zero);
            System.Console.ForegroundColor = color;
            System.Console.Write(charcater);
            System.Console.ResetColor();
        }

        public static void Write(int code, Vector2 writAt, int layer)
        {
            char charcater = (char)code;
            SetCursorPos(writAt);
            System.Console.Write(charcater);
        }

        public static void Write(int code, ConsoleColor color, Vector2 writAt, int layer)
        {
            char charcater = (char)code;
            SetCursorPos(writAt);
            System.Console.ForegroundColor = color;
            System.Console.Write(charcater);
            System.Console.ResetColor();
        }

        public static void WriteLine(int code, int layer)
        {
            char charcater = (char)code;
            SetCursorPos(Vector2.Zero);
            System.Console.WriteLine(charcater);
        }

        public static void WriteLine(int code, ConsoleColor color, int layer)
        {
            char charcater = (char)code;
            SetCursorPos(Vector2.Zero);
            System.Console.ForegroundColor = color;
            System.Console.WriteLine(charcater);
            System.Console.ResetColor();
        }

        public static void WriteLine(int code, Vector2 writAt, int layer)
        {
            char charcater = (char)code;
            SetCursorPos(writAt);
            System.Console.WriteLine(charcater);
        }

        public static void WriteLine(int code, ConsoleColor color, Vector2 writAt, int layer)
        {
            char charcater = (char)code;
            SetCursorPos(writAt);
            System.Console.ForegroundColor = color;
            System.Console.WriteLine(charcater);
            System.Console.ResetColor();
        }


        public static void UnLoggedManualWrite(int code, ConsoleColor color, Vector2 writAt)
        {
            char charcater = (char)code;
            SetCursorPos(writAt);
            System.Console.ForegroundColor = color;
            System.Console.Write(charcater);
            System.Console.ResetColor();
        }


        public static void Replace(int Char, Vector2 charAt)
        {
            Remove(charAt);
            WriteLine(Char, charAt);
        }

        public static void Replace(int Char, ConsoleColor color, Vector2 charAt)
        {
            Remove(charAt);
            WriteLine(Char, color, charAt);
        }

        public static void Replace(int Char, ConsoleColor color, Vector2 RemovecharAt, Vector2 addCharAt)
        {
            Remove(RemovecharAt);
            WriteLine(Char, color, addCharAt);
        }

        public static void Replace(int Char, Vector2 RemovecharAt, Vector2 addCharAt)
        {
            Remove(RemovecharAt);
            WriteLine(Char, addCharAt);
        }


        //Full text writers

        public static void Write(string code)
        {
            System.Console.Write(code);
        }

        public static void Write(string code, ConsoleColor color)
        {
            System.Console.ForegroundColor = color;
            System.Console.Write(code);
            System.Console.ResetColor();
        }

        public static void Write(string code, Vector2 writAt)
        {
            SetCursorPos(writAt);
            System.Console.Write(code);
        }

        public static void Write(string code, ConsoleColor color, Vector2 writAt)
        {
            SetCursorPos(writAt);
            System.Console.ForegroundColor = color;
            System.Console.Write(code);
            System.Console.ResetColor();
        }

        public static void WriteLine(string code)
        {
            System.Console.WriteLine(code);
        }

        public static void WriteLine(string code, ConsoleColor color)
        {
            System.Console.ForegroundColor = color;
            System.Console.WriteLine(code);
            System.Console.ResetColor();
        }

        public static void WriteLine(string code, Vector2 writAt)
        {
            SetCursorPos(writAt);
            System.Console.WriteLine(code);
        }

        public static void WriteLine(string code, ConsoleColor color, Vector2 writAt)
        {
            SetCursorPos(writAt);
            System.Console.ForegroundColor = color;
            System.Console.WriteLine(code);
            System.Console.ResetColor();
        }

        public static void Replace(string Char, Vector2 charAt)
        {
            Remove(charAt);
            WriteLine(Char, charAt);
        }

        public static void Replace(string Char, ConsoleColor color, Vector2 charAt)
        {
            Remove(charAt);
            WriteLine(Char, color, charAt);
        }

        public static void Replace(string Char, ConsoleColor color, Vector2 RemovecharAt, Vector2 addCharAt)
        {
            Remove(RemovecharAt);
            WriteLine(Char, color, addCharAt);
        }

        public static void Replace(string Char, Vector2 RemovecharAt, Vector2 addCharAt)
        {
            Remove(RemovecharAt);
            WriteLine(Char, addCharAt);
        }

        //Utility

        public static void Remove(Vector2 charAt, int layer = 0)
        {
            SetCursorPos(charAt);
            System.Console.WriteLine(" ");
        }

        public static bool GetInput(ConsoleKey key)
        {
            return (System.Console.KeyAvailable && System.Console.ReadKey(true).Key == key);
        }

        private static void SetCursorPos(Vector2 pos)
        {
            System.Console.SetCursorPosition((pos.x >= 0 && pos.x < System.Console.BufferWidth) ? pos.x : 0, (pos.y >= 0 && pos.y < System.Console.BufferHeight) ? pos.y : 0);
        }
    }
}
