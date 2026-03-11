using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Linq.Expressions;

namespace WindowsFormsApp2
{
    public partial class UyeFormu : Form
    {

        Veritabanı vt = new Veritabanı();

        public UyeFormu()
        {
            InitializeComponent();
        }

        private void btnuyelistele_Click(object sender, EventArgs e)
        {
            try
            {
                string sorgu = "SELECT*FROM tblUye";
                dgvUyeler.DataSource = vt.VeriGetir(sorgu);
                MessageBox.Show("Listeleme başarıyla gerçekleşti.");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnuyeekle_Click(object sender, EventArgs e)
        {
            try
            {
                string isim = txtuyeisim.Text.Trim();
                string soyisim = txtuyesoyisim.Text.Trim();
                string tcNo = txttcno.Text.Trim();
                string eposta = txteposta.Text.Trim();
                string cinsiyet = cmbcinsiyet.Text;
                DateTime dogumtarihi = dtpdogumtarihi.Value;
                int uyelikturuId = Convert.ToInt32(cmbuyeliktur.SelectedValue);
                int adresId = Convert.ToInt32(cmbadres.SelectedValue);
                SqlConnection baglanti = new SqlConnection(vt.baglantiAdresi);

                string komut = @"INSERT INTO [dbo].[tblUye]
                      ([TcNo], [Isim], [Soyisim], [Eposta], [Dogumtarihi], [Cinsiyet], [UyeAdresID], [UyelikTuruID])
                       VALUES (@TcNo, @Isim, @Soyisim, @Eposta, @Dogumtarihi, @Cinsiyet, @UyeAdresID, @UyelikTuruID)";

                SqlCommand cmd = new SqlCommand(komut, baglanti);
                baglanti.Open();


                cmd.Parameters.AddWithValue("@TcNo", tcNo);
                cmd.Parameters.AddWithValue("@Isim", isim);
                cmd.Parameters.AddWithValue("@Soyisim", soyisim);
                cmd.Parameters.AddWithValue("@Eposta", eposta);
                cmd.Parameters.AddWithValue("@Dogumtarihi", dogumtarihi);
                cmd.Parameters.AddWithValue("@Cinsiyet", cinsiyet);
                cmd.Parameters.AddWithValue("@UyeAdresID", adresId);
                cmd.Parameters.AddWithValue("@UyelikTuruID", uyelikturuId);

                cmd.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Yeni üye başarıyla eklendi");
                txtuyeisim.Clear();
                txtuyesoyisim.Clear();
                txteposta.Clear();
                txttcno.Clear();
                cmbuyeliktur.SelectedIndex = 0;
                cmbuyeliktur.Text = "";
                cmbadres.SelectedIndex = 0;
                cmbadres.Text = "";
                cmbcinsiyet.SelectedIndex = 0;
                cmbadres.Text = "";
                dtpdogumtarihi.Value = DateTime.Now;
                txttcno.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ekleme sırasında hata oluştu:" + ex.Message);
            }
        
            }

        private void btnuyesil_Click(object sender, EventArgs e)
        {
            if (dgvUyeler.CurrentRow == null)
            {
                MessageBox.Show("Lütfen bir sütun seçiniz");
                return;
            }
            var cell = dgvUyeler.CurrentRow.Cells[0];
            string selectedID = cell?.Value?.ToString();
            DialogResult result = MessageBox.Show(
                "Seçili üyeyi silmek istediğinize emin misiniz?",
                "ONAY",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
              );
            if (result == DialogResult.Yes)
            {
                try
                {
                    SqlConnection baglanti = new SqlConnection(vt.baglantiAdresi);
                    string komut = "DELETE FROM tblUye WHERE UyeID = @id";
                    SqlCommand cmd = new SqlCommand(komut, baglanti);
                    cmd.Parameters.AddWithValue("@id", selectedID);
                    baglanti.Open();
                    cmd.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Seçilen üye silindi");
                    btnuyelistele.PerformClick();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veri tabanı hatası:" + ex.ToString());
                }
            }
        }

        private void UyeFormu_Load(object sender, EventArgs e)
        {
            DataTable dtUyelikturu = vt.VeriGetir("SELECT UyelikTuruID, UyelikTuruAd FROM tblUyelikTuru");
            cmbuyeliktur.DataSource = dtUyelikturu;
            cmbuyeliktur.DisplayMember = "UyelikTuruAd";
            cmbuyeliktur.ValueMember = "UyelikTuruID";

            DataTable dtadres = vt.VeriGetir("SELECT AdresID ,Il FROM tblUyeAdres");
            cmbadres.DataSource = dtadres;
            cmbadres.DisplayMember = "Il";
            cmbadres.ValueMember = "AdresID";
        }

        private void dgvUyeler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnuyeguncelle_Click(object sender, EventArgs e)
        {
            try
            {
                string uyeid = dgvUyeler.CurrentRow.Cells["UyeID"].Value.ToString();
                string tcno = txttcno.Text.Trim();
                string isim = txtuyeisim.Text.Trim();
                string soyisim= txtuyesoyisim.Text.Trim();
                string eposta = txteposta.Text.Trim();
                string cinsiyet = cmbcinsiyet.Text;
                DateTime dogumtarihi = dtpdogumtarihi.Value;
                int uyelikturuId = Convert.ToInt32(cmbuyeliktur.SelectedValue);
                int adresId = Convert.ToInt32(cmbadres.SelectedValue);


                SqlConnection baglanti = new SqlConnection(vt.baglantiAdresi);
                string sorgu = @"UPDATE [dbo].[tblUye] SET  
                        [TcNo] = @TcNo, [Isim] = @Isim, [Soyisim] = @Soyisim, [Eposta] = @Eposta, [Dogumtarihi] = @Dogumtarihi,
                        [Cinsiyet] = @Cinsiyet, [UyeAdresID] = @UyeAdresID, [UyelikTuruID] = @UyelikTuruID
                        WHERE [UyeID] =  @UyeID";
                SqlCommand cmd = new SqlCommand(sorgu , baglanti);
                baglanti.Open();

                cmd.Parameters.AddWithValue("@TcNo", tcno);
                cmd.Parameters.AddWithValue("@Isim", isim);
                cmd.Parameters.AddWithValue("@Soyisim", soyisim);
                cmd.Parameters.AddWithValue("@Eposta", eposta);
                cmd.Parameters.AddWithValue("@Dogumtarihi", dogumtarihi);
                cmd.Parameters.AddWithValue("@Cinsiyet", cinsiyet);
                cmd.Parameters.AddWithValue("@UyeAdresID", adresId);
                cmd.Parameters.AddWithValue("@UyelikTuruID", uyelikturuId);
                cmd.Parameters.AddWithValue("@UyeID", uyeid);
                cmd.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Üye güncellendi");
                btnuyelistele.PerformClick();
                txttcno.Clear();
                txtuyeisim.Clear();
                txtuyesoyisim.Clear();
                txteposta.Clear();
                cmbcinsiyet.SelectedIndex = 0;
                cmbadres.SelectedIndex = 0;
                dtpdogumtarihi.Value = DateTime.Now;
                txtuyeisim.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri tabanı hatası:" + ex.Message);
            }
        }

        private void txteposta_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbadres_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvUyeler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow satir = dgvUyeler.Rows[e.RowIndex];
            txttcno.Text = satir.Cells["TcNo"].Value.ToString();
            txtuyeisim.Text = satir.Cells["Isim"].Value.ToString();
            txtuyesoyisim.Text = satir.Cells["Soyisim"].Value.ToString();
            txteposta.Text = satir.Cells["Eposta"].Value.ToString();
            cmbcinsiyet.Text = satir.Cells["Cinsiyet"].Value.ToString();
            cmbadres.SelectedValue = satir.Cells["UyeAdresID"].Value;
            cmbuyeliktur.SelectedValue = satir.Cells["UyelikTuruID"].Value;
           

            if (satir.Cells["Dogumtarihi"].Value.ToString() != "")
            {
                dtpdogumtarihi.Value = Convert.ToDateTime(satir.Cells["Dogumtarihi"].Value.ToString());
            }
         

        }
    }
    }

