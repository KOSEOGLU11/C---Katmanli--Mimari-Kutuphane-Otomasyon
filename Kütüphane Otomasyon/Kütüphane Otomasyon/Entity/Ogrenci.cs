using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kütüphane_Otomasyon.Entity
{
    class Ogrenci
    {
        int ogrenciId;
        string ogrenciAd, ogrenciSoyad, ogrenciNo, ogrenciSifre, ogrenciCinsiyet;
        float ogrenciCeza;

        public int OgrenciId { get => ogrenciId; set => ogrenciId = value; }
        public string OgrenciAd { get => ogrenciAd; set => ogrenciAd = value; }
        public string OgrenciSoyad { get => ogrenciSoyad; set => ogrenciSoyad = value; }
        public string OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
        public string OgrenciSifre { get => ogrenciSifre; set => ogrenciSifre = value; }
        public string OgrenciCinsiyet { get => ogrenciCinsiyet; set => ogrenciCinsiyet = value; }
        public float OgrenciCeza { get => ogrenciCeza; set => ogrenciCeza = value; }
    }
}
