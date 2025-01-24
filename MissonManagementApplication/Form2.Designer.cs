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
            SuspendLayout();
            // 
            // gorevadiTextBox
            // 
            gorevadiTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gorevadiTextBox.ForeColor = SystemColors.ScrollBar;
            gorevadiTextBox.Location = new Point(12, 200);
            gorevadiTextBox.Name = "gorevadiTextBox";
            gorevadiTextBox.Size = new Size(723, 23);
            gorevadiTextBox.TabIndex = 0;
            gorevadiTextBox.Text = "  Görev Adı";
            gorevadiTextBox.KeyPress += gorevadiTextBox_KeyPress;
            // 
            // aciklamaTextBox
            // 
            aciklamaTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            aciklamaTextBox.ForeColor = SystemColors.ScrollBar;
            aciklamaTextBox.Location = new Point(12, 275);
            aciklamaTextBox.Multiline = true;
            aciklamaTextBox.Name = "aciklamaTextBox";
            aciklamaTextBox.Size = new Size(723, 23);
            aciklamaTextBox.TabIndex = 1;
            aciklamaTextBox.Text = "  Açıklama";
            aciklamaTextBox.KeyPress += aciklamaTextBox_KeyPress;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label1.Location = new Point(12, 178);
            label1.Name = "label1";
            label1.Size = new Size(134, 19);
            label1.TabIndex = 4;
            label1.Text = "Görev Adı Giriniz: ";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label2.Location = new Point(12, 253);
            label2.Name = "label2";
            label2.Size = new Size(125, 19);
            label2.TabIndex = 4;
            label2.Text = "Açıklama Giriniz:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label3.Location = new Point(12, 328);
            label3.Name = "label3";
            label3.Size = new Size(178, 19);
            label3.TabIndex = 4;
            label3.Text = "Öncelik Derecesi Giriniz:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label4.Location = new Point(12, 478);
            label4.Name = "label4";
            label4.Size = new Size(136, 19);
            label4.TabIndex = 4;
            label4.Text = "Bitiş Tarihi Giriniz:";
            // 
            // ekleButton
            // 
            ekleButton.Anchor = AnchorStyles.Bottom;
            ekleButton.Location = new Point(235, 559);
            ekleButton.Name = "ekleButton";
            ekleButton.Size = new Size(91, 41);
            ekleButton.TabIndex = 5;
            ekleButton.Text = "Ekle";
            ekleButton.UseVisualStyleBackColor = true;
            ekleButton.Click += ekleButton_Click;
            // 
            // iptaletButton
            // 
            iptaletButton.Anchor = AnchorStyles.Bottom;
            iptaletButton.Location = new Point(401, 559);
            iptaletButton.Name = "iptaletButton";
            iptaletButton.Size = new Size(91, 41);
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
            label5.Location = new Point(12, 403);
            label5.Name = "label5";
            label5.Size = new Size(170, 19);
            label5.TabIndex = 4;
            label5.Text = "Başlangıç Tarihi Giriniz:";
            // 
            // baslangicTarihiDateTimePicker
            // 
            baslangicTarihiDateTimePicker.Location = new Point(12, 425);
            baslangicTarihiDateTimePicker.Name = "baslangicTarihiDateTimePicker";
            baslangicTarihiDateTimePicker.Size = new Size(723, 23);
            baslangicTarihiDateTimePicker.TabIndex = 7;
            // 
            // bitisTarihiDateTimePicker
            // 
            bitisTarihiDateTimePicker.Location = new Point(12, 500);
            bitisTarihiDateTimePicker.Name = "bitisTarihiDateTimePicker";
            bitisTarihiDateTimePicker.Size = new Size(723, 23);
            bitisTarihiDateTimePicker.TabIndex = 8;
            // 
            // oncelikDerecesiComboBox
            // 
            oncelikDerecesiComboBox.ForeColor = SystemColors.ControlText;
            oncelikDerecesiComboBox.FormattingEnabled = true;
            oncelikDerecesiComboBox.Items.AddRange(new object[] { "Düşük", "Orta", "Yüksek" });
            oncelikDerecesiComboBox.Location = new Point(12, 350);
            oncelikDerecesiComboBox.Name = "oncelikDerecesiComboBox";
            oncelikDerecesiComboBox.Size = new Size(723, 23);
            oncelikDerecesiComboBox.TabIndex = 9;
            // 
            // atayanTextBox
            // 
            atayanTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            atayanTextBox.ForeColor = SystemColors.ScrollBar;
            atayanTextBox.Location = new Point(12, 50);
            atayanTextBox.Name = "atayanTextBox";
            atayanTextBox.Size = new Size(723, 23);
            atayanTextBox.TabIndex = 0;
            atayanTextBox.Text = "  Adı - Soyadı";
            atayanTextBox.KeyPress += atayanTextBox_KeyPress;
            // 
            // atananTextBox
            // 
            atananTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            atananTextBox.ForeColor = SystemColors.ScrollBar;
            atananTextBox.Location = new Point(12, 125);
            atananTextBox.Multiline = true;
            atananTextBox.Name = "atananTextBox";
            atananTextBox.Size = new Size(723, 23);
            atananTextBox.TabIndex = 1;
            atananTextBox.Text = "  Adı - Soyadı";
            atananTextBox.KeyPress += atananTextBox_KeyPress;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label6.Location = new Point(12, 28);
            label6.Name = "label6";
            label6.Size = new Size(111, 19);
            label6.TabIndex = 4;
            label6.Text = "Görev Atayan: ";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label7.Location = new Point(12, 103);
            label7.Name = "label7";
            label7.Size = new Size(107, 19);
            label7.TabIndex = 4;
            label7.Text = "Görev Atanan:";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.AIRAKS_LOGO_02;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(751, 612);
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
    }
}