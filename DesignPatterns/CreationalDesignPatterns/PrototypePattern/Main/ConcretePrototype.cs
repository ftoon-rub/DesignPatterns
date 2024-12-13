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
        private string gender { get; set; }

        public ConcretePrototype()
        {
            
        }
        private ConcretePrototype(ConcretePrototype prototype)
        {
            age = prototype.age;
            name = prototype.name;
            skills = new List<string>(prototype.skills);
            gender = prototype.gender;
        }
        public IPrototype Clone()
        {
            return new ConcretePrototype(this);
        }

        public IPrototype ShallowClone()
        {
            return (IPrototype)this.MemberwiseClone();
        }
        public void setGender(string gender)
        {
            this.gender = gender;
        }
        public override string ToString()
        {
            return $"name: {name}, age: {age}, gender: {gender}, skills: {string.Join(",",skills)}";
        }
    }
}
