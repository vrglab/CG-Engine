using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.ConsoleManager;

namespace Engine
{
    public class Application
    {
        public static Encoding ActivEncoding { get => Encoding.UTF8; }
        public static ConsoleColor DefaultColor { get => ConsoleColor.White; }

        public static void Start(string appName)
        {
            Console.OutputEncoding = ActivEncoding;
            
            while (!C_Manager.GetInput(ConsoleKey.Escape))
            {
                Console.Title = appName;
                //TODO: remove this code as is test code
                if (C_Manager.GetInput(ConsoleKey.W))
                {
                    Console.WriteLine("w was pressed");
                }
            }
        }
    }
}
