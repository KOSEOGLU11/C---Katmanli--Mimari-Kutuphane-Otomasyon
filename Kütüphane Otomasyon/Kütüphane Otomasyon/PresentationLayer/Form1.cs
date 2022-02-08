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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void personel_giris_Click(object sender, EventArgs e)
        {
            string gelenad = textBox1.Text;
            string gelensifre = textBox2.Text;

            if (gelenad.Equals("admin")&&gelensifre.Equals("123"))
            {
                MessageBox.Show("giriş başarılı");

                Islem_Paneli_Form panel1 = new Islem_Paneli_Form();
                panel1.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("giriş başarısız");
            }
        }
    }
}
