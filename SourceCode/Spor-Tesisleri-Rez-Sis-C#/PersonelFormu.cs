using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
 
    public partial class PersonelFormu: Form
    {
        Veritabanı vt = new Veritabanı();
        public PersonelFormu()
        {
            InitializeComponent();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            try
            {
                string isim = txtisim.Text.Trim();
                string soyisim = txtsoyisim.Text.Trim();
                string bassaati = txtbaslngcsaati.Text;
                string bitsaati = txtbitsaati.Text;
                string eposta = txteposta.Text.Trim();
                string cinsiyet = cmbcinsiyet.Text.Substring(0, 1);
                DateTime bastarihi = dtpbastarihi.Value;
                int maas = Convert.ToInt32(txtmaas.Text);
                int tipID = Convert.ToInt32(cmbtip.SelectedValue);
                int personelTurID = Convert.ToInt32(cmbpersoneltur.SelectedValue);
                int uzamanlıkID = cmbuzmanlik.SelectedValue != null ? Convert.ToInt32(cmbuzmanlik.SelectedValue) : 0;
                int ogrencikapasitesi = string.IsNullOrEmpty(txtkapasite.Text) ? 0 : Convert.ToInt32(txtkapasite.Text);
                int deneyimyil = string.IsNullOrEmpty(txtdeneyim.Text) ? 0 : Convert.ToInt32(txtdeneyim.Text);
                SqlConnection baglanti = new SqlConnection(vt.baglantiAdresi);

                string komut = @"INSERT INTO [dbo].[tblPersonel]
                       ([Isım], [Soyısım], [Eposta], [Cinsiyet], [CalBasSaati], [calBitSaati], [TipID], [BasTarihi], [Maas], [PersonelTurID], [UzmanlikAlaniID], [OgrenciKapasitesi], [DeneyimYil])
                       VALUES (@Isim, @Soyisim, @Eposta, @Cinsiyet, @BasSaati, @BitSaati, @TipID, @BasTarihi, @Maas, @TurID, @UzmanID, @Kapasite, @Deneyim)";

                SqlCommand cmd = new SqlCommand(komut, baglanti);
                baglanti.Open();

                cmd.Parameters.AddWithValue("@Isim", isim);
                cmd.Parameters.AddWithValue("@Soyisim", soyisim);
                cmd.Parameters.AddWithValue("@BasSaati", bassaati);
                cmd.Parameters.AddWithValue("@BitSaati", bitsaati);
                cmd.Parameters.AddWithValue("@Eposta", eposta);
                cmd.Parameters.AddWithValue("@Cinsiyet", cinsiyet);
                cmd.Parameters.AddWithValue("@BasTarihi", bastarihi);
                cmd.Parameters.AddWithValue("@Maas", maas);
                cmd.Parameters.AddWithValue("@TipID", tipID);
                cmd.Parameters.AddWithValue("@TurID", personelTurID);
                cmd.Parameters.AddWithValue("@UzmanID", uzamanlıkID);
                cmd.Parameters.AddWithValue("@Kapasite", ogrencikapasitesi);
                cmd.Parameters.AddWithValue("@Deneyim", deneyimyil);

                cmd.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Yeni personel başarıyla eklendi");

                txtisim.Clear();
                txtsoyisim.Clear();
                txteposta.Clear();
                txtmaas.Clear();
                txtbaslngcsaati.Clear();
                txtbitsaati.Clear();
                txtkapasite.Clear();
                txtdeneyim.Clear();
                cmbtip.SelectedIndex = 0;
                cmbcinsiyet.SelectedIndex = 0;
                cmbpersoneltur.SelectedIndex = 0;
                cmbuzmanlik.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ekleme sırasında hata oluştu:" + ex.Message);
            }


        }
        

        private void btnlistele_Click(object sender, EventArgs e)
        {
            try
            {
                string sorgu = "SELECT*FROM [dbo].[tblPersonel]";
                dgvpersonel.DataSource = vt.VeriGetir(sorgu);
              
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if (dgvpersonel.CurrentRow == null)
            {
                MessageBox.Show("Lütfen bir sütun seçiniz");
                return;
            }
            var cell = dgvpersonel.CurrentRow.Cells[0];
            string selectedID = cell?.Value?.ToString();
            DialogResult result = MessageBox.Show(
                "Seçili personeli silmek istediğinize emin misiniz?",
                "ONAY",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
              );
              if (result==DialogResult.Yes)
            {
                try
                {
                    SqlConnection baglanti = new SqlConnection(vt.baglantiAdresi);
                    string komut = "DELETE FROM tblPersonel WHERE PersonelID = @id";
                    SqlCommand cmd = new SqlCommand(komut, baglanti);
                    cmd.Parameters.AddWithValue("@id", selectedID);
                    baglanti.Open();
                    cmd.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Seçilen personel silindi");
                    btnListele.PerformClick();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veri tabanı hatası:" + ex.ToString());
                }
            }
                


        }

        private void dgvpersonel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow satir = dgvpersonel.Rows[e.RowIndex];
            txtisim.Text = satir.Cells["Isım"].Value.ToString();
            txtsoyisim.Text = satir.Cells["Soyısım"].Value.ToString();
            txteposta.Text = satir.Cells["Eposta"].Value.ToString();
            txtbaslngcsaati.Text = satir.Cells["CalBasSaati"].Value.ToString();
            txtbitsaati.Text = satir.Cells["calBitSaati"].Value.ToString();
            txtmaas.Text = satir.Cells["Maas"].Value.ToString();
            txtkapasite.Text = satir.Cells["OgrenciKapasitesi"].Value.ToString();
            txtdeneyim.Text = satir.Cells["DeneyimYil"].Value.ToString();
            cmbcinsiyet.Text = satir.Cells["Cinsiyet"].Value.ToString();

            if (satir.Cells["BasTarihi"].Value.ToString() != "")
            {
                dtpbastarihi.Value = Convert.ToDateTime(satir.Cells["BasTarihi"].Value.ToString());
            }
            cmbtip.SelectedValue = satir.Cells["TipID"].Value;
            cmbpersoneltur.SelectedValue = satir.Cells["PersonelTurID"].Value;
            cmbuzmanlik.SelectedValue = satir.Cells["UzmanlikAlaniID"].Value;

        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            try
            {
                string isim = txtisim.Text.Trim();
                string soyisim = txtsoyisim.Text.Trim();
                string eposta = txteposta.Text.Trim();
                string bassaati = txtbaslngcsaati.Text.Trim();
                string bitsaati = txtbitsaati.Text.Trim();
                string cinsiyet = cmbcinsiyet.Text;
                int maas = Convert.ToInt32(txtmaas.Text);
                int tipID = Convert.ToInt32(cmbtip.SelectedValue);
                int turID = Convert.ToInt32(cmbpersoneltur.SelectedValue);
                DateTime bastarihi = dtpbastarihi.Value;
                int uzmanlikID = cmbuzmanlik.SelectedValue != null ? Convert.ToInt32(cmbuzmanlik.SelectedValue) : 0;
                int kapasite = string.IsNullOrEmpty(txtkapasite.Text) ? 0 : Convert.ToInt32(txtkapasite.Text);
                int deneyim = string.IsNullOrEmpty(txtdeneyim.Text) ? 0 : Convert.ToInt32(txtdeneyim.Text);
                string currentID = dgvpersonel.CurrentRow.Cells["PersonelID"].Value.ToString();

                SqlConnection baglanti = new SqlConnection(vt.baglantiAdresi);
                string sorgu = @"UPDATE [dbo].[tblPersonel] SET 
                       [Isım] = @Isim, [Soyısım] = @Soyisim, [Eposta] = @Eposta, [Cinsiyet] = @Cinsiyet, [CalBasSaati] = @CalBasSaati,
                       [calBitSaati] = @calBitSaati, [TipID] = @TipID, [BasTarihi] = @BasTarihi, [Maas] = @Maas,
                       [PersonelTurID] = @PersonelTurID, [UzmanlikAlaniID] = @UzmanlikAlaniID, [OgrenciKapasitesi] = @OgrenciKapasitesi, [DeneyimYil] = @DeneyimYil
                       WHERE [PersonelID] = @PersonelID";
                SqlCommand cmd = new SqlCommand(sorgu, baglanti);
                baglanti.Open();

                cmd.Parameters.AddWithValue("@Isim", isim);
                cmd.Parameters.AddWithValue("@Soyisim", soyisim);
                cmd.Parameters.AddWithValue("@Eposta", eposta);
                cmd.Parameters.AddWithValue("@Cinsiyet", cinsiyet);
                cmd.Parameters.AddWithValue("@CalBasSaati", bassaati);
                cmd.Parameters.AddWithValue("@calBitSaati", bitsaati);
                cmd.Parameters.AddWithValue("@TipID", tipID);
                cmd.Parameters.AddWithValue("@BasTarihi", bastarihi);
                cmd.Parameters.AddWithValue("@Maas", maas);
                cmd.Parameters.AddWithValue("@PersonelTurID", turID);
                cmd.Parameters.AddWithValue("@OgrenciKapasitesi", kapasite);
                cmd.Parameters.AddWithValue("@DeneyimYil", deneyim);
                cmd.Parameters.AddWithValue("@PersonelID", currentID);
                if (cmbuzmanlik.SelectedValue== null)
                {
                    cmd.Parameters.AddWithValue("@UzmanlikAlaniID", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@UzmanlikAlaniID", cmbuzmanlik.SelectedValue);
                }
                    cmd.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Personel güncellendi");
                btnListele.PerformClick();
                txtisim.Clear();
                txtsoyisim.Clear();
                txteposta.Clear();
                txtmaas.Clear();
                txtbaslngcsaati.Clear(); 
                txtbitsaati.Clear();
                txtkapasite.Clear();
                txtdeneyim.Clear();
                cmbcinsiyet.SelectedIndex = 0;
                cmbtip.SelectedIndex = 0;
                dtpbastarihi.Value = DateTime.Now;
                txtisim.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri tabanı hatası:" + ex.Message);
            }
        }

        private void PersonelFormu_Load(object sender, EventArgs e)
        {
            DataTable dttip = vt.VeriGetir("SELECT TipID, CalismaTipi FROM tblCalismaTipi");
            cmbtip.DataSource = dttip;
            cmbtip.DisplayMember = "CalismaTipi";
            cmbtip.ValueMember = "TipID";

            DataTable dttur = vt.VeriGetir("SELECT PersonelTurID, PersonelTuru FROM tblPersonelTuru");
            cmbpersoneltur.DataSource = dttur;
            cmbpersoneltur.DisplayMember = "PersonelTuru";
            cmbpersoneltur.ValueMember = "PersonelTurID";

            DataTable dtuzmanlık = vt.VeriGetir("SELECT UzmanlikAlaniID, UzmanlikAlani FROM tblUzmanlikAlani");
            cmbuzmanlik.DataSource = dtuzmanlık;
            cmbuzmanlik.DisplayMember = "UzmanlikAlani";
            cmbuzmanlik.ValueMember = "UzmanlikAlaniID";
            btnListele.PerformClick();
        }

        private void txtdeneyim_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbpersoneltur_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvpersonel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
