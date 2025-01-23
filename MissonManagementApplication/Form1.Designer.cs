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
            duzenleButton = new Button();
            silButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { gorevAdi, aciklama, oncelikDerecesi, baslangicTarihi, bitisTarihi });
            dataGridView1.Dock = DockStyle.Top;
            dataGridView1.ImeMode = ImeMode.NoControl;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1173, 160);
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
            gorevekleButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            gorevekleButton.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gorevekleButton.Location = new Point(12, 477);
            gorevekleButton.Name = "gorevekleButton";
            gorevekleButton.Size = new Size(91, 46);
            gorevekleButton.TabIndex = 2;
            gorevekleButton.Text = "Görev Ekle";
            gorevekleButton.UseVisualStyleBackColor = true;
            gorevekleButton.Click += gorevekleButton_Click;
            // 
            // duzenleButton
            // 
            duzenleButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            duzenleButton.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            duzenleButton.Location = new Point(12, 529);
            duzenleButton.Name = "duzenleButton";
            duzenleButton.Size = new Size(91, 46);
            duzenleButton.TabIndex = 3;
            duzenleButton.Text = "Düzenle";
            duzenleButton.UseVisualStyleBackColor = true;
            duzenleButton.Click += duzenleButton_Click;
            // 
            // silButton
            // 
            silButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            silButton.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            silButton.Location = new Point(12, 581);
            silButton.Name = "silButton";
            silButton.Size = new Size(91, 46);
            silButton.TabIndex = 4;
            silButton.Text = "Sil";
            silButton.UseVisualStyleBackColor = true;
            silButton.Click += silButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.AIRAKS_LOGO_02;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1173, 639);
            Controls.Add(silButton);
            Controls.Add(duzenleButton);
            Controls.Add(gorevekleButton);
            Controls.Add(dataGridView1);
            DoubleBuffered = true;
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
        private Button duzenleButton;
        private Button silButton;
    }
}
