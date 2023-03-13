using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example
{
    internal class GradeFileSystem
    {
        string url = "grades.txt";

        public void Add(Grade newGrade)
        {
            FileStream fs = new FileStream(url, FileMode.Append, FileAccess.Write);
            using (StreamWriter sw = new StreamWriter(fs))
            {
                sw.WriteLine(newGrade.GetString());
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

                while(line != null)
                {
                    Grade someGrade = new Grade(line);
                    if (someGrade.Id != id) data += line + Environment.NewLine;
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

        public void Update(Grade updatedGrade)
        {
            FileStream fs = new FileStream(url, FileMode.Append, FileAccess.Write);
            using (StreamWriter sw = new StreamWriter(fs))
            {
                sw.WriteLine(updatedGrade.GetString());
            }
            fs.Close();
        }

        public List<Grade> GetGradesList()
        {
            List<Grade> grades = new List<Grade>();

            FileStream fs = new FileStream(url, FileMode.OpenOrCreate, FileAccess.Read);
            using (StreamReader sr = new StreamReader(fs))
            {
                string line = sr.ReadLine();

                while(line != null)
                {
                    Grade someGrade = new Grade(line);
                    grades.Add(someGrade);
                    line = sr.ReadLine();
                }
            }
            fs.Close();

            return grades;
        }
    }
}
