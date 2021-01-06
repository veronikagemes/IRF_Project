using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.IO;

namespace IRF_Project
{
    public partial class Helyfoglalas : Form
    {
        UtazasokEntities context = new UtazasokEntities();
        public Helyfoglalas()
        {
            InitializeComponent();
            Adatbetoltes();
            Ulesrajzolo();
        }
        private List<FoglalashozAdatok> _foglalashozadatok = new List<FoglalashozAdatok>();
        private void Adatbetoltes() 
        {
            _foglalashozadatok.Clear();

            int azon = 1;//int.Parse(GlobalisValtozok.Idk);

            var eredmeny = from x in context.Busz
                           join y in context.Buszules
                           on x.BuszulesID equals y.BuszulesID
                           join z in context.Ules
                           on y.UlesID equals z.UlesID
                           where x.BuszID == azon
                           select new { z.Ulesszam, z.Pozicio, y.Foglaltsag };

             _foglalashozadatok = (List<FoglalashozAdatok>)eredmeny;


        }

        private void Ulesrajzolo() 
        {
            int lineWidth = 5;

            for (int row = 1; row < 4; row++)
            {
                for (int col = 1; col < 13; col++)
                {
                    Ulesek ules = new Ulesek();
                    ules.Left = col * ules.Width + (int)(Math.Floor((double)(col / 4))) * lineWidth;
                    ules.Top = row * ules.Height + (int)(Math.Floor((double)(row / 4))) * lineWidth;
                    this.Controls.Add(ules);
                }
            }
        }
    }
}
