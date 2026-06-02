namespace eczaneoto
{
    partial class Form1
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
            this.btn_Hastalar = new System.Windows.Forms.Button();
            this.btn_Receteler = new System.Windows.Forms.Button();
            this.btn_Ilaclar = new System.Windows.Forms.Button();
            this.btn_kategoriler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Hastalar
            // 
            this.btn_Hastalar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Hastalar.Location = new System.Drawing.Point(152, 101);
            this.btn_Hastalar.Name = "btn_Hastalar";
            this.btn_Hastalar.Size = new System.Drawing.Size(215, 77);
            this.btn_Hastalar.TabIndex = 0;
            this.btn_Hastalar.Text = "HASTA İŞLEMLERİ";
            this.btn_Hastalar.UseVisualStyleBackColor = false;
            this.btn_Hastalar.Click += new System.EventHandler(this.btn_Hastalar_Click);
            // 
            // btn_Receteler
            // 
            this.btn_Receteler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Receteler.Location = new System.Drawing.Point(575, 91);
            this.btn_Receteler.Name = "btn_Receteler";
            this.btn_Receteler.Size = new System.Drawing.Size(237, 78);
            this.btn_Receteler.TabIndex = 1;
            this.btn_Receteler.Text = "REÇETE";
            this.btn_Receteler.UseVisualStyleBackColor = false;
            this.btn_Receteler.Click += new System.EventHandler(this.btn_Recete_Click);
            // 
            // btn_Ilaclar
            // 
            this.btn_Ilaclar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Ilaclar.Location = new System.Drawing.Point(152, 346);
            this.btn_Ilaclar.Name = "btn_Ilaclar";
            this.btn_Ilaclar.Size = new System.Drawing.Size(215, 74);
            this.btn_Ilaclar.TabIndex = 2;
            this.btn_Ilaclar.Text = "İLAÇ LİSTESİ";
            this.btn_Ilaclar.UseVisualStyleBackColor = false;
            this.btn_Ilaclar.Click += new System.EventHandler(this.btn_Ilac_Click);
            // 
            // btn_kategoriler
            // 
            this.btn_kategoriler.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_kategoriler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_kategoriler.Location = new System.Drawing.Point(592, 344);
            this.btn_kategoriler.Name = "btn_kategoriler";
            this.btn_kategoriler.Size = new System.Drawing.Size(220, 79);
            this.btn_kategoriler.TabIndex = 3;
            this.btn_kategoriler.Text = "KATEGORİ YÖNETİMİ";
            this.btn_kategoriler.UseVisualStyleBackColor = false;
            this.btn_kategoriler.Click += new System.EventHandler(this.btn_Kategori_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::eczaneoto.Properties.Resources.indir__4_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(945, 499);
            this.Controls.Add(this.btn_kategoriler);
            this.Controls.Add(this.btn_Ilaclar);
            this.Controls.Add(this.btn_Receteler);
            this.Controls.Add(this.btn_Hastalar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Hastalar;
        private System.Windows.Forms.Button btn_Receteler;
        private System.Windows.Forms.Button btn_Ilaclar;
        private System.Windows.Forms.Button btn_kategoriler;
    }
}

