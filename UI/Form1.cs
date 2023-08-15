using DAL;
using DATA;
using Microsoft.IdentityModel.Tokens;

namespace UI
{
    public partial class Form1 : Form
    {
        Context db;
        List<string> birimler;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            db = new Context();
            erkekRadioButton.Checked = true;
            kadinRadioButton.Checked = false;
            temizleButton.Enabled = false;

            isimTBox.TextChanged += genel_TextChanged;
            isimTBox.MaxLength = 30;

            soyIsimTBox.TextChanged += genel_TextChanged;
            soyIsimTBox.MaxLength = 50;

            tcknTBox.TextChanged += genel_TextChanged;
            tcknTBox.MaxLength = 11;
            birimler = new List<string>() { "Memur", "Beyaz Yaka", "Mavi Yaka" };

            foreach (string item in birimler)
            {
                birimComboBox.Items.Add(item);
            }
            birimComboBox.SelectedItem = birimComboBox.Items[0];
            birimComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void genel_TextChanged(object? sender, EventArgs e)
        {
            if (sender is System.Windows.Forms.TextBox)
            {
                var tBox = sender as System.Windows.Forms.TextBox;

                if (!String.IsNullOrEmpty(tBox.Text))
                {
                    temizleButton.Enabled = true;
                }
                else
                {
                    if (String.IsNullOrEmpty(isimTBox.Text) && String.IsNullOrEmpty(soyIsimTBox.Text) && String.IsNullOrEmpty(tcknTBox.Text))
                    {
                        temizleButton.Enabled = false;
                    }
                }
            }
        }

        private void kaydetButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(isimTBox.Text))
            {
                MesajGonder("İsim alanını doldurun.");
                return;
            }
            if (String.IsNullOrEmpty(soyIsimTBox.Text))
            {
                MesajGonder("Soyisim alanını doldurun.");
                return;
            }
            if (String.IsNullOrEmpty(tcknTBox.Text))
            {
                MesajGonder("TCKN alanını doldurun.");
                return;
            }
            if (dogumTarihiDateTimePicker.Value > DateTime.Now.AddYears(-18))
            {
                MesajGonder("En az 18 yaşında olmalı");
                return;
            }

            if (db.Personeller.FirstOrDefault(x => x.TCKimlikNo == tcknTBox.Text) != null)
            {
                MesajGonder("Bu TCKN ile işlem yapılmıştır. Lütfen başka bir TCKN kullanınız");
                return;
            }

            Personel personel = new Personel()
            {
                Birim = birimComboBox.Text,
                Cinsiyet = erkekRadioButton.Checked ? true : false,
                DogumTarihi = dogumTarihiDateTimePicker.Value,
                Isim = isimTBox.Text,
                Soyisim = soyIsimTBox.Text,
                TCKimlikNo = tcknTBox.Text
            };

            db.Personeller.Add(personel);
            db.SaveChanges();

            MesajGonder("Kayıt başarılı");
        }
        void MesajGonder(string message)
        {
            MessageBox.Show(message);
        }

        private void temizleButton_Click(object sender, EventArgs e)
        {
            isimTBox.Text = String.Empty;
            soyIsimTBox.Text = String.Empty;
            tcknTBox.Text = String.Empty;
            dogumTarihiDateTimePicker.Value = DateTime.Now;
        }

        private void navigasyonButton_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}