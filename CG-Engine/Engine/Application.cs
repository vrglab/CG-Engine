using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.ConsoleManager;
using Engine.ConsoleManager.Layering;
using Engine.LevelManagement;
using Console = Engine.ConsoleManager.Console;

namespace Engine
{
    public class Application
    {
        public static Encoding ActivEncoding { get => Encoding.UTF8; }

        public static LevelManager LevelManager { get; private set; }

        public static LayerManager LayerManager { get; private set; }

        public static void Start(string appName, Level startingLevel, int layerAmnt = 1)
        {
            System.Console.OutputEncoding = ActivEncoding;
            LayerManager = new LayerManager(layerAmnt);
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
