using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalDesignPatterns.FactoryMethodPattern.Main
{
    public abstract class ProductsCreator
    {
        public void Render()
        {
            CreateProduct().DoSomthing();
        }

        protected abstract IProduct CreateProduct();
    }
}
