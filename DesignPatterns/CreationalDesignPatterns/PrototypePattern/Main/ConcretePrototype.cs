using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalDesignPatterns.PrototypePattern.Main
{
    public class ConcretePrototype : IPrototype
    {
        public int age { get; set; }
        public string name { get; set; }
        public List<string> skills { get; set; }
        public ConcretePrototype()
        {
            
        }
        private ConcretePrototype(ConcretePrototype prototype)
        {
            age = prototype.age;
            name = prototype.name;
            skills = new List<string>(prototype.skills);
        }
        public IPrototype Clone()
        {
            return new ConcretePrototype(this);
        }

        public IPrototype ShallowClone()
        {
            return (IPrototype)this.MemberwiseClone();
        }

        public override string ToString()
        {
            return $"name: {name}, age: {age}, skills: {string.Join(",",skills)}";
        }
    }
}
