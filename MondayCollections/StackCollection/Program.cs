using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace StackCollection
{
    class Program
    {
        static void Main(string[] args)
        {

            Stack<int> stack = new Stack<int>();
            string data = "valmi";
            int number;

            while (data.Length >0 )
            {
                Console.WriteLine("Write number or push the enter: ");
                data = (Console.ReadLine());
                if (data.Length > 0)
                {
                    number = Int32.Parse(data);
                    stack.Push(number);
                }
                
                
            }
            

            while (stack.Count > 0)
            {
                object obj = stack.Pop();
                Console.WriteLine("From Stack: {0}", obj);
            }

            Console.ReadLine();

        }
    }
}
