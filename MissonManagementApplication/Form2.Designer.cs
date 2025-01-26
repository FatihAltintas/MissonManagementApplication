namespace MissonManagementApplication
{
    partial class Form2
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
            gorevadiTextBox = new TextBox();
            aciklamaTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ekleButton = new Button();
            iptaletButton = new Button();
            label5 = new Label();
            baslangicTarihiDateTimePicker = new DateTimePicker();
            bitisTarihiDateTimePicker = new DateTimePicker();
            oncelikDerecesiComboBox = new ComboBox();
            atayanTextBox = new TextBox();
            atananTextBox = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            tamamlandiComboBox = new ComboBox();
            SuspendLayout();
            // 
            // gorevadiTextBox
            // 
            gorevadiTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gorevadiTextBox.ForeColor = SystemColors.ScrollBar;
            gorevadiTextBox.Location = new Point(14, 267);
            gorevadiTextBox.Margin = new Padding(3, 4, 3, 4);
            gorevadiTextBox.Name = "gorevadiTextBox";
            gorevadiTextBox.Size = new Size(826, 27);
            gorevadiTextBox.TabIndex = 0;
            gorevadiTextBox.Text = "  Görev Adı";
            gorevadiTextBox.KeyPress += gorevadiTextBox_KeyPress;
            // 
            // aciklamaTextBox
            // 
            aciklamaTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            aciklamaTextBox.ForeColor = SystemColors.ScrollBar;
            aciklamaTextBox.Location = new Point(14, 367);
            aciklamaTextBox.Margin = new Padding(3, 4, 3, 4);
            aciklamaTextBox.Multiline = true;
            aciklamaTextBox.Name = "aciklamaTextBox";
            aciklamaTextBox.Size = new Size(826, 29);
            aciklamaTextBox.TabIndex = 1;
            aciklamaTextBox.Text = "  Açıklama";
            aciklamaTextBox.KeyPress += aciklamaTextBox_KeyPress;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label1.Location = new Point(14, 237);
            label1.Name = "label1";
            label1.Size = new Size(173, 23);
            label1.TabIndex = 4;
            label1.Text = "Görev Adı Giriniz: ";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label2.Location = new Point(14, 337);
            label2.Name = "label2";
            label2.Size = new Size(160, 23);
            label2.TabIndex = 4;
            label2.Text = "Açıklama Giriniz:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label3.Location = new Point(14, 437);
            label3.Name = "label3";
            label3.Size = new Size(226, 23);
            label3.TabIndex = 4;
            label3.Text = "Öncelik Derecesi Giriniz:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label4.Location = new Point(14, 637);
            label4.Name = "label4";
            label4.Size = new Size(173, 23);
            label4.TabIndex = 4;
            label4.Text = "Bitiş Tarihi Giriniz:";
            // 
            // ekleButton
            // 
            ekleButton.Anchor = AnchorStyles.Bottom;
            ekleButton.Location = new Point(269, 822);
            ekleButton.Margin = new Padding(3, 4, 3, 4);
            ekleButton.Name = "ekleButton";
            ekleButton.Size = new Size(104, 55);
            ekleButton.TabIndex = 5;
            ekleButton.Text = "Ekle";
            ekleButton.UseVisualStyleBackColor = true;
            ekleButton.Click += ekleButton_Click;
            // 
            // iptaletButton
            // 
            iptaletButton.Anchor = AnchorStyles.Bottom;
            iptaletButton.Location = new Point(458, 822);
            iptaletButton.Margin = new Padding(3, 4, 3, 4);
            iptaletButton.Name = "iptaletButton";
            iptaletButton.Size = new Size(104, 55);
            iptaletButton.TabIndex = 6;
            iptaletButton.Text = "İptal Et";
            iptaletButton.UseVisualStyleBackColor = true;
            iptaletButton.Click += iptaletButton_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label5.Location = new Point(14, 537);
            label5.Name = "label5";
            label5.Size = new Size(215, 23);
            label5.TabIndex = 4;
            label5.Text = "Başlangıç Tarihi Giriniz:";
            // 
            // baslangicTarihiDateTimePicker
            // 
            baslangicTarihiDateTimePicker.Location = new Point(14, 567);
            baslangicTarihiDateTimePicker.Margin = new Padding(3, 4, 3, 4);
            baslangicTarihiDateTimePicker.Name = "baslangicTarihiDateTimePicker";
            baslangicTarihiDateTimePicker.Size = new Size(826, 27);
            baslangicTarihiDateTimePicker.TabIndex = 7;
            // 
            // bitisTarihiDateTimePicker
            // 
            bitisTarihiDateTimePicker.Location = new Point(14, 667);
            bitisTarihiDateTimePicker.Margin = new Padding(3, 4, 3, 4);
            bitisTarihiDateTimePicker.Name = "bitisTarihiDateTimePicker";
            bitisTarihiDateTimePicker.Size = new Size(826, 27);
            bitisTarihiDateTimePicker.TabIndex = 8;
            // 
            // oncelikDerecesiComboBox
            // 
            oncelikDerecesiComboBox.ForeColor = SystemColors.ControlText;
            oncelikDerecesiComboBox.FormattingEnabled = true;
            oncelikDerecesiComboBox.Items.AddRange(new object[] { "Düşük", "Orta", "Yüksek" });
            oncelikDerecesiComboBox.Location = new Point(14, 467);
            oncelikDerecesiComboBox.Margin = new Padding(3, 4, 3, 4);
            oncelikDerecesiComboBox.Name = "oncelikDerecesiComboBox";
            oncelikDerecesiComboBox.Size = new Size(826, 28);
            oncelikDerecesiComboBox.TabIndex = 9;
            // 
            // atayanTextBox
            // 
            atayanTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            atayanTextBox.ForeColor = SystemColors.ScrollBar;
            atayanTextBox.Location = new Point(14, 67);
            atayanTextBox.Margin = new Padding(3, 4, 3, 4);
            atayanTextBox.Name = "atayanTextBox";
            atayanTextBox.Size = new Size(826, 27);
            atayanTextBox.TabIndex = 0;
            atayanTextBox.Text = "  Adı - Soyadı";
            atayanTextBox.KeyPress += atayanTextBox_KeyPress;
            // 
            // atananTextBox
            // 
            atananTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            atananTextBox.ForeColor = SystemColors.ScrollBar;
            atananTextBox.Location = new Point(14, 167);
            atananTextBox.Margin = new Padding(3, 4, 3, 4);
            atananTextBox.Multiline = true;
            atananTextBox.Name = "atananTextBox";
            atananTextBox.Size = new Size(826, 29);
            atananTextBox.TabIndex = 1;
            atananTextBox.Text = "  Adı - Soyadı";
            atananTextBox.KeyPress += atananTextBox_KeyPress;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label6.Location = new Point(14, 37);
            label6.Name = "label6";
            label6.Size = new Size(141, 23);
            label6.TabIndex = 4;
            label6.Text = "Görev Atayan: ";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label7.Location = new Point(14, 137);
            label7.Name = "label7";
            label7.Size = new Size(136, 23);
            label7.TabIndex = 4;
            label7.Text = "Görev Atanan:";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label8.Location = new Point(14, 737);
            label8.Name = "label8";
            label8.Size = new Size(193, 23);
            label8.TabIndex = 11;
            label8.Text = "Tamamlanma Durumu";
            // 
            // tamamlandiComboBox
            // 
            tamamlandiComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tamamlandiComboBox.FormattingEnabled = true;
            tamamlandiComboBox.Items.AddRange(new object[] { "Evet", "Hayır" });
            tamamlandiComboBox.Location = new Point(14, 763);
            tamamlandiComboBox.Name = "tamamlandiComboBox";
            tamamlandiComboBox.Size = new Size(826, 28);
            tamamlandiComboBox.TabIndex = 12;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.AIRAKS_LOGO_02;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(858, 893);
            Controls.Add(tamamlandiComboBox);
            Controls.Add(label8);
            Controls.Add(oncelikDerecesiComboBox);
            Controls.Add(bitisTarihiDateTimePicker);
            Controls.Add(baslangicTarihiDateTimePicker);
            Controls.Add(iptaletButton);
            Controls.Add(ekleButton);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(atananTextBox);
            Controls.Add(label1);
            Controls.Add(atayanTextBox);
            Controls.Add(aciklamaTextBox);
            Controls.Add(gorevadiTextBox);
            DoubleBuffered = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox gorevadiTextBox;
        private TextBox aciklamaTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button ekleButton;
        private Button iptaletButton;
        private Label label5;
        private DateTimePicker baslangicTarihiDateTimePicker;
        private DateTimePicker bitisTarihiDateTimePicker;
        private ComboBox oncelikDerecesiComboBox;
        private TextBox atayanTextBox;
        private TextBox atananTextBox;
        private Label label6;
        private Label label7;
        private Label label8;
        private ComboBox tamamlandiComboBox;
    }
}