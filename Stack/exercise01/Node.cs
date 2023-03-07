using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise01
{
    internal class Node
    {
        public Node(int id = 0)
        {
            this.Id = id;
            this.Next = null;
        }

        public int Id { get; set; }
        public Node Next { get; set; }
    }
}
