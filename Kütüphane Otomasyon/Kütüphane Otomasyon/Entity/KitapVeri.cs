using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kütüphane_Otomasyon.Entity
{
    class KitapVeri
    {
        int kitapId;
        string kitapAd, kitapTuru, kitapSayfa, kitapYazar;
        public int KitapId { get => kitapId; set => kitapId = value; }
        public string KitapAd { get => kitapAd; set => kitapAd = value; }
        public string KitapTuru { get => kitapTuru; set => kitapTuru = value; }
        public string KitapSayfa { get => kitapSayfa; set => kitapSayfa = value; }
        public string KitapYazar { get => kitapYazar; set => kitapYazar = value; }
    }
}
