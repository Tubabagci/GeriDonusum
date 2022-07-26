using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ndp_Proje
{
    class CamK : Atiklar, IAtik, IAtikKutusu, IDolabilen, IKazanc
    {
        public int Hacim { get; set; }
        public Image Image => throw new NotImplementedException();

        //Property'lerin tanımlanması.

        public int Kapasite { get; set; }
        public int DoluHacim { get; set; }
        public int Doluluk { get; set; }
        public int DolulukOrani { get; set; }
        
        public int BosaltmaPuani { get; set; }
        public string Sure { get; set; }

        public CamK()
        {//Kurucu
            int _kapasite = 2200;
            Kapasite = _kapasite;
            
        }
        public void HacimAta(int rastgele)
        {//Gelen nesneye göre hacşm atar.


            if (rastgele == 1)
            {
                Hacim = 250;
                Rastgele = rastgele;
            }

            if (rastgele == 2)
            {
                Hacim = 600;
                Rastgele = rastgele;
            }
        }
        public void PuanHesapla(string puan)
        {//Nesneye göre puan eklemesi yapar

            BosaltmaPuani = Convert.ToInt32(puan);
            BosaltmaPuani += Hacim;
        }

        public bool DolulukDurumu(int doluKisim)//Doluysa daha fazla ürün eklememesini sağlamak içindir.
        {
         int eklenecek=   100 * Hacim / Kapasite;
            int bosKisim = 100 - doluKisim;
            
            if (bosKisim >= eklenecek)
            {
                doluKisim += eklenecek;
                Doluluk=doluKisim;
                return true;
            }

            return false;
        }

        public bool Ekle(IAtik atik)//Atıkları istenen kutulara ekler.
        {


            if (Kapasite > DoluHacim + Hacim)
            {
                if (Rastgele == 1)
                {
                    EklenecekAtik = "Cam bardak" + " (" + Convert.ToString(Hacim) + ")";
                    DoluHacim += Hacim;
                    return true;
                }

                else if (Rastgele == 2)
                {

                    EklenecekAtik = "Cam şişe" + " (" + Convert.ToString(Hacim) + ")";
                    DoluHacim += Hacim;
                    return true;
                }
                return false;
            }
            return false;

        }

        public bool DoluMu(int _doluKisim)//%75 dolu ise boşaltma yapsın.
        {
            if (_doluKisim >= 75)
                return true;
            else
                return false;

        }

      public bool Bosalt(int doluKisim) {//Kutuyu boşaltır.
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
