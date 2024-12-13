using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalDesignPatterns.SingletonPattern.Main
{
    public class SingletonLazyThreadSafe
    {
        private static readonly Lazy<SingletonLazyThreadSafe> _instance = new(() => new SingletonLazyThreadSafe());
        public static SingletonLazyThreadSafe Instance => _instance.Value;
        private SingletonLazyThreadSafe() { }
    }
}
