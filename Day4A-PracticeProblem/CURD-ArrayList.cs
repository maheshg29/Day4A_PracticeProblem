using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4A_PracticeProblem
{
    class CURD_ArrayList
    {
        public static void ArrayList()
        {
            // create an ArrayList
            ArrayList fruits = new ArrayList();

            // add elements to the ArrayList
            fruits.Add("apple");
            fruits.Add("banana");
            fruits.Add("orange");

            // read elements from the ArrayList
            Console.WriteLine("The first fruit is " + fruits[0]);
            Console.WriteLine("The second fruit is " + fruits[1]);
            Console.WriteLine("The third fruit is " + fruits[2]);

            // update an element in the ArrayList
            fruits[1] = "kiwi";
            Console.WriteLine("The second fruit is now " + fruits[1]);

            // remove an element from the ArrayList
            fruits.Remove("orange");
            Console.WriteLine("The ArrayList now contains " + fruits.Count + " elements");

            // clear all elements from the ArrayList
            fruits.Clear();
            Console.WriteLine("The ArrayList now contains " + fruits.Count + " elements");

            // wait for user input
            Console.ReadLine();
        }
    }
}
 
