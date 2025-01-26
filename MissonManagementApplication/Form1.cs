using System.Data.SqlClient;
namespace MissonManagementApplication
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }
        string connectionString = "Server=DESKTOP-M7VEO25\\SQLEXPRESS;Database=GorevTakip;Integrated Security=True;";
        

private void GorevEkle(string atayan, string atanan, string gorevAdi, string aciklama, string oncelik, string baslangic, string bitis, string tamamlandi)
    {
        string connectionString = "Server=SERVER_ADI;Database=MissionManagement;Integrated Security=True;";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            string query = "INSERT INTO Gorevler (Atayan, Atanan, GorevAdi, Aciklama, OncelikDerecesi, BaslangicTarihi, BitisTarihi, Tamamlandi) " +
                           "VALUES (@Atayan, @Atanan, @GorevAdi, @Aciklama, @OncelikDerecesi, @BaslangicTarihi, @BitisTarihi, @Tamamlandi)";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Atayan", atayan);
                command.Parameters.AddWithValue("@Atanan", atanan);
                command.Parameters.AddWithValue("@GorevAdi", gorevAdi);
                command.Parameters.AddWithValue("@Aciklama", aciklama);
                command.Parameters.AddWithValue("@OncelikDerecesi", oncelik);
                command.Parameters.AddWithValue("@BaslangicTarihi", baslangic);
                command.Parameters.AddWithValue("@BitisTarihi", bitis);
                command.Parameters.AddWithValue("@Tamamlandi", tamamlandi);

                command.ExecuteNonQuery();
            }
        }
    }
    private void gorevekleButton_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            form2.GorevEkleVeyaDuzenle += Form2_GorevEkleVeyaDuzenle;
            form2.ShowDialog();
            


        }
        private void duzenleButton_Click(object sender, EventArgs e)
        {
            // DataGridView'de bir satır seçili mi kontrol et
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Seçili satırın indeksini al
                int selectedRowIndex = dataGridView1.SelectedRows[0].Index;

                // Seçili satırın bilgilerini al
                string atayan = dataGridView1.Rows[selectedRowIndex].Cells[0].Value?.ToString();
                string atanan = dataGridView1.Rows[selectedRowIndex].Cells[1].Value?.ToString();
                string gorevAdi = dataGridView1.Rows[selectedRowIndex].Cells[2].Value?.ToString();
                string aciklama = dataGridView1.Rows[selectedRowIndex].Cells[3].Value?.ToString();
                string oncelikDerecesi = dataGridView1.Rows[selectedRowIndex].Cells[4].Value?.ToString();
                string baslangicTarihi = dataGridView1.Rows[selectedRowIndex].Cells[5].Value?.ToString();
                string bitisTarihi = dataGridView1.Rows[selectedRowIndex].Cells[6].Value?.ToString();
                string tamamlandi = dataGridView1.Rows[selectedRowIndex].Cells[7].Value?.ToString();

                Form2 form2 = new Form2();

                // Form2'yi aç ve mevcut bilgileri ayarla

                form2.gorevBilgileriniAyarla(atayan, atanan, gorevAdi, aciklama, oncelikDerecesi, baslangicTarihi, bitisTarihi, tamamlandi, selectedRowIndex);

                // Form2'nin olayını dinle
                form2.GorevEkleVeyaDuzenle += Form2_GorevEkleVeyaDuzenle;

                // Form2'yi göster
                form2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Lütfen düzenlemek için bir satır seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void silButton_Click(object sender, EventArgs e)
        {
            // DataGridView'de bir satır seçili mi kontrol et
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Kullanıcıdan onay al
                var result = MessageBox.Show("Seçili görevi silmek istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Seçili sat?r? sil
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        if (!row.IsNewRow) // Yeni satır değilse
                        {
                            dataGridView1.Rows.Remove(row);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek için bir satır seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /*private void Form2_GorevEkleVeyaDuzenle(string gorevAdi, string aciklama, string oncelikDerecesi, string baslangicTarihi, string bitisTarihi,int index)
        {
            dataGridView1.Rows.Add(gorevAdi, aciklama, oncelikDerecesi, baslangicTarihi, bitisTarihi);
        }*/
        private void Form2_GorevEkleVeyaDuzenle(string atayan, string atanan, string gorevAdi, string aciklama, string oncelikDerecesi, string baslangicTarihi, string bitisTarihi, string tamamlandi, int index)
        {
            if (index >= 0) // Düzenleme işlemi
            {
                dataGridView1.Rows[index].Cells[0].Value = atayan;
                dataGridView1.Rows[index].Cells[1].Value = atanan;
                dataGridView1.Rows[index].Cells[2].Value = gorevAdi;
                dataGridView1.Rows[index].Cells[3].Value = aciklama;
                dataGridView1.Rows[index].Cells[4].Value = oncelikDerecesi;
                dataGridView1.Rows[index].Cells[5].Value = baslangicTarihi;
                dataGridView1.Rows[index].Cells[6].Value = bitisTarihi;
                dataGridView1.Rows[index].Cells[7].Value = tamamlandi;


            }
            else // Yeni görev ekleme
            {
                dataGridView1.Rows.Add(atayan, atanan, gorevAdi, aciklama, oncelikDerecesi, baslangicTarihi, bitisTarihi, tamamlandi);
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // "BitisTarihi" sütunu indeksini belirleyin (örneğin 6. sütun)
            int bitisTarihiIndex = 6;
            int tamamlandiIndex = 7;

            // Sadece satırları renklendirmek için işlemleri yap
            if (e.RowIndex >= 0 && e.ColumnIndex == bitisTarihiIndex)
            {
                var row = dataGridView1.Rows[e.RowIndex];
                string bitisTarihiStr = row.Cells[bitisTarihiIndex].Value?.ToString();
                string tamamlandi = row.Cells[tamamlandiIndex].Value?.ToString();

                DateTime bitisTarihi;
                bool tarihDonusumBasarili = DateTime.TryParse(bitisTarihiStr, out bitisTarihi);

                // Tarih dönüşümü başarılıysa renklendirme yap
                if (tarihDonusumBasarili)
                {
                    if (tamamlandi=="Evet")
                    {
                        // Görev tamamlandı, yeşil renk
                        row.DefaultCellStyle.BackColor = Color.LightGreen;
                    }
                    else if (bitisTarihi < DateTime.Now)
                    {
                        // Bitiş tarihi geçti ve görev tamamlanmadı, kırmızı renk
                        row.DefaultCellStyle.BackColor = Color.LightCoral;
                    }
                    else
                    {
                        // Bitiş tarihi geçmedi, varsayılan renk
                        row.DefaultCellStyle.BackColor = Color.White;
                    }
                }
                else
                {
                    // Tarih dönüşümü başarısızsa (hatalı tarih formatı), varsayılan renk
                    row.DefaultCellStyle.BackColor = Color.White;
                }
            }


        }
    }
}
