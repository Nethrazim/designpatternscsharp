using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCSharp.Prototype
{
    public abstract class Prototype
    {
        string id;
        public Prototype(string id)
        {
            this.id = id;
        }

        public string Id
        {
            get { return id; }
        }

        public abstract Prototype Clone();
    }

    public class ConcretePrototype1 : Prototype
    {
        public ConcretePrototype1(string id) : base(id)
        {
            
        }

        public override Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();
        }
    }

    internal class PrototypeSample
    {
        public void Run()
        {
            ConcretePrototype1 p1 = new ConcretePrototype1("I");
            ConcretePrototype1 c1 = (ConcretePrototype1)p1.Clone();
            Console.WriteLine($"Cloned: {c1.Id}");
        }
    }
}
