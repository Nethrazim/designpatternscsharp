using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternsCSharp.AbstractFactory;
using DesignPatternsCSharp.FactoryMethod;
using DesignPatternsCSharp.Singleton;
using DesignPatternsCSharp.Builder;
using DesignPatternsCSharp.Prototype;
using DesignPatternsCSharp.Adapter;
using DesignPatternsCSharp.Composite;
using DesignPatternsCSharp.Decorator;
using DesignPatternsCSharp.Facade;
using DesignPatternsCSharp.Mediator;
using DesignPatternsCSharp.Observer;
using DesignPatternsCSharp.ChainOfResponsability;
using DesignPatternsCSharp.Proxy;

namespace DesignPatternsCSharp
{
    public class Program
    {
        FactorySample ex1 = new FactorySample();
        AbstractFactorySample ex2 = new AbstractFactorySample();
        SingletonSample ex3 = new SingletonSample();
        BuilderSample ex4 = new BuilderSample();
        PrototypeSample ex5 = new PrototypeSample();
        AdapterSample ex6 = new AdapterSample();    
        CompositeSample ex7 = new CompositeSample();
        DecoratorSample ex8 = new DecoratorSample();
        FacadeSample ex9 = new FacadeSample();
        MediatorSample ex10 = new MediatorSample();
        ObserverSample ex11 = new ObserverSample();
        ChainOfResponsabilitySample ex12 = new ChainOfResponsabilitySample();
        ProxySample ex13 = new ProxySample();
        static void Main(string[] args)
        {
            new Program().Run();
        }

        public void Run()
        {
            //ex1.Run();
            //ex2.Run();
            //ex3.Run();
            //ex4.Run();
            //ex5.Run();
            //ex6.Run();
            //ex7.Run();
            ex8.Run();
            //ex9.Run();
            //ex10.Run();
            //ex11.Run();
            //ex12.Run();
            //ex13.Run();

            Console.ReadKey();
        }
    }
}
