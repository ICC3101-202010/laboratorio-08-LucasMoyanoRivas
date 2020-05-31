using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Recreacional
    {
        private string name;
        private string id;
        private string schedule;

        public Recreacional(string name, string id, string schedule)
        {
            this.Name = name;
            this.Id = id;
            this.Schedule = schedule;
        }

        public string Name { get => name; set => name = value; }
        public string Id { get => id; set => id = value; }
        public string Schedule { get => schedule; set => schedule = value; }
    }
}
