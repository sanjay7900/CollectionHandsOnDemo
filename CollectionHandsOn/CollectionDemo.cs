using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CollectionHandsOn
{
    public class CollectionDemo
    {
       private int[] values = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
       private string[] names = new string[4] { "Tim", "Martin", "Nikki", "Sara" };
       private bool[] TureFalse = new bool[10]
        {
                true,false,true,false,true,false,true,false,true,false
        };
        public void ArrayConcept()
        {
            Console.WriteLine("this is the Vales Array");
            for(int i = 0; i < values.Length; i++)
            {
                Console.WriteLine(values[i]);
            }
            Console.WriteLine("this the names Array");
            for(int j = 0; j < names.Length; j++)
            {
                Console.WriteLine(names[j]);
            }
            Console.WriteLine("this is the Alternate Ture False");
            for(int i = 0; i < TureFalse.Length; i++)
            {
                Console.WriteLine(TureFalse[i]);    
            }
            
        }

        public void IceCreameFlavors()
        {
            List<string> iceFlavors=new List<string>();
            iceFlavors.Add("Vanilla");
            iceFlavors.Add("Chocolate");
            iceFlavors.Add("Chocolate Chip");
            iceFlavors.Add("Butter Pecan");
            iceFlavors.Add("Chocolate Chip Cookie Dough");
            iceFlavors.Add("Eggnog");
            iceFlavors.Add("Strawberry.");
            Console.WriteLine("This List Containt the these ice creame Flavors");
            foreach(string name in iceFlavors)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("The length of Ice Flavors List: {0}",iceFlavors.Count);
            
            Console.WriteLine("This is The third flavors: {0}", iceFlavors[2]);
            Console.WriteLine("Remove the Third Flavors");
            iceFlavors.RemoveAt(2);
            Console.WriteLine("The Length of the flavors List After Removing the third flavors");
            Console.WriteLine("length:{0}", iceFlavors.Count);



        }

    }
}
