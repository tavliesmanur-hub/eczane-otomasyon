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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Form yüklenirken yapılacak bir işlem varsa buraya yazılabilir
        private void Form1_Load(object sender, EventArgs e)
        {
            // İsteğe bağlı: Form ekranın ortasında açılsın istersen
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        // HASTA butonuna basınca Hasta formunu açar
        private void btn_Hastalar_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        // REÇETE butonuna basınca Form2'yi açar
        private void btn_Recete_Click(object sender, EventArgs e)
        {
            // ── REÇETE FORMUNU (FORM3) AÇMA KODU ──
            Form3 frmRecete = new Form3(); // Hatırlarsan reçete formunu Form3 yapmıştık
            frmRecete.ShowDialog();
        }

        // İLAÇ butonuna basınca İlaç formunu açar
        private void btn_Ilac_Click(object sender, EventArgs e)
        {
            // ── İLAÇ FORMUNU AÇMA KODU ──
            Form4 frmIlac = new Form4(); // İlaç formunun adı projedeki haliyle Form4'tü
            frmIlac.ShowDialog();
        }

        // KATEGORİ butonuna basınca Kategori formunu açar

        private void btn_Kategori_Click(object sender, EventArgs e) // Butonunun adı neyse o metot
        {
            // ── KATEGORİ FORMUNU ÇAĞIRMA VE AÇMA KODU ──
            KategoriForm frmKategori = new KategoriForm();
            frmKategori.ShowDialog(); // Formu ekrana kilitli (üstte) olarak açar
        }
    }
    }
