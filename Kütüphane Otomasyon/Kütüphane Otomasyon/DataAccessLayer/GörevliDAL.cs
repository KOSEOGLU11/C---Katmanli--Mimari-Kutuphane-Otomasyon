using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;  // Veri tabanı bağlantısı için gerekli kütüphaneyi ekledik.
using System.Data;       // Veri tabanı bağlantısı için gerekli kütüphaneyi ekledik.
//using Entity;          // Entity katmanını kullandık.
using Kütüphane_Otomasyon.Entity;
using System.Windows.Forms;


namespace DAL
{
    public class GorevliDAL
    {
        //Görevlinin sistemde kayıtlı olma durumu kontrol edildi
        public static bool gorevliKontrol(string GorevliTc, string GorevliSifre)
        {
            Görevli gorevli = new Görevli();
            OleDbCommand command = new OleDbCommand("Select * from Gorevli where GorevliTc=@gorevTc and GorevliSifre=@gorevSifre", Baglanti.baglanti);
            Baglanti.Connection(command);
            command.Parameters.AddWithValue("@gorevTc", gorevli.gorevTc);
            command.Parameters.AddWithValue("@gorevSifre", gorevli.gorevSifre);

            OleDbDataReader okuma = command.ExecuteReader();
            bool sonuc = false;
            int sayac = 0;

            while (okuma.Read())
            {
                sayac++;
            }


            if (sayac > 0)
            {
                sonuc = true;
            }

            return sonuc;


        }
    }
}
