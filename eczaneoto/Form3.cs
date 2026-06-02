using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace eczaneoto
{
    public partial class Form3 : Form
    {
        EczaneDbContext db = new EczaneDbContext();

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            combo_hasta.DataSource = db.Hastalar.ToList();
            combo_hasta.DisplayMember = "Hasta_Ad";
            combo_hasta.ValueMember = "Hasta_Id";

            combo_ilac.DataSource = db.Ilaclar.ToList();
            combo_ilac.DisplayMember = "Ilac_Adi";
            combo_ilac.ValueMember = "Ilac_Id";
        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            db = new EczaneDbContext();
            dataGridView1.DataSource = db.Receteler
                .Select(r => new {
                    r.Recete_Id,
                    Hasta = r.Hasta.Hasta_Ad + " " + r.Hasta.Hasta_Soyad,
                    Ilac = r.Ilac.Ilac_Adi,
                    r.Recete_Tarih,
                    r.Recete_Miktar
                }).ToList();
            
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            var recete = new Recete
            {
                Hasta_Id = (int)combo_hasta.SelectedValue,
                Ilac_Id = (int)combo_ilac.SelectedValue,
                Recete_Tarih = dtp_tarih.Value,
                Recete_Miktar = Convert.ToInt32(txt_miktar.Text)
            };
            db.Receteler.Add(recete);
            db.SaveChanges();
            MessageBox.Show("Reçete eklendi!");
            btn_listele.PerformClick();
            txt_miktar.Text = "";
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                var onay = MessageBox.Show("Silmek istiyor musunuz?", "Onay", MessageBoxButtons.YesNo);
                if (onay == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Recete_Id"].Value);
                    Recete r = db.Receteler.Find(id);
                    db.Receteler.Remove(r);
                    db.SaveChanges();
                    btn_listele.PerformClick();
                }
            }
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            this.Close();
       
        }
    
        private void rb_enCokSatan_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_EnCokSatan.Checked)
            {
                // LINQ Sorgusu 1: Reçetelerde en çok adette yazılan (en popüler) ilacın adını bulur
                var EnCokYazilanIlac = db.Receteler
                    .GroupBy(r => r.Ilac.Ilac_Adi)
                    .Select(g => new { IlacAdi = g.Key, ToplamMiktar = g.Sum(r => r.Recete_Miktar) })
                    .OrderByDescending(x => x.ToplamMiktar)
                    .FirstOrDefault();

                if (EnCokYazilanIlac != null)
                {
                    lbl_LinqSonuc.Text = $"En Çok Yazılan İlaç: {EnCokYazilanIlac.IlacAdi} ({EnCokYazilanIlac.ToplamMiktar} Adet)";
                }
                else
                {
                    lbl_LinqSonuc.Text = "Henüz reçete kaydı yok.";
                }
            }
        }

        private void rb_toplamRecete_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_ToplamRecete.Checked)
            {
                // LINQ Sorgusu 2: Sistemdeki toplam reçete sayısını ve toplam satılan ilaç adedini hesaplar
                int toplamReceteSayisi = db.Receteler.Count();
                int? toplamIlacAdedi = db.Receteler.Sum(r => (int?)r.Recete_Miktar) ?? 0;

                lbl_LinqSonuc.Text = $"Sistemde Toplam {toplamReceteSayisi} Reçete Var.\nToplam Dağıtılan İlaç: {toplamIlacAdedi} Adet.";
            }
        }
    }
}
