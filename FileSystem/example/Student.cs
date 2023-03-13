using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example
{
    internal class Student
    {
        public Student(string data)
        {
            string[] studentData = data.Split(',');
            this.Id = long.Parse(studentData[0]);
            this.Name = studentData[1];
            this.Surname = studentData[2];
        }

        public string GetString()
        {
            return $"{this.Id},{this.Name},{this.Surname}";
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
