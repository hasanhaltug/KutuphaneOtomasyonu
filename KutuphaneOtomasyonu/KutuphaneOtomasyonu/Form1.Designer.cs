
namespace KutuphaneOtomasyonu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnUye = new System.Windows.Forms.Button();
            this.btnKitap = new System.Windows.Forms.Button();
            this.btnTakip = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUye
            // 
            this.btnUye.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUye.BackColor = System.Drawing.SystemColors.Info;
            this.btnUye.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUye.Location = new System.Drawing.Point(226, 136);
            this.btnUye.Name = "btnUye";
            this.btnUye.Size = new System.Drawing.Size(138, 52);
            this.btnUye.TabIndex = 0;
            this.btnUye.Text = "Üye İşlemleri";
            this.btnUye.UseVisualStyleBackColor = false;
            this.btnUye.Click += new System.EventHandler(this.btnUye_Click);
            // 
            // btnKitap
            // 
            this.btnKitap.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnKitap.BackColor = System.Drawing.SystemColors.Info;
            this.btnKitap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKitap.Location = new System.Drawing.Point(226, 194);
            this.btnKitap.Name = "btnKitap";
            this.btnKitap.Size = new System.Drawing.Size(138, 52);
            this.btnKitap.TabIndex = 1;
            this.btnKitap.Text = "Kitap İşlemleri";
            this.btnKitap.UseVisualStyleBackColor = false;
            this.btnKitap.Click += new System.EventHandler(this.btnKitap_Click);
            // 
            // btnTakip
            // 
            this.btnTakip.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTakip.BackColor = System.Drawing.SystemColors.Info;
            this.btnTakip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTakip.Location = new System.Drawing.Point(226, 252);
            this.btnTakip.Name = "btnTakip";
            this.btnTakip.Size = new System.Drawing.Size(138, 52);
            this.btnTakip.TabIndex = 2;
            this.btnTakip.Text = "Takip İşlemleri";
            this.btnTakip.UseVisualStyleBackColor = false;
            this.btnTakip.Click += new System.EventHandler(this.btnTakip_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(592, 450);
            this.Controls.Add(this.btnTakip);
            this.Controls.Add(this.btnKitap);
            this.Controls.Add(this.btnUye);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kütüphane Otomasyonu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUye;
        private System.Windows.Forms.Button btnKitap;
        private System.Windows.Forms.Button btnTakip;
    }
}

