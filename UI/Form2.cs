using DAL;
using DATA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Form2 : Form
    {
        Context db;
        List<Personel> personeller;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            db = new Context();
            personeller = db.Personeller.ToList();

            girisVeyaGuncellemeButton.Enabled = true;
        }

        private void girisVeyaGuncellemeButton_Click(object sender, EventArgs e)
        {
            if (personeller != null && personeller.Count > 0)
            {
                foreach (Personel p in personeller)
                {
                    personelComboBox.Items.Add(p.IsimSoyisim + " / " + p.TCKimlikNo);
                }

                personelComboBox.SelectedItem = personelComboBox.Items[0];
                personelComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
                girisVeyaGuncellemeButton.Enabled = true;
                IletisimBilgisi iletisimBilgisi = db.IletisimBilgileri.FirstOrDefault(y => y.PersonelID == personeller[0].PersonelID);

                if (iletisimBilgisi != null)
                {
                    addresRTextBox.Text = iletisimBilgisi.Adres;
                    epostaTextBox.Text = iletisimBilgisi.Eposta;
                    telefonMTextBox.Text = iletisimBilgisi.Telefon;
                }
            }
        }

        private void kaydetButton_Click(object sender, EventArgs e)
        {
            string tckn = personelComboBox.SelectedItem.ToString().Split('/')[1].Trim();
            int index = personelComboBox.SelectedIndex;
            int personelID = personeller[index].PersonelID;
            IletisimBilgisi iletisimBilgisi = db.IletisimBilgileri.FirstOrDefault(y => y.PersonelID == personelID);

            //TO - DO girilen form bilgilerini kontrol et, boş data girdirme!
            if (iletisimBilgisi == null)
            {
                iletisimBilgisi = new IletisimBilgisi
                {
                    Adres = addresRTextBox.Text,
                    Eposta = epostaTextBox.Text,
                    Telefon = telefonMTextBox.Text,
                    PersonelID = personelID
                };
                db.IletisimBilgileri.Add(iletisimBilgisi);
                
            }
            else
            {
                iletisimBilgisi.Adres = addresRTextBox.Text;
                iletisimBilgisi.Eposta = epostaTextBox.Text;
                iletisimBilgisi.Telefon = telefonMTextBox.Text;
            }
            MessageBox.Show("Veri kaydı başarılı");
            db.SaveChanges();
        }
    }
}
