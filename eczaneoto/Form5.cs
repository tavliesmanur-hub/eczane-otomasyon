using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq; 
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eczaneoto
{
    public partial class KategoriForm : Form
    {
       
        EczaneDbContext db = new EczaneDbContext();

        public KategoriForm()
        {
            InitializeComponent();
            btn_ekle.Click += new EventHandler(btn_ekle_Click);
            btn_guncelle.Click += new EventHandler(btn_guncelle_Click);
            btn_sil.Click += new EventHandler(btn_sil_Click);
            btn_listele.Click += new EventHandler(btn_listele_Click);
           

           
            dataGridView1.CellClick += new DataGridViewCellEventHandler(dataGridView1_CellClick);
        }

        private void KategoriForm_Load(object sender, EventArgs e)
        {
            
            KategoriListeleLINQ();
        }

       
        private void KategoriListeleLINQ()
        {
            try
            {
                using (EczaneDbContext sorguDb = new EczaneDbContext())
                {
                   
                    var kategoriListesi = sorguDb.Kategoriler
                        .Select(k => new
                        {
                            k.Kategori_Id,
                            Kategori_Adi = k.Kategori_Adi,
                            Aciklama = k.Kategori_Aciklama
                        })
                        .OrderBy(k => k.Kategori_Adi) 
                        .ToList();

                    dataGridView1.DataSource = kategoriListesi;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Listeleme hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            KategoriListeleLINQ();
        }

       
        private void btn_ekle_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_KategoriAdi.Text))
                {
                    MessageBox.Show("Lütfen Kategori Adını boş bırakmayın!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string yeniAd = txt_KategoriAdi.Text.Trim();

                using (EczaneDbContext kayitDb = new EczaneDbContext())
                {
                    
                    bool varMi = kayitDb.Kategoriler.Any(k => k.Kategori_Adi.ToLower() == yeniAd.ToLower());

                    if (varMi)
                    {
                        MessageBox.Show("Bu kategori adı veritabanında zaten mevcut!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    var yeniKategori = new Kategori
                    {
                        Kategori_Adi = yeniAd,
                        Kategori_Aciklama = txt_Aciklama.Text.Trim()
                    };

                    kayitDb.Kategoriler.Add(yeniKategori);
                    kayitDb.SaveChanges();
                }

                MessageBox.Show("Kategori başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                KategoriTemizle();
                KategoriListeleLINQ(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ekleme hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow == null)
                {
                    MessageBox.Show("Lütfen güncellemek için tablodan bir kategori seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txt_KategoriAdi.Text))
                {
                    MessageBox.Show("Kategori adı boş olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int secilenId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Kategori_Id"].Value);

                using (EczaneDbContext guncelleDb = new EczaneDbContext())
                {
                   
                    var guncellenecekKategori = guncelleDb.Kategoriler
                        .FirstOrDefault(k => k.Kategori_Id == secilenId);

                    if (guncellenecekKategori != null)
                    {
                        guncellenecekKategori.Kategori_Adi = txt_KategoriAdi.Text.Trim();
                        guncellenecekKategori.Kategori_Aciklama = txt_Aciklama.Text.Trim();

                        guncelleDb.SaveChanges();
                        MessageBox.Show("Kategori başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        KategoriTemizle();
                        KategoriListeleLINQ(); 
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void btn_sil_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow == null)
                {
                    MessageBox.Show("Lütfen silmek için tablodan bir kategori seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var onay = MessageBox.Show("Bu kategoriyi silmek istediğinize emin misiniz?", "Kategori Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (onay == DialogResult.Yes)
                {
                    int secilenId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Kategori_Id"].Value);

                    using (EczaneDbContext silDb = new EczaneDbContext())
                    {
                        
                        var silinecekKategori = silDb.Kategoriler
                            .SingleOrDefault(k => k.Kategori_Id == secilenId);

                        if (silinecekKategori != null)
                        {
                            silDb.Kategoriler.Remove(silinecekKategori);
                            silDb.SaveChanges();
                            MessageBox.Show("Kategori silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            KategoriTemizle();
                            KategoriListeleLINQ(); 
                        }
                    }
                }
            }
            catch (Exception)
            {
              
                MessageBox.Show("Bu kategori silinemez! Bu kategoriye bağlı ilaçlar bulunuyor. Önce o ilaçları silmeli veya değiştirmelisiniz.", "Silme Engellendi", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.Rows[e.RowIndex].Cells["Kategori_Adi"].Value != null)
            {
                txt_KategoriAdi.Text = dataGridView1.Rows[e.RowIndex].Cells["Kategori_Adi"].Value.ToString();

                var aciklamaDeger = dataGridView1.Rows[e.RowIndex].Cells["Aciklama"].Value;
                txt_Aciklama.Text = aciklamaDeger != null ? aciklamaDeger.ToString() : "";
            }
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void KategoriTemizle()
        {
            txt_KategoriAdi.Text = "";
            txt_Aciklama.Text = "";
        }

        private void KategoriForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
