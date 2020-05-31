using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases;

namespace Lab8.Controller
{
    public class ControllerRest
    {
        List<Restaurante> restaurantes = new List<Restaurante>();
        Form1 form1;
        public ControllerRest(Form form1)
        {
            Initialize();
            this.form1 = form1 as Form1;
            //    this.form1.localesexistentesClicked += OnlocalesexistentesClicked;
        }
        public void Initialize()
        {
            restaurantes.Add(new Restaurante("Tanta", "7", "inicio: 8:30 cierre: 22:00", true));
            restaurantes.Add(new Restaurante("Chilenazo", "8", "inicio: 9:00 cierre: 19:00", true));
            restaurantes.Add(new Restaurante("McDonalds", "9", "inicio: 12:30 cierre: 20:30", false));
        }
    }
}
