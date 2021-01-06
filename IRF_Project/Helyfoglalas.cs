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

            //_foglalashozadatok = (List<FoglalashozAdatok>)eredmeny;
            using (StreamWriter sw = new StreamWriter("Textfile1.txt", false, Encoding.UTF8))
            {
                foreach (var s in eredmeny)
                {
                    sw.Write(s.Ulesszam.ToString());
                    sw.Write(";");
                    sw.Write(s.Pozicio);
                    sw.Write(";");
                    sw.Write(s.Foglaltsag);
                    sw.WriteLine();
                }
            }

        }

        private void Ulesrajzolo() 
        {
            for (int row = 1; row < 14; row++)
            {
                for (int col = 1; col < 5; col++)
                {
                    Ulesek ules = new Ulesek();
                    if (col < 3)
                    {
                        ules.Left = col * ules.Width + (int)(Math.Floor((double)(col / 4)));
                    }
                    else if (col > 2)
                    {
                        ules.Left = (col + 1) * ules.Width + (int)(Math.Floor((double)(col / 4)));
                    }
                    ules.Top = row * ules.Height + (int)(Math.Floor((double)(row / 4)));
                    if (!((row == 1 && col == 3)
                        || (row == 1 && col == 4)
                        || (row == 6 && col == 3)
                        || (row == 6 && col == 4)
                        || (row == 7 && col == 3)
                        || (row == 7 && col == 4)
                        ))
                    {
                        this.Controls.Add(ules);
                    }
                }
            }
            int sor = 13;
            Ulesek extraules = new Ulesek();
            extraules.Left = 3 * extraules.Width + (int)(Math.Floor((double)(3 / 4)));
            extraules.Top = sor * extraules.Height + (int)(Math.Floor((double)(sor / 4)));
            this.Controls.Add(extraules);
        }
    }
}
