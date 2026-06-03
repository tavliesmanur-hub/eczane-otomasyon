using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace eczaneoto
{
    public partial class Form4 : Form
    {
       
        EczaneDbContext db = new EczaneDbContext();

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            btn_listele.PerformClick();
        }

        
        private void btn_listele_Click(object sender, EventArgs e)
        {
            try
            {
                
                db = new EczaneDbContext();

                
                cmbKategori.DataSource = db.Kategoriler.ToList();
                cmbKategori.DisplayMember = "Kategori_Adi";
                cmbKategori.ValueMember = "Kategori_Id";

                
                var ilaclar = db.Ilaclar
                    .Include(i => i.Kategori)
                    .Select(i => new
                    {
                        i.Ilac_Id,
                        i.Ilac_Adi,
                        i.Ilac_Barkod,
                        i.Ilac_Fiyat,
                        i.Ilac_Stok,
                        Kategori = i.Kategori.Kategori_Adi
                    }).ToList();

                dataGridView1.DataSource = ilaclar;

                
                dataGridView1.Columns["Ilac_Id"].HeaderText = "İlaç ID";
                dataGridView1.Columns["Ilac_Adi"].HeaderText = "İlaç Adı";
                dataGridView1.Columns["Ilac_Barkod"].HeaderText = "Barkod";
                dataGridView1.Columns["Ilac_Fiyat"].HeaderText = "Fiyat (TL)";
                dataGridView1.Columns["Ilac_Stok"].HeaderText = "Stok";
                dataGridView1.Columns["Kategori"].HeaderText = "Kategori";

               
                dataGridView1.Columns["Ilac_Id"].Visible = false;

               
                dataGridView1.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata = {ex.Message}");
            }
        }

       
        private void btn_ekle_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_IlacAdi.Text) ||
                    string.IsNullOrWhiteSpace(txt_Barkod.Text) ||
                    string.IsNullOrWhiteSpace(txt_Fiyat.Text) ||
                    string.IsNullOrWhiteSpace(txt_Stok.Text))
                {
                    MessageBox.Show("Lütfen tüm alanları doldurun!",
                        "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Ilac yeniIlac = new Ilac()
                {
                    Ilac_Adi = txt_IlacAdi.Text,
                    Ilac_Barkod = txt_Barkod.Text,
                    Ilac_Fiyat = decimal.Parse(txt_Fiyat.Text),
                    Ilac_Stok = int.Parse(txt_Stok.Text),
                    Kategori_Id = (int)cmbKategori.SelectedValue
                };

                db.Ilaclar.Add(yeniIlac);
                db.SaveChanges();
                MessageBox.Show("Yeni İlaç Eklendi!");
                btn_listele.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata = {ex.Message}");
            }
        }

        private void dataGridView1_CellClick(object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txt_IlacAdi.Text = dataGridView1.Rows[e.RowIndex]
                    .Cells["Ilac_Adi"].Value.ToString();
                txt_Barkod.Text = dataGridView1.Rows[e.RowIndex]
                    .Cells["Ilac_Barkod"].Value.ToString();
                txt_Fiyat.Text = dataGridView1.Rows[e.RowIndex]
                    .Cells["Ilac_Fiyat"].Value.ToString();
                txt_Stok.Text = dataGridView1.Rows[e.RowIndex]
                    .Cells["Ilac_Stok"].Value.ToString();
            }
        }

        
        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow != null)
                {
                    int selectedId = Convert.ToInt32(
                        dataGridView1.CurrentRow.Cells["Ilac_Id"].Value);

                    Ilac ilac = db.Ilaclar.Find(selectedId);

                    if (ilac != null)
                    {
                        ilac.Ilac_Adi = txt_IlacAdi.Text;
                        ilac.Ilac_Barkod = txt_Barkod.Text;
                        ilac.Ilac_Fiyat = decimal.Parse(txt_Fiyat.Text);
                        ilac.Ilac_Stok = int.Parse(txt_Stok.Text);
                        ilac.Kategori_Id = (int)cmbKategori.SelectedValue;

                        db.SaveChanges();
                        MessageBox.Show("İlaç Güncellendi!");
                        btn_listele.PerformClick();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata = {ex.Message}");
            }
        }

       
        private void btn_sil_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult sonuc = MessageBox.Show(
                    "Silmek istediğinize emin misiniz?",
                    "Silme Onayı",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (sonuc == DialogResult.Yes)
                {
                    if (dataGridView1.CurrentRow != null)
                    {
                        int selectedId = Convert.ToInt32(
                            dataGridView1.CurrentRow.Cells["Ilac_Id"].Value);

                        Ilac ilac = db.Ilaclar.Find(selectedId);

                        if (ilac != null)
                        {
                            db.Ilaclar.Remove(ilac);
                            db.SaveChanges();
                            MessageBox.Show("İlaç Silindi!");
                            btn_listele.PerformClick();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata = {ex.Message}");
            }
        }

      
        private void btn_geri_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}