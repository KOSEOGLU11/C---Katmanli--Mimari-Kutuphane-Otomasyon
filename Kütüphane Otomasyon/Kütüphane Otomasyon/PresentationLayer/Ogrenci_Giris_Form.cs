
using Kütüphane_Otomasyon.BusinessLayer;
using Kütüphane_Otomasyon.Entity;
using Kütüphane_Otomasyon.PresentationLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kütüphane_Otomasyon
{
    public partial class Ogrenci_Giris_Form : Form
    {
        public Ogrenci_Giris_Form()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "") //Textlerin boş bırakılmaması kontrol edildi
            {
                Ogrenci ogrenci = new Ogrenci()       //Entity katmanındaki verilere girilen değerler aktarıldı
                {
                    OgrenciNo = textBox1.Text,
                    OgrenciSifre = textBox2.Text

                };

                //    if (OgrenciBL.ogrenciKontrol_BL(ogrenci) == true) // Veritabanındaki tabloda girilen değerlere ait öğrenci var mı kontrol edildi
                //    {
                //        lblIdOgrenciGiris.Text = OgrenciBL.ogrenciIdSorgu(ogrenci).ToString(); //id ataması yapıldı
                //        MessageBox.Show("Giriş Başarlı");
                //        Öğrenci_Form ogr = new Öğrenci_Form();
                //        ogr.lblIdOgrenciForm.Text = lblIdOgrenciGiris.Text;
                //        this.Hide();                         // Şuan bulunduğumuz form kapatıldı
                //        ogr.Show();                 // Oluşturulan nesne ile geçiş yapılacak form ekranı açıldı


                //    }
                //    else
                //        MessageBox.Show("Hatalı giriş !");

                //}

                //else
                //{
                //    MessageBox.Show("Gerekli alanları doldurunuz!");
                //}

            }

        }
    }
}
