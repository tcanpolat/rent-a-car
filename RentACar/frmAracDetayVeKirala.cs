using RentACar.ORM.Context;
using RentACar.ORM.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACar
{
    public partial class frmAracDetayVeKirala : Form
    {
        public string kid;
        public int id;
        public int gun;

        DataContext _context = new DataContext();
        public frmAracDetayVeKirala()
        {
            InitializeComponent();
        }

        private void frmAracDetayVeKirala_Load(object sender, EventArgs e)
        {
            Araba araba = _context.Arabalar.Where(a => a.ID == id).First();
            lbl_marka.Text = araba.Marka;
            lbl_model.Text = araba.Model;
            lbl_plaka.Text = araba.Plaka;
            lbl_vitesturu.Text = araba.Vites;
            lbl_yakittipi.Text = araba.YakitTipi;
            lbl_aracturu.Text = araba.AracTipi;
            lbl_gunlukfiyat.Text = araba.Fiyat.ToString() + " TL";
            pictureBox_arac.Image = ConvertToBase64ToImage(araba.ImageUrl);

            dtp_alistarihi.MinDate = DateTime.Now;
            dtp_teslimtarihi.Enabled = false;


        }

        private Image ConvertToBase64ToImage(string imageUrl)
        {
            byte[] imageBytes = Convert.FromBase64String(imageUrl);
            using (MemoryStream ms = new MemoryStream(imageBytes,0,imageBytes.Length))
            {
                ms.Write(imageBytes, 0, imageBytes.Length);
                return Image.FromStream(ms, true);
            }
        }

        private void dtp_alistarihi_ValueChanged(object sender, EventArgs e)
        {
            dtp_teslimtarihi.Enabled = true;
            dtp_teslimtarihi.MinDate = dtp_alistarihi.Value.AddDays(1);
        }

        private void dtp_teslimtarihi_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan gunFarki = dtp_teslimtarihi.Value.Subtract(dtp_alistarihi.Value);
            gun = gunFarki.Days;

            if(gun < 1)
            {
                MessageBox.Show("Teslim Tarihi Alış Tarihinden önce veya aynı gün olamaz");
                lbl_gun.Text = null;
                lbl_faturatutari.Text = null;
            }
            else
            {
                lbl_gun.Text = gun.ToString();
                double faturaTutari = gun * Convert.ToDouble(lbl_gunlukfiyat.Text.Replace(" TL", ""));
                lbl_faturatutari.Text = faturaTutari.ToString() + " TL";

            }
        }

        private void btn_kirala_Click(object sender, EventArgs e)
        {
            Araba arabaKiralikMi = _context.Arabalar.Where(a => a.ID == id && a.AktifMi == false).FirstOrDefault();
            Araba araba = _context.Arabalar.Where(a => a.ID == id).FirstOrDefault();

            if(arabaKiralikMi != null)
            {
                MessageBox.Show("Seçtiğiniz araç şu an kirada !");
            }
            else
            {
                Kiralama kiralama = new Kiralama()
                {
                    ArabaID = id,
                    YoneticiID = int.Parse(kid),
                    AlisTarihi = dtp_alistarihi.Value,
                    TeslimTarihi = dtp_teslimtarihi.Value,
                    KiralamaSuresi = gun,
                    FaturaTutari = Convert.ToDouble(lbl_faturatutari.Text.Replace(" TL","")),
                    AddDate = DateTime.Now,
                    AktifMi = true
                };

                araba.AktifMi = false;

                _context.Kiralamalar.Add(kiralama);
                _context.SaveChanges();
                MessageBox.Show("Araç Kiralandı.");
                this.Hide();
            }
        }

        private void btn_iptal_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
