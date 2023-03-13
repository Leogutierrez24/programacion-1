using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercise01
{
    internal class StudentSystem
    {
        string url = "student.txt";

        public void Add(Student newStudent)
        {
            FileStream fs = new FileStream(url, FileMode.Append, FileAccess.Write);
            using (StreamWriter sw = new StreamWriter(fs))
            {
                sw.WriteLine(newStudent.GetString());
            }
            fs.Close();
        }

        public List<Student> GetList()
        {
            List<Student> students = new List<Student>();

            FileStream fs = new FileStream(url, FileMode.OpenOrCreate, FileAccess.Read);
            using (StreamReader sr = new StreamReader(fs))
            {
                string line = sr.ReadLine();

                while (line != null)
                {
                    Student someStudent = new Student(line);
                    students.Add(someStudent);
                    line = sr.ReadLine();
                }
            }
            fs.Close();

            return students;
        }

        public List<Student> Order()
        {
            List<Student> toOrder = this.GetList();
            return toOrder.OrderBy(e => e.Id).ToList();
        }
    }
}
