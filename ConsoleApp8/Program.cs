using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            LinkedList<string> list1 = new LinkedList<string>();

            list1.AddFirst("yes");
            list1.AddLast("nO");
            LinkedListNode<String> nozzle = new LinkedListNode<string>("Done");
            list1.AddFirst(nozzle);
            list1.AddBefore(nozzle, "Tool");
            list1.AddAfter(nozzle, "Cool");

            Console.WriteLine("The LinkedList Before Reversing: ");

            foreach (var item in list1)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("The LinkedList After Reversing: ");

            foreach (var item in list1.Reverse())
            {
                Console.WriteLine(item);
            }
        }
    }
}
