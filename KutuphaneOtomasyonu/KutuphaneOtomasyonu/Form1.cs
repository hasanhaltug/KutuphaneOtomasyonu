using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUye_Click(object sender, EventArgs e)
        {
            Uye _uye = new Uye();
            _uye.Show();
        }

        private void btnKitap_Click(object sender, EventArgs e)
        {
            Kitap _kitap = new Kitap();
            _kitap.Show();
        }

        private void btnTakip_Click(object sender, EventArgs e)
        {
               
            Takip _takip = new Takip();
            _takip.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
