﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kütüphane_Otomasyon.Entity
{
    class Kitap_Iade
    {
        int kitapKayitId, ogrenciId, kitapId;
        DateTime kitapTeslim;
        DateTime kitapAlinma;
        bool kitapKontrol;
        float ogrenciCeza;


        public int KitapKayitId { get => kitapKayitId; set => kitapKayitId = value; }
        public int KitapId { get => kitapId; set => kitapId = value; }
        public int OgrenciId { get => ogrenciId; set => ogrenciId = value; }
        public DateTime KitapAlinma { get => kitapAlinma; set => kitapAlinma = value; }
        public DateTime KitapTeslim { get => kitapTeslim; set => kitapTeslim = value; }
        public bool KitapKontrol { get => kitapKontrol; set => kitapKontrol = value; }
        public float OgrenciCeza { get => ogrenciCeza; set => ogrenciCeza = value; }
    }
}
