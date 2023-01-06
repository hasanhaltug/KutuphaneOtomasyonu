using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace KutuphaneOtomasyonu
{
    public partial class Kitap : Form
    {
        public static string link = "Data Source=DESKTOP-D8TI7N7\\SQLEXPRESS;Initial Catalog=Kutuphane;Integrated Security=True";
        SqlConnection connection = new SqlConnection(link);

        SqlIslemler _sqlIslemler = new SqlIslemler();
        public Kitap()
        {
            InitializeComponent();
            
        }

        private void Kitap_Load(object sender, EventArgs e)
        {
            dtGVKitap.DataSource = _sqlIslemler.listele("Select * From Kitaplar");
        }

        private void TextBoxClear()
        {
            txtKitapAdi.Clear();
            txtYazar.Clear();
            txtTur.Clear();
            txtSayfa.Clear();
            checkUygunluk.Checked = false;
            
        }

        private void btnKEkle_Click(object sender, EventArgs e)
        {
            var uygunlukbit = 1;
            SqlCommand komut2 = new SqlCommand("Insert Into Kitaplar (KitapAdi,Yazar,Tur,Sayfa,Uygunluk) Values (@KitapAdi, @Yazar, @Tur,@Sayfa,@Uygunluk)", connection);
            if (txtKitapAdi.Text != "" & txtYazar.Text != "")
            {
                connection.Open();

                komut2.Parameters.AddWithValue("@KitapAdi", txtKitapAdi.Text.ToString());
                komut2.Parameters.AddWithValue("@Yazar", txtYazar.Text.ToString());
                komut2.Parameters.AddWithValue("@Tur", txtTur.Text.ToString());
                komut2.Parameters.AddWithValue("@Sayfa", int.Parse(txtSayfa.Text.ToString()));

                if (checkUygunluk.Checked == true)
                    uygunlukbit = 1;
                else
                    uygunlukbit = 0;

                komut2.Parameters.AddWithValue("@Uygunluk", uygunlukbit);
                komut2.ExecuteNonQuery();
                connection.Close();
                TextBoxClear();

            }
            else
            {
                MessageBox.Show("Kitap adı ve yazar adı boş bırakılamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            dtGVKitap.DataSource = _sqlIslemler.listele("Select * From Kitaplar");
            MessageBox.Show("Kitap kaydı başarıyla gerçekleşmiştir", "Bilgilendirme", MessageBoxButtons.OK,MessageBoxIcon.Information);         
        }

        private void btnKSil_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Silmek istediğinizden emin misiniz?", "Kontol", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            SqlCommand cmdDelete = new SqlCommand("Delete Kitaplar where ID = @SecilenUye", connection);

            if ((int)dtGVKitap.SelectedRows.Count == 1 & res == DialogResult.Yes)
            {
                connection.Open();
                cmdDelete.Parameters.AddWithValue("@SecilenUye", (int)dtGVKitap.SelectedCells[0].Value);
                cmdDelete.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Kitap silme işlemi başarıyla gerçekleşmiştir", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            dtGVKitap.DataSource = _sqlIslemler.listele("Select * From Kitaplar");


        }

        private void btnKGuncelle_Click(object sender, EventArgs e)
        {
            txtKitapAdi.Text = dtGVKitap.CurrentRow.Cells[1].Value.ToString();
            txtYazar.Text = dtGVKitap.CurrentRow.Cells[2].Value.ToString();
            txtTur.Text = dtGVKitap.CurrentRow.Cells[3].Value.ToString();
            txtSayfa.Text =  dtGVKitap.CurrentRow.Cells[4].Value.ToString();
            string uygunluk = dtGVKitap.CurrentRow.Cells[5].Value.ToString();
            if (uygunluk == "True")
                checkUygunluk.Checked = true;
            else
                checkUygunluk.Checked = false;

            btnKGuncelle.Visible = false;
            btnKEkle.Visible = false;
            btnKEkle.Enabled = false;
            //buton oluşturma
            Button btnGuncel = new Button();
            btnGuncel.Width = 130;
            btnGuncel.Height = 23;
            btnGuncel.BackColor = Color.Gainsboro;
            btnGuncel.ForeColor = Color.Black;
            btnGuncel.Location = new Point(952, 324);
            btnGuncel.Text = "Güncelle";
            btnGuncel.Name = "btnGuncel";
            btnGuncel.Font = new Font("Segoe UI", 9);
            btnGuncel.Click += new EventHandler(btnGuncel_Click);
            Controls.Add(btnGuncel);

        }

        private void btnGuncel_Click(object sender, EventArgs e)
        {
            var bit = 1;
            SqlCommand cmd = new SqlCommand("Update Kitaplar set KitapAdi=@kitapadi,Yazar=@yazar,Tur=@tur,Sayfa=@sayfa,Uygunluk=@uygunluk where ID=@secilenID", connection);
            SqlCommand cmd2 = new SqlCommand("Select GeldigiTarih from Takip where KitapID=@kitapId", connection);
            connection.Open();
            cmd2.Parameters.AddWithValue("@kitapId", (int)dtGVKitap.CurrentRow.Cells[0].Value);
            DataTable dt = new DataTable();
            SqlDataAdapter _adapter = new SqlDataAdapter(cmd2);
            _adapter.Fill(dt);
            connection.Close();
            int sayac = 0;
            foreach (DataRow item  in dt.Rows)
            {
                if(dt.Rows[sayac].ItemArray[0].ToString() == "")
                {
                    bit = 0;
                }
                sayac++;
            }


            if (checkUygunluk.Checked == true & bit == 0)
            {
                 MessageBox.Show("Bu kitapta uygunluk güncellemesini aktif edemezsiniz. Kitap henüz teslim edilmemiştir.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                 DialogResult res = MessageBox.Show("Güncellemek istediğinizden emin misiniz?", "Kontrol", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (res == DialogResult.Yes)
                {
                    var uygunlukbit = 1;
                    if (checkUygunluk.Checked == true)
                        uygunlukbit = 1;
                    else
                        uygunlukbit = 0;

                    connection.Open();
                    cmd.Parameters.AddWithValue("@secilenID", (int)dtGVKitap.CurrentRow.Cells[0].Value);
                    cmd.Parameters.AddWithValue("@kitapadi", txtKitapAdi.Text);
                    cmd.Parameters.AddWithValue("@yazar", txtYazar.Text);
                    cmd.Parameters.AddWithValue("@tur", txtTur.Text);
                    cmd.Parameters.AddWithValue("@sayfa", int.Parse(txtSayfa.Text));
                    cmd.Parameters.AddWithValue("@uygunluk", uygunlukbit);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Güncelleme işlemi başarıyla gerçekleşmiştir", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dtGVKitap.DataSource = _sqlIslemler.listele("Select * From Kitaplar");
                    TextBoxClear();
                    btnKGuncelle.Visible = true;
                    btnKEkle.Visible = true;
                    btnKEkle.Enabled = true;

                    }

                }              
        }
    }
}
