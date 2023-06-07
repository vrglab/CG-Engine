using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.ConsoleManager;
using Engine.ConsoleManager.Layering;
using Engine.LevelManagement;
using Engine.Renderer;
using Console = Engine.ConsoleManager.Console;

namespace Engine
{
    public class Application
    {
        public static Encoding ActivEncoding { get => Encoding.UTF8; }

        public static Renderer.Renderer Renderer { get; private set; }
        public static LevelManager LevelManager { get; private set; }

        public static void Start(string appName, Level startingLevel, int layerAmnt = 1)
        {
            System.Console.OutputEncoding = ActivEncoding;
            Renderer = new Renderer.Renderer();
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
