using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilgi_Yarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        int soru_no = 0, dogru = 0, yanlis = 0;

        private void BTNB_Click(object sender, EventArgs e)
        {
            BTNA.Enabled = false;
            BTNB.Enabled = false;
            BTNC.Enabled = false;
            BTND.Enabled = false;
            BTNSonraki.Enabled = true;
            label5.Text = BTNB.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                labelDogrusayisi.Text = dogru.ToString();
                picturureBoxDogru.Visible = true;
            }
            else
            {
                yanlis++;
                labelyanlissayisi.Text = yanlis.ToString();
                pictureBoxYanlis.Visible = true;
            }
        }

        private void BTNC_Click(object sender, EventArgs e)
        {
            BTNA.Enabled = false;
            BTNB.Enabled = false;
            BTNC.Enabled = false;
            BTND.Enabled = false;
            BTNSonraki.Enabled = true;
            label5.Text = BTNC.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                labelDogrusayisi.Text = dogru.ToString();
                picturureBoxDogru.Visible = true;
            }
            else
            {
                yanlis++;
                labelyanlissayisi.Text = yanlis.ToString();
                pictureBoxYanlis.Visible = true;
            }
        }

        private void BTND_Click(object sender, EventArgs e)
        {
            BTNA.Enabled = false;
            BTNB.Enabled = false;
            BTNC.Enabled = false;
            BTND.Enabled = false;
            BTNSonraki.Enabled = true;
            label5.Text = BTND.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                labelDogrusayisi.Text = dogru.ToString();
                picturureBoxDogru.Visible = true;
            }
            else
            {
                yanlis++;
                labelyanlissayisi.Text = yanlis.ToString();
                pictureBoxYanlis.Visible = true;
            }
        }

        private void BTNA_Click(object sender, EventArgs e)
        {
            BTNA.Enabled = false;
            BTNB.Enabled = false;
            BTNC.Enabled = false;
            BTND.Enabled = false;
            BTNSonraki.Enabled = true;
            label5.Text = BTNA.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                labelDogrusayisi.Text = dogru.ToString();
                picturureBoxDogru.Visible = true;
            }
            else
            {
                yanlis++;
                labelyanlissayisi.Text = yanlis.ToString();
                pictureBoxYanlis.Visible = true;
            }
        }

        private void BTNSonraki_Click(object sender, EventArgs e)
        {
            BTNA.Enabled = true;
            BTNB.Enabled = true;
            BTNC.Enabled = true;
            BTND.Enabled = true;
            BTNSonraki.Enabled = false;
            picturureBoxDogru.Visible = false;
            pictureBoxYanlis.Visible = false;
            soru_no++;
            labelSoruNo.Text = soru_no.ToString();



            if (soru_no == 1)
            {
                richTextBox2.Text = "Cumhuriyet kac yilinda ilan edilmistir?";
                BTNA.Text = "1920";
                BTNB.Text = "1921";
                BTNC.Text = "1922";
                BTND.Text = "1923";
                label4.Text = "1923";
            }
            else if (soru_no == 2)
            {
                richTextBox2.Text = "Saltanatın kaldırılması kaç yılında olmuştur?";
                BTNA.Text = "1918";
                BTNB.Text = "1924";
                BTNC.Text = "1922";
                BTND.Text = "1925";
                label4.Text = "1922";
            }
            else if (soru_no == 3)
            {
                richTextBox2.Text = "Istanbul kac yılında fethedilmiştir?";
                BTNA.Text = "1453";
                BTNB.Text = "1462";
                BTNC.Text = "1451";
                BTND.Text = "1354";
                label4.Text = "1453";
            }
            else if (soru_no == 4)
            {
                richTextBox2.Text = "Kanuni Sultan Süleyman kac yasinda padisah olmustur?";
                BTNA.Text = "20";
                BTNB.Text = "26";
                BTNC.Text = "27";
                BTND.Text = "18";
                label4.Text = "26";

            }
            else if (soru_no == 5)
            {
                richTextBox2.Text = "Prezeve deniz savasi kac yilinda olmustur.?";
                BTNA.Text = "28 Eylül 1538";
                BTNB.Text = "26 Kasım 1620";
                BTNC.Text = "2 Ocak 1540";
                BTND.Text = "11 Temmuz 1542";
                label4.Text = "28 Eylül 1538";
            }
            else if (soru_no == 6)
            {
                BTNSonraki.Text = "Sonuclar";
                MessageBox.Show("\nSonuclar:\nDogru:"+dogru+""+"\nYanlis:"+yanlis);
            }

            else
            {
                richTextBox2.Text = "Sınavınız bitmiştir.Soruları kontrol edin veya direk bitir butonuna basın.";
                BTNA.Text = " ";
                BTNB.Text = "";
                BTNC.Text = " ";
                BTND.Text = " ";
                label4.Text = " ";
            }



        }
    }
}
