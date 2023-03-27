using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4A_PracticeProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Day 4A Practice Problem");
            Console.WriteLine("Select any one Option for Opreration");
            Console.WriteLine("\n 1. For Nlog Example \n 2. CURD operation in ArrayList collection \n 3. CURD operation in Dictionary");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    ArithmaticOperation.Sum(20, 50);
                    break;
                case 2:
                    CURD_ArrayList.ArrayList();
                    break;
                case 3:
                    Dictionary.CURDoperationINDictionary();
                    break;

            }
        }
    }
}
