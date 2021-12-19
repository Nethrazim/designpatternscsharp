using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternsCSharp.AbstractFactory;
using DesignPatternsCSharp.FactoryMethod;
using DesignPatternsCSharp.Singleton;

namespace DesignPatternsCSharp
{
    internal class Program
    {
        FactorySample ex1 = new FactorySample();
        AbstractFactorySample ex2 = new AbstractFactorySample();
        SingletonSample ex3 = new SingletonSample();
        static void Main(string[] args)
        {
            new Program().Run();
        }

        public void Run()
        {
            //ex1.Run();
            //ex2.Run();
            ex3.Run();
            Console.ReadKey();
        }
    }
}
