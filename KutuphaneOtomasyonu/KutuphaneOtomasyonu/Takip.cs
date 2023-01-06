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
    public partial class Takip : Form
    {
        public static string link = "Data Source=DESKTOP-D8TI7N7\\SQLEXPRESS;Initial Catalog=Kutuphane;Integrated Security=True";
        SqlConnection connection = new SqlConnection(link);
        SqlIslemler _sqlIslemler = new SqlIslemler();
        DataTable dt2;
        DateTime gelis;
        public Takip()
        {
            InitializeComponent();
            dt2 = new DataTable();
            gelis = new DateTime();

        }

        private void Takip_Load(object sender, EventArgs e)
        {
            dtGVTakip.DataSource = _sqlIslemler.listele("Select * From Takip");
            cmbDoldur();

        }
        void cmbDoldur()
        {
            dt2 = _sqlIslemler.listele("Select ID,KitapAdi From Kitaplar where Uygunluk = 1");
            foreach (DataRow item in dt2.Rows)
            {
                cmbKitaplar.Items.Add(item.ItemArray[1].ToString());
            }

        }

        private void TextBoxClear()
        {
            txtUyeID.Clear();
        }
        

        private void btnEkle_Click(object sender, EventArgs e)
        {
            
            SqlCommand komut3 = new SqlCommand("Insert Into Takip (UyeID,KitapID,AlımTarihi,TeslimTarihi) Values (@UyeID,@KitapID,@AlımTarihi,@TeslimTarihi)", connection);
            connection.Open();
            SqlCommand kontrolUye = new SqlCommand("Select Count(ID) from Uyeler where ID=@uyekontrol", connection);
            kontrolUye.Parameters.AddWithValue("@uyekontrol", int.Parse(txtUyeID.Text));
            int _Uye = (int)kontrolUye.ExecuteScalar();

            connection.Close();

            
            if (txtUyeID.Text != "" & cmbKitaplar.SelectedItem != null )
            {
                if(_Uye == 1)
                {
                    SqlCommand IDCheck = new SqlCommand("Select ID from Kitaplar Where KitapAdi=@Secilen",connection);
                    SqlCommand KitapGuncelle = new SqlCommand("Update Kitaplar set Uygunluk = 0 where ID = @SecilenID", connection);

                    connection.Open();
                    IDCheck.Parameters.AddWithValue("@Secilen", cmbKitaplar.SelectedItem.ToString());
                    KitapGuncelle.Parameters.AddWithValue("@SecilenID", (int)IDCheck.ExecuteScalar());
                    komut3.Parameters.AddWithValue("@UyeID", int.Parse(txtUyeID.Text));
                    komut3.Parameters.AddWithValue("@KitapID",(int)IDCheck.ExecuteScalar());
                    komut3.Parameters.AddWithValue("@AlımTarihi", DateTime.Now);
                    DateTime teslim = DateTime.Today.AddDays(15);
                    komut3.Parameters.AddWithValue("@TeslimTarihi", teslim);
                    komut3.ExecuteNonQuery();
                    KitapGuncelle.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("Kİtap alım başarıyla gerçekleşmiştir", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TextBoxClear();
                    cmbKitaplar.Items.Clear();
                    cmbKitaplar.Text = null;
                    cmbDoldur();

                }
                else
                {
                    MessageBox.Show("Bu ID ye ait Üye kaydı bulunamamıştır.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            else
            {
                MessageBox.Show("Üye Id veya Kitap seçimi boş bırakılamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

            dtGVTakip.DataSource = _sqlIslemler.listele("Select * From Takip");
           
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SayfaDuzenDegisimi();

        }

        void SayfaDuzenDegisimi()
        {
            lblUyeID.Visible = false;
            lblKitaplar.Visible = false;
            txtUyeID.Visible = false;
            cmbKitaplar.Visible = false;
            btnGuncelle.Visible = false;
            btnEkle.Visible = false;
            btnEkle.Enabled = false;
            dtpTakvim.Visible = true;
            lbliade.Visible = true;
            btnGuncel.Visible = true;

            //Label oluşturma
            //Label lblGeldigiTarih = new Label();
            //lblGeldigiTarih.Width = 83;
            //lblGeldigiTarih.Height = 23;
            //lblGeldigiTarih.BackColor = Color.WhiteSmoke;
            //lblGeldigiTarih.ForeColor = Color.Black;
            //lblGeldigiTarih.Location = new Point(511, 60);
            //lblGeldigiTarih.Text = "İade Tarihi:";
            //lblGeldigiTarih.Name = "lblGeldigiTarih";
            //lblGeldigiTarih.Font = new Font("Segoe UI", 12);
            //Controls.Add(lblGeldigiTarih);

            //DateTime
            //DateTimePicker takvim = new DateTimePicker();
            //takvim.Width = 289; ;
            //takvim.Height = 23;
            //takvim.Location = new Point(600, 58);
            //takvim.Name = "dtptakvim";


            //buton oluşturma
            //Button btnGuncel = new Button();
            //btnGuncel.Width = 144;
            //btnGuncel.Height = 23;
            //btnGuncel.BackColor = Color.Gainsboro;
            //btnGuncel.ForeColor = Color.Black;
            //btnGuncel.Location = new Point(658, 115);
            //btnGuncel.Text = "Güncelle";
            //btnGuncel.Name = "btnGuncel";
            //btnGuncel.Font = new Font("Segoe UI", 9);
            //btnGuncel.Click += new EventHandler(btnGuncel_Click);
            //Controls.Add(btnGuncel);

            //datetimepicker gmrünür kısım belirleme
            SqlCommand cmd = new SqlCommand("select AlımTarihi from Takip where ID=@secilen", connection);
            connection.Open();
            cmd.Parameters.AddWithValue("@secilen", (int)dtGVTakip.CurrentRow.Cells[0].Value);
            DataTable alim = new DataTable();
            SqlDataAdapter _adapter = new SqlDataAdapter(cmd);
            _adapter.Fill(alim);
            connection.Close();
            foreach (DataRow item in alim.Rows)
            {
                dtpTakvim.MinDate = (DateTime)item.ItemArray[0];
            }
            dtpTakvim.MaxDate = DateTime.Now;

        }

        private void btnGuncel_Click(object sender, EventArgs e)
        {
            int ceza;
            SqlCommand cmd = new SqlCommand("Update Takip set GeldigiTarih=@takvim where ID=@kontrol", connection);
            SqlCommand cmd2 = new SqlCommand("Update Kitaplar set Uygunluk=1 where ID=@secilen", connection);
            SqlCommand cmd3 = new SqlCommand("Update Uyeler set CezaPuanı=@ceza where ID=@uye", connection);
            SqlCommand cmd4 = new SqlCommand("Select CezaPuanı from Uyeler where ID=@uye", connection);
            connection.Open();
            cmd.Parameters.AddWithValue("@kontrol", (int)dtGVTakip.CurrentRow.Cells[0].Value);
            cmd.Parameters.AddWithValue("@takvim", dtpTakvim.Value);
            cmd2.Parameters.AddWithValue("@secilen", (int)dtGVTakip.CurrentRow.Cells[2].Value);
            cmd3.Parameters.AddWithValue("@uye", (int)dtGVTakip.CurrentRow.Cells[1].Value);
            cmd4.Parameters.AddWithValue("@uye", (int)dtGVTakip.CurrentRow.Cells[1].Value);
            DataTable cezaPuan = new DataTable();
            SqlDataAdapter _adapter = new SqlDataAdapter(cmd4);
            _adapter.Fill(cezaPuan);
            foreach (DataRow item in cezaPuan.Rows)
            {
                ceza = (int)item.ItemArray[0];
                int sonuc;
                DateTime dt, ts = new DateTime();
                dt = (DateTime)dtGVTakip.CurrentRow.Cells[4].Value;
                ts = dtpTakvim.Value;

                if (dtpTakvim.Value > (DateTime)dtGVTakip.CurrentRow.Cells[4].Value)
                {
                    TimeSpan cezagun = ts - dt;
                    int hesap = int.Parse(cezagun.Days.ToString());
                    sonuc = ceza + (2 * hesap);
                    cmd3.Parameters.AddWithValue("@ceza", sonuc);
                    MessageBox.Show("Teslim geciktiğinden ceza alınmıştır. \nGüncel ceza:" + sonuc.ToString(), "Ceza Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    cmd3.Parameters.AddWithValue("@ceza", ceza);
                    MessageBox.Show("Ceza almadan teslim gerçekleşmiştir. \nGüncel ceza:" + ceza.ToString(), "Ceza Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            cmd.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            cmd3.ExecuteNonQuery();
            connection.Close();
            lblUyeID.Visible = true;
            lblKitaplar.Visible = true;
            txtUyeID.Visible = true;
            cmbKitaplar.Visible = true;
            btnGuncelle.Visible = true;
            btnEkle.Visible = true;
            btnEkle.Enabled = true;
            dtpTakvim.Visible = false;
            lbliade.Visible = false;
            btnGuncel.Visible = false;

            dtGVTakip.DataSource = _sqlIslemler.listele("Select * From Takip");
            TextBoxClear();
            cmbKitaplar.Items.Clear();
            cmbKitaplar.Text = null;
            cmbDoldur();
        }       
    }
}
