using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ndp_Proje
{
    public partial class Form1 : Form
    {
        //Kullanılacak nesnelerin oluşturulması.
        Atiklar atiklar = new Atiklar();
        CamK camAtik = new CamK();
        OrgAtikK orgAtik = new OrgAtikK();
        KagitK kagit = new KagitK();
        MetalK metal = new MetalK();

        public Form1()
        {
            InitializeComponent();
        }

        int _saniye = 60;
        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Interval = 1000;//timer kullanımı.
            lblSure.Text = "60";
            btnCikis.Enabled = false;

            btnCam.Enabled = false;
            btnOrg.Enabled = false;
            btnKagit.Enabled = false;
            btnMetal.Enabled = false;
            clearKagit.Enabled = false;
            clearOrg.Enabled = false;
            clearCam.Enabled = false;

            clearMetal.Enabled = false;
        }

      
        public void AtikGetir()
        {
            atiklar.RastgeleGetir(); //Rastgele atık fotoğrafı getirir.
            pctrBoxAtik.ImageLocation = atiklar.Rastgele + ".jpg";
        }

   
        private void BtnYeniOyun_Click(object sender, EventArgs e)
        {
            timer.Start();
            _saniye = 60;
            lblPuan.Text = "0";
            lblSure.Text = Convert.ToString(_saniye);

            btnCam.Enabled = true;
            btnOrg.Enabled = true;
            btnKagit.Enabled = true;
            btnMetal.Enabled = true;
            clearKagit.Enabled = true;
            clearOrg.Enabled = true;
            clearMetal.Enabled = true;
            clearCam.Enabled = true;

            AtikGetir();
        }

     

        private void Timer_Tick(object sender, EventArgs e)
        {
            _saniye--;
            lblSure.Text = Convert.ToString(_saniye);

            if (lblSure.Text == "0")
            {
                timer.Stop();

                btnCam.Enabled = false;
                btnOrg.Enabled = false;
                btnKagit.Enabled = false;
                btnMetal.Enabled = false;
                clearKagit.Enabled = false;
                clearOrg.Enabled = false;
                clearCam.Enabled = false;

                clearMetal.Enabled = false;
            }



        }

        private void BtnCam_Click(object sender, EventArgs e)//cam butonuna basıldığında yapılacak işlemler.
        {
            if ((atiklar.Rastgele == 1) || (atiklar.Rastgele == 2))
            {
                if (camAtik.DolulukDurumu(prgBarCam.Value))
                {
                    camAtik.HacimAta(atiklar.Rastgele);
                    camAtik.Ekle(camAtik);
                    camAtik.PuanHesapla(lblPuan.Text);
                    lstBoxCam.Items.Add(camAtik.EklenecekAtik);
                    prgBarCam.Value = camAtik.Doluluk;
                    lblPuan.Text = Convert.ToString(camAtik.BosaltmaPuani);
                    AtikGetir();
                }
            }
            AtikGetir();

        }



        private void BtnOrg_Click(object sender, EventArgs e)//Organik atık butonuna basıldığında yapılacak işlemler.
        {
            if ((atiklar.Rastgele == 3) || (atiklar.Rastgele == 4))
            {
                if (orgAtik.DolulukDurumu(prgBarOrg.Value))
                {
                    orgAtik.HacimAta(atiklar.Rastgele);
                    orgAtik.Ekle(orgAtik);
                    orgAtik.PuanHesapla(lblPuan.Text);
                    lstBoxOrg.Items.Add(orgAtik.EklenecekAtik);
                    prgBarOrg.Value = orgAtik.Doluluk;
                    lblPuan.Text = Convert.ToString(orgAtik.BosaltmaPuani);
                    AtikGetir();
                }
            }
            AtikGetir();

        }

        private void BtnKagit_Click(object sender, EventArgs e)// Kağıt butonuna basıldığında yapılacak işlemler.
        {
            if ((atiklar.Rastgele == 5) || (atiklar.Rastgele == 6))
            {
                if (kagit.DolulukDurumu(prgBarKagit.Value))
                {
                    kagit.HacimAta(atiklar.Rastgele);
                    kagit.Ekle(kagit);
                    kagit.PuanHesapla(lblPuan.Text);
                    lstBoxKagit.Items.Add(kagit.EklenecekAtik);
                    prgBarKagit.Value = kagit.Doluluk;
                    lblPuan.Text = Convert.ToString(kagit.BosaltmaPuani);
                    AtikGetir();
                }

            }
            AtikGetir();

        }

        private void BtnMetal_Click(object sender, EventArgs e)//Metal butonuna basıldığında yapılacak işlemler.
        {
            if ((atiklar.Rastgele == 7) || (atiklar.Rastgele == 8))
            {
                if (metal.DolulukDurumu(prgBarMetal.Value))
                {
                    metal.HacimAta(atiklar.Rastgele);
                    metal.Ekle(metal);
                    metal.PuanHesapla(lblPuan.Text);
                    lstBoxMetal.Items.Add(metal.EklenecekAtik);
                    prgBarMetal.Value = metal.Doluluk;
                    lblPuan.Text = Convert.ToString(metal.BosaltmaPuani);
                    AtikGetir();
                }
            }
            AtikGetir();

        }

        private void ClearOrg_Click(object sender, EventArgs e) //Organik atık boşaltılmak istendiğinde.
        {
            if (orgAtik.DoluMu(prgBarOrg.Value))

            {
                orgAtik.Bosalt(prgBarOrg.Value);
                prgBarOrg.Value = 0;
                lstBoxOrg.Items.Clear();
                lblSure.Text = atiklar.SureArttir(_saniye);
            }

        }

        private void ClearMetal_Click(object sender, EventArgs e)
        {
            if (metal.DoluMu(prgBarMetal.Value))

            {
                metal.Bosalt(prgBarMetal.Value);
                prgBarMetal.Value = 0;
                lstBoxMetal.Items.Clear();
                lblSure.Text = atiklar.SureArttir(_saniye);
            }
        }

        private void ClearCam_Click(object sender, EventArgs e)
        {
            if (camAtik.DoluMu(prgBarCam.Value))

            {
                camAtik.Bosalt(prgBarCam.Value);
                prgBarCam.Value = 0;
                lstBoxCam.Items.Clear();
                lblSure.Text = atiklar.SureArttir(_saniye);
            }
        }

        private void ClearKagit_Click(object sender, EventArgs e)
        {
            if (kagit.DoluMu(prgBarKagit.Value))

            {
                kagit.Bosalt(prgBarKagit.Value);
                prgBarKagit.Value = 0;
                lstBoxKagit.Items.Clear();
                lblSure.Text = atiklar.SureArttir(_saniye);
            }
        }
    }
}
