using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Linq;

namespace KutuphaneOtomasyonu
{
    public partial class Uye : Form
    {
        SqlIslemler _sqlIslemler = new SqlIslemler();

        public static string link = "Data Source=DESKTOP-D8TI7N7\\SQLEXPRESS;Initial Catalog=Kutuphane;Integrated Security=True";
        SqlConnection connection = new SqlConnection(link);
        public Uye()
        {
            InitializeComponent();
        }

        private void Uye_Load(object sender, EventArgs e)
        {
            dtGVUye.DataSource = _sqlIslemler.listele("Select * From Uyeler");  
        }
        
        private void TextBoxClear()
        {          
                txtUAd.Clear();
                txtSoyad.Clear();
                txtMeslek.Clear();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Insert Into Uyeler (Ad,Soyad,Meslek,CezaPuanı) Values (@Ad, @Soyad, @Meslek,'" + 0 + "')", connection);
            if (txtUAd.Text != "" & txtSoyad.Text != "")
            {
                connection.Open();
                komut.Parameters.AddWithValue("@Ad", txtUAd.Text);
                komut.Parameters.AddWithValue("@Soyad", txtSoyad.Text);
                komut.Parameters.AddWithValue("@Meslek", txtMeslek.Text);
                komut.ExecuteNonQuery();
                connection.Close();
                TextBoxClear();
                MessageBox.Show("Üye kaydı başarıyla gerçekleşmiştir", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ad ve soyad boş bırakılamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dtGVUye.DataSource = _sqlIslemler.listele("Select * From Uyeler");
            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Silmek istediğinizden emin misiniz?", "Kontol", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            SqlCommand cmdDelete = new SqlCommand("Delete Uyeler where ID = @SecilenUye", connection);

            if ((int)dtGVUye.SelectedRows.Count == 1 & res == DialogResult.Yes)
            {
                connection.Open();
                cmdDelete.Parameters.AddWithValue("@SecilenUye", (int)dtGVUye.SelectedCells[0].Value);
                cmdDelete.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Üye silme işlemi başarıyla gerçekleşmiştir", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            dtGVUye.DataSource = _sqlIslemler.listele("Select * From Uyeler");

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {         
            txtUAd.Text = dtGVUye.CurrentRow.Cells[1].Value.ToString();
            txtSoyad.Text = dtGVUye.CurrentRow.Cells[2].Value.ToString();
            txtMeslek.Text = dtGVUye.CurrentRow.Cells[3].Value.ToString();
            
            btnGuncelle.Visible = false;
            btnEkle.Visible = false;
            btnEkle.Enabled = false;
            //buton oluşturma
            Button btnGuncel = new Button();
            btnGuncel.Width = 130;
            btnGuncel.Height = 23;
            btnGuncel.BackColor = Color.Gainsboro;
            btnGuncel.ForeColor = Color.Black;
            btnGuncel.Location = new Point(640, 274);
            btnGuncel.Text = "Güncelle";
            btnGuncel.Name = "btnGuncel";
            btnGuncel.Font = new Font("Segoe UI", 9);
            btnGuncel.Click += new EventHandler(btnGuncel_Click);
            Controls.Add(btnGuncel);

        }

        private void btnGuncel_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Güncellemek istediğinizden emin misiniz?", "Kontrol", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            SqlCommand cmd = new SqlCommand("Update Uyeler set Ad=@ad, Soyad=@soyad, Meslek=@meslek where ID=@secilenID", connection);
            if (res == DialogResult.Yes)
            {
                connection.Open();
                cmd.Parameters.AddWithValue("@secilenID", (int)dtGVUye.CurrentRow.Cells[0].Value);
                cmd.Parameters.AddWithValue("@ad", txtUAd.Text);
                cmd.Parameters.AddWithValue("@soyad", txtSoyad.Text);
                cmd.Parameters.AddWithValue("@meslek", txtMeslek.Text);
                cmd.ExecuteNonQuery();
                connection.Close();
                TextBoxClear();
                MessageBox.Show("Güncelleme işlemi başarıyla gerçekleşmiştir", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtGVUye.DataSource = _sqlIslemler.listele("Select * From Uyeler");
                btnGuncelle.Visible = true;
                btnEkle.Visible = true;
                btnEkle.Enabled = true;

            }
        }

       
    }

    
}
