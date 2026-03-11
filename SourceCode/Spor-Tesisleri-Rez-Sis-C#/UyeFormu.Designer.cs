namespace WindowsFormsApp2
{
    partial class UyeFormu
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
            this.txtuyeisim = new System.Windows.Forms.TextBox();
            this.txtuyesoyisim = new System.Windows.Forms.TextBox();
            this.txttcno = new System.Windows.Forms.TextBox();
            this.txteposta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpdogumtarihi = new System.Windows.Forms.DateTimePicker();
            this.cmbadres = new System.Windows.Forms.ComboBox();
            this.cmbuyeliktur = new System.Windows.Forms.ComboBox();
            this.btnuyeekle = new System.Windows.Forms.Button();
            this.btnuyesil = new System.Windows.Forms.Button();
            this.btnuyeguncelle = new System.Windows.Forms.Button();
            this.btnuyelistele = new System.Windows.Forms.Button();
            this.dgvUyeler = new System.Windows.Forms.DataGridView();
            this.cmbcinsiyet = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUyeler)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtuyeisim
            // 
            this.txtuyeisim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtuyeisim.Location = new System.Drawing.Point(141, 86);
            this.txtuyeisim.Name = "txtuyeisim";
            this.txtuyeisim.Size = new System.Drawing.Size(142, 26);
            this.txtuyeisim.TabIndex = 0;
            // 
            // txtuyesoyisim
            // 
            this.txtuyesoyisim.Location = new System.Drawing.Point(141, 132);
            this.txtuyesoyisim.Name = "txtuyesoyisim";
            this.txtuyesoyisim.Size = new System.Drawing.Size(142, 26);
            this.txtuyesoyisim.TabIndex = 1;
            // 
            // txttcno
            // 
            this.txttcno.Location = new System.Drawing.Point(141, 40);
            this.txttcno.Name = "txttcno";
            this.txttcno.Size = new System.Drawing.Size(142, 26);
            this.txttcno.TabIndex = 6;
            // 
            // txteposta
            // 
            this.txteposta.Location = new System.Drawing.Point(141, 177);
            this.txteposta.Name = "txteposta";
            this.txteposta.Size = new System.Drawing.Size(205, 26);
            this.txteposta.TabIndex = 7;
            this.txteposta.TextChanged += new System.EventHandler(this.txteposta_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(57, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "İsim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Soyisim";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "TcNo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Eposta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 386);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Doğum Tarihi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Cinsiyet";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Adres";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 334);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Üyelik Türü";
            // 
            // dtpdogumtarihi
            // 
            this.dtpdogumtarihi.Location = new System.Drawing.Point(141, 386);
            this.dtpdogumtarihi.Name = "dtpdogumtarihi";
            this.dtpdogumtarihi.Size = new System.Drawing.Size(243, 26);
            this.dtpdogumtarihi.TabIndex = 16;
            // 
            // cmbadres
            // 
            this.cmbadres.FormattingEnabled = true;
            this.cmbadres.Location = new System.Drawing.Point(141, 279);
            this.cmbadres.Name = "cmbadres";
            this.cmbadres.Size = new System.Drawing.Size(142, 28);
            this.cmbadres.TabIndex = 17;
            this.cmbadres.SelectedIndexChanged += new System.EventHandler(this.cmbadres_SelectedIndexChanged);
            // 
            // cmbuyeliktur
            // 
            this.cmbuyeliktur.FormattingEnabled = true;
            this.cmbuyeliktur.Location = new System.Drawing.Point(141, 334);
            this.cmbuyeliktur.Name = "cmbuyeliktur";
            this.cmbuyeliktur.Size = new System.Drawing.Size(142, 28);
            this.cmbuyeliktur.TabIndex = 18;
            // 
            // btnuyeekle
            // 
            this.btnuyeekle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnuyeekle.Location = new System.Drawing.Point(324, 63);
            this.btnuyeekle.Name = "btnuyeekle";
            this.btnuyeekle.Size = new System.Drawing.Size(98, 38);
            this.btnuyeekle.TabIndex = 19;
            this.btnuyeekle.Text = "Üye ekle";
            this.btnuyeekle.UseVisualStyleBackColor = false;
            this.btnuyeekle.Click += new System.EventHandler(this.btnuyeekle_Click);
            // 
            // btnuyesil
            // 
            this.btnuyesil.Location = new System.Drawing.Point(111, 63);
            this.btnuyesil.Name = "btnuyesil";
            this.btnuyesil.Size = new System.Drawing.Size(87, 38);
            this.btnuyesil.TabIndex = 20;
            this.btnuyesil.Text = "Sil";
            this.btnuyesil.UseVisualStyleBackColor = true;
            this.btnuyesil.Click += new System.EventHandler(this.btnuyesil_Click);
            // 
            // btnuyeguncelle
            // 
            this.btnuyeguncelle.Location = new System.Drawing.Point(218, 63);
            this.btnuyeguncelle.Name = "btnuyeguncelle";
            this.btnuyeguncelle.Size = new System.Drawing.Size(100, 38);
            this.btnuyeguncelle.TabIndex = 21;
            this.btnuyeguncelle.Text = "Güncelle";
            this.btnuyeguncelle.UseVisualStyleBackColor = true;
            this.btnuyeguncelle.Click += new System.EventHandler(this.btnuyeguncelle_Click);
            // 
            // btnuyelistele
            // 
            this.btnuyelistele.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnuyelistele.Location = new System.Drawing.Point(6, 63);
            this.btnuyelistele.Name = "btnuyelistele";
            this.btnuyelistele.Size = new System.Drawing.Size(87, 38);
            this.btnuyelistele.TabIndex = 22;
            this.btnuyelistele.Text = "Listele";
            this.btnuyelistele.UseVisualStyleBackColor = true;
            this.btnuyelistele.Click += new System.EventHandler(this.btnuyelistele_Click);
            // 
            // dgvUyeler
            // 
            this.dgvUyeler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUyeler.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvUyeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUyeler.Location = new System.Drawing.Point(52, 482);
            this.dgvUyeler.MultiSelect = false;
            this.dgvUyeler.Name = "dgvUyeler";
            this.dgvUyeler.RowHeadersWidth = 51;
            this.dgvUyeler.RowTemplate.Height = 24;
            this.dgvUyeler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUyeler.Size = new System.Drawing.Size(860, 150);
            this.dgvUyeler.TabIndex = 23;
            this.dgvUyeler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUyeler_CellClick);
            this.dgvUyeler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUyeler_CellContentClick);
            // 
            // cmbcinsiyet
            // 
            this.cmbcinsiyet.FormattingEnabled = true;
            this.cmbcinsiyet.Items.AddRange(new object[] {
            "E",
            "K"});
            this.cmbcinsiyet.Location = new System.Drawing.Point(141, 227);
            this.cmbcinsiyet.Name = "cmbcinsiyet";
            this.cmbcinsiyet.Size = new System.Drawing.Size(142, 28);
            this.cmbcinsiyet.TabIndex = 24;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbcinsiyet);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cmbuyeliktur);
            this.groupBox1.Controls.Add(this.txtuyeisim);
            this.groupBox1.Controls.Add(this.dtpdogumtarihi);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbadres);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txttcno);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtuyesoyisim);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txteposta);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(30, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(517, 450);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Üye Bilgileri";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnuyelistele);
            this.groupBox2.Controls.Add(this.btnuyesil);
            this.groupBox2.Controls.Add(this.btnuyeguncelle);
            this.groupBox2.Controls.Add(this.btnuyeekle);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(588, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(434, 120);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Üye İşlemleri";
            // 
            // UyeFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(1048, 662);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvUyeler);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "UyeFormu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Üye Bilgileri";
            this.Load += new System.EventHandler(this.UyeFormu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUyeler)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtuyeisim;
        private System.Windows.Forms.TextBox txtuyesoyisim;
        private System.Windows.Forms.TextBox txttcno;
        private System.Windows.Forms.TextBox txteposta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpdogumtarihi;
        private System.Windows.Forms.ComboBox cmbadres;
        private System.Windows.Forms.ComboBox cmbuyeliktur;
        private System.Windows.Forms.Button btnuyeekle;
        private System.Windows.Forms.Button btnuyesil;
        private System.Windows.Forms.Button btnuyeguncelle;
        private System.Windows.Forms.Button btnuyelistele;
        private System.Windows.Forms.DataGridView dgvUyeler;
        private System.Windows.Forms.ComboBox cmbcinsiyet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}