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
using System.Globalization;

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
            Buszmegjelenites();
            
        }

        private void Uticelvalasztas() {
            context.Uticel.Load();
            uticelBindingSource.DataSource = context.Uticel.Local;
        }

        private void Datumvalasztas() {
           
            /*var a =
                from x in context.Uticel
                join y in context.Utazas
                on x.UticelID equals y.UticelID
                join z in context.Datum
                on y.DatumID equals z.DatumID
                where x.Varos == comboBox1.Text && y.DatumID == 1
                select new { z.DatumID };

            int aa = int.Parse(a.ToString());
            context.Datum.Where(p => p.DatumID == aa).Select(x => x).Load();*/

           
            context.Datum.Load();
            datumBindingSource.DataSource = context.Datum.Local;
        }

        private void Buszmegjelenites() {



            /*string iDate = "05/05/2005";
            DateTime oDate = Convert.ToDateTime(iDate);
            MessageBox.Show(oDate.Day + " " + oDate.Month + "  " + oDate.Year);*/

            /*string iString = comboBox2.Text;
            DateTime oDate = DateTime.ParseExact(iString, "yyyy/MM/dd HH:mm", null);
            MessageBox.Show(oDate.ToString());*/

            /*textBox1.Text =
                from x in context.Uticel
                join y in context.Utazas
                on x.UticelID equals y.UticelID
                join z in context.Datum
                on y.DatumID equals z.DatumID
                where (x.Varos == comboBox1.Text) && (z.Datum1 == dt)
                join w in context.Busz

                select new { w. };*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //GlobalisValtozok.Idk = textBox1.Text;
            Helyfoglalas hf = new Helyfoglalas();
            hf.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*DateTime UtazasDatuma = comboBox2.Text;
            var s =
                from x in context.Uticel
                join y in context.Utazas
                on x.UticelID equals y.UticelID
                join z in context.Datum
                on y.DatumID equals z.DatumID
                where (x.Varos == comboBox1.Text) && (z.Datum1 == UtazasDatuma)
                select new { y.UtazasID};
            GlobalisValtozok.Idk = s;*/
            GlobalisValtozok.Idk = "1";
            Utaslista ul = new Utaslista();
            ul.Show();
        }
    }
}
