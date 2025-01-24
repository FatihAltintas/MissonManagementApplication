using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace MissonManagementApplication
{
    public partial class Form2 : Form
    {
        //Form1 form1 = new Form1();

        //Form1'e bilgi göndermek için bir event tanımlıyoruz
        public event Action<string, string, string, string, string, string, string, int> GorevEkleVeyaDuzenle;

        private int? gorevIndex; //Düzenlenen satırın indeksini tutar (düzenleme işlemi için)
        public Form2()
        {
            InitializeComponent();
            atayanTextBox.TabIndex=0;
            atananTextBox.TabIndex = 1;
            gorevadiTextBox.TabIndex = 2;
            aciklamaTextBox.TabIndex = 3;
            oncelikDerecesiComboBox.TabIndex = 4;
            baslangicTarihiDateTimePicker.TabIndex = 5;
            bitisTarihiDateTimePicker.TabIndex=6;
            ekleButton.TabIndex = 7;
            iptaletButton.TabIndex = 8;


            oncelikDerecesiComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.Controls.Add(oncelikDerecesiComboBox);
        }
        public void gorevBilgileriniAyarla(string atayan, string atanan, string gorevadi, string aciklama, string oncelikderecesi, string baslangictarihi, string bitistarihi, int? index = null)
        {
            atayanTextBox.Text = atayan;
            atananTextBox.Text = atanan;
            gorevadiTextBox.Text = gorevadi;
            aciklamaTextBox.Text = aciklama;
            oncelikDerecesiComboBox.Text = oncelikderecesi;
            baslangicTarihiDateTimePicker.Text = baslangictarihi;
            bitisTarihiDateTimePicker.Text = bitistarihi;
            gorevIndex = index; //Eğer düzenleme modundaysa satır indeksini tut
        }
        //Ekle butonuna tıklandığında çalışacak kod
        private void ekleButton_Click(object sender, EventArgs e)
        {
            string atayan = atayanTextBox.Text;
            string atanan = atananTextBox.Text;
            string gorevadi = gorevadiTextBox.Text;
            string aciklama = aciklamaTextBox.Text;
            string oncelikderecesi = oncelikDerecesiComboBox.Text;
            string baslangictarihi = baslangicTarihiDateTimePicker.Text;
            string bitistarihi = bitisTarihiDateTimePicker.Text;



            if (string.IsNullOrWhiteSpace(gorevadi))
            {
                MessageBox.Show("Görev adı boş bırakılamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrWhiteSpace(aciklama))
            {
                MessageBox.Show("Açıklama boş bırakılamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrWhiteSpace(oncelikderecesi))
            {
                MessageBox.Show("Öncelik derecesi boş bırakılamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrWhiteSpace(baslangictarihi))
            {
                MessageBox.Show("Başlangıç tarihi boş bırakılamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrWhiteSpace(bitistarihi))
            {
                MessageBox.Show("Bitiş tarihi boş bırakılamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //Event tetikleniyor ve Form1'e bilgi gönderiliyor
            GorevEkleVeyaDuzenle?.Invoke(atayan, atanan, gorevadi, aciklama, oncelikderecesi, baslangictarihi, bitistarihi, gorevIndex ?? -1);

            //Formu kapat
            this.Hide();
        }

        private void iptaletButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void atayanTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (atayanTextBox.Text == "  Adı - Soyadı")
            {
                atayanTextBox.Clear();
                atayanTextBox.ForeColor = Color.Black;
            }
        }

        private void atananTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (atananTextBox.Text == "  Adı - Soyadı")
            {
                atananTextBox.Clear();
                atananTextBox.ForeColor = Color.Black;
            }
        }
        private void gorevadiTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (gorevadiTextBox.Text == "  Görev Adı")
            {
                gorevadiTextBox.Clear();
                gorevadiTextBox.ForeColor = Color.Black;
            }
        }

        private void aciklamaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (aciklamaTextBox.Text == "  Açıklama")
            {
                aciklamaTextBox.Clear();
                aciklamaTextBox.ForeColor = Color.Black;
            }
        }

        
    }
}
