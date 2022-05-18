using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCSharp.FactoryMethod
{
    public abstract class A
    {
        public virtual string FirstName { get; set; } = "Default First Name";
        public abstract void SpellFirstName();
    }

    class AB : A 
    { 
        public override string FirstName { get; set; } = "AB FirstName";

        public override void SpellFirstName()
        {
            Console.WriteLine($"{FirstName} is spelled in the AB way;");
        }
    }
    class AA : A 
    { 
        public override string FirstName { get; set; } = "AA FirstName";

        public override void SpellFirstName()
        {
            Console.WriteLine($"{FirstName} is spelled in the AA way");
        }
    }

    public class AFactory
    {
        public A GetA(string param)
        {
            if (param == "A")
                return new AA();
            
            if (param == "B")
                return new AB();

            return new AA(); //default object
        }
    }

    class FactorySample
    {
        public void Run()
        {
            AFactory aFactory = new AFactory();
            A aa = aFactory.GetA("A");
            A ab = aFactory.GetA("B");
            A a = aFactory.GetA("C");

            aa.SpellFirstName();
            ab.SpellFirstName();
        }
    }
}
