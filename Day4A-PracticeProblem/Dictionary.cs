using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4A_PracticeProblem
{
    public class Dictionary
    {
        public static void CURDoperationINDictionary()
        {
            // create a Dictionary
            Dictionary<string, int> ages = new Dictionary<string, int>();

            // add elements to the Dictionary
            ages.Add("Alice", 25);
            ages.Add("Bob", 30);
            ages.Add("Charlie", 35);

            // read elements from the Dictionary
            Console.WriteLine("Alice is " + ages["Alice"] + " years old");
            Console.WriteLine("Bob is " + ages["Bob"] + " years old");
            Console.WriteLine("Charlie is " + ages["Charlie"] + " years old");

            // update an element in the Dictionary
            ages["Bob"] = 31;
            Console.WriteLine("Bob is now " + ages["Bob"] + " years old");

            // remove an element from the Dictionary
            ages.Remove("Charlie");
            Console.WriteLine("The Dictionary now contains " + ages.Count + " elements");

            // clear all elements from the Dictionary
            ages.Clear();
            Console.WriteLine("The Dictionary now contains " + ages.Count + " elements");

            // wait for user input
            Console.ReadLine();
        }
    }
}
