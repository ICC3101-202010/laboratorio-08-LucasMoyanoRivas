using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases;

namespace Lab8.Controller
{
    public class ControllerRec
    {
        List<Recreacional> recreacionales = new List<Recreacional>();
        Form1 form1;
        public ControllerRec(Form form1)
        {
            Initialize();
            this.form1 = form1 as Form1;
            //    this.form1.localesexistentesClicked += OnlocalesexistentesClicked;
        }
        public void Initialize()
        {
            recreacionales.Add(new Recreacional("Gimnasio", "10", "inicio: 11:00 cierre: 22:00"));
            recreacionales.Add(new Recreacional("Parque Araucano", "11", "inicio: 10:00 cierre: 19:00"));
            recreacionales.Add(new Recreacional("Fantasylandia", "12", "inicio: 12:00 cierre: 20:30"));
        }
    }
}
