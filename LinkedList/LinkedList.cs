using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedList<T>
    {
        private Node<T> head;
        public LinkedList()
        {
            head = null;
        }

        public void PrintList()
        {
            Node<T> current = head;

            while (current != null)
            {
                Console.Write($"{current.Data} -> ");
                current = current.Link;
            }

            Console.WriteLine("null");
        }

        public void AddNodeToEnd(T data)
        {
            Node<T> nodeToInsert = new Node<T>(data);

            if (head == null)
            {
                head = nodeToInsert;
                return;
            }

            Node<T> current = head;

            while (current.Link != null)
            {
                current = current.Link;
            }

            current.Link = nodeToInsert;
        }

        public void AddNodeToStart(T data)
        {
            Node<T> nodeToInsert = new Node<T>(data);

            nodeToInsert.Link = head;
            head = nodeToInsert;
        }

        public void RemoveNode(T data)
        {
            if (head == null)
            {
                return;
            }

            if (head.Data.Equals(data))
            {
                head = head.Link;
                return;
            }

            Node<T> current = head;

            while (current.Link != null)
            {
                if (current.Link.Data.Equals(data))
                {
                    current.Link = current.Link.Link;
                    return;
                }

                current = current.Link;
            }
        }
    }
}
