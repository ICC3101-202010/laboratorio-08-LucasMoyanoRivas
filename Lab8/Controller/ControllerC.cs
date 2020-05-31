using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases;

namespace Lab8.Controller
{
    public class ControllerC
    {
        List<Cine> cines = new List<Cine>();
        Form1 form1;
        public ControllerC(Form form1)
        {
            Initialize();
            this.form1 = form1 as Form1;
        //    this.form1.localesexistentesClicked += OnlocalesexistentesClicked;
        }
        public void Initialize()
        {
            cines.Add(new Cine("CineHoyts", "4", "inicio: 10:30 cierre: 21:00", 10));
            cines.Add(new Cine("CinePlanet", "5", "inicio: 9:30 cierre: 20:00", 12));
            cines.Add(new Cine("CineMark", "6", "inicio: 11:30 cierre: 19:30", 15));
        }
    }
}
