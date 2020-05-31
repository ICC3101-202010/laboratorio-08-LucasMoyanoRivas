using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Restaurante
    {
        private string name;
        private string id;
        private string schedule;
        private bool mesasexclusivas;

        public Restaurante(string name, string id, string schedule, bool mesasexclusivas)
        {
            this.Name = name;
            this.Id = id;
            this.Schedule = schedule;
            this.Mesasexclusivas = mesasexclusivas;
        }

        public string Name { get => name; set => name = value; }
        public string Id { get => id; set => id = value; }
        public string Schedule { get => schedule; set => schedule = value; }
        public bool Mesasexclusivas { get => mesasexclusivas; set => mesasexclusivas = value; }
    }
}
