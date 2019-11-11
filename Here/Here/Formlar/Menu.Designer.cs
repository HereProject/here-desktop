namespace Here.Formlar
{
    partial class Menu
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_yoklama = new System.Windows.Forms.Button();
            this.btn_dersler = new System.Windows.Forms.Button();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.btn_kullanici = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_yoklama
            // 
            this.btn_yoklama.BackColor = System.Drawing.Color.Transparent;
            this.btn_yoklama.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_yoklama.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_yoklama.ForeColor = System.Drawing.Color.RosyBrown;
            this.btn_yoklama.Location = new System.Drawing.Point(35, 287);
            this.btn_yoklama.Name = "btn_yoklama";
            this.btn_yoklama.Size = new System.Drawing.Size(188, 71);
            this.btn_yoklama.TabIndex = 1;
            this.btn_yoklama.Text = "Yoklama İşlemleri";
            this.btn_yoklama.UseVisualStyleBackColor = false;
            this.btn_yoklama.Click += new System.EventHandler(this.btn_yoklama_Click);
            // 
            // btn_dersler
            // 
            this.btn_dersler.BackColor = System.Drawing.Color.Transparent;
            this.btn_dersler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dersler.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dersler.ForeColor = System.Drawing.Color.RosyBrown;
            this.btn_dersler.Location = new System.Drawing.Point(35, 378);
            this.btn_dersler.Name = "btn_dersler";
            this.btn_dersler.Size = new System.Drawing.Size(188, 71);
            this.btn_dersler.TabIndex = 2;
            this.btn_dersler.Text = "Ders İşlemleri";
            this.btn_dersler.UseVisualStyleBackColor = false;
            this.btn_dersler.Click += new System.EventHandler(this.btn_dersler_Click);
            // 
            // btn_cikis
            // 
            this.btn_cikis.BackColor = System.Drawing.Color.Transparent;
            this.btn_cikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cikis.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cikis.ForeColor = System.Drawing.Color.RosyBrown;
            this.btn_cikis.Location = new System.Drawing.Point(35, 555);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(188, 71);
            this.btn_cikis.TabIndex = 3;
            this.btn_cikis.Text = "Çıkış";
            this.btn_cikis.UseVisualStyleBackColor = false;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // btn_kullanici
            // 
            this.btn_kullanici.BackColor = System.Drawing.Color.Transparent;
            this.btn_kullanici.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kullanici.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kullanici.ForeColor = System.Drawing.Color.RosyBrown;
            this.btn_kullanici.Location = new System.Drawing.Point(35, 467);
            this.btn_kullanici.Name = "btn_kullanici";
            this.btn_kullanici.Size = new System.Drawing.Size(188, 71);
            this.btn_kullanici.TabIndex = 4;
            this.btn_kullanici.Text = "Kullanıcı İşlemleri";
            this.btn_kullanici.UseVisualStyleBackColor = false;
            this.btn_kullanici.Click += new System.EventHandler(this.btn_kullanici_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Here.Properties.Resources.Fu2;
            this.pictureBox1.Location = new System.Drawing.Point(12, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(229, 185);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.Controls.Add(this.btn_kullanici);
            this.Controls.Add(this.btn_cikis);
            this.Controls.Add(this.btn_dersler);
            this.Controls.Add(this.btn_yoklama);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Menu";
            this.Size = new System.Drawing.Size(253, 687);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_yoklama;
        private System.Windows.Forms.Button btn_dersler;
        private System.Windows.Forms.Button btn_cikis;
        private System.Windows.Forms.Button btn_kullanici;
    }
}
