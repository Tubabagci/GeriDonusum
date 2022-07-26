using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ndp_Proje
{
    class KagitK :Atiklar, IAtik, IAtikKutusu, IDolabilen
    {
        public int Hacim { get; set; }
        public Image Image => throw new NotImplementedException();
        Atiklar atik = new Atiklar();

        public int Kapasite { get; set; }
        public int DoluHacim { get; set; }
        public int Doluluk { get; set; }
        public int DolulukOrani { get; set; }

        public int BosaltmaPuani { get; set; }
        public string Sure { get; set; }

        public KagitK()
        {
            int _kapasite = 1200;
            Kapasite = _kapasite;

        }
        public void HacimAta(int rastgele)
        {


            if (rastgele == 5)
            {
                Hacim = 250;
                Rastgele = rastgele;
            }

            if (rastgele == 6)
            {
                Hacim = 200;
                Rastgele = rastgele;
            }
        }
        public void PuanHesapla(string puan)
        {

            BosaltmaPuani = Convert.ToInt32(puan);
            BosaltmaPuani += Hacim;
        }
        public bool DolulukDurumu(int doluKisim)
        {
            int eklenecek = 100 * Hacim / Kapasite;
            int bosKisim = 100 - doluKisim;

            if (bosKisim >= eklenecek)
            {
                doluKisim += eklenecek;
                Doluluk = doluKisim;
                return true;
            }

            return false;
        }

        public bool Ekle(IAtik atik)
        {


            if (Kapasite > DoluHacim + Hacim)
            {
                if (Rastgele == 5)
                {
                    EklenecekAtik = "Gazete" + " (" + Convert.ToString(Hacim) + ")";
                    DoluHacim += Hacim;
                    return true;
                }

                else if (Rastgele == 6)
                {

                    EklenecekAtik = "Dergi" + " (" + Convert.ToString(Hacim) + ")";
                    DoluHacim += Hacim;
                    return true;
                }
                return false;
            }
            return false;

        }


        public bool DoluMu(int _doluKisim)
        {
            if (_doluKisim >= 75)
                return true;
            else
                return false;

        }
        public bool Bosalt(int doluKisim)
        {
            int sinir;
            DolulukOrani = doluKisim;

            sinir = Kapasite * 75 / 100;

            if (sinir <= DolulukOrani)
            {
                DolulukOrani = 0;
                DoluHacim = 0;

                return true;
            }
            return false;
        }




    }
}
