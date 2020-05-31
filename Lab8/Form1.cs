using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases;
using Lab8.CustomArgs;

namespace Lab8
{
    public partial class Form1 : Form
    {
        public delegate bool LocalExistenteEventHandler(object source, LocalExistenteEventArgs args);
        public event LocalExistenteEventHandler localesexistentesClicked;
        public Form1()
        {
            InitializeComponent();
        }

        private void localesexistentes_Click(object sender, EventArgs e)
        {
            string name = 
            OnlocalesexistentesClicked();
        }
        private void OnlocalesexistentesClicked()
        {
            if(localesexistentesClicked != null)
            {
                bool result = localesexistentesClicked(this, new LocalExistenteEventArgs() { nameText =, idText =, ScheduleText =, categorias = });
                if(!result)
                {

                }
            }
        }

        private void InfoLocal_Click(object sender, EventArgs e)
        {

        }

        private void localnuevo_Click(object sender, EventArgs e)
        {

        }
    }
}
