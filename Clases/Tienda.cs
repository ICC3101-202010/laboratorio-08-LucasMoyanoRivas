using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Tienda
    {
        private string name;
        private string id;
        private string schedule;
        private List<string> categorias = new List<string>();

        public Tienda(string name, string id, string schedule, List<string> categorias)
        {
            this.Name = name;
            this.Id = id;
            this.Schedule = schedule;
            this.Categorias = categorias;
        }

        public string Name { get => name; set => name = value; }
        public string Id { get => id; set => id = value; }
        public string Schedule { get => schedule; set => schedule = value; }
        public List<string> Categorias { get => categorias; set => categorias = value; }

        public bool Checkear(string name, string id)
    }
}
