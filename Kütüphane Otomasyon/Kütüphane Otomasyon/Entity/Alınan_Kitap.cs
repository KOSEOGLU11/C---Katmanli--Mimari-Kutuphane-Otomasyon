using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kütüphane_Otomasyon.Entity
{
    class AlınanKitap //alınan kitapları diğer katmanlarda kullanabilmek için burada get ve set işlemlerini kullanıyoruz.
    {
        int ogrenciId;
        string kitapAd, kitapTeslim;
        DateTime kitapAlinma;
        bool kitapKontrol;

        public int OgrenciId { get => ogrenciId; set => ogrenciId = value; }
        public string KitapAd { get => kitapAd; set => kitapAd = value; }
        public DateTime KitapAlinma { get => kitapAlinma; set => kitapAlinma = value; }
        public string KitapTeslim { get => kitapTeslim; set => kitapTeslim = value; }
        public bool KitapKontrol { get => kitapKontrol; set => kitapKontrol = value; }
    }
}
