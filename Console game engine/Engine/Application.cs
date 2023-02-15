using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.ConsoleManager;
using Engine.LevelManagement;
using Console = Engine.ConsoleManager.Console;

namespace Engine
{
    public class Application
    {
        public static Encoding ActivEncoding { get => Encoding.UTF8; }

        public static LevelManager LevelManager { get; private set; }

        public static void Start(string appName, Level startingLevel)
        {
            System.Console.OutputEncoding = ActivEncoding;
            LevelManager = new LevelManager(startingLevel);
            
            while (!Console.GetInput(ConsoleKey.Escape))
            {
                System.Console.Title = appName;

                LevelManager.GetCurentLevel().Update();
                LevelManager.GetCurentLevel().Render();
            }
            LevelManager.GetCurentLevel().Unload();
        }
    }
}
