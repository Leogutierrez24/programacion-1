using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace exercise01
{
    internal class GradeSystem
    {
        string url = "grade.txt";

        public void Add(Grade newGrade)
        {
            FileStream fs = new FileStream(url, FileMode.Append, FileAccess.Write);
            using (StreamWriter sw = new StreamWriter(fs))
            {
                sw.WriteLine(newGrade.GetString());
            }
            fs.Close();
        }

        public List<Grade> GetList()
        {
            List<Grade> grades = new List<Grade>();

            FileStream fs = new FileStream(url, FileMode.OpenOrCreate, FileAccess.Read);
            using (StreamReader sr = new StreamReader(fs))
            {
                string line = sr.ReadLine();

                while (line != null)
                {
                    Grade someGrade = new Grade(line);
                    grades.Add(someGrade);
                    line = sr.ReadLine();
                }
            }
            fs.Close();

            return grades;
        }

        public List<Grade> Order()
        {
            List<Grade> toOrder = this.GetList();
            return toOrder.OrderBy(e => e.Id).ToList();
        }
    }
}
