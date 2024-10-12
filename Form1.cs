using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HangMan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            basla();
        }
        public int sayac = 0;
        public String secilenSehir;
        public char[] sifreliSehir;
        String[] sehirler = {"ADANA", "ADIYAMAN", "AFYONKARAHİSAR", "AĞRI", "AMASYA", "ANKARA", "ANTALYA", "ARTVİN",
        "AYDIN", "BALIKESİR", "BİLECİK", "BİNGÖL", "BİTLİS", "BOLU", "BURDUR", "BURSA", "ÇANAKKALE", "ÇANKIRI", "ÇORUM",
        "DENİZLİ", "DİYARBAKIR", "EDİRNE", "ELAZIĞ", "ERZİNCAN", "ERZURUM", "ESKİŞEHİR", "GAZİANTEP", "GİRESUN", "GÜMÜŞHANE",
        "HAKKARİ", "HATAY", "ISPARTA", "MERSİN", "İSTANBUL", "İZMİR", "KARS", "KASTAMONU", "KAYSERİ", "KIRIKKALE", "KIRKLARELİ",
        "KIRŞEHİR", "KOCAELİ", "KONYA", "KÜTAHYA", "MALATYA", "MANİSA", "KAHRAMANMARAŞ", "MARDİN", "MUĞLA", "MUŞ", "NEVŞEHİR",
        "NİĞDE", "ORDU", "RİZE", "SAKARYA", "SAMSUN", "SİİRT", "SİNOP", "SİVAS", "TEKİRDAĞ", "TOKAT", "TRABZON", "TUNCELİ",
        "ŞANLIURFA", "UŞAK", "VAN", "YOZGAT", "ZONGULDAK", "AKSARAY", "BAYBURT", "KARAMAN", "KIRIKKALE", "BATMAN", "ŞIRNAK", "BARTIN", "ARDAHAN", "IĞDIR", "YALOVA", "KARABÜK", "KİLİS", "OSMANİYE"};

        private string sehirSec()
        {
            Random random = new Random(); 
            int rasgeleSayi = random.Next(sehirler.Length); 
            string secilenSehir = sehirler[rasgeleSayi];
            return secilenSehir; 
        }

        private char[] sehirSifrele(int uzunluk)
        {
            char[] sifreliSehirOlustur = new char[uzunluk]; 
            for (int i = 0; i < uzunluk; i++)
            {
                sifreliSehirOlustur[i] = '_'; 
            }
            return sifreliSehirOlustur; 
        }
        private char[] sehriAc(char[] sifre, char karakter, string seciliSehir)
        {
            for (int i = 0; i < seciliSehir.Length; i++)
            {
                if (seciliSehir[i] == karakter)
                {
                    sifre[i] = karakter;
                }
            }
            return sifre; 
        }

        private bool sehrinTamamiAcildiMi(char[] sifreliGelenSehir)
        {
            for (int i = 0; i < sifreliGelenSehir.Length; i++)
            {
                if (sifreliGelenSehir[i] == '_')
                {
                    return false;
                }
            }
            return true; 
        }
        BindingList<string> model = new BindingList<string>();
        public void yenidenBaslat()
        {
            sayac = 0; 
            secilenSehir = sehirSec(); 
            sifreliSehir = sehirSifrele(secilenSehir.Length);
            
            string gizliSehir = new string('_', sifreliSehir.Length); 
            lblSifreliSehir.Text = "";

            
            lblAdam.Image = Image.FromFile("C: \\Users\\apode\\source\\repos\\HangMan\\adamasmaca.jpg");

            txtGirilenHarf.Text = ""; 
            lstCikanHarf.DataSource = null; 
            model.Clear(); 
            kalanDenemeHakki();
        }

        public void kalanDenemeHakki()
        {
            lblSayac.Text = (10 - sayac).ToString(); 
        }
        public bool tahminYanlisMi(char girilenKarakter)
        {
            bool tahmin = true; 
            char girienKarakter = '\0'; 

            sifreliSehir = sehriAc(sifreliSehir, girienKarakter, secilenSehir);

            for (int i = 0; i < sifreliSehir.Length; i++)
            {
                if (sifreliSehir[i] == girilenKarakter)
                {
                    tahmin = false; 
                    break; 
                }
            }

            return tahmin; 
        }

        public void basla()
        {
            secilenSehir = sehirSec(); 
            sifreliSehir = sehirSifrele(secilenSehir.Length); 

            string gizliSehir = new string('_', sifreliSehir.Length); 
            lblSifreliSehir.Text = gizliSehir; 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        
      

        private void txtGirilenHarf_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHarfAl_Click_1(object sender, EventArgs e)
        {
            string girilenHarf = txtGirilenHarf.Text.ToUpper();
            if (girilenHarf.Length == 1)
            {
                char karakter = girilenHarf[0];
                sifreliSehir = sehriAc(sifreliSehir, karakter, secilenSehir);

                string sifreliSehirYazdir = new string(sifreliSehir);
                lblSifreliSehir.Text = sifreliSehirYazdir;

                if (sehrinTamamiAcildiMi(sifreliSehir))
                {
                    MessageBox.Show("Tebrikler Oyunu Kazandınız!", "Oyun Sonucu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    yenidenBaslat();
                    return;
                }

                if (tahminYanlisMi(karakter))
                {
                    sayac++;
                    
                    kalanDenemeHakki();

                    string imgPath = $"C: \\Users\\apode\\source\\repos\\HangMan\\adamasmaca{sayac}.jpg";
                    lblAdam.Image = Image.FromFile(imgPath);

                    model.Add(karakter.ToString());
                    lstCikanHarf.DataSource = new BindingSource(model, null);
                    lstCikanHarf.Height = 123; 
                }

                if (sayac == 10)
                {
                    MessageBox.Show($"Kaybettiniz !!  Şehir --> '{secilenSehir}'", "Oyun Sonucu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    yenidenBaslat();
                    return;
                }
            }
            else
            {
                MessageBox.Show("Lütfen Tek Karakter Harf Giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            txtGirilenHarf.Text = "";
        }

        private void btnRestart_Click_1(object sender, EventArgs e)
        {
            yenidenBaslat();

        }
    }
}
