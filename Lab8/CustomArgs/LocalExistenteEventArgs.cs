using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8.CustomArgs
{
    public class LocalExistenteEventArgs : EventArgs
    {
        public string nameText { get; set; }
        public string idText { get; set; }
        public string ScheduleText { get; set; }
        public List<string> categorias { get; set; }
    }
}
