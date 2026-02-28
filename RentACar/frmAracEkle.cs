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
    public partial class frmAracEkle : Form
    {
        DataContext _context = new DataContext();
        public frmAracEkle()
        {
            InitializeComponent();
        }

        private void btn_aracekle_Click(object sender, EventArgs e)
        {
            string base64;

            // Dispose
            using (Image image = pictureBox_arac.Image.Clone() as Image)
            {
                base64 = ConvertImageToBase64(image);
            }

            Araba araba = new Araba()
            {
                Plaka = txt_plaka.Text,
                Marka = txt_marka.Text,
                Model = txt_model.Text,
                AracTipi = cmb_aractipi.Text,
                Vites = cmb_vites.Text,
                YakitTipi = cmb_yakittipi.Text,
                ImageUrl = base64,
                Fiyat = Convert.ToDouble(txt_gunlukfiyat.Text),
                AktifMi = true,
                AddDate = DateTime.Now
            };

            _context.Arabalar.Add(araba);
            _context.SaveChanges();
            MessageBox.Show("Araç başarıyla eklendi.");
            this.Close();
        }

        private string ConvertImageToBase64(Image image)
        {
            // Image'i base64 string'e dönüştürme
            using (MemoryStream memoryStream = new MemoryStream())
            {
                image.Save(memoryStream, image.RawFormat);
                byte[] imageBytes = memoryStream.ToArray();
                return Convert.ToBase64String(imageBytes);
            }
        }

        private void btn_fileDialog_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Resim Dosyaları (*.jpg;*.jpeg;*.png;*.gif;*.bmp) | *.jpg;*.jpeg;*.png;*.gif;*.bmp";

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox_arac.Image = new Bitmap(ofd.FileName);
                fileName.Text = ofd.FileName;
            }
        }
    }
}
