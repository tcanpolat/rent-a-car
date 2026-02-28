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
    public partial class frmYoneticiPanel : Form
    {
        public string kid;
        public frmYoneticiPanel()
        {
            InitializeComponent();
        }

        private void frmYoneticiPanel_Load(object sender, EventArgs e)
        {

        }

        private void tsb_kiralamalar_MouseHover(object sender, EventArgs e)
        {
            tslbl_kiralamalar.Visible = true;
        }

        private void tsb_kiralamalar_MouseLeave(object sender, EventArgs e)
        {
            tslbl_kiralamalar.Visible = false;
        }

        private void tsb_aracEkle_MouseHover(object sender, EventArgs e)
        {
            tslbl_aracekle.Visible = true;
        }

        private void tsb_aracEkle_MouseLeave(object sender, EventArgs e)
        {
            tslbl_aracekle.Visible = false;
        }

        private void tsb_aracListesi_MouseHover(object sender, EventArgs e)
        {
            tslbl_aracListesi.Visible = true;
        }

        private void tsb_aracListesi_MouseLeave(object sender, EventArgs e)
        {
            tslbl_aracListesi.Visible = false;
        }

        private void tsb_kiralamalar_Click(object sender, EventArgs e)
        {
            frmKiralamalar frmKiralamalar = new frmKiralamalar();
            frmKiralamalar.Show();
        }

        private void tsb_aracEkle_Click(object sender, EventArgs e)
        {
            frmAracEkle frmAracEkle = new frmAracEkle();
            frmAracEkle.Show();
        }

        private void tsb_aracListesi_Click(object sender, EventArgs e)
        {
            frmAracListesi frmAracListesi = new frmAracListesi();
            frmAracListesi.Show();
        }
    }
}
