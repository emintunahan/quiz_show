using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje_bilgi_yarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int soruno = 0 , dogru=0, yanlis=0;

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnB_Click(object sender, EventArgs e)
        {
            if (btnB.Text == label4.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pctrGreen.Visible = true;
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnSonraki.Enabled = true;
            }
            else
            {
                yanlis++;
                lblYanlıs.Text = yanlis.ToString();
                pctrRed.Visible = true;
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnSonraki.Enabled = true;
                MessageBox.Show("Doğru Cevap: " + label4.Text);
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            if (btnC.Text == label4.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pctrGreen.Visible = true;
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnSonraki.Enabled = true;
            }
            else
            {
                yanlis++;
                lblYanlıs.Text = yanlis.ToString();
                pctrRed.Visible = true;
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnSonraki.Enabled = true;
                MessageBox.Show("Doğru Cevap: " + label4.Text);
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            if (btnD.Text == label4.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pctrGreen.Visible = true;
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnSonraki.Enabled = true;
            }
            else
            {
                yanlis++;
                lblYanlıs.Text = yanlis.ToString();
                pctrRed.Visible = true;
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnSonraki.Enabled = true;
                MessageBox.Show("Doğru Cevap: " + label4.Text);
            }
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            if(btnA.Text==label4.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pctrGreen.Visible = true;
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnSonraki.Enabled = true;
            }
            else
            {
                yanlis++;
                lblYanlıs.Text = yanlis.ToString();
                pctrRed.Visible = true;
                MessageBox.Show("Doğru Cevap: " + label4.Text);
            }
        }

        private void btnSonraki_Click(object sender, EventArgs e)
        {
            soruno++;
            lblSoruno.Text = soruno.ToString();
            if(soruno==1)
            {
                btnSonraki.Enabled = false;
                richTextBox1.Text = "Sare Holding CEO'su ve yönetim kurulu başkanı kimdir?";
                btnA.Text = "Elif Sare Şile";
                btnB.Text = "Haydar İleri";
                btnC.Text = "Akif Madan";
                btnD.Text = "Asi Ataseven";
                label4.Text = btnA.Text;
                btnA.Enabled = true;
                btnB.Enabled = true;
                btnC.Enabled = true;
                btnD.Enabled = true;
                pctrRed.Visible = false;
                pctrGreen.Visible = false;

            }
            if (soruno == 2)
            {
                btnSonraki.Enabled = false;
                richTextBox1.Text = "Dünyanın temiz hava, aktivite ve mimari yapı açısından örnek gösterdiği mühendislik fakültesi neresidir?";
                btnA.Text = "Boğaziçi Ü. Tıp Fakültesi";
                btnB.Text = "Çorlu Mühendislik Fak.";
                btnC.Text = "ODTÜ Müh. Fakültesi";
                btnD.Text = "Yıldız Teknik Ü. Fen Edeb. Fak.";
                label4.Text = btnB.Text;
                btnA.Enabled = true;
                btnB.Enabled = true;
                btnC.Enabled = true;
                btnD.Enabled = true;
                pctrRed.Visible = false;
                pctrGreen.Visible = false;

            }
            if (soruno == 3)
            {
                btnSonraki.Enabled = false;
                richTextBox1.Text = "İstanbul'un Şile ilçesinin tapusu kimdedir?";
                btnA.Text = "Devletin malıdır";
                btnB.Text = "Recep Tayyip Erdoğan";
                btnC.Text = "Elif Sare Şile";
                btnD.Text = "Fatih Sultan Mehmet";
                label4.Text = btnC.Text;
                btnA.Enabled = true;
                btnB.Enabled = true;
                btnC.Enabled = true;
                btnD.Enabled = true;
                pctrRed.Visible = false;
                pctrGreen.Visible = false;

            }
            if(soruno==4)
            {
                btnSonraki.Text = "SONUÇLAR";
                lblSoruno.Visible = false;
                pctrRed.Visible = false;
                pctrGreen.Visible = false;
                richTextBox1.Text = "OPPO RENO 4'ün sunduğu bilgi yarışması sona erdi.";
                MessageBox.Show("Yarışma bitti." + "\n" + "Doğru sayısı:" + lblDogru.Text + "\n" + "Yanlış sayısı:" + lblYanlıs.Text);


            }



        }
    }
}
