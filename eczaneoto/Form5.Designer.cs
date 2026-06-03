namespace eczaneoto
{
    partial class KategoriForm
    {
        
        private System.ComponentModel.IContainer components = null;

       
       
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        
        private void InitializeComponent()
        {
            this.txt_KategoriAdi = new System.Windows.Forms.TextBox();
            this.txt_Aciklama = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_listele = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            
            this.txt_KategoriAdi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_KategoriAdi.Location = new System.Drawing.Point(651, 85);
            this.txt_KategoriAdi.Name = "txt_KategoriAdi";
            this.txt_KategoriAdi.Size = new System.Drawing.Size(100, 26);
            this.txt_KategoriAdi.TabIndex = 0;
           
            this.txt_Aciklama.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_Aciklama.Location = new System.Drawing.Point(651, 120);
            this.txt_Aciklama.Name = "txt_Aciklama";
            this.txt_Aciklama.Size = new System.Drawing.Size(100, 26);
            this.txt_Aciklama.TabIndex = 1;
            
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dataGridView1.Location = new System.Drawing.Point(11, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(518, 199);
            this.dataGridView1.TabIndex = 2;
           
            this.btn_ekle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ekle.Location = new System.Drawing.Point(535, 184);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(96, 40);
            this.btn_ekle.TabIndex = 3;
            this.btn_ekle.Text = "EKLE";
            this.btn_ekle.UseVisualStyleBackColor = false;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            
            this.btn_guncelle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_guncelle.Location = new System.Drawing.Point(651, 184);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(123, 44);
            this.btn_guncelle.TabIndex = 4;
            this.btn_guncelle.Text = "GÜNCELLE";
            this.btn_guncelle.UseVisualStyleBackColor = false;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            
            this.btn_sil.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_sil.Location = new System.Drawing.Point(540, 228);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(87, 43);
            this.btn_sil.TabIndex = 5;
            this.btn_sil.Text = "SİL";
            this.btn_sil.UseVisualStyleBackColor = false;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
           
            this.btn_listele.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_listele.Location = new System.Drawing.Point(651, 232);
            this.btn_listele.Name = "btn_listele";
            this.btn_listele.Size = new System.Drawing.Size(123, 39);
            this.btn_listele.TabIndex = 6;
            this.btn_listele.Text = "LİSTELE";
            this.btn_listele.UseVisualStyleBackColor = false;
            this.btn_listele.Click += new System.EventHandler(this.btn_listele_Click);
            
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(536, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Kategori Adı";
            
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(554, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Açıklama";
            
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::eczaneoto.Properties.Resources._7247b464_8d38_4294_8d90_3d4606930f491;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(866, 463);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_listele);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_Aciklama);
            this.Controls.Add(this.txt_KategoriAdi);
            this.Name = "KategoriForm";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.KategoriForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_KategoriAdi;
        private System.Windows.Forms.TextBox txt_Aciklama;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_listele;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}