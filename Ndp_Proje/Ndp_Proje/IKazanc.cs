using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ndp_Proje
{
    interface IKazanc
    {
       
        string Sure { get; set; }
        void PuanHesapla(string puan);
        void HacimAta(int rastgele);
     
    }
}
