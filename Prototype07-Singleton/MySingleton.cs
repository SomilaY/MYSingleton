using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype07_Singleton
{
    public sealed class MySingleton
    {
        private static MySingleton instance = null;
        private static readonly object padlock = new object();

        private MySingleton()
        {
            // Private constructor to prevent external instantiation
        }

        public static MySingleton Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new MySingleton();
                    }
                    return instance;
                }
            }
        }

        public void DoSomething()
        {
            // Method of the Singleton class
            Console.WriteLine("Doing something...");
            Console.ReadLine();
        }
    }

}
