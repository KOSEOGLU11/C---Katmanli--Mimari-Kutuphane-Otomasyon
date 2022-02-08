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
    public partial class Islem_Paneli_Form : Form
    {
        public Islem_Paneli_Form()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit(); // Uygulama kapatıldı
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kitap_Islemleri_Form kitap = new Kitap_Islemleri_Form(); //Nesne oluşturuldu
            this.Hide();                                      // aktif form kapatıldı
            kitap.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Ogrenci_Giris_Form ogrenci = new Ogrenci_Giris_Form(); //Nesne oluşturuldu
            this.Hide();                                      // aktif form kapatıldı
            ogrenci.Show();

        }
    }
}
