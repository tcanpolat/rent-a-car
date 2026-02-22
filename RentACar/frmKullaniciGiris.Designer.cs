namespace RentACar
{
    partial class frmKullaniciGiris
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_tc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_parola = new System.Windows.Forms.TextBox();
            this.btn_giris = new System.Windows.Forms.Button();
            this.lnklbl_kayitol = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(87, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC Kimlik No";
            // 
            // txt_tc
            // 
            this.txt_tc.Location = new System.Drawing.Point(91, 76);
            this.txt_tc.Name = "txt_tc";
            this.txt_tc.Size = new System.Drawing.Size(180, 20);
            this.txt_tc.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.IndianRed;
            this.label2.Location = new System.Drawing.Point(87, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Parola";
            // 
            // txt_parola
            // 
            this.txt_parola.Location = new System.Drawing.Point(91, 135);
            this.txt_parola.Name = "txt_parola";
            this.txt_parola.Size = new System.Drawing.Size(180, 20);
            this.txt_parola.TabIndex = 1;
            this.txt_parola.UseSystemPasswordChar = true;
            // 
            // btn_giris
            // 
            this.btn_giris.BackColor = System.Drawing.Color.IndianRed;
            this.btn_giris.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_giris.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_giris.Location = new System.Drawing.Point(91, 184);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(180, 52);
            this.btn_giris.TabIndex = 2;
            this.btn_giris.Text = "Giriş Yap";
            this.btn_giris.UseVisualStyleBackColor = false;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // lnklbl_kayitol
            // 
            this.lnklbl_kayitol.AutoSize = true;
            this.lnklbl_kayitol.LinkColor = System.Drawing.Color.IndianRed;
            this.lnklbl_kayitol.Location = new System.Drawing.Point(153, 262);
            this.lnklbl_kayitol.Name = "lnklbl_kayitol";
            this.lnklbl_kayitol.Size = new System.Drawing.Size(43, 13);
            this.lnklbl_kayitol.TabIndex = 3;
            this.lnklbl_kayitol.TabStop = true;
            this.lnklbl_kayitol.Text = "Kayıt Ol";
            this.lnklbl_kayitol.VisitedLinkColor = System.Drawing.Color.Black;
            this.lnklbl_kayitol.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklbl_kayitol_LinkClicked);
            // 
            // frmKullaniciGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 363);
            this.Controls.Add(this.lnklbl_kayitol);
            this.Controls.Add(this.btn_giris);
            this.Controls.Add(this.txt_parola);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_tc);
            this.Controls.Add(this.label1);
            this.Name = "frmKullaniciGiris";
            this.Text = "Yönetici Girişi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_tc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_parola;
        private System.Windows.Forms.Button btn_giris;
        private System.Windows.Forms.LinkLabel lnklbl_kayitol;
    }
}

