using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternsCSharp.FactoryMethod;

namespace DesignPatternsCSharp
{
    internal class Program
    {
        FactorySample ex1 = new FactorySample();
        static void Main(string[] args)
        {
            new Program().Run();
        }

        public void Run()
        {
            ex1.Run();
            Console.ReadKey();
        }
    }
}
