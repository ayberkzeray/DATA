namespace UI
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
            groupBox1 = new GroupBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            birimComboBox = new ComboBox();
            kadinRadioButton = new RadioButton();
            erkekRadioButton = new RadioButton();
            dogumTarihiDateTimePicker = new DateTimePicker();
            soyIsimTBox = new TextBox();
            tcknTBox = new TextBox();
            isimTBox = new TextBox();
            temizleButton = new Button();
            kaydetButton = new Button();
            navigasyonButton = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(birimComboBox);
            groupBox1.Controls.Add(kadinRadioButton);
            groupBox1.Controls.Add(erkekRadioButton);
            groupBox1.Controls.Add(dogumTarihiDateTimePicker);
            groupBox1.Controls.Add(soyIsimTBox);
            groupBox1.Controls.Add(tcknTBox);
            groupBox1.Controls.Add(isimTBox);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(422, 428);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Personel Kayıt Ekranı";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(76, 131);
            label6.Name = "label6";
            label6.Size = new Size(60, 21);
            label6.TabIndex = 12;
            label6.Text = "Soyadı:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 191);
            label5.Name = "label5";
            label5.Size = new Size(109, 21);
            label5.TabIndex = 11;
            label5.Text = "T.C. Kimlik No:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 251);
            label4.Name = "label4";
            label4.Size = new Size(106, 21);
            label4.TabIndex = 10;
            label4.Text = "Doğum Tarihi:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 311);
            label3.Name = "label3";
            label3.Size = new Size(72, 21);
            label3.TabIndex = 9;
            label3.Text = "Cinsiyeti:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(82, 371);
            label2.Name = "label2";
            label2.Size = new Size(54, 21);
            label2.TabIndex = 8;
            label2.Text = "Birimi:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(94, 74);
            label1.Name = "label1";
            label1.Size = new Size(36, 21);
            label1.TabIndex = 7;
            label1.Text = "Adı:";
            // 
            // birimComboBox
            // 
            birimComboBox.FormattingEnabled = true;
            birimComboBox.Location = new Point(150, 371);
            birimComboBox.Name = "birimComboBox";
            birimComboBox.Size = new Size(245, 29);
            birimComboBox.TabIndex = 6;
            // 
            // kadinRadioButton
            // 
            kadinRadioButton.AutoSize = true;
            kadinRadioButton.Location = new Point(328, 311);
            kadinRadioButton.Name = "kadinRadioButton";
            kadinRadioButton.Size = new Size(67, 25);
            kadinRadioButton.TabIndex = 5;
            kadinRadioButton.TabStop = true;
            kadinRadioButton.Text = "Kadın";
            kadinRadioButton.UseVisualStyleBackColor = true;
            // 
            // erkekRadioButton
            // 
            erkekRadioButton.AutoSize = true;
            erkekRadioButton.Location = new Point(150, 311);
            erkekRadioButton.Name = "erkekRadioButton";
            erkekRadioButton.Size = new Size(66, 25);
            erkekRadioButton.TabIndex = 4;
            erkekRadioButton.TabStop = true;
            erkekRadioButton.Text = "Erkek";
            erkekRadioButton.UseVisualStyleBackColor = true;
            // 
            // dogumTarihiDateTimePicker
            // 
            dogumTarihiDateTimePicker.Location = new Point(147, 251);
            dogumTarihiDateTimePicker.Name = "dogumTarihiDateTimePicker";
            dogumTarihiDateTimePicker.Size = new Size(247, 29);
            dogumTarihiDateTimePicker.TabIndex = 3;
            // 
            // soyIsimTBox
            // 
            soyIsimTBox.Location = new Point(147, 131);
            soyIsimTBox.Name = "soyIsimTBox";
            soyIsimTBox.Size = new Size(247, 29);
            soyIsimTBox.TabIndex = 2;
            soyIsimTBox.TextChanged += genel_TextChanged;
            // 
            // tcknTBox
            // 
            tcknTBox.Location = new Point(147, 191);
            tcknTBox.Name = "tcknTBox";
            tcknTBox.Size = new Size(247, 29);
            tcknTBox.TabIndex = 1;
            // 
            // isimTBox
            // 
            isimTBox.Location = new Point(147, 71);
            isimTBox.Name = "isimTBox";
            isimTBox.Size = new Size(247, 29);
            isimTBox.TabIndex = 0;
            isimTBox.TextChanged += genel_TextChanged;
            // 
            // temizleButton
            // 
            temizleButton.Location = new Point(12, 446);
            temizleButton.Name = "temizleButton";
            temizleButton.Size = new Size(144, 48);
            temizleButton.TabIndex = 1;
            temizleButton.Text = "TEMİZLE";
            temizleButton.UseVisualStyleBackColor = true;
            temizleButton.Click += temizleButton_Click;
            // 
            // kaydetButton
            // 
            kaydetButton.Location = new Point(290, 446);
            kaydetButton.Name = "kaydetButton";
            kaydetButton.Size = new Size(144, 48);
            kaydetButton.TabIndex = 2;
            kaydetButton.Text = "KAYDET";
            kaydetButton.UseVisualStyleBackColor = true;
            kaydetButton.Click += kaydetButton_Click;
            // 
            // navigasyonButton
            // 
            navigasyonButton.Location = new Point(12, 500);
            navigasyonButton.Name = "navigasyonButton";
            navigasyonButton.Size = new Size(422, 48);
            navigasyonButton.TabIndex = 3;
            navigasyonButton.Text = "İLETİŞİM BİLGİLERİNİ GÖR";
            navigasyonButton.UseVisualStyleBackColor = true;
            navigasyonButton.Click += navigasyonButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(446, 560);
            Controls.Add(navigasyonButton);
            Controls.Add(kaydetButton);
            Controls.Add(temizleButton);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox birimComboBox;
        private RadioButton kadinRadioButton;
        private RadioButton erkekRadioButton;
        private DateTimePicker dogumTarihiDateTimePicker;
        private TextBox soyIsimTBox;
        private TextBox tcknTBox;
        private TextBox isimTBox;
        private Button temizleButton;
        private Button kaydetButton;
        private Button navigasyonButton;
    }
}