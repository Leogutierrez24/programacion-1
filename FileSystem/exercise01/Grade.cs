using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise01
{
    internal class Grade
    {
        public Grade(int id, int calif)
        {
            this.Id = id;
            this.Calif = calif;
        }

        public Grade(string data)
        {
            string[] d = data.Split(',');
            this.Id = int.Parse(d[0]);
            this.Calif = int.Parse(d[1]);
        }

        public int Id { get; private set; }
        public int Calif { get; private set; }

        public string GetString()
        {
            return $"{this.Id},{this.Calif}";
        }
    }
}
