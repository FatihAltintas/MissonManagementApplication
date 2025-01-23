namespace MissonManagementApplication
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        
        private void gorevekleButton_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            form2.GorevEkleVeyaDuzenle += Form2_GorevEkleVeyaDuzenle;
            form2.ShowDialog();

        }
        private void duzenleButton_Click(object sender, EventArgs e)
        {
            // DataGridView'de bir sat?r se�ili mi kontrol et
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Se�ili sat?r?n indeksini al
                int selectedRowIndex = dataGridView1.SelectedRows[0].Index;

                // Se�ili sat?r?n bilgilerini al
                string gorevAdi = dataGridView1.Rows[selectedRowIndex].Cells[0].Value?.ToString();
                string aciklama = dataGridView1.Rows[selectedRowIndex].Cells[1].Value?.ToString();
                string oncelikDerecesi = dataGridView1.Rows[selectedRowIndex].Cells[2].Value?.ToString();
                string baslangicTarihi = dataGridView1.Rows[selectedRowIndex].Cells[3].Value?.ToString();
                string bitisTarihi = dataGridView1.Rows[selectedRowIndex].Cells[4].Value?.ToString();

                Form2 form2 = new Form2();

                // Form2'yi a� ve mevcut bilgileri ayarla

                form2.gorevBilgileriniAyarla(gorevAdi, aciklama, oncelikDerecesi, baslangicTarihi, bitisTarihi, selectedRowIndex);

                // Form2'nin olay?n? dinle
                form2.GorevEkleVeyaDuzenle += Form2_GorevEkleVeyaDuzenle;

                // Form2'yi g�ster
                form2.ShowDialog();
            }
            else
            {
                MessageBox.Show("L�tfen d�zenlemek i�in bir sat?r se�in!", "Uyar?", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void silButton_Click(object sender, EventArgs e)
        {
            // DataGridView'de bir sat?r se�ili mi kontrol et
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Kullan?c?dan onay al
                var result = MessageBox.Show("Se�ili g�revi silmek istedi?inizden emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Se�ili sat?r? sil
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        if (!row.IsNewRow) // Yeni sat?r de?ilse
                        {
                            dataGridView1.Rows.Remove(row);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("L�tfen silmek i�in bir sat?r se�in!", "Uyar?", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /*private void Form2_GorevEkleVeyaDuzenle(string gorevAdi, string aciklama, string oncelikDerecesi, string baslangicTarihi, string bitisTarihi,int index)
        {
            dataGridView1.Rows.Add(gorevAdi, aciklama, oncelikDerecesi, baslangicTarihi, bitisTarihi);
        }*/
        private void Form2_GorevEkleVeyaDuzenle(string gorevAdi, string aciklama, string oncelikDerecesi, string baslangicTarihi, string bitisTarihi, int index)
        {
            if (index >= 0) // D�zenleme i?lemi
            {
                dataGridView1.Rows[index].Cells[0].Value = gorevAdi;
                dataGridView1.Rows[index].Cells[1].Value = aciklama;
                dataGridView1.Rows[index].Cells[2].Value = oncelikDerecesi;
                dataGridView1.Rows[index].Cells[3].Value = baslangicTarihi;
                dataGridView1.Rows[index].Cells[4].Value = bitisTarihi;

            }
            else // Yeni g�rev ekleme
            {
                dataGridView1.Rows.Add(gorevAdi, aciklama, oncelikDerecesi, baslangicTarihi, bitisTarihi);
            }
        }

        
    }
}
