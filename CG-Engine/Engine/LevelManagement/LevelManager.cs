using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace Engine.LevelManagement
{
    public class LevelManager
    {
        private static Level curentlevel;

        public LevelManager(Level curentLevel)
        {
            SetLevel(curentLevel);
        }

        public void SetLevel(Level scene)
        {
            if (curentlevel != null)
            {
                curentlevel.Unload();
                curentlevel = scene;
                curentlevel.Load();
                curentlevel.Awake();
            }
            else
            {
                curentlevel = scene;
                curentlevel.Load();
                curentlevel.Awake();
            }
        }

        public Level GetCurentLevel()
        {
            return curentlevel;
        }
    }
}
