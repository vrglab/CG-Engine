using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.EventSystem
{
    public class EngineEvent
    {
        public delegate void Func();
        private Dictionary<int, Func> Listeners = new Dictionary<int, Func>();

        public void Invoke()
        {
            foreach (var listner in Listeners)
            {
                listner.Value();
            }
        }

        public void AddListner(object listner, Func func)
        {
            int hashcode = listner.GetHashCode();
            if (!Listeners.ContainsKey(hashcode))
            {
                Listeners.Add(hashcode, func);
            }
        }

        public void RemoveListner(object listner)
        {
            int hashcode = listner.GetHashCode();
            if (Listeners.ContainsKey(hashcode))
            {
                Listeners.Remove(hashcode);
            }
        }
    }
}
