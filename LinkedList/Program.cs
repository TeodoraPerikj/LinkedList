using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var linkedList = new LinkedList<int>();

            linkedList.AddNodeToEnd(1);
            linkedList.AddNodeToEnd(2);
            linkedList.AddNodeToStart(3);
            linkedList.AddNodeToEnd(4);
            linkedList.PrintList();

            linkedList.RemoveNode(2);
            linkedList.PrintList();

            Console.ReadKey();
        }
    }
}
