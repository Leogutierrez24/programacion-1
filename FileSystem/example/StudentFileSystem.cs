using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example
{
    internal class StudentFileSystem
    {
        string url = "student.txt";

        public void Add(Student newStudent)
        {
            FileStream fs = new FileStream(url, FileMode.Append, FileAccess.Write);
            using (StreamWriter sw = new StreamWriter(fs))
            {
                string line = newStudent.GetString();
                sw.WriteLine(line);
            }
            fs.Close();
        }

        public void Delete(long id)
        {
            string data = string.Empty;

            FileStream fs = new FileStream(url, FileMode.OpenOrCreate, FileAccess.Read);
            using (StreamReader sr = new StreamReader(fs))
            {
                string line = sr.ReadLine();

                while (line != null)
                {
                    Student someStudent = new Student(line);
                    if (someStudent.Id != id) data += line + Environment.NewLine;
                    line = sr.ReadLine();
                }
            }

            fs = new FileStream(url, FileMode.Truncate, FileAccess.Write);
            using (StreamWriter sr = new StreamWriter(fs))
            {
                sr.Write(data);
            }
            fs.Close();
        }

        public void Update(Student updatedStudent)
        {
            FileStream fs = new FileStream(url, FileMode.Append, FileAccess.Write);
            using (StreamWriter sw = new StreamWriter(fs))
            {
                string line = updatedStudent.GetString();
                sw.WriteLine(line);
            }
            fs.Close();
        }

        public List<Student> GetStudentList()
        {
            List<Student> students = new List<Student>();

            FileStream fs = new FileStream(url, FileMode.OpenOrCreate, FileAccess.Read);
            using (StreamReader sr = new StreamReader(fs))
            {
                string line = sr.ReadLine();

                while (line != null)
                {
                    Student student = new Student(line);
                    students.Add(student);
                    line = sr.ReadLine();
                }
            }
            fs.Close();

            return students;
        }
    }
}
