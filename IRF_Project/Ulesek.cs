using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRF_Project
{
    class Ulesek : Button
    {

        private int _foglaltsag;
        public int Foglaltsag
        {
            get { return _foglaltsag; }
            set
            {
                _foglaltsag = value;
                if (_foglaltsag == 0)
                    Text = "Szabad";
                else
                    Foglaltules();

            }
        }

        public Ulesek()
        {
            Height = 25;
            Width = 60;
            BackColor = Color.White;
            Foglaltsag = 0;
            MouseClick += Ulesek_MouseClick;
        }

        private void Ulesek_MouseClick(object sender, MouseEventArgs e)
        {
            if (_foglaltsag != 0) return;
        }

        private void Foglaltules() {
            Text = "Foglalt";
            BackColor = Color.LightGray;
        }
    }
}
