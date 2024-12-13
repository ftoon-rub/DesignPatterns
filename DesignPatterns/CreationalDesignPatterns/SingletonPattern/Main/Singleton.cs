using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalDesignPatterns.SingletonPattern.Main
{
    public class Singleton
    {
        private static Singleton _instance;
        private Singleton() { }
        public static Singleton Instance 
        {
            get
            {
                // Multiple threads may enter here simultaneously
                if (_instance == null)
                    _instance = new Singleton();
                return _instance;
            }
        }
    }
}
