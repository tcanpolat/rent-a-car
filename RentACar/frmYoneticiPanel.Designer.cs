namespace RentACar
{
    partial class frmYoneticiPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmYoneticiPanel));
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_kiralamalar = new System.Windows.Forms.ToolStripButton();
            this.tslbl_kiralamalar = new System.Windows.Forms.ToolStripLabel();
            this.tsb_aracEkle = new System.Windows.Forms.ToolStripButton();
            this.tslbl_aracekle = new System.Windows.Forms.ToolStripLabel();
            this.tsb_aracListesi = new System.Windows.Forms.ToolStripButton();
            this.tslbl_aracListesi = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(251, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(443, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "UBY RENT A CAR";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_kiralamalar,
            this.tslbl_kiralamalar,
            this.tsb_aracEkle,
            this.tslbl_aracekle,
            this.tsb_aracListesi,
            this.tslbl_aracListesi});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(899, 28);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsb_kiralamalar
            // 
            this.tsb_kiralamalar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_kiralamalar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tsb_kiralamalar.Image = ((System.Drawing.Image)(resources.GetObject("tsb_kiralamalar.Image")));
            this.tsb_kiralamalar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_kiralamalar.Name = "tsb_kiralamalar";
            this.tsb_kiralamalar.Size = new System.Drawing.Size(23, 25);
            this.tsb_kiralamalar.Text = "Kiralamalar";
            this.tsb_kiralamalar.Click += new System.EventHandler(this.tsb_kiralamalar_Click);
            this.tsb_kiralamalar.MouseLeave += new System.EventHandler(this.tsb_kiralamalar_MouseLeave);
            this.tsb_kiralamalar.MouseHover += new System.EventHandler(this.tsb_kiralamalar_MouseHover);
            // 
            // tslbl_kiralamalar
            // 
            this.tslbl_kiralamalar.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.tslbl_kiralamalar.Name = "tslbl_kiralamalar";
            this.tslbl_kiralamalar.Size = new System.Drawing.Size(109, 25);
            this.tslbl_kiralamalar.Text = "Kiralamalar";
            this.tslbl_kiralamalar.Visible = false;
            // 
            // tsb_aracEkle
            // 
            this.tsb_aracEkle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_aracEkle.Image = ((System.Drawing.Image)(resources.GetObject("tsb_aracEkle.Image")));
            this.tsb_aracEkle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_aracEkle.Name = "tsb_aracEkle";
            this.tsb_aracEkle.Size = new System.Drawing.Size(23, 25);
            this.tsb_aracEkle.Text = "Araç Ekle";
            this.tsb_aracEkle.Click += new System.EventHandler(this.tsb_aracEkle_Click);
            this.tsb_aracEkle.MouseLeave += new System.EventHandler(this.tsb_aracEkle_MouseLeave);
            this.tsb_aracEkle.MouseHover += new System.EventHandler(this.tsb_aracEkle_MouseHover);
            // 
            // tslbl_aracekle
            // 
            this.tslbl_aracekle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.tslbl_aracekle.Name = "tslbl_aracekle";
            this.tslbl_aracekle.Size = new System.Drawing.Size(91, 25);
            this.tslbl_aracekle.Text = "Araç Ekle";
            this.tslbl_aracekle.Visible = false;
            // 
            // tsb_aracListesi
            // 
            this.tsb_aracListesi.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_aracListesi.Image = ((System.Drawing.Image)(resources.GetObject("tsb_aracListesi.Image")));
            this.tsb_aracListesi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_aracListesi.Name = "tsb_aracListesi";
            this.tsb_aracListesi.Size = new System.Drawing.Size(23, 25);
            this.tsb_aracListesi.Text = "Araç Listesi";
            this.tsb_aracListesi.Click += new System.EventHandler(this.tsb_aracListesi_Click);
            this.tsb_aracListesi.MouseLeave += new System.EventHandler(this.tsb_aracListesi_MouseLeave);
            this.tsb_aracListesi.MouseHover += new System.EventHandler(this.tsb_aracListesi_MouseHover);
            // 
            // tslbl_aracListesi
            // 
            this.tslbl_aracListesi.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.tslbl_aracListesi.Name = "tslbl_aracListesi";
            this.tslbl_aracListesi.Size = new System.Drawing.Size(108, 25);
            this.tslbl_aracListesi.Text = "Araç Listesi";
            this.tslbl_aracListesi.Visible = false;
            // 
            // frmYoneticiPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(899, 398);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "frmYoneticiPanel";
            this.Text = "Yönetici Paneli";
            this.Load += new System.EventHandler(this.frmYoneticiPanel_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsb_kiralamalar;
        private System.Windows.Forms.ToolStripLabel tslbl_kiralamalar;
        private System.Windows.Forms.ToolStripButton tsb_aracEkle;
        private System.Windows.Forms.ToolStripLabel tslbl_aracekle;
        private System.Windows.Forms.ToolStripButton tsb_aracListesi;
        private System.Windows.Forms.ToolStripLabel tslbl_aracListesi;
    }
}