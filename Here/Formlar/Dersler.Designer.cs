﻿namespace Here.Formlar
{
    partial class Dersler
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
            this.txt_dersadi = new System.Windows.Forms.TextBox();
            this.txt_derskod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_bolum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_dtarih = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_dsaati = new System.Windows.Forms.TextBox();
            this.btn_dersekle = new System.Windows.Forms.Button();
            this.btn_derssil = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_yoklama)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_yoklama
            // 
            this.dgv_yoklama.BackgroundColor = System.Drawing.Color.RosyBrown;
            this.dgv_yoklama.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_yoklama.Location = new System.Drawing.Point(30, 93);
            this.dgv_yoklama.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_yoklama.Name = "dgv_yoklama";
            this.dgv_yoklama.RowTemplate.Height = 24;
            this.dgv_yoklama.Size = new System.Drawing.Size(430, 358);
            this.dgv_yoklama.TabIndex = 4;
            // 
            // txt_dersadi
            // 
            this.txt_dersadi.BackColor = System.Drawing.Color.Linen;
            this.txt_dersadi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dersadi.ForeColor = System.Drawing.Color.RosyBrown;
            this.txt_dersadi.Location = new System.Drawing.Point(166, 41);
            this.txt_dersadi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_dersadi.Name = "txt_dersadi";
            this.txt_dersadi.Size = new System.Drawing.Size(147, 29);
            this.txt_dersadi.TabIndex = 2;
            // 
            // txt_derskod
            // 
            this.txt_derskod.BackColor = System.Drawing.Color.Linen;
            this.txt_derskod.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_derskod.ForeColor = System.Drawing.Color.RosyBrown;
            this.txt_derskod.Location = new System.Drawing.Point(166, 85);
            this.txt_derskod.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_derskod.Name = "txt_derskod";
            this.txt_derskod.Size = new System.Drawing.Size(147, 29);
            this.txt_derskod.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.RosyBrown;
            this.label2.Location = new System.Drawing.Point(29, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ders Adı Giriniz :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.RosyBrown;
            this.label1.Location = new System.Drawing.Point(29, 93);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "Bölüm ID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.RosyBrown;
            this.label3.Location = new System.Drawing.Point(29, 136);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "Bölüm:";
            // 
            // txt_bolum
            // 
            this.txt_bolum.BackColor = System.Drawing.Color.Linen;
            this.txt_bolum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bolum.ForeColor = System.Drawing.Color.RosyBrown;
            this.txt_bolum.Location = new System.Drawing.Point(166, 128);
            this.txt_bolum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_bolum.Name = "txt_bolum";
            this.txt_bolum.Size = new System.Drawing.Size(147, 29);
            this.txt_bolum.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.RosyBrown;
            this.label4.Location = new System.Drawing.Point(29, 177);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 21);
            this.label4.TabIndex = 14;
            this.label4.Text = "Ögretmen ID";
            // 
            // txt_dtarih
            // 
            this.txt_dtarih.BackColor = System.Drawing.Color.Linen;
            this.txt_dtarih.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dtarih.ForeColor = System.Drawing.Color.RosyBrown;
            this.txt_dtarih.Location = new System.Drawing.Point(166, 169);
            this.txt_dtarih.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_dtarih.Name = "txt_dtarih";
            this.txt_dtarih.Size = new System.Drawing.Size(147, 29);
            this.txt_dtarih.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.RosyBrown;
            this.label5.Location = new System.Drawing.Point(29, 218);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 21);
            this.label5.TabIndex = 16;
            this.label5.Text = "ID";
            // 
            // txt_dsaati
            // 
            this.txt_dsaati.BackColor = System.Drawing.Color.Linen;
            this.txt_dsaati.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dsaati.ForeColor = System.Drawing.Color.RosyBrown;
            this.txt_dsaati.Location = new System.Drawing.Point(166, 210);
            this.txt_dsaati.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_dsaati.Name = "txt_dsaati";
            this.txt_dsaati.Size = new System.Drawing.Size(147, 29);
            this.txt_dsaati.TabIndex = 17;
            // 
            // btn_dersekle
            // 
            this.btn_dersekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dersekle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_dersekle.ForeColor = System.Drawing.Color.RosyBrown;
            this.btn_dersekle.Location = new System.Drawing.Point(98, 260);
            this.btn_dersekle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_dersekle.Name = "btn_dersekle";
            this.btn_dersekle.Size = new System.Drawing.Size(146, 41);
            this.btn_dersekle.TabIndex = 18;
            this.btn_dersekle.Text = "Ders Ekle";
            this.btn_dersekle.UseVisualStyleBackColor = true;
            // 
            // btn_derssil
            // 
            this.btn_derssil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_derssil.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_derssil.ForeColor = System.Drawing.Color.RosyBrown;
            this.btn_derssil.Location = new System.Drawing.Point(98, 318);
            this.btn_derssil.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_derssil.Name = "btn_derssil";
            this.btn_derssil.Size = new System.Drawing.Size(146, 41);
            this.btn_derssil.TabIndex = 19;
            this.btn_derssil.Text = "Seçili Dersi Sil";
            this.btn_derssil.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_derssil);
            this.groupBox1.Controls.Add(this.txt_dersadi);
            this.groupBox1.Controls.Add(this.btn_dersekle);
            this.groupBox1.Controls.Add(this.txt_derskod);
            this.groupBox1.Controls.Add(this.txt_dsaati);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_dtarih);
            this.groupBox1.Controls.Add(this.txt_bolum);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.RosyBrown;
            this.groupBox1.Location = new System.Drawing.Point(465, 84);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(318, 368);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ders İşlemleri";
            // 
            // Dersler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_yoklama);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Dersler";
            this.Size = new System.Drawing.Size(785, 558);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_yoklama)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_yoklama;
        private System.Windows.Forms.TextBox txt_dersadi;
        private System.Windows.Forms.TextBox txt_derskod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_bolum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_dtarih;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_dsaati;
        private System.Windows.Forms.Button btn_dersekle;
        private System.Windows.Forms.Button btn_derssil;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
