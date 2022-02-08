using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
//using DAL;      // DAL katmanına erişim sağlandı
//using Entity;  //   Entity katmanına erişim sağlandı
//using Kütüphane_Otomasyon.DataAccessLayer;
using Kütüphane_Otomasyon.Entity;

namespace BL
{
    public class OgrenciBL
    {
        public static bool ogrenciKontrol_BL(string OgrenciNo, string OgrenciSifre)
        {
            Ogrenci ogrenci = new Ogrenci();
            if (ogrenci.OgrenciNo != "" && ogrenci.OgrenciSifre != "") // Gelen verilerin boş olmadığı kontrol edildi
            {
                return OgrenciDAL.ogrenciKontrol(ogrenci); // Veritabanından girilen değerlere ait öğrenci kontrol edildi
            }

            else                    //Eğer gelen veri boş ise false döndürdü
                return true;
        }

        public static bool ogrenciOkulNoKOntrol(string OgrenciNo)
        {
            Ogrenci ogrenci = new Ogrenci();
            if (ogrenci.OgrenciNo != "") // Gelen verilerin boş olmadığı kontrol edildi
            {
                return OgrenciDAL.OgrenciOkulNoKontrol(ogrenci); // Veritabanından girilen değerlere ait öğrenci kontrol edildi
            }

            else                    //Eğer gelen veri boş ise false döndürdü
                return false;
        }

        public static int ogrenciIdSorgu(string OgrenciNo, string OgrenciSifre)
        {
            Ogrenci ogrenci = new Ogrenci();
            if (ogrenci.OgrenciNo != "" && ogrenci.OgrenciSifre != "") // Gelen verilerin boş olmadığı kontrol edildi
            {
                return OgrenciDAL.ogrenciIdSorgu(ogrenci); // Veritabanından girilen değerlere ait öğrenci kontrol edildi
            }

            else                    //Eğer gelen veri boş ise false döndürdü
                return -1;
        }

        //public static bool ogrenciIdBilgi(int OgrenciId)
        //{
        //    Ogrenci ogrenci = new Ogrenci();
        //    if (ogrenci.OgrenciId != 0) // Gelen verilerin boş olmadığı kontrol edildi
        //    {
        //        return OgrenciDAL.ogrenciIdBilgi(ogrenci); // Veritabanından girilen değerlere ait öğrenci kontrol edildi
        //    }

        //    else                    //Eğer gelen veri boş ise NULL döndürdü
        //        return null;
        //}

        public static bool ogrenciSorgu_BL(int OgrenciId)
        {
            Ogrenci ogrenci = new Ogrenci();
            if (ogrenci.OgrenciId != 0) // Gelen verilerin boş olmadığı kontrol edildi
            {
                return OgrenciDAL.ogrenciSorgu(ogrenci); // Veritabanından girilen değerlere ait öğrenci kontrol edildi
            }

            else                    //Eğer gelen veri boş ise false döndürdü
                return false;
        }


        //Girilen öğrenci bilgileri DAL katmanı kullanılarak veritabanına eklendi
        public static int ogrenciEkle(string OgrenciAd, string OgrenciSoyad, string OgrenciNo, string OgrenciSifre)
        {
            Ogrenci ogrenci = new Ogrenci();
            if (ogrenci.OgrenciAd != "" && ogrenci.OgrenciSoyad != "" && ogrenci.OgrenciNo != "" && ogrenci.OgrenciSifre != "" && ogrenci.OgrenciCinsiyet != "")
            {

                return OgrenciDAL.ogrenciEkle(ogrenci);
            }

            else
                return -1;
        }


        //Girilen id 'ye  ait öğrenci DAL katmanı kullanılarak veri tabanından silindi
        public static int ogrenciSil(int OgrenciId)
        {
            Ogrenci ogrenci = new Ogrenci();
            if (ogrenci.OgrenciId != 0)
            {

                return OgrenciDAL.ogrenciSil(ogrenci);
            }

            else
                return -1;
        }

        //Girilen id 'ye  ait öğrenci DAL katmanı kullanılarak veri tabanındaki verileri güncellendi
        public static int ogrenciGuncelle(string OgrenciAd, string OgrenciSoyad, string OgrenciNo, string OgrenciSifre, string OgrenciCinsiyet, int OgrenciId)
        {
            Ogrenci ogrenci = new Ogrenci();
            if (ogrenci.OgrenciAd != "" && ogrenci.OgrenciSoyad != "" && ogrenci.OgrenciNo != "" && ogrenci.OgrenciSifre != "" && ogrenci.OgrenciCinsiyet != "" && ogrenci.OgrenciId != 0)
            {

                return OgrenciDAL.ogrenciGuncelle(ogrenci);
            }

            else
                return -1;
        }


        //Veri tabanındaki tüm öğrenci bilgileri DAL katmanı kullanılarak listeye aktarıldı
        //public static List<Ogrenci> liste()
        //{

        //    return OgrenciDAL.liste();
        //}






    }
}
