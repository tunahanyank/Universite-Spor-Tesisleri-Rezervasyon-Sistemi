namespace WindowsFormsApp2
{
    partial class PersonelFormu
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtisim = new System.Windows.Forms.TextBox();
            this.txtbitsaati = new System.Windows.Forms.TextBox();
            this.txtbaslngcsaati = new System.Windows.Forms.TextBox();
            this.txtmaas = new System.Windows.Forms.TextBox();
            this.txteposta = new System.Windows.Forms.TextBox();
            this.txtsoyisim = new System.Windows.Forms.TextBox();
            this.cmbuzmanlik = new System.Windows.Forms.ComboBox();
            this.cmbpersoneltur = new System.Windows.Forms.ComboBox();
            this.cmbcinsiyet = new System.Windows.Forms.ComboBox();
            this.cmbtip = new System.Windows.Forms.ComboBox();
            this.dgvpersonel = new System.Windows.Forms.DataGridView();
            this.btnekle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpbastarihi = new System.Windows.Forms.DateTimePicker();
            this.txtkapasite = new System.Windows.Forms.TextBox();
            this.txtdeneyim = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpersonel)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 371);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 217);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ç bitiş saati";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Soyisim";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 142);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cinsiyet";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 105);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "E posta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 389);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Personel Türü";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 257);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Çalışma Tipi";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 181);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Ç başlangıç saati";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 427);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Uzmanlık Alanı";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 302);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "Başlangıç Tarihi";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(72, 343);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 20);
            this.label11.TabIndex = 10;
            this.label11.Text = "Maaş";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(72, 37);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 20);
            this.label12.TabIndex = 11;
            this.label12.Text = "İsim";
            // 
            // txtisim
            // 
            this.txtisim.Location = new System.Drawing.Point(164, 34);
            this.txtisim.Margin = new System.Windows.Forms.Padding(4);
            this.txtisim.Name = "txtisim";
            this.txtisim.Size = new System.Drawing.Size(124, 26);
            this.txtisim.TabIndex = 12;
            // 
            // txtbitsaati
            // 
            this.txtbitsaati.Location = new System.Drawing.Point(164, 214);
            this.txtbitsaati.Margin = new System.Windows.Forms.Padding(4);
            this.txtbitsaati.Name = "txtbitsaati";
            this.txtbitsaati.Size = new System.Drawing.Size(124, 26);
            this.txtbitsaati.TabIndex = 13;
            // 
            // txtbaslngcsaati
            // 
            this.txtbaslngcsaati.Location = new System.Drawing.Point(164, 178);
            this.txtbaslngcsaati.Margin = new System.Windows.Forms.Padding(4);
            this.txtbaslngcsaati.Name = "txtbaslngcsaati";
            this.txtbaslngcsaati.Size = new System.Drawing.Size(124, 26);
            this.txtbaslngcsaati.TabIndex = 14;
            // 
            // txtmaas
            // 
            this.txtmaas.Location = new System.Drawing.Point(161, 347);
            this.txtmaas.Margin = new System.Windows.Forms.Padding(4);
            this.txtmaas.Name = "txtmaas";
            this.txtmaas.Size = new System.Drawing.Size(124, 26);
            this.txtmaas.TabIndex = 15;
            // 
            // txteposta
            // 
            this.txteposta.Location = new System.Drawing.Point(164, 102);
            this.txteposta.Margin = new System.Windows.Forms.Padding(4);
            this.txteposta.Name = "txteposta";
            this.txteposta.Size = new System.Drawing.Size(124, 26);
            this.txteposta.TabIndex = 16;
            // 
            // txtsoyisim
            // 
            this.txtsoyisim.Location = new System.Drawing.Point(164, 68);
            this.txtsoyisim.Margin = new System.Windows.Forms.Padding(4);
            this.txtsoyisim.Name = "txtsoyisim";
            this.txtsoyisim.Size = new System.Drawing.Size(124, 26);
            this.txtsoyisim.TabIndex = 17;
            // 
            // cmbuzmanlik
            // 
            this.cmbuzmanlik.FormattingEnabled = true;
            this.cmbuzmanlik.Location = new System.Drawing.Point(164, 427);
            this.cmbuzmanlik.Margin = new System.Windows.Forms.Padding(4);
            this.cmbuzmanlik.Name = "cmbuzmanlik";
            this.cmbuzmanlik.Size = new System.Drawing.Size(150, 28);
            this.cmbuzmanlik.TabIndex = 18;
            // 
            // cmbpersoneltur
            // 
            this.cmbpersoneltur.FormattingEnabled = true;
            this.cmbpersoneltur.Location = new System.Drawing.Point(161, 386);
            this.cmbpersoneltur.Margin = new System.Windows.Forms.Padding(4);
            this.cmbpersoneltur.Name = "cmbpersoneltur";
            this.cmbpersoneltur.Size = new System.Drawing.Size(150, 28);
            this.cmbpersoneltur.TabIndex = 19;
            this.cmbpersoneltur.SelectedIndexChanged += new System.EventHandler(this.cmbpersoneltur_SelectedIndexChanged);
            // 
            // cmbcinsiyet
            // 
            this.cmbcinsiyet.FormattingEnabled = true;
            this.cmbcinsiyet.Items.AddRange(new object[] {
            "E",
            "K"});
            this.cmbcinsiyet.Location = new System.Drawing.Point(164, 142);
            this.cmbcinsiyet.Margin = new System.Windows.Forms.Padding(4);
            this.cmbcinsiyet.Name = "cmbcinsiyet";
            this.cmbcinsiyet.Size = new System.Drawing.Size(150, 28);
            this.cmbcinsiyet.TabIndex = 20;
            // 
            // cmbtip
            // 
            this.cmbtip.FormattingEnabled = true;
            this.cmbtip.Location = new System.Drawing.Point(164, 254);
            this.cmbtip.Margin = new System.Windows.Forms.Padding(4);
            this.cmbtip.Name = "cmbtip";
            this.cmbtip.Size = new System.Drawing.Size(150, 28);
            this.cmbtip.TabIndex = 21;
            // 
            // dgvpersonel
            // 
            this.dgvpersonel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvpersonel.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvpersonel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpersonel.Location = new System.Drawing.Point(13, 553);
            this.dgvpersonel.Margin = new System.Windows.Forms.Padding(4);
            this.dgvpersonel.Name = "dgvpersonel";
            this.dgvpersonel.RowHeadersWidth = 51;
            this.dgvpersonel.RowTemplate.Height = 24;
            this.dgvpersonel.Size = new System.Drawing.Size(1263, 405);
            this.dgvpersonel.TabIndex = 22;
            this.dgvpersonel.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvpersonel_CellClick);
            this.dgvpersonel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvpersonel_CellContentClick);
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(164, 80);
            this.btnekle.Margin = new System.Windows.Forms.Padding(4);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(115, 52);
            this.btnekle.TabIndex = 23;
            this.btnekle.Text = "Personel ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(305, 80);
            this.btnsil.Margin = new System.Windows.Forms.Padding(4);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(115, 52);
            this.btnsil.TabIndex = 24;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.Location = new System.Drawing.Point(435, 80);
            this.btnguncelle.Margin = new System.Windows.Forms.Padding(4);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(115, 52);
            this.btnguncelle.TabIndex = 25;
            this.btnguncelle.Text = "Güncelle";
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(8, 80);
            this.btnListele.Margin = new System.Windows.Forms.Padding(4);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(115, 52);
            this.btnListele.TabIndex = 26;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnlistele_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnListele);
            this.groupBox1.Controls.Add(this.btnekle);
            this.groupBox1.Controls.Add(this.btnsil);
            this.groupBox1.Controls.Add(this.btnguncelle);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(606, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(565, 192);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel İşlemleri";
            // 
            // dtpbastarihi
            // 
            this.dtpbastarihi.Location = new System.Drawing.Point(161, 302);
            this.dtpbastarihi.Margin = new System.Windows.Forms.Padding(4);
            this.dtpbastarihi.Name = "dtpbastarihi";
            this.dtpbastarihi.Size = new System.Drawing.Size(249, 26);
            this.dtpbastarihi.TabIndex = 28;
            // 
            // txtkapasite
            // 
            this.txtkapasite.Location = new System.Drawing.Point(165, 467);
            this.txtkapasite.Margin = new System.Windows.Forms.Padding(4);
            this.txtkapasite.Name = "txtkapasite";
            this.txtkapasite.Size = new System.Drawing.Size(124, 26);
            this.txtkapasite.TabIndex = 29;
            // 
            // txtdeneyim
            // 
            this.txtdeneyim.Location = new System.Drawing.Point(164, 506);
            this.txtdeneyim.Margin = new System.Windows.Forms.Padding(4);
            this.txtdeneyim.Name = "txtdeneyim";
            this.txtdeneyim.Size = new System.Drawing.Size(124, 26);
            this.txtdeneyim.TabIndex = 30;
            this.txtdeneyim.TextChanged += new System.EventHandler(this.txtdeneyim_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtdeneyim);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.dtpbastarihi);
            this.groupBox2.Controls.Add(this.txtkapasite);
            this.groupBox2.Controls.Add(this.cmbpersoneltur);
            this.groupBox2.Controls.Add(this.txtisim);
            this.groupBox2.Controls.Add(this.cmbuzmanlik);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtsoyisim);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.cmbtip);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtbaslngcsaati);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtmaas);
            this.groupBox2.Controls.Add(this.txteposta);
            this.groupBox2.Controls.Add(this.cmbcinsiyet);
            this.groupBox2.Controls.Add(this.txtbitsaati);
            this.groupBox2.Location = new System.Drawing.Point(13, -4);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(530, 549);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Personel Bilgileri";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(31, 503);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(102, 20);
            this.label14.TabIndex = 33;
            this.label14.Text = "Deneyim Yılı";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 467);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(151, 20);
            this.label13.TabIndex = 32;
            this.label13.Text = "Öğrenci Kapasitesi";
            // 
            // PersonelFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1297, 971);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvpersonel);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PersonelFormu";
            this.Text = "Personel Bilgileri";
            this.Load += new System.EventHandler(this.PersonelFormu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvpersonel)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtisim;
        private System.Windows.Forms.TextBox txtbitsaati;
        private System.Windows.Forms.TextBox txtbaslngcsaati;
        private System.Windows.Forms.TextBox txtmaas;
        private System.Windows.Forms.TextBox txteposta;
        private System.Windows.Forms.TextBox txtsoyisim;
        private System.Windows.Forms.ComboBox cmbuzmanlik;
        private System.Windows.Forms.ComboBox cmbpersoneltur;
        private System.Windows.Forms.ComboBox cmbcinsiyet;
        private System.Windows.Forms.ComboBox cmbtip;
        private System.Windows.Forms.DataGridView dgvpersonel;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpbastarihi;
        private System.Windows.Forms.TextBox txtkapasite;
        private System.Windows.Forms.TextBox txtdeneyim;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}