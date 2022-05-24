using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionHandsOn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CollectionDemo collectionDemo = new CollectionDemo();
            collectionDemo.ArrayConcept();
            Console.WriteLine("--------------------------------------");
            collectionDemo.IceCreameFlavors();  
            Console.ReadKey();  
        }
    }
}
