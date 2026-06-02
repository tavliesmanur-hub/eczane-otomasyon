namespace eczaneoto
{
    partial class Form3
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.combo_hasta = new System.Windows.Forms.ComboBox();
            this.combo_ilac = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_tarih = new System.Windows.Forms.DateTimePicker();
            this.txt_miktar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_listele = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_geri = new System.Windows.Forms.Button();
            this.rd_EnCokSatan = new System.Windows.Forms.RadioButton();
            this.rd_ToplamRecete = new System.Windows.Forms.RadioButton();
            this.lbl_LinqSonuc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SandyBrown;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(742, 167);
            this.dataGridView1.TabIndex = 0;
            // 
            // combo_hasta
            // 
            this.combo_hasta.BackColor = System.Drawing.Color.Orange;
            this.combo_hasta.FormattingEnabled = true;
            this.combo_hasta.Location = new System.Drawing.Point(22, 209);
            this.combo_hasta.Name = "combo_hasta";
            this.combo_hasta.Size = new System.Drawing.Size(274, 28);
            this.combo_hasta.TabIndex = 1;
            // 
            // combo_ilac
            // 
            this.combo_ilac.BackColor = System.Drawing.Color.Orange;
            this.combo_ilac.FormattingEnabled = true;
            this.combo_ilac.Location = new System.Drawing.Point(429, 209);
            this.combo_ilac.Name = "combo_ilac";
            this.combo_ilac.Size = new System.Drawing.Size(304, 28);
            this.combo_ilac.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hasta Seç";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(442, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "İlaç Seç";
            // 
            // dtp_tarih
            // 
            this.dtp_tarih.CalendarMonthBackground = System.Drawing.Color.Orange;
            this.dtp_tarih.Location = new System.Drawing.Point(22, 291);
            this.dtp_tarih.Name = "dtp_tarih";
            this.dtp_tarih.Size = new System.Drawing.Size(236, 26);
            this.dtp_tarih.TabIndex = 5;
            // 
            // txt_miktar
            // 
            this.txt_miktar.BackColor = System.Drawing.Color.Orange;
            this.txt_miktar.Location = new System.Drawing.Point(446, 292);
            this.txt_miktar.Name = "txt_miktar";
            this.txt_miktar.Size = new System.Drawing.Size(288, 26);
            this.txt_miktar.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tarih";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(442, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Miktar";
            // 
            // btn_listele
            // 
            this.btn_listele.BackColor = System.Drawing.Color.FloralWhite;
            this.btn_listele.Location = new System.Drawing.Point(62, 352);
            this.btn_listele.Name = "btn_listele";
            this.btn_listele.Size = new System.Drawing.Size(92, 31);
            this.btn_listele.TabIndex = 9;
            this.btn_listele.Text = "LİSTELE";
            this.btn_listele.UseVisualStyleBackColor = false;
            this.btn_listele.Click += new System.EventHandler(this.btn_listele_Click);
            // 
            // btn_ekle
            // 
            this.btn_ekle.BackColor = System.Drawing.Color.FloralWhite;
            this.btn_ekle.Location = new System.Drawing.Point(170, 352);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(75, 32);
            this.btn_ekle.TabIndex = 10;
            this.btn_ekle.Text = "EKLE";
            this.btn_ekle.UseVisualStyleBackColor = false;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.BackColor = System.Drawing.Color.FloralWhite;
            this.btn_sil.Location = new System.Drawing.Point(264, 352);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(80, 32);
            this.btn_sil.TabIndex = 11;
            this.btn_sil.Text = "SİL";
            this.btn_sil.UseVisualStyleBackColor = false;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_geri
            // 
            this.btn_geri.BackColor = System.Drawing.Color.FloralWhite;
            this.btn_geri.Location = new System.Drawing.Point(665, 403);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(99, 34);
            this.btn_geri.TabIndex = 12;
            this.btn_geri.Text = "GERİ";
            this.btn_geri.UseVisualStyleBackColor = false;
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // rd_EnCokSatan
            // 
            this.rd_EnCokSatan.AutoSize = true;
            this.rd_EnCokSatan.Location = new System.Drawing.Point(384, 352);
            this.rd_EnCokSatan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rd_EnCokSatan.Name = "rd_EnCokSatan";
            this.rd_EnCokSatan.Size = new System.Drawing.Size(127, 24);
            this.rd_EnCokSatan.TabIndex = 13;
            this.rd_EnCokSatan.TabStop = true;
            this.rd_EnCokSatan.Text = "En cok satan";
            this.rd_EnCokSatan.UseVisualStyleBackColor = true;
            this.rd_EnCokSatan.CheckedChanged += new System.EventHandler(this.rb_enCokSatan_CheckedChanged);
            // 
            // rd_ToplamRecete
            // 
            this.rd_ToplamRecete.AutoSize = true;
            this.rd_ToplamRecete.Location = new System.Drawing.Point(384, 415);
            this.rd_ToplamRecete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rd_ToplamRecete.Name = "rd_ToplamRecete";
            this.rd_ToplamRecete.Size = new System.Drawing.Size(131, 24);
            this.rd_ToplamRecete.TabIndex = 14;
            this.rd_ToplamRecete.TabStop = true;
            this.rd_ToplamRecete.Text = "toplam recete";
            this.rd_ToplamRecete.UseVisualStyleBackColor = true;
            this.rd_ToplamRecete.CheckedChanged += new System.EventHandler(this.rb_toplamRecete_CheckedChanged);
            // 
            // lbl_LinqSonuc
            // 
            this.lbl_LinqSonuc.Location = new System.Drawing.Point(519, 365);
            this.lbl_LinqSonuc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_LinqSonuc.Name = "lbl_LinqSonuc";
            this.lbl_LinqSonuc.Size = new System.Drawing.Size(144, 35);
            this.lbl_LinqSonuc.TabIndex = 15;
            this.lbl_LinqSonuc.Text = "label5";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::eczaneoto.Properties.Resources._9d32387279581247bf0c0734d4e776ac;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.lbl_LinqSonuc);
            this.Controls.Add(this.rd_ToplamRecete);
            this.Controls.Add(this.rd_EnCokSatan);
            this.Controls.Add(this.btn_geri);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.btn_listele);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_miktar);
            this.Controls.Add(this.dtp_tarih);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combo_ilac);
            this.Controls.Add(this.combo_hasta);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox combo_hasta;
        private System.Windows.Forms.ComboBox combo_ilac;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_tarih;
        private System.Windows.Forms.TextBox txt_miktar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_listele;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_geri;
        private System.Windows.Forms.RadioButton rd_EnCokSatan;
        private System.Windows.Forms.RadioButton rd_ToplamRecete;
        private System.Windows.Forms.Label lbl_LinqSonuc;
    }
}