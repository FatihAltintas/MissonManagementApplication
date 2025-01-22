namespace MissonManagementApplication
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            gorevAdi = new DataGridViewTextBoxColumn();
            aciklama = new DataGridViewTextBoxColumn();
            oncelikDerecesi = new DataGridViewTextBoxColumn();
            baslangicTarihi = new DataGridViewTextBoxColumn();
            bitisTarihi = new DataGridViewTextBoxColumn();
            gorevekleButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { gorevAdi, aciklama, oncelikDerecesi, baslangicTarihi, bitisTarihi });
            dataGridView1.Dock = DockStyle.Top;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(660, 150);
            dataGridView1.TabIndex = 0;
            // 
            // gorevAdi
            // 
            gorevAdi.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            gorevAdi.HeaderText = "Görev Adı";
            gorevAdi.Name = "gorevAdi";
            // 
            // aciklama
            // 
            aciklama.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            aciklama.HeaderText = "Açıklama";
            aciklama.Name = "aciklama";
            // 
            // oncelikDerecesi
            // 
            oncelikDerecesi.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            oncelikDerecesi.HeaderText = "Öncelik Derecesi";
            oncelikDerecesi.Name = "oncelikDerecesi";
            // 
            // baslangicTarihi
            // 
            baslangicTarihi.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            baslangicTarihi.HeaderText = "Başlangıç Tarihi";
            baslangicTarihi.Name = "baslangicTarihi";
            // 
            // bitisTarihi
            // 
            bitisTarihi.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            bitisTarihi.HeaderText = "Bitiş Tarihi";
            bitisTarihi.Name = "bitisTarihi";
            // 
            // gorevekleButton
            // 
            gorevekleButton.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gorevekleButton.Location = new Point(12, 172);
            gorevekleButton.Name = "gorevekleButton";
            gorevekleButton.Size = new Size(86, 39);
            gorevekleButton.TabIndex = 2;
            gorevekleButton.Text = "Görev Ekle";
            gorevekleButton.UseVisualStyleBackColor = true;
            gorevekleButton.Click += gorevekleButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(660, 424);
            Controls.Add(gorevekleButton);
            Controls.Add(dataGridView1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Görev Yönetim Uygulaması";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button gorevekleButton;
        private DataGridViewTextBoxColumn gorevAdi;
        private DataGridViewTextBoxColumn aciklama;
        private DataGridViewTextBoxColumn oncelikDerecesi;
        private DataGridViewTextBoxColumn baslangicTarihi;
        private DataGridViewTextBoxColumn bitisTarihi;
    }
}
