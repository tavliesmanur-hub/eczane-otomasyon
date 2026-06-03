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

       
        private void Form1_Load(object sender, EventArgs e)
        {
            
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        
        private void btn_Hastalar_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

       
        private void btn_Recete_Click(object sender, EventArgs e)
        {
           
            Form3 frmRecete = new Form3(); 
            frmRecete.ShowDialog();
        }

       
        private void btn_Ilac_Click(object sender, EventArgs e)
        {
            
            Form4 frmIlac = new Form4(); 
            frmIlac.ShowDialog();
        }

        

        private void btn_Kategori_Click(object sender, EventArgs e) 
        {
           
            KategoriForm frmKategori = new KategoriForm();
            frmKategori.ShowDialog(); 
        }
    }
    }
