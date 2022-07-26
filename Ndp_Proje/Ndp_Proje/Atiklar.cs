using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ndp_Proje
{
    public class Atiklar
    {
        public int Rastgele { get; set; }
        public string EklenecekAtik { get; set; }

        Random rnd = new Random();

        public void RastgeleGetir()//Rastgele fotoğrafı seçer.
        {

            int rastgele = rnd.Next(1, 8);
            Rastgele = rastgele;
        }
        public string SureArttir(int _saniye)//Sğreye 3 sn ekler.
        {
          _saniye += 3;
          return Convert.ToString(_saniye);
        }




    }
}
