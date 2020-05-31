using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases;
using Lab8.CustomArgs;

namespace Lab8.Controller
{
    public class ControllerT
    {
        List<Tienda> tiendas = new List<Tienda>();
        Form1 form1;
        public ControllerT(Form form1)
        {
            Initialize();
            this.form1 = form1 as Form1;
            this.form1.localesexistentesClicked += OnlocalesexistentesClicked;
        }
        public void Initialize()
        {
            List<string> c1 = new List<string>();
            c1.Add("Deporte");
            List<string> c2 = new List<string>();
            c2.Add("Consolas");
            c2.Add("VideoJuegos");
            List<string> c3 = new List<string>();
            c3.Add("Vestuario");
            tiendas.Add(new Tienda("Adidas", "1", "inicio: 10:00 cierre: 21:00", c1));
            tiendas.Add(new Tienda("Zmart", "2", "inicio: 9:00 cierre: 20:00", c2));
            tiendas.Add(new Tienda("Americanino", "3", "inicio: 11:00 cierre: 19:30", c3));
        }
        private bool OnlocalesexistentesClicked(object sender, LocalExistenteEventArgs e)
        {
            Tienda tienda = null;
            tienda = tiendas.Where(n => n.Name.ToUpper().Contains(e.nameText.ToUpper())).FirstOrDefault();
            if(tienda is null)
            {
                return false;
            }
            else
            {

            }
        }
    }
}
