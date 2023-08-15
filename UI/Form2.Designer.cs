namespace UI
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
            label1 = new Label();
            personelComboBox = new ComboBox();
            girisVeyaGuncellemeButton = new Button();
            groupBox1 = new GroupBox();
            telefonMTextBox = new MaskedTextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            kaydetButton = new Button();
            addresRTextBox = new RichTextBox();
            epostaTextBox = new TextBox();
            button1 = new Button();
            button2 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 13);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(394, 21);
            label1.TabIndex = 0;
            label1.Text = "İletişim Bilgilerini Tamamlamak İçin Bir Personel Seçiniz:";
            // 
            // personelComboBox
            // 
            personelComboBox.FormattingEnabled = true;
            personelComboBox.Location = new Point(15, 54);
            personelComboBox.Name = "personelComboBox";
            personelComboBox.Size = new Size(515, 29);
            personelComboBox.TabIndex = 1;
            // 
            // girisVeyaGuncellemeButton
            // 
            girisVeyaGuncellemeButton.Location = new Point(15, 99);
            girisVeyaGuncellemeButton.Name = "girisVeyaGuncellemeButton";
            girisVeyaGuncellemeButton.Size = new Size(515, 60);
            girisVeyaGuncellemeButton.TabIndex = 2;
            girisVeyaGuncellemeButton.Text = "GİRİŞ VEYA GÜNCELLEME YAP";
            girisVeyaGuncellemeButton.UseVisualStyleBackColor = true;
            girisVeyaGuncellemeButton.Click += girisVeyaGuncellemeButton_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(telefonMTextBox);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(kaydetButton);
            groupBox1.Controls.Add(addresRTextBox);
            groupBox1.Controls.Add(epostaTextBox);
            groupBox1.Location = new Point(15, 194);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(519, 361);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "İletişim Bilgisi Giriş Ekranı";
            // 
            // telefonMTextBox
            // 
            telefonMTextBox.Location = new Point(153, 120);
            telefonMTextBox.Mask = "(999) 000-0000";
            telefonMTextBox.Name = "telefonMTextBox";
            telefonMTextBox.Size = new Size(360, 29);
            telefonMTextBox.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(56, 180);
            label4.Name = "label4";
            label4.Size = new Size(77, 21);
            label4.TabIndex = 6;
            label4.Text = "Ev Adresi:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(62, 120);
            label3.Name = "label3";
            label3.Size = new Size(71, 21);
            label3.TabIndex = 5;
            label3.Text = "Telefonu:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 60);
            label2.Name = "label2";
            label2.Size = new Size(113, 21);
            label2.TabIndex = 4;
            label2.Text = "E-posta Adresi:";
            // 
            // kaydetButton
            // 
            kaydetButton.Location = new Point(373, 292);
            kaydetButton.Name = "kaydetButton";
            kaydetButton.Size = new Size(140, 62);
            kaydetButton.TabIndex = 3;
            kaydetButton.Text = "KAYDET";
            kaydetButton.UseVisualStyleBackColor = true;
            kaydetButton.Click += kaydetButton_Click;
            // 
            // addresRTextBox
            // 
            addresRTextBox.Location = new Point(153, 180);
            addresRTextBox.Name = "addresRTextBox";
            addresRTextBox.Size = new Size(360, 96);
            addresRTextBox.TabIndex = 2;
            addresRTextBox.Text = "";
            // 
            // epostaTextBox
            // 
            epostaTextBox.Location = new Point(153, 60);
            epostaTextBox.Name = "epostaTextBox";
            epostaTextBox.Size = new Size(360, 29);
            epostaTextBox.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(15, 584);
            button1.Name = "button1";
            button1.Size = new Size(200, 62);
            button1.TabIndex = 7;
            button1.Text = "KAYDET";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(334, 584);
            button2.Name = "button2";
            button2.Size = new Size(200, 62);
            button2.TabIndex = 8;
            button2.Text = "KAYDET";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(546, 658);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(girisVeyaGuncellemeButton);
            Controls.Add(personelComboBox);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox personelComboBox;
        private Button girisVeyaGuncellemeButton;
        private GroupBox groupBox1;
        private MaskedTextBox telefonMTextBox;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button kaydetButton;
        private RichTextBox addresRTextBox;
        private TextBox epostaTextBox;
        private Button button1;
        private Button button2;
    }
}