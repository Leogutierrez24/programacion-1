using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise01
{
    internal class Stack
    {
        Node pointer = new Node();

        private int GetLength(Node someNode)
        {
            int length = 0;
            if (someNode != null) length += 1 + GetLength(someNode.Next);
            return length;
        }

        public int Length()
        {
            return GetLength(pointer.Next);
        }

        public void Push(Node someNode)
        {
            if (pointer.Next != null)
            {
                Node aux = pointer.Next;
                pointer.Next = someNode;
                someNode.Next = aux;
            } else pointer.Next = someNode;
        }

        public void Pop()
        {
            if (pointer.Next != null)
            {
                Node aux = pointer.Next;
                pointer.Next = aux.Next;
                aux.Next = null;
            }
        }

        public Node Show()
        {
            return pointer.Next;
        }
    }
}
