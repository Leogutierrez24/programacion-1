using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example
{
    internal class Node
    {
        public Node(string id) 
        {
            this.Id = id;
            this.Right = null;
            this.Left = null;
        }

        public string Id { get; set; }
        public Node Right { get; set; }
        public Node Left { get; set; }
    }
}
