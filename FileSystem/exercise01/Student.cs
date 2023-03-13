using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise01
{
    internal class Student
    {
        public Student(string data)
        {
            string[] d = data.Split(',');
            this.Id = int.Parse(d[0]);
            this.Name = d[1];
        }

        public Student(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public string Name { get; set; }
        public int Id { get; set; }

        public string GetString()
        {
            return $"{this.Id},{this.Name}";
        }
    }
}
