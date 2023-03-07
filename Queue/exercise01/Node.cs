using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise01
{
    internal class Node
    {
        public Node(string name = "", string sex = "")
        {
            this.Name = name;
            this.Sex = sex;
            this.Next = null;
        }

        public string Name { get; set; }
        public string Sex { get; set; }
        public Node Next { get; set; }
    }
}
