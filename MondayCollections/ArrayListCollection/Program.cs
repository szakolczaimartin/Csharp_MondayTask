using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ArrayListCollection
{
    class Program
    {
        static void Main(string[] args)
        {

            ArrayList myList = new ArrayList();
            string data = "valami";


            while (data.Length > 0)
            {
                Console.WriteLine("Write something or push the enter: ");
                data = Console.ReadLine();
                myList.Add(data);
            }

            myList.Sort();

            foreach (var VARIABLE in myList)
            {
                Console.WriteLine(VARIABLE);
            }


            Console.ReadLine();

        }
    }
}
