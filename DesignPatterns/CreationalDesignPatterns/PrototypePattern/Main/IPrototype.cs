using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalDesignPatterns.PrototypePattern.Main
{
    public interface IPrototype
    {
        IPrototype Clone();
        /// <summary>
        /// reference to the same ref type properties on the cloned object
        /// </summary>
        /// <returns></returns>
        IPrototype ShallowClone();

    }
}
