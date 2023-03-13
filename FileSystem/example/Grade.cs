using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example
{
    internal class Grade
    {
        public Grade(string data)
        {
            string[] newGrade = data.Split(',');
            this.Calif = int.Parse(newGrade[0]);
            this.Date = DateTime.Parse(newGrade[1]);
            this.Id = long.Parse(newGrade[2]);
        }

        public int Calif { get; set; }
        public DateTime Date { get; set; }
        public long Id { get; set; }    

        public string GetString()
        {
            return $"{this.Calif},{this.Date.ToShortDateString()},{this.Id}";
        }

    }
}
