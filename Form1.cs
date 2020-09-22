/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2019-2020 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........: Proje
**				ÖĞRENCİ ADI............: Ekhtiram Khudiev
**				ÖĞRENCİ NUMARASI.......: B161210558
**              DERSİN ALINDIĞI GRUP...: 1A
****************************************************************************/
using System;
using System.Drawing;
using System.Windows.Forms;

namespace B161210558
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int counter;


        //sistme baslayinca interval 1000 milisaniye olarak tasarrlanacak
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;

        }

        public string[] atiklar = { "Domates.jpg", "Cam Şişe.jpg", "Bardak.jpg", "Dergi.jpg",  "Kola Kutusu.jpg", "Salça Kutusu.jpg", "Salatalık.jpg" ,"Gazete.jpg"};
        public Random random = new Random();


        //Yeni oyun baslayinca timer basliyor
        private void YeniOyunButton_Click(object sender, EventArgs e)
        {
            timer1.Start();
            counter = 60;

            string randomAtik = atiklar[random.Next(0, 8)];
            atikPictureBox.Image = Image.FromFile(Application.StartupPath + "\\" + randomAtik);
            atikPictureBox.Name = randomAtik;

            yeniOyunButton.Enabled = false;
            organikKutusu.Enabled = true;
            kagitKutusu.Enabled = true;
            camKutusu.Enabled = true;
            metalKutusu.Enabled = true;
            organikButton.Enabled = true;
            kagitButton.Enabled = true;
            camButton.Enabled = true;
            metalButton.Enabled = true;

            label3.Text = "0";
            OrganikAtikKutusu.Value = 0;
            KagitAtikKutusu.Value = 0;
            CamAtikKutusu.Value = 0;
            MetalAtikKutusu.Value = 0;

            organikLabel.Items.Clear();
            kagitLabel.Items.Clear();
            camLabel.Items.Clear();
            metalLabel.Items.Clear();


        }

        //timer 1 eksiliyor
        private void timer1_Tick(object sender, EventArgs e)
        {
            counter--;
            label2.Text = counter.ToString();


            if (counter == 0)
            {
                timer1.Stop();
                yeniOyunButton.Enabled = true;
                organikKutusu.Enabled = false;
                kagitKutusu.Enabled = false;
                camKutusu.Enabled = false;
                metalKutusu.Enabled = false;
                organikButton.Enabled = false;
                kagitButton.Enabled = false;
                camButton.Enabled = false;
                metalButton.Enabled = false;

            }
        }

        //cikis butonuna tiklandigi zaman program kapaniyor
        private void ÇıkışButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OrganikButton_Click(object sender, EventArgs e)
        {

            if (atikPictureBox.Name == "Domates.jpg" && OrganikAtikKutusu.Value <= 550)
            {
                OrganikAtikKutusu.Value += 150;
                label3.Text = (int.Parse(label3.Text) + 150).ToString();


                string atik = atiklar[random.Next(0, 8)];
                atikPictureBox.Image = Image.FromFile(Application.StartupPath + "\\" + atik);
                atikPictureBox.Name = atik;

                organikLabel.Items.Add("Domates  150");
            }

            else if (atikPictureBox.Name == "Salatalık.jpg" && OrganikAtikKutusu.Value <= 580)
            {
                OrganikAtikKutusu.Value += 120;
                label3.Text = (int.Parse(label3.Text) + 120).ToString();

                string atik = atiklar[random.Next(0, 8)];
                atikPictureBox.Image = Image.FromFile(Application.StartupPath + "\\" + atik);
                atikPictureBox.Name = atik;

                organikLabel.Items.Add("Salatalık  120");
            }

        }

        private void KagitButton_Click(object sender, EventArgs e)
        {

            if (atikPictureBox.Name == "Gazete.jpg" && KagitAtikKutusu.Value <= 950)
            {
                KagitAtikKutusu.Value += 250;
                label3.Text = (int.Parse(label3.Text) + 250).ToString();

                string atik = atiklar[random.Next(0, 8)];
                atikPictureBox.Image = Image.FromFile(Application.StartupPath + "\\" + atik);
                atikPictureBox.Name = atik;


                kagitLabel.Items.Add("Gazete  250");
            }

            else if (atikPictureBox.Name == "Dergi.jpg" && KagitAtikKutusu.Value <= 1000)
            {
                KagitAtikKutusu.Value += 200;
                label3.Text = (int.Parse(label3.Text) + 200).ToString();

                string atik = atiklar[random.Next(0, 8)];
                atikPictureBox.Image = Image.FromFile(Application.StartupPath + "\\" + atik);
                atikPictureBox.Name = atik;


                kagitLabel.Items.Add("Dergi  200");
            }


        }

        private void CamButton_Click(object sender, EventArgs e)
        {




            if (atikPictureBox.Name == "Bardak.jpg" && CamAtikKutusu.Value <= 1950)
            {
                CamAtikKutusu.Value += 250;
                label3.Text = (int.Parse(label3.Text) + 250).ToString();

                string atik = atiklar[random.Next(0, 8)];
                atikPictureBox.Image = Image.FromFile(Application.StartupPath + "\\" + atik);
                atikPictureBox.Name = atik;

                camLabel.Items.Add("Bardak  250");
            }


            else if (atikPictureBox.Name == "Cam Şişe.jpg" && CamAtikKutusu.Value <= 1600)
            {
                CamAtikKutusu.Value += 600;
                label3.Text = (int.Parse(label3.Text) + 600).ToString();

                string atik = atiklar[random.Next(0, 8)];
                atikPictureBox.Image = Image.FromFile(Application.StartupPath + "\\" + atik);
                atikPictureBox.Name = atik;

                camLabel.Items.Add("Cam Şişe  600");
            }


        }

        private void MetalButton_Click(object sender, EventArgs e)
        {


            if (atikPictureBox.Name == "Kola Kutusu.jpg" && MetalAtikKutusu.Value <= 1950)
            {
                MetalAtikKutusu.Value += 350;
                label3.Text = (int.Parse(label3.Text) + 350).ToString();


                string atik = atiklar[random.Next(0, 8)];
                atikPictureBox.Image = Image.FromFile(Application.StartupPath + "\\" + atik);
                atikPictureBox.Name = atik;

                metalLabel.Items.Add("Kola Kutusu  350");
            }


            else if (atikPictureBox.Name == "Salça Kutusu.jpg" && MetalAtikKutusu.Value <= 1750)
            {
                MetalAtikKutusu.Value += 550;
                label3.Text = (int.Parse(label3.Text) + 550).ToString();

                string atik = atiklar[random.Next(0, 8)];
                atikPictureBox.Image = Image.FromFile(Application.StartupPath + "\\" + atik);
                atikPictureBox.Name = atik;

                metalLabel.Items.Add("Salça Kutusu  550");

            }


        }

        private void OrganikBosaltButton_Click(object sender, EventArgs e)
        {
            if (OrganikAtikKutusu.Value >= 700 * 75 / 100)
            {
                OrganikAtikKutusu.Value = 0;
                counter += 3;
                organikLabel.Items.Clear();
            }
        }

        private void KagitBosaltButton_Click(object sender, EventArgs e)
        {
            if (KagitAtikKutusu.Value >= 1200 * 75 / 100)
            {
                KagitAtikKutusu.Value = 0;
                counter += 3;
                label3.Text = (int.Parse(label3.Text) + 1000).ToString();
                kagitLabel.Items.Clear();
            }
        }

        private void CamBosaltButton_Click(object sender, EventArgs e)
        {
            if (CamAtikKutusu.Value >= 2200 * 75 / 100)
            {
                CamAtikKutusu.Value = 0;
                counter += 3;
                label3.Text = (int.Parse(label3.Text) + 600).ToString();
                camLabel.Items.Clear();
            }
        }

        private void MetalBosaltButton_Click(object sender, EventArgs e)
        {
            if (MetalAtikKutusu.Value >= 2300 * 75 / 100)
            {
                MetalAtikKutusu.Value = 0;
                counter += 3;
                label3.Text = (int.Parse(label3.Text) + 800).ToString();
                metalLabel.Items.Clear();
            }
        }
    }
}
