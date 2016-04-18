using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Diagnostics.Eventing;

namespace DictionaryCollection
{
    class Program
    {
        static void Main(string[] args)
        {

            Hashtable lookup = new Hashtable();
            lookup["0"] = "Zero";
            lookup["1"] = "One";
            lookup["2"] = "Two";
            lookup["3"] = "Three";
            lookup["4"] = "Four";
            lookup["5"] = "Five";
            lookup["6"] = "Six";
            lookup["7"] = "Seven";
            lookup["8"] = "Eight";
            lookup["9"] = "Nine";

            string number = "valami";

            while (number.Length > 0)
            {
                Console.WriteLine("Write a number in 0-10 beetwen:");
                 number = Console.ReadLine();

                if (lookup.ContainsKey(number))
                {
                    Console.WriteLine(lookup[number]);
                }
            }

            

            Console.ReadLine();

        }
    }
}
