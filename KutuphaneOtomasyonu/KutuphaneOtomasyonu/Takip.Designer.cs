
namespace KutuphaneOtomasyonu
{
    partial class Takip
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
            this.dtGVTakip = new System.Windows.Forms.DataGridView();
            this.groupbox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblKitaplar = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtUyeID = new System.Windows.Forms.TextBox();
            this.lblUyeID = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.cmbKitaplar = new System.Windows.Forms.ComboBox();
            this.dtpTakvim = new System.Windows.Forms.DateTimePicker();
            this.lbliade = new System.Windows.Forms.Label();
            this.btnGuncel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVTakip)).BeginInit();
            this.groupbox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtGVTakip
            // 
            this.dtGVTakip.AllowUserToAddRows = false;
            this.dtGVTakip.AllowUserToDeleteRows = false;
            this.dtGVTakip.AllowUserToResizeColumns = false;
            this.dtGVTakip.AllowUserToResizeRows = false;
            this.dtGVTakip.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtGVTakip.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtGVTakip.BackgroundColor = System.Drawing.Color.White;
            this.dtGVTakip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGVTakip.GridColor = System.Drawing.Color.White;
            this.dtGVTakip.Location = new System.Drawing.Point(6, 22);
            this.dtGVTakip.MultiSelect = false;
            this.dtGVTakip.Name = "dtGVTakip";
            this.dtGVTakip.ReadOnly = true;
            this.dtGVTakip.RowHeadersVisible = false;
            this.dtGVTakip.RowTemplate.Height = 25;
            this.dtGVTakip.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGVTakip.Size = new System.Drawing.Size(481, 352);
            this.dtGVTakip.StandardTab = true;
            this.dtGVTakip.TabIndex = 0;
            this.dtGVTakip.TabStop = false;
            // 
            // groupbox1
            // 
            this.groupbox1.Controls.Add(this.dtGVTakip);
            this.groupbox1.Location = new System.Drawing.Point(12, 12);
            this.groupbox1.Name = "groupbox1";
            this.groupbox1.Size = new System.Drawing.Size(493, 390);
            this.groupbox1.TabIndex = 1;
            this.groupbox1.TabStop = false;
            this.groupbox1.Text = "Kitap Takip";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(658, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "Kitap Alış İşlemleri";
            // 
            // lblKitaplar
            // 
            this.lblKitaplar.AutoSize = true;
            this.lblKitaplar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblKitaplar.Location = new System.Drawing.Point(513, 111);
            this.lblKitaplar.Name = "lblKitaplar";
            this.lblKitaplar.Size = new System.Drawing.Size(66, 21);
            this.lblKitaplar.TabIndex = 7;
            this.lblKitaplar.Text = "Kitaplar:";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(658, 160);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(144, 23);
            this.btnEkle.TabIndex = 3;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtUyeID
            // 
            this.txtUyeID.Location = new System.Drawing.Point(585, 58);
            this.txtUyeID.Name = "txtUyeID";
            this.txtUyeID.Size = new System.Drawing.Size(304, 23);
            this.txtUyeID.TabIndex = 1;
            // 
            // lblUyeID
            // 
            this.lblUyeID.AutoSize = true;
            this.lblUyeID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUyeID.Location = new System.Drawing.Point(520, 60);
            this.lblUyeID.Name = "lblUyeID";
            this.lblUyeID.Size = new System.Drawing.Size(59, 21);
            this.lblUyeID.TabIndex = 8;
            this.lblUyeID.Text = "Üye ID:";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(154, 408);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(165, 23);
            this.btnGuncelle.TabIndex = 4;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // cmbKitaplar
            // 
            this.cmbKitaplar.FormattingEnabled = true;
            this.cmbKitaplar.Location = new System.Drawing.Point(585, 109);
            this.cmbKitaplar.MaxLength = 50;
            this.cmbKitaplar.Name = "cmbKitaplar";
            this.cmbKitaplar.Size = new System.Drawing.Size(304, 23);
            this.cmbKitaplar.TabIndex = 2;
            // 
            // dtpTakvim
            // 
            this.dtpTakvim.Location = new System.Drawing.Point(600, 83);
            this.dtpTakvim.Name = "dtpTakvim";
            this.dtpTakvim.Size = new System.Drawing.Size(289, 23);
            this.dtpTakvim.TabIndex = 5;
            this.dtpTakvim.Visible = false;
            // 
            // lbliade
            // 
            this.lbliade.AutoSize = true;
            this.lbliade.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbliade.Location = new System.Drawing.Point(513, 85);
            this.lbliade.Name = "lbliade";
            this.lbliade.Size = new System.Drawing.Size(83, 21);
            this.lbliade.TabIndex = 15;
            this.lbliade.Text = "İade Tarihi:";
            this.lbliade.Visible = false;
            // 
            // btnGuncel
            // 
            this.btnGuncel.Location = new System.Drawing.Point(658, 134);
            this.btnGuncel.Name = "btnGuncel";
            this.btnGuncel.Size = new System.Drawing.Size(144, 23);
            this.btnGuncel.TabIndex = 6;
            this.btnGuncel.Text = "Guncelle";
            this.btnGuncel.UseVisualStyleBackColor = true;
            this.btnGuncel.Visible = false;
            this.btnGuncel.Click += new System.EventHandler(this.btnGuncel_Click);
            // 
            // Takip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 450);
            this.Controls.Add(this.btnGuncel);
            this.Controls.Add(this.lbliade);
            this.Controls.Add(this.dtpTakvim);
            this.Controls.Add(this.cmbKitaplar);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblKitaplar);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtUyeID);
            this.Controls.Add(this.lblUyeID);
            this.Controls.Add(this.groupbox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Takip";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Takip";
            this.Load += new System.EventHandler(this.Takip_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGVTakip)).EndInit();
            this.groupbox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGVTakip;
        private System.Windows.Forms.GroupBox groupbox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblKitaplar;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtUyeID;
        private System.Windows.Forms.Label lblUyeID;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.ComboBox cmbKitaplar;
        private System.Windows.Forms.DateTimePicker dtpTakvim;
        private System.Windows.Forms.Label lbliade;
        private System.Windows.Forms.Button btnGuncel;
    }
}