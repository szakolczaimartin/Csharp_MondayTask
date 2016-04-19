using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkeldListCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> linked = new LinkedList<string>();
           
            linked.AddLast("cat");
            linked.AddLast("dog");
            linked.AddLast("man");
            linked.AddFirst("first");
           
            foreach (var item in linked)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine( );

            LinkedList<int> linkedInt = new LinkedList<int>();

            linkedInt.AddFirst(1);
            linkedInt.AddFirst(2);
            linkedInt.AddFirst(3);
            linkedInt.AddFirst(4);

            foreach (var item in linkedInt)
            {
                Console.WriteLine(item);
            }

            LinkedList<bool> linkedBool = new LinkedList<bool>();

            linkedBool.AddFirst(true);
           
            foreach (var item in linkedBool)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
