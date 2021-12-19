using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCSharp.Singleton
{
    public class SingletonClass
    {
        private static SingletonClass singleInstance = null; // new SingletonClass() eager initialization
        private SingletonClass() {
            throw new NotImplementedException("Use getInstance not reflection!");
        }
        
        [MethodImpl(MethodImplOptions.Synchronized)]
        public static SingletonClass getInstance()
        {
            if (singleInstance == null)
            {
                singleInstance = new SingletonClass(); // lazy initialization
            }
                
            return singleInstance;
        }
    }
    internal class SingletonSample
    {
        public void Run()
        {
            Console.WriteLine(SingletonClass.getInstance().GetHashCode());
            Console.Write(SingletonClass.getInstance().GetHashCode());
        }
    }
}
