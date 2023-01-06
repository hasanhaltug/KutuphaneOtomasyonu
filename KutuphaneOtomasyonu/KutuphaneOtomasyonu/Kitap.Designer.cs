
namespace KutuphaneOtomasyonu
{
    partial class Kitap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtGVKitap = new System.Windows.Forms.DataGridView();
            this.txtTur = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtYazar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnKEkle = new System.Windows.Forms.Button();
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.btnKSil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKGuncelle = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSayfa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.checkUygunluk = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVKitap)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(894, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 21);
            this.label4.TabIndex = 15;
            this.label4.Text = "Kitap Kayıt Bilgileri";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtGVKitap);
            this.groupBox1.Location = new System.Drawing.Point(8, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(811, 388);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kitap Listesi";
            // 
            // dtGVKitap
            // 
            this.dtGVKitap.AllowUserToAddRows = false;
            this.dtGVKitap.AllowUserToDeleteRows = false;
            this.dtGVKitap.AllowUserToResizeColumns = false;
            this.dtGVKitap.AllowUserToResizeRows = false;
            this.dtGVKitap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtGVKitap.BackgroundColor = System.Drawing.Color.White;
            this.dtGVKitap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGVKitap.GridColor = System.Drawing.SystemColors.Window;
            this.dtGVKitap.Location = new System.Drawing.Point(7, 23);
            this.dtGVKitap.MultiSelect = false;
            this.dtGVKitap.Name = "dtGVKitap";
            this.dtGVKitap.ReadOnly = true;
            this.dtGVKitap.RowHeadersVisible = false;
            this.dtGVKitap.RowTemplate.Height = 25;
            this.dtGVKitap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGVKitap.Size = new System.Drawing.Size(798, 359);
            this.dtGVKitap.TabIndex = 0;
            this.dtGVKitap.TabStop = false;
            // 
            // txtTur
            // 
            this.txtTur.Location = new System.Drawing.Point(926, 191);
            this.txtTur.Name = "txtTur";
            this.txtTur.Size = new System.Drawing.Size(181, 23);
            this.txtTur.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(869, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tür:";
            // 
            // txtYazar
            // 
            this.txtYazar.Location = new System.Drawing.Point(926, 151);
            this.txtYazar.Name = "txtYazar";
            this.txtYazar.Size = new System.Drawing.Size(181, 23);
            this.txtYazar.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(855, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Yazar:";
            // 
            // btnKEkle
            // 
            this.btnKEkle.Location = new System.Drawing.Point(952, 324);
            this.btnKEkle.Name = "btnKEkle";
            this.btnKEkle.Size = new System.Drawing.Size(130, 23);
            this.btnKEkle.TabIndex = 6;
            this.btnKEkle.Text = "Ekle";
            this.btnKEkle.UseVisualStyleBackColor = true;
            this.btnKEkle.Click += new System.EventHandler(this.btnKEkle_Click);
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.Location = new System.Drawing.Point(926, 112);
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(181, 23);
            this.txtKitapAdi.TabIndex = 1;
            // 
            // btnKSil
            // 
            this.btnKSil.Location = new System.Drawing.Point(395, 411);
            this.btnKSil.Name = "btnKSil";
            this.btnKSil.Size = new System.Drawing.Size(121, 23);
            this.btnKSil.TabIndex = 8;
            this.btnKSil.Text = "Sil";
            this.btnKSil.UseVisualStyleBackColor = true;
            this.btnKSil.Click += new System.EventHandler(this.btnKSil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(830, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Kitap Adı:";
            // 
            // btnKGuncelle
            // 
            this.btnKGuncelle.Location = new System.Drawing.Point(104, 411);
            this.btnKGuncelle.Name = "btnKGuncelle";
            this.btnKGuncelle.Size = new System.Drawing.Size(121, 23);
            this.btnKGuncelle.TabIndex = 7;
            this.btnKGuncelle.Text = "Güncelle";
            this.btnKGuncelle.UseVisualStyleBackColor = true;
            this.btnKGuncelle.Click += new System.EventHandler(this.btnKGuncelle_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(854, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Sayfa:";
            // 
            // txtSayfa
            // 
            this.txtSayfa.Location = new System.Drawing.Point(926, 233);
            this.txtSayfa.Name = "txtSayfa";
            this.txtSayfa.Size = new System.Drawing.Size(181, 23);
            this.txtSayfa.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(825, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 21);
            this.label6.TabIndex = 8;
            this.label6.Text = "Uygunluk:";
            // 
            // checkUygunluk
            // 
            this.checkUygunluk.AutoSize = true;
            this.checkUygunluk.Location = new System.Drawing.Point(926, 280);
            this.checkUygunluk.Name = "checkUygunluk";
            this.checkUygunluk.Size = new System.Drawing.Size(79, 19);
            this.checkUygunluk.TabIndex = 5;
            this.checkUygunluk.Text = "Uygundur";
            this.checkUygunluk.UseVisualStyleBackColor = true;
            // 
            // Kitap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 450);
            this.Controls.Add(this.checkUygunluk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtTur);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSayfa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtYazar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnKEkle);
            this.Controls.Add(this.txtKitapAdi);
            this.Controls.Add(this.btnKSil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKGuncelle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Kitap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap İşlemleri";
            this.Load += new System.EventHandler(this.Kitap_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGVKitap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTur;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtYazar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnKEkle;
        private System.Windows.Forms.TextBox txtKitapAdi;
        private System.Windows.Forms.Button btnKSil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKGuncelle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSayfa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dtGVKitap;
        private System.Windows.Forms.CheckBox checkUygunluk;
    }
}