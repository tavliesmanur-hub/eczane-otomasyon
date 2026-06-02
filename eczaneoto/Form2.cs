using System;
using System.Windows.Forms;
using System.Linq;

namespace eczaneoto
{
    public partial class Form2 : Form
    {
        EczaneDbContext db = new EczaneDbContext();

        public Form2()
        {
            InitializeComponent();
        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            db = new EczaneDbContext();
            dataGridView1.DataSource = db.Hastalar.ToList();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            var hasta = new Hasta
            {
                Hasta_Ad = txt_ad.Text,
                Hasta_Soyad = txt_soyad.Text,
                Hasta_TcNo = txt_tc.Text,
                Hasta_Telefon = txt_telefon.Text
            };
            db.Hastalar.Add(hasta);
            db.SaveChanges();
            MessageBox.Show("Hasta eklendi!");
            btn_listele.PerformClick();
            Temizle();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txt_ad.Text = dataGridView1.Rows[e.RowIndex].Cells["Hasta_Ad"].Value.ToString();
                txt_soyad.Text = dataGridView1.Rows[e.RowIndex].Cells["Hasta_Soyad"].Value.ToString();
                txt_tc.Text = dataGridView1.Rows[e.RowIndex].Cells["Hasta_TcNo"].Value.ToString();
                txt_telefon.Text = dataGridView1.Rows[e.RowIndex].Cells["Hasta_Telefon"].Value.ToString();
            }
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Hasta_Id"].Value);
                using (var db2 = new EczaneDbContext())
                {
                    Hasta h = db2.Hastalar.Find(id);
                    if (h != null)
                    {
                        h.Hasta_Ad = txt_ad.Text;
                        h.Hasta_Soyad = txt_soyad.Text;
                        h.Hasta_TcNo = txt_tc.Text;
                        h.Hasta_Telefon = txt_telefon.Text;
                        db2.SaveChanges();
                        MessageBox.Show("Güncellendi!");
                        btn_listele.PerformClick();
                        Temizle();
                    }
                }
            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                var onay = MessageBox.Show("Silmek istiyor musunuz?", "Onay", MessageBoxButtons.YesNo);
                if (onay == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Hasta_Id"].Value);
                    Hasta h = db.Hastalar.Find(id);
                    db.Hastalar.Remove(h);
                    db.SaveChanges();
                    btn_listele.PerformClick();
                }
            }
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Temizle()
        {
            txt_ad.Text = "";
            txt_soyad.Text = "";
            txt_tc.Text = "";
            txt_telefon.Text = "";
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}