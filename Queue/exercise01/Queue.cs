using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise01
{
    internal class Queue
    {
        Node Pointer = new Node();

        private Node GetLastNode(Node someNode)
        {
            Node auxNode = someNode;
            if (someNode.Next != null) auxNode = GetLastNode(someNode.Next);
            return auxNode;
        }

        public void Enqueue(Node newNode)
        {
            if (Pointer.Next != null)
            {
                Node lastNode = GetLastNode(Pointer.Next);
                lastNode.Next = newNode;
            }
            else Pointer.Next = newNode;
        }

        public Node Dequeue()
        {
            Node toDequeue = null;
            if (Pointer.Next != null)
            {
                toDequeue = Pointer.Next;
                Pointer.Next = toDequeue.Next;
                toDequeue.Next = null;
            }
            return toDequeue;
        }

        public Node Peek()
        {
            return Pointer.Next;
        }
    }
}
