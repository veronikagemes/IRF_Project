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

namespace IRF_Project
{
    public partial class Utaslista : Form
    {
        UtazasokEntities context = new UtazasokEntities();
        public Utaslista()
        {
            InitializeComponent();
            Listamegjelenites();
            
        }

        private void Listamegjelenites() {
            int azon = int.Parse(GlobalisValtozok.Idk);

            var eredmeny = from x in context.Utazas
                           join y in context.Busz
                           on x.BuszID equals y.BuszID
                           join z in context.Buszules
                           on y.BuszulesID equals z.BuszulesID
                           join w in context.Ules
                           on z.UlesID equals w.UlesID
                           join q in context.Utas
                           on z.UtasID equals q.UtasID
                           where x.UtazasID == azon
                           select new { w.Ulesszam, q.Nev };

            Utaslistadgw.DataSource = eredmeny.ToList();
        }
    }
}
