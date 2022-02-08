using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;  //  Grafik işlemlerini yapabilmek için ZedGraph kütüphanesini kullanmamız gerekiyordu.
                 //  Bu yüzden proje üzerindeki Reference bölümünden bunu kodumuza dahil ettik daha sonra
                 //  toolbox menüsünde .net framework alanından zedgraph.dll seçeneğini işaretleyip toolbox menüsüne dahil etmiş olduk. 





namespace Kütüphane_Otomasyon.PresentationLayer
{
    public partial class Grafik_Form : Form
    {
        public Grafik_Form()
        {
            InitializeComponent();
        }

        private void Grafik_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
