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
    public partial class Form1 : Form
    {
        UtazasokEntities context = new UtazasokEntities();
        public Form1()
        {
            InitializeComponent();
            Uticelvalasztas();
            Datumvalasztas();
            
        }

        private void Uticelvalasztas() {
            context.Uticel.Load();
            uticelBindingSource.DataSource = context.Uticel.Local;
        }

        private void Datumvalasztas() {
            var a =
                from x in context.Uticel
                join y in context.Utazas
                on x.UticelID equals y.UticelID
                join z in context.Datum
                on y.DatumID equals z.DatumID
                where x.Varos == comboBox1.Text
                select new { z.DatumID };
            //context.Datum.Where(p => p.DatumID == a.ToString()).Select(x => x).Load();
            context.Datum.Load();
           
            datumBindingSource.DataSource = context.Datum.Local;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Helyfoglalas hf = new Helyfoglalas();
            hf.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Utaslista ul = new Utaslista();
            ul.Show();
        }
    }
}
