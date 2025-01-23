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
            oncelikderecesiTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ekleButton = new Button();
            iptaletButton = new Button();
            baslangicTarihiTextBox = new TextBox();
            label5 = new Label();
            bitistarihiTextBox = new TextBox();
            baslangicTarihiDateTimePicker = new DateTimePicker();
            bitisTarihiDateTimePicker = new DateTimePicker();
            SuspendLayout();
            // 
            // gorevadiTextBox
            // 
            gorevadiTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gorevadiTextBox.ForeColor = SystemColors.ScrollBar;
            gorevadiTextBox.Location = new Point(16, 54);
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
            aciklamaTextBox.Location = new Point(16, 129);
            aciklamaTextBox.Multiline = true;
            aciklamaTextBox.Name = "aciklamaTextBox";
            aciklamaTextBox.Size = new Size(723, 23);
            aciklamaTextBox.TabIndex = 1;
            aciklamaTextBox.Text = "  Açıklama";
            aciklamaTextBox.KeyPress += aciklamaTextBox_KeyPress;
            // 
            // oncelikderecesiTextBox
            // 
            oncelikderecesiTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            oncelikderecesiTextBox.ForeColor = SystemColors.ScrollBar;
            oncelikderecesiTextBox.Location = new Point(16, 204);
            oncelikderecesiTextBox.Name = "oncelikderecesiTextBox";
            oncelikderecesiTextBox.Size = new Size(723, 23);
            oncelikderecesiTextBox.TabIndex = 2;
            oncelikderecesiTextBox.Text = "  Öncelik Derecesi";
            oncelikderecesiTextBox.KeyPress += oncelikderecesiTextBox_KeyPress;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label1.Location = new Point(16, 32);
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
            label2.Location = new Point(16, 107);
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
            label3.Location = new Point(16, 182);
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
            label4.Location = new Point(16, 332);
            label4.Name = "label4";
            label4.Size = new Size(136, 19);
            label4.TabIndex = 4;
            label4.Text = "Bitiş Tarihi Giriniz:";
            // 
            // ekleButton
            // 
            ekleButton.Anchor = AnchorStyles.Bottom;
            ekleButton.Location = new Point(235, 457);
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
            iptaletButton.Location = new Point(401, 457);
            iptaletButton.Name = "iptaletButton";
            iptaletButton.Size = new Size(91, 41);
            iptaletButton.TabIndex = 6;
            iptaletButton.Text = "İptal Et";
            iptaletButton.UseVisualStyleBackColor = true;
            iptaletButton.Click += iptaletButton_Click;
            // 
            // baslangicTarihiTextBox
            // 
            baslangicTarihiTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            baslangicTarihiTextBox.ForeColor = SystemColors.ScrollBar;
            baslangicTarihiTextBox.Location = new Point(16, 279);
            baslangicTarihiTextBox.Name = "baslangicTarihiTextBox";
            baslangicTarihiTextBox.Size = new Size(723, 23);
            baslangicTarihiTextBox.TabIndex = 3;
            baslangicTarihiTextBox.Text = "  Başlangıç Tarihi";
            baslangicTarihiTextBox.KeyPress += baslangicTarihiTextBox_KeyPress;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label5.Location = new Point(16, 257);
            label5.Name = "label5";
            label5.Size = new Size(170, 19);
            label5.TabIndex = 4;
            label5.Text = "Başlangıç Tarihi Giriniz:";
            // 
            // bitistarihiTextBox
            // 
            bitistarihiTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            bitistarihiTextBox.ForeColor = SystemColors.ScrollBar;
            bitistarihiTextBox.Location = new Point(16, 354);
            bitistarihiTextBox.Name = "bitistarihiTextBox";
            bitistarihiTextBox.Size = new Size(723, 23);
            bitistarihiTextBox.TabIndex = 3;
            bitistarihiTextBox.Text = "  Bitiş Tarihi";
            bitistarihiTextBox.KeyPress += bitistarihiTextBox_KeyPress;
            // 
            // baslangicTarihiDateTimePicker
            // 
            baslangicTarihiDateTimePicker.Location = new Point(570, 279);
            baslangicTarihiDateTimePicker.Name = "baslangicTarihiDateTimePicker";
            baslangicTarihiDateTimePicker.Size = new Size(169, 23);
            baslangicTarihiDateTimePicker.TabIndex = 7;
            // 
            // bitisTarihiDateTimePicker
            // 
            bitisTarihiDateTimePicker.Location = new Point(570, 354);
            bitisTarihiDateTimePicker.Name = "bitisTarihiDateTimePicker";
            bitisTarihiDateTimePicker.Size = new Size(169, 23);
            bitisTarihiDateTimePicker.TabIndex = 8;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.AIRAKS_LOGO_02;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(751, 510);
            Controls.Add(bitisTarihiDateTimePicker);
            Controls.Add(baslangicTarihiDateTimePicker);
            Controls.Add(iptaletButton);
            Controls.Add(ekleButton);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(bitistarihiTextBox);
            Controls.Add(baslangicTarihiTextBox);
            Controls.Add(label1);
            Controls.Add(oncelikderecesiTextBox);
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
        private TextBox oncelikderecesiTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button ekleButton;
        private Button iptaletButton;
        private TextBox baslangicTarihiTextBox;
        private Label label5;
        private TextBox bitistarihiTextBox;
        private DateTimePicker baslangicTarihiDateTimePicker;
        private DateTimePicker bitisTarihiDateTimePicker;
    }
}