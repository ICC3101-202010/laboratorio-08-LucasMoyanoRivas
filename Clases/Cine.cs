using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Cine
    {
        private string name;
        private string id;
        private string schedule;
        private int numberofsalas;

        public Cine(string name, string id, string schedule, int numberofsalas)
        {
            this.Name = name;
            this.Id = id;
            this.Schedule = schedule;
            this.Numberofsalas = numberofsalas;
        }

        public string Name { get => name; set => name = value; }
        public string Id { get => id; set => id = value; }
        public string Schedule { get => schedule; set => schedule = value; }
        public int Numberofsalas { get => numberofsalas; set => numberofsalas = value; }
    }
}
