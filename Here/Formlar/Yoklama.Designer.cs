namespace Here.Formlar
{
    partial class Yoklama
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
            this.dgv_yoklama = new System.Windows.Forms.DataGridView();
            this.btn_yGetir = new System.Windows.Forms.Button();
            this.btn_yEkle = new System.Windows.Forms.Button();
            this.btn_ySil = new System.Windows.Forms.Button();
            this.txt_ogrencino = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ykod = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_yBitir = new System.Windows.Forms.Button();
            this.btn_yBaslat = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_yoklama)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_yoklama
            // 
            this.dgv_yoklama.BackgroundColor = System.Drawing.Color.RosyBrown;
            this.dgv_yoklama.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_yoklama.Location = new System.Drawing.Point(25, 22);
            this.dgv_yoklama.Name = "dgv_yoklama";
            this.dgv_yoklama.RowTemplate.Height = 24;
            this.dgv_yoklama.Size = new System.Drawing.Size(611, 397);
            this.dgv_yoklama.TabIndex = 1;
            // 
            // btn_yGetir
            // 
            this.btn_yGetir.BackColor = System.Drawing.Color.Transparent;
            this.btn_yGetir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_yGetir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_yGetir.ForeColor = System.Drawing.Color.RosyBrown;
            this.btn_yGetir.Location = new System.Drawing.Point(117, 330);
            this.btn_yGetir.Name = "btn_yGetir";
            this.btn_yGetir.Size = new System.Drawing.Size(188, 54);
            this.btn_yGetir.TabIndex = 7;
            this.btn_yGetir.Text = "Yoklamayı Getir";
            this.btn_yGetir.UseVisualStyleBackColor = false;
            // 
            // btn_yEkle
            // 
            this.btn_yEkle.BackColor = System.Drawing.Color.Transparent;
            this.btn_yEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_yEkle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_yEkle.ForeColor = System.Drawing.Color.RosyBrown;
            this.btn_yEkle.Location = new System.Drawing.Point(151, 100);
            this.btn_yEkle.Name = "btn_yEkle";
            this.btn_yEkle.Size = new System.Drawing.Size(188, 68);
            this.btn_yEkle.TabIndex = 8;
            this.btn_yEkle.Text = "Yoklama Kaydı ekle";
            this.btn_yEkle.UseVisualStyleBackColor = false;
            // 
            // btn_ySil
            // 
            this.btn_ySil.BackColor = System.Drawing.Color.Transparent;
            this.btn_ySil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ySil.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ySil.ForeColor = System.Drawing.Color.RosyBrown;
            this.btn_ySil.Location = new System.Drawing.Point(117, 406);
            this.btn_ySil.Name = "btn_ySil";
            this.btn_ySil.Size = new System.Drawing.Size(188, 54);
            this.btn_ySil.TabIndex = 9;
            this.btn_ySil.Text = "Seçili Kaydı Sil";
            this.btn_ySil.UseVisualStyleBackColor = false;
            // 
            // txt_ogrencino
            // 
            this.txt_ogrencino.BackColor = System.Drawing.Color.Linen;
            this.txt_ogrencino.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ogrencino.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ogrencino.ForeColor = System.Drawing.Color.RosyBrown;
            this.txt_ogrencino.Location = new System.Drawing.Point(255, 60);
            this.txt_ogrencino.Name = "txt_ogrencino";
            this.txt_ogrencino.Size = new System.Drawing.Size(188, 34);
            this.txt_ogrencino.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.RosyBrown;
            this.label1.Location = new System.Drawing.Point(21, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 28);
            this.label1.TabIndex = 11;
            this.label1.Text = "Öğrenci numarası giriniz :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.RosyBrown;
            this.label2.Location = new System.Drawing.Point(18, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 28);
            this.label2.TabIndex = 13;
            this.label2.Text = "Ders Kodu Giriniz :";
            // 
            // txt_ykod
            // 
            this.txt_ykod.BackColor = System.Drawing.Color.Linen;
            this.txt_ykod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ykod.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ykod.ForeColor = System.Drawing.Color.RosyBrown;
            this.txt_ykod.Location = new System.Drawing.Point(197, 52);
            this.txt_ykod.Name = "txt_ykod";
            this.txt_ykod.Size = new System.Drawing.Size(188, 34);
            this.txt_ykod.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_yEkle);
            this.groupBox1.Controls.Add(this.txt_ogrencino);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.RosyBrown;
            this.groupBox1.Location = new System.Drawing.Point(87, 425);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(495, 206);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci Ekle";
            // 
            // btn_yBitir
            // 
            this.btn_yBitir.BackColor = System.Drawing.Color.Transparent;
            this.btn_yBitir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_yBitir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_yBitir.ForeColor = System.Drawing.Color.RosyBrown;
            this.btn_yBitir.Location = new System.Drawing.Point(117, 255);
            this.btn_yBitir.Name = "btn_yBitir";
            this.btn_yBitir.Size = new System.Drawing.Size(188, 54);
            this.btn_yBitir.TabIndex = 16;
            this.btn_yBitir.Text = "Yoklamayı Bitir";
            this.btn_yBitir.UseVisualStyleBackColor = false;
            // 
            // btn_yBaslat
            // 
            this.btn_yBaslat.BackColor = System.Drawing.Color.Transparent;
            this.btn_yBaslat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_yBaslat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_yBaslat.ForeColor = System.Drawing.Color.RosyBrown;
            this.btn_yBaslat.Location = new System.Drawing.Point(117, 184);
            this.btn_yBaslat.Name = "btn_yBaslat";
            this.btn_yBaslat.Size = new System.Drawing.Size(188, 54);
            this.btn_yBaslat.TabIndex = 17;
            this.btn_yBaslat.Text = "Yoklamayı Başlat";
            this.btn_yBaslat.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txt_ykod);
            this.groupBox2.Controls.Add(this.btn_yBaslat);
            this.groupBox2.Controls.Add(this.btn_yGetir);
            this.groupBox2.Controls.Add(this.btn_yBitir);
            this.groupBox2.Controls.Add(this.btn_ySil);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.RosyBrown;
            this.groupBox2.Location = new System.Drawing.Point(642, 134);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(390, 497);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yoklama İşlemleri";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.Linen;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(238, 109);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(147, 36);
            this.comboBox1.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.RosyBrown;
            this.label3.Location = new System.Drawing.Point(8, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 28);
            this.label3.TabIndex = 18;
            this.label3.Text = "Öğrenim Türünü Seçiniz:";
            // 
            // Yoklama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_yoklama);
            this.Name = "Yoklama";
            this.Size = new System.Drawing.Size(1047, 687);
            this.Load += new System.EventHandler(this.Yoklama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_yoklama)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_yoklama;
        private System.Windows.Forms.Button btn_yGetir;
        private System.Windows.Forms.Button btn_yEkle;
        private System.Windows.Forms.Button btn_ySil;
        private System.Windows.Forms.TextBox txt_ogrencino;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ykod;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_yBitir;
        private System.Windows.Forms.Button btn_yBaslat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
    }
}
