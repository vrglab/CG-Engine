using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.ConsoleMannager;

namespace Engine
{
    public class Application
    {
        public static Encoding ActivEncoding { get => Encoding.UTF8; }

        public static void Start(string appName)
        {
            Console.OutputEncoding = ActivEncoding;
            Console.Title = appName;

            while (!C_Mannager.GetInput(ConsoleKey.Escape))
            {
                if (C_Mannager.GetInput(ConsoleKey.W))
                {
                    Console.WriteLine("w was pressed");
                }
            }
        }
    }
}
