using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Draw_Point
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ListaSvihTacaka = new List<PointD>();
            ListaSelektovanihTacaka = new List<PointD>();
        }
        //Deklarisane liste (lista svih tacaka i lista svih selektovanih tacaka)
        List <PointD> ListaSvihTacaka;
        List<PointD> ListaSelektovanihTacaka;
        //Metoda za ukljucivanje ToolBox-a i njegovih elemenata
        void UkljucivanjeElemenataToolBoxa()
        {
            if (ListaSelektovanihTacaka.Count == 2)
                CrtajPravuButton.Enabled = true;
            else
                CrtajPravuButton.Enabled = false;
            if (ListaSelektovanihTacaka.Count == 3)
                CrtajTrougaoButton.Enabled = true;
            else
                CrtajTrougaoButton.Enabled = false;
        }

        //Radnje sa misem
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Graphics g = PictureBox.CreateGraphics();
            //Pozicija zadata misem
            PointD point = new PointD(e.X, e.Y);
            //Kada je prvi radioButton cekiran onda bi trebalo samo da crtamo tacke po PictureBox-u
            //Kada je stikliran drugi radioButton onda bi trebalo da ukljuci ToolBox i klikom na tacku bi trebalo da je doda u listu SelecteedListBox   
            if (CrtajTackeRadioButton.Checked)
            {
                int ElementiListe = ListaSvihTacaka.Count;    
                bool TackaJePreblizu = false;
                for (int i = 0; i < ElementiListe; i++)
                    if (ListaSvihTacaka[i].ProveraBlizine(point) == true)
                    {
                        TackaJePreblizu = true;
                        MessageBox.Show("Radnja nije moguca. Tacka je preblizu drugoj!");
                        break;
                    }
                if (TackaJePreblizu == false)
                {
                    ListaSvihTacaka.Add(point);
                    ListaSvihTacaka[ElementiListe].CrtajTacku(g);
                }

            }
                //Drugi radioButton
            else if (ToolBoxRadioButton.Checked)
            {
                int ElementiListe = ListaSvihTacaka.Count;
                int ElementiListeSelektovanihTacaka=ListaSelektovanihTacaka.Count;
                for (int i = 0; i < ElementiListe; i++)
                    if (ListaSvihTacaka[i].ProveraBlizine(point) == true)
                    {
                     
                            ListaSelektovanihTacaka.Add(ListaSvihTacaka[i]);

                       
                        break;
                    }
                foreach (PointD point1 in ListaSelektovanihTacaka)
                    point1.IfSelected(g);
                UkljucivanjeElemenataToolBoxa();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Pocetno stanje
            CrtajTackeRadioButton.Checked = true;
            ToolBox.Enabled = false;
            //ListaSvihTacaka.Add(new PointD(-4, -4));
        }

        private void radToolBoxUse_CheckedChanged(object sender, EventArgs e)
        {
            //UkljucivanjeToolBox-a
            if (ToolBoxRadioButton.Checked == true)
            {
                ToolBox.Enabled = true;
                UkljucivanjeElemenataToolBoxa();
            }
        }

        private void radDrawPoints_CheckedChanged(object sender, EventArgs e)
        {
            //Iskljucivanje ToolBox-a i ponovna mogucnost crtanja tacaka
            UkljucivanjeElemenataToolBoxa();
            ToolBox.Enabled = false;
        }
    }
}
