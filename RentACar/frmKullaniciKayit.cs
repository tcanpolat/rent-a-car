using RentACar.ORM.Context;
using RentACar.ORM.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACar
{
    public partial class frmKullaniciKayit : Form
    {
        DataContext _context = new DataContext();
        public frmKullaniciKayit()
        {
            InitializeComponent();
        }

        private void btn_kayitol_Click(object sender, EventArgs e)
        {
            List<Yonetici> ynt = new List<Yonetici>();
            ynt =  _context.Yoneticiler.ToList();
            bool kullaniciVar = false;
            foreach (var yonetici in ynt)
            {
                if(yonetici.TC == txt_tc.Text)
                {
                    kullaniciVar = true;
                }
            }

            if (kullaniciVar)
            {
                MessageBox.Show("Bu TC numarasıyla kayıtlı bir kullanıcı zaten var.");
            }
            else
            {
                // Kontrol işlemleri yapılabilir.
                Yonetici yonetici = new Yonetici()
                {
                    Ad = txt_ad.Text,
                    Soyad = txt_soyad.Text,
                    TC = txt_tc.Text,
                    EhliyetNo = txt_ehliyetno.Text,
                    Sifre = txt_parola.Text,
                    Telefon = txt_telefon.Text,
                    Email = txt_email.Text,
                    Adres = txt_adres.Text,
                    AktifMi = true,
                    AddDate = DateTime.Now
                };
                _context.Yoneticiler.Add(yonetici);
                _context.SaveChanges();
                MessageBox.Show("Kayıt başarılı!");
                this.Hide();
            }

        }
    }
}
