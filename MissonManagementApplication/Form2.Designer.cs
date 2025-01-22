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
            bitistarihiTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ekleButton = new Button();
            iptaletButton = new Button();
            SuspendLayout();
            // 
            // gorevadiTextBox
            // 
            gorevadiTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gorevadiTextBox.Location = new Point(16, 50);
            gorevadiTextBox.Name = "gorevadiTextBox";
            gorevadiTextBox.Size = new Size(421, 23);
            gorevadiTextBox.TabIndex = 0;
            // 
            // aciklamaTextBox
            // 
            aciklamaTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            aciklamaTextBox.Location = new Point(16, 125);
            aciklamaTextBox.Name = "aciklamaTextBox";
            aciklamaTextBox.Size = new Size(421, 23);
            aciklamaTextBox.TabIndex = 1;
            // 
            // oncelikderecesiTextBox
            // 
            oncelikderecesiTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            oncelikderecesiTextBox.Location = new Point(16, 200);
            oncelikderecesiTextBox.Name = "oncelikderecesiTextBox";
            oncelikderecesiTextBox.Size = new Size(421, 23);
            oncelikderecesiTextBox.TabIndex = 2;
            // 
            // bitistarihiTextBox
            // 
            bitistarihiTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            bitistarihiTextBox.Location = new Point(16, 275);
            bitistarihiTextBox.Name = "bitistarihiTextBox";
            bitistarihiTextBox.Size = new Size(421, 23);
            bitistarihiTextBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(16, 32);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 4;
            label1.Text = "Görev Adı";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(16, 107);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 4;
            label2.Text = "Açıklama";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(16, 182);
            label3.Name = "label3";
            label3.Size = new Size(94, 15);
            label3.TabIndex = 4;
            label3.Text = "Öncelik Derecesi";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(16, 257);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 4;
            label4.Text = "Bitiş Tarihi";
            // 
            // ekleButton
            // 
            ekleButton.Anchor = AnchorStyles.Bottom;
            ekleButton.Location = new Point(84, 322);
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
            iptaletButton.Location = new Point(250, 322);
            iptaletButton.Name = "iptaletButton";
            iptaletButton.Size = new Size(91, 41);
            iptaletButton.TabIndex = 6;
            iptaletButton.Text = "İptal Et";
            iptaletButton.UseVisualStyleBackColor = true;
            iptaletButton.Click += iptaletButton_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(449, 375);
            Controls.Add(iptaletButton);
            Controls.Add(ekleButton);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(bitistarihiTextBox);
            Controls.Add(oncelikderecesiTextBox);
            Controls.Add(aciklamaTextBox);
            Controls.Add(gorevadiTextBox);
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
        private TextBox bitistarihiTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button ekleButton;
        private Button iptaletButton;
    }
}