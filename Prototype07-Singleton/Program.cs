using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype07_Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MySingleton instance = MySingleton.Instance;

            // Call a method on the Singleton instance
            instance.DoSomething();

        }
    }
}
