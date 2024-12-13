using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalDesignPatterns.SingletonPattern.Main
{
    public class SingletonLockThreadSafe
    {
        private static SingletonLockThreadSafe _instance;
        private static readonly object _lock = new object();
        private SingletonLockThreadSafe() { }
        public static SingletonLockThreadSafe Instance 
        {
            get
            {
                //Reduces the performance overhead of locking every time.
                if (_instance == null)
                {
                    // Ensures only one thread can enter this block at a time
                    lock (_lock)
                    {
                        if(_instance == null)
                            _instance = new SingletonLockThreadSafe();
                    }
                }
                return _instance;
            }
        }
    }
}
