using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NtpFinallyProject
{
    public partial class frmGelAl4 : Form
    {
        public List<string> urunIsımleri = new List<string>();
        public List<double> urunFiyatlari = new List<double>();
        double nakitOdemeToplamı = 0;
        double kartOdemeToplamı = 0;
        double toplamTutarG4 = 0;

        Database db = new Database();
        public frmGelAl4()
        {
            InitializeComponent();
        }

        private void frmGelAl4_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;
            comboBox5.SelectedIndex = 0;
            comboBox6.SelectedIndex = 0;
            comboBox7.SelectedIndex = 0;
            comboBox8.SelectedIndex = 0;
            comboBox9.SelectedIndex = 0;
            comboBox10.SelectedIndex = 0;
            comboBox11.SelectedIndex = 0;
            comboBox12.SelectedIndex = 0;

        }
        public void masayiTemizle()
        {
            this.listBox1.Items.Clear();
            urunIsımleri.Clear();
            urunFiyatlari.Clear();
            toplamTutarG4 = 0;
            label2.Text = 0.ToString();
        }
        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            if (frmMasa1.anasayfa.masaDoluMuM1())
            {

                frmMasa1.anasayfa.btnMasa1.BackColor = Color.Maroon;


            }
            else
            {
                frmMasa1.anasayfa.btnMasa1.BackColor = Color.Green;
            }
            if (frmMasa1.anasayfa.masaDoluMuM2())
            {

                frmMasa1.anasayfa.btnMasa2.BackColor = Color.Maroon;


            }
            else
            {
                frmMasa1.anasayfa.btnMasa2.BackColor = Color.Green;
            }
            if (frmMasa1.anasayfa.masaDoluMuM3())
            {

                frmMasa1.anasayfa.btnMasa3.BackColor = Color.Maroon;


            }
            else
            {
                frmMasa1.anasayfa.btnMasa3.BackColor = Color.Green;
            }
            if (frmMasa1.anasayfa.masaDoluMuM4())
            {
                frmMasa1.anasayfa.btnMasa4.BackColor = Color.Maroon;
            }

            else
            {
                frmMasa1.anasayfa.btnMasa4.BackColor = Color.Green;
            }
            if (frmMasa1.anasayfa.masaDoluMuM5())
            {
                frmMasa1.anasayfa.btnMasa5.BackColor = Color.Maroon;
            }

            else
            {
                frmMasa1.anasayfa.btnMasa5.BackColor = Color.Green;
            }
            if (frmMasa1.anasayfa.masaDoluMuM6())
            {
                frmMasa1.anasayfa.btnMasa6.BackColor = Color.Maroon;
            }

            else
            {
                frmMasa1.anasayfa.btnMasa6.BackColor = Color.Green;
            }
            if (frmMasa1.anasayfa.masaDoluMuM7())
            {
                frmMasa1.anasayfa.btnMasa7.BackColor = Color.Maroon;
            }

            else
            {
                frmMasa1.anasayfa.btnMasa7.BackColor = Color.Green;
            }
            if (frmMasa1.anasayfa.masaDoluMuM8())
            {
                frmMasa1.anasayfa.btnMasa8.BackColor = Color.Maroon;
            }

            else
            {
                frmMasa1.anasayfa.btnMasa8.BackColor = Color.Green;
            }
            if (frmMasa1.anasayfa.GelAlDolumu1())
            {
                frmMasa1.anasayfa.btnGelAl1.BackColor = Color.Maroon;
            }

            else
            {
                frmMasa1.anasayfa.btnGelAl1.BackColor = Color.Green;
            }
            if (frmMasa1.anasayfa.GelAlDolumu2())
            {
                frmMasa1.anasayfa.btnGelAl2.BackColor = Color.Maroon;
            }

            else
            {
                frmMasa1.anasayfa.btnGelAl2.BackColor = Color.Green;
            }
            if (frmMasa1.anasayfa.GelAlDolumu3())
            {
                frmMasa1.anasayfa.btnGelAl3.BackColor = Color.Maroon;
            }

            else
            {
                frmMasa1.anasayfa.btnGelAl3.BackColor = Color.Green;
            }
            if (frmMasa1.anasayfa.GelAlDolumu4())
            {
                frmMasa1.anasayfa.btnGelAl4.BackColor = Color.Maroon;
            }

            else
            {
                frmMasa1.anasayfa.btnGelAl4.BackColor = Color.Green;
            }

            frmMasa1.anasayfa.Show();
            this.Hide();
        }
        private void btnNakitOde_Click(object sender, EventArgs e)
        {
            if (this.listBox1.Items.Count == 0)
            {
                MessageBox.Show("LÜTFEN SİPARİŞ EKLEYİNİZ !", "EKSİK SİPARİŞ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                nakitOdemeToplamı = toplamTutarG4;
                frmMasa1.anasayfa.gunSonu.Add(nakitOdemeToplamı);
                frmMasa1.anasayfa.gunSonuNakit.Add(nakitOdemeToplamı);

                DialogResult secenek1 = MessageBox.Show("NAKİT ÖDEME SEÇENEĞİNİ ONAYLIYOR MUSUNUZ ?", "Bilgilendirme Penceresi", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (secenek1 == DialogResult.Yes)
                {
                    MessageBox.Show("TOPLAM TUTAR NAKİT OLARAK ÖDENMİŞTİR ! --> " + nakitOdemeToplamı + " TL", "İŞLEM BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    masayiTemizle();
                }

            }
        }
        private void btnKartOde_Click(object sender, EventArgs e)
        {
            if (this.listBox1.Items.Count == 0)
            {
                MessageBox.Show("LÜTFEN SİPARİŞ EKLEYİNİZ!", "EKSİK SİPARİŞ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            else
            {
                kartOdemeToplamı = toplamTutarG4;
                frmMasa1.anasayfa.gunSonu.Add(kartOdemeToplamı);
                frmMasa1.anasayfa.gunSonuKredi.Add(kartOdemeToplamı);
                DialogResult secenek2 = MessageBox.Show("KREDİ KARTI İLE ÖDEME SEÇENEĞİNİ ONAYLIYOR MUSUNUZ ?", "Bilgilendirme Penceresi", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (secenek2 == DialogResult.Yes)
                {
                    MessageBox.Show("TOPLAM TUTAR KREDİ KARTI KULLANILARAK ÖDENMİŞTİR ! --> " + kartOdemeToplamı + " TL", "İŞLEM BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    masayiTemizle();
                }
            }

        }
        private void btnMasayiBosalt_Click(object sender, EventArgs e)
        {
            if (this.listBox1.Items.Count == 0)
            {
                MessageBox.Show("HERHANGİ BİR SİPARİŞ ALINMAMIŞ !", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else
            {

                DialogResult secenek5 = MessageBox.Show("SİPARİŞİ İPTAL ETMEK İSTİYOR MUSUNUZ ?", "Bilgilendirme Penceresi", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (secenek5 == DialogResult.Yes)
                {

                    masayiTemizle();

                }


            }

        }

        private void btn1KgProf_Click(object sender, EventArgs e)
        {
            //tutar

            toplamTutarG4 += (comboBox1.SelectedIndex + 1) * db.Profiterol1kg();
            label2.Text = toplamTutarG4.ToString();

            //listbox item kısmı

            string urunAciklamasi = "1 KİLO PROFİTEROL  X ";
            listBox1.Items.Add(urunAciklamasi + (comboBox1.SelectedIndex + 1));

            //Liste işlemleri
            urunIsımleri.Add(urunAciklamasi + (comboBox1.SelectedIndex + 1));
            urunFiyatlari.Add(db.Profiterol1kg());


        }
        private void btnProf750gr_Click(object sender, EventArgs e)
        {
            toplamTutarG4 += (comboBox3.SelectedIndex + 1) * db.Profiterol750gr();
            label2.Text = toplamTutarG4.ToString();

            //listbox item kısmı

            string urunAciklamasi = "750 GR PROFİTEROL  X ";
            listBox1.Items.Add(urunAciklamasi + (comboBox3.SelectedIndex + 1));

            //Liste işlemleri
            urunIsımleri.Add(urunAciklamasi + (comboBox1.SelectedIndex + 1));
            urunFiyatlari.Add(db.Profiterol750gr());
        }
        private void btnProf500gr_Click(object sender, EventArgs e)
        {
            toplamTutarG4 += (comboBox2.SelectedIndex + 1) * db.Profiterol500gr();
            label2.Text = toplamTutarG4.ToString();

            //listbox item kısmı

            string urunAciklamasi = "YARIM KİLO PROFİTEROL  X ";
            listBox1.Items.Add(urunAciklamasi + (comboBox2.SelectedIndex + 1));

            //Liste işlemleri
            urunIsımleri.Add(urunAciklamasi + (comboBox1.SelectedIndex + 1));
            urunFiyatlari.Add(db.Profiterol500gr());

        }
        private void btnProfPrsyn(object sender, EventArgs e)
        {
            toplamTutarG4 += (comboBox4.SelectedIndex + 1) * db.ProfiterolPorsiyon();
            label2.Text = toplamTutarG4.ToString();

            //listbox item kısmı

            string urunAciklamasi = "1 PORSİYON PROFİTEROL  X ";
            listBox1.Items.Add(urunAciklamasi + (comboBox4.SelectedIndex + 1));

            //Liste işlemleri
            urunIsımleri.Add(urunAciklamasi + (comboBox1.SelectedIndex + 1));
            urunFiyatlari.Add(db.ProfiterolPorsiyon());
        }
        private void btnEkler1KG_Click(object sender, EventArgs e)
        {
            toplamTutarG4 += (comboBox5.SelectedIndex + 1) * db.Ekler1KG();
            label2.Text = toplamTutarG4.ToString();

            //listbox item kısmı

            string urunAciklamasi = "1 KİLO EKLER  X ";
            listBox1.Items.Add(urunAciklamasi + (comboBox5.SelectedIndex + 1));

            //Liste işlemleri
            urunIsımleri.Add(urunAciklamasi + (comboBox1.SelectedIndex + 1));
            urunFiyatlari.Add(db.Ekler1KG());
        }
        private void btnEkler750GR_Click(object sender, EventArgs e)
        {
            toplamTutarG4 += (comboBox6.SelectedIndex + 1) * db.Ekler750gr();
            label2.Text = toplamTutarG4.ToString();

            //listbox item kısmı

            string urunAciklamasi = "750 GR EKLER  X ";
            listBox1.Items.Add(urunAciklamasi + (comboBox6.SelectedIndex + 1));

            //Liste işlemleri
            urunIsımleri.Add(urunAciklamasi + (comboBox1.SelectedIndex + 1));
            urunFiyatlari.Add(db.Ekler750gr());
        }
        private void btnEklerPrsyn_Click(object sender, EventArgs e)
        {
            toplamTutarG4 += (comboBox8.SelectedIndex + 1) * db.EklerPorsiyon();
            label2.Text = toplamTutarG4.ToString();

            //listbox item kısmı

            string urunAciklamasi = "1 PORSİYON EKLER  X ";
            listBox1.Items.Add(urunAciklamasi + (comboBox8.SelectedIndex + 1));

            //Liste işlemleri
            urunIsımleri.Add(urunAciklamasi + (comboBox1.SelectedIndex + 1));
            urunFiyatlari.Add(db.EklerPorsiyon());
        }
        private void btnEkler500GR_Click(object sender, EventArgs e)
        {
            toplamTutarG4 += (comboBox7.SelectedIndex + 1) * db.Ekler500gr();
            label2.Text = toplamTutarG4.ToString();

            //listbox item kısmı

            string urunAciklamasi = "500 GR EKLER  X ";
            listBox1.Items.Add(urunAciklamasi + (comboBox7.SelectedIndex + 1));

            //Liste işlemleri
            urunIsımleri.Add(urunAciklamasi + (comboBox1.SelectedIndex + 1));
            urunFiyatlari.Add(db.Ekler500gr());
        }
        private void btnTekKisilikPasta_Click(object sender, EventArgs e)
        {
            toplamTutarG4 += (comboBox9.SelectedIndex + 1) * db.TekKisilikPasta();
            label2.Text = toplamTutarG4.ToString();

            //listbox item kısmı

            string urunAciklamasi = "TEK KİŞİLİK DİLİM PASTA  X ";
            listBox1.Items.Add(urunAciklamasi + (comboBox9.SelectedIndex + 1));

            //Liste işlemleri
            urunIsımleri.Add(urunAciklamasi + (comboBox1.SelectedIndex + 1));
            urunFiyatlari.Add(db.TekKisilikPasta());

        }
        private void brnTrilice_Click(object sender, EventArgs e)
        {
            toplamTutarG4 += (comboBox32.SelectedIndex + 1) * db.Trilice();
            label2.Text = toplamTutarG4.ToString();

            //listbox item kısmı

            string urunAciklamasi = "TRİLİÇE  X ";
            listBox1.Items.Add(urunAciklamasi + (comboBox32.SelectedIndex + 1));

            //Liste işlemleri
            urunIsımleri.Add(urunAciklamasi + (comboBox1.SelectedIndex + 1));
            urunFiyatlari.Add(db.Trilice());

        }
        private void btnTiramisu_Click(object sender, EventArgs e)
        {
            toplamTutarG4 += (comboBox29.SelectedIndex + 1) * db.Tiramisu();
            label2.Text = toplamTutarG4.ToString();

            //listbox item kısmı

            string urunAciklamasi = "TİRAMİSU  X ";
            listBox1.Items.Add(urunAciklamasi + (comboBox29.SelectedIndex + 1));

            //Liste işlemleri
            urunIsımleri.Add(urunAciklamasi + (comboBox1.SelectedIndex + 1));
            urunFiyatlari.Add(db.Tiramisu());

        }
        private void btnMagnolia_Click(object sender, EventArgs e)
        {
            toplamTutarG4 += (comboBox28.SelectedIndex + 1) * db.Magnolia();
            label2.Text = toplamTutarG4.ToString();

            //listbox item kısmı

            string urunAciklamasi = "MAGNOLİA  X ";
            listBox1.Items.Add(urunAciklamasi + (comboBox28.SelectedIndex + 1));

            //Liste işlemleri
            urunIsımleri.Add(urunAciklamasi + (comboBox1.SelectedIndex + 1));
            urunFiyatlari.Add(db.Magnolia());


        }
        private void btnDonut_Click(object sender, EventArgs e)
        {
            toplamTutarG4 += (comboBox27.SelectedIndex + 1) * db.Donut();
            label2.Text = toplamTutarG4.ToString();

            //listbox item kısmı

            string urunAciklamasi = "DONUT  X ";
            listBox1.Items.Add(urunAciklamasi + (comboBox27.SelectedIndex + 1));

            //Liste işlemleri
            urunIsımleri.Add(urunAciklamasi + (comboBox1.SelectedIndex + 1));
            urunFiyatlari.Add(db.Donut());

        }
        private void btnMakaron_Click(object sender, EventArgs e)
        {
            toplamTutarG4 += (comboBox26.SelectedIndex + 1) * db.Makaron();
            label2.Text = toplamTutarG4.ToString();

            //listbox item kısmı

            string urunAciklamasi = "MAKARON  X ";
            listBox1.Items.Add(urunAciklamasi + (comboBox26.SelectedIndex + 1));

            //Liste işlemleri
            urunIsımleri.Add(urunAciklamasi + (comboBox1.SelectedIndex + 1));
            urunFiyatlari.Add(db.Makaron());
        }
        private void btnSanSebastian_Click(object sender, EventArgs e)
        {
            toplamTutarG4 += (comboBox25.SelectedIndex + 1) * db.SanSenbastian();
            label2.Text = toplamTutarG4.ToString();

            //listbox item kısmı

            string urunAciklamasi = "SANSEBASTİAN  X ";
            listBox1.Items.Add(urunAciklamasi + (comboBox25.SelectedIndex + 1));

            //Liste işlemleri
            urunIsımleri.Add(urunAciklamasi + (comboBox1.SelectedIndex + 1));
            urunFiyatlari.Add(db.SanSenbastian());

        }
        private void btn46Pasta_Click(object sender, EventArgs e)
        {
            toplamTutarG4 += (comboBox10.SelectedIndex + 1) * db.Pasta46();
            label2.Text = toplamTutarG4.ToString();

            //listbox item kısmı

            string urunAciklamasi = "4 - 6 KİŞİLİK PASTA  X ";
            listBox1.Items.Add(urunAciklamasi + (comboBox10.SelectedIndex + 1));

            //Liste işlemleri
            urunIsımleri.Add(urunAciklamasi + (comboBox1.SelectedIndex + 1));
            urunFiyatlari.Add(db.Pasta46());

        }
        private void btn68Pasta_Click(object sender, EventArgs e)
        {
            toplamTutarG4 += (comboBox11.SelectedIndex + 1) * db.Pasta68();
            label2.Text = toplamTutarG4.ToString();

            //listbox item kısmı

            string urunAciklamasi = "6 - 8 KİŞİLİK PASTA  X ";
            listBox1.Items.Add(urunAciklamasi + (comboBox11.SelectedIndex + 1));

            //Liste işlemleri
            urunIsımleri.Add(urunAciklamasi + (comboBox1.SelectedIndex + 1));
            urunFiyatlari.Add(db.Pasta68());
        }
        private void btnDondurma1Top_Click(object sender, EventArgs e)
        {
            toplamTutarG4 += (comboBox12.SelectedIndex + 1) * db.Dondurma1Top();
            label2.Text = toplamTutarG4.ToString();

            //listbox item kısmı

            string urunAciklamasi = "DONDURMA 1 TOP  X ";
            listBox1.Items.Add(urunAciklamasi + (comboBox12.SelectedIndex + 1));

            //Liste işlemleri
            urunIsımleri.Add(urunAciklamasi + (comboBox1.SelectedIndex + 1));
            urunFiyatlari.Add(db.Dondurma1Top());
        }
        private void btnDondurma1KG_Click(object sender, EventArgs e)
        {
            toplamTutarG4 += (comboBox31.SelectedIndex + 1) * db.Dondurma1Kg();
            label2.Text = toplamTutarG4.ToString();

            //listbox item kısmı

            string urunAciklamasi = "DONDURMA 1 KG  X ";
            listBox1.Items.Add(urunAciklamasi + (comboBox31.SelectedIndex + 1));

            //Liste işlemleri
            urunIsımleri.Add(urunAciklamasi + (comboBox1.SelectedIndex + 1));
            urunFiyatlari.Add(db.Dondurma1Kg());
        }
        private void btnDondurma500gr_Click(object sender, EventArgs e)
        {
            toplamTutarG4 += (comboBox30.SelectedIndex + 1) * db.Dondurma500Gr();
            label2.Text = toplamTutarG4.ToString();

            //listbox item kısmı

            string urunAciklamasi = "DONDURMA 500 GR  X ";
            listBox1.Items.Add(urunAciklamasi + (comboBox30.SelectedIndex + 1));

            //Liste işlemleri
            urunIsımleri.Add(urunAciklamasi + (comboBox1.SelectedIndex + 1));
            urunFiyatlari.Add(db.Dondurma500Gr());
        }
        private void btnTurkKahvesi_Click(object sender, EventArgs e)
        {
            toplamTutarG4 += (comboBox24.SelectedIndex + 1) * db.TurkKahvesi();
            label2.Text = toplamTutarG4.ToString();

            //listbox item kısmı

            string urunAciklamasi = "TÜRK KAHVESİ  X ";
            listBox1.Items.Add(urunAciklamasi + (comboBox24.SelectedIndex + 1));

            //Liste işlemleri
            urunIsımleri.Add(urunAciklamasi + (comboBox1.SelectedIndex + 1));
            urunFiyatlari.Add(db.TurkKahvesi());

        }
        private void btnKahveCesitleri_Click(object sender, EventArgs e)
        {
            toplamTutarG4 += (comboBox23.SelectedIndex + 1) * db.KahveCesitleri();
            label2.Text = toplamTutarG4.ToString();

            //listbox item kısmı

            string urunAciklamasi = "KAHVE ÇEŞİTLERİ  X ";
            listBox1.Items.Add(urunAciklamasi + (comboBox23.SelectedIndex + 1));

            //Liste işlemleri
            urunIsımleri.Add(urunAciklamasi + (comboBox1.SelectedIndex + 1));
            urunFiyatlari.Add(db.KahveCesitleri());
        }
        private void btnSu_Click(object sender, EventArgs e)
        {
            toplamTutarG4 += (comboBox22.SelectedIndex + 1) * db.Su();
            label2.Text = toplamTutarG4.ToString();

            //listbox item kısmı

            string urunAciklamasi = "SU  X ";
            listBox1.Items.Add(urunAciklamasi + (comboBox22.SelectedIndex + 1));

            //Liste işlemleri
            urunIsımleri.Add(urunAciklamasi + (comboBox1.SelectedIndex + 1));
            urunFiyatlari.Add(db.Su());
        }
        private void btnCay_Click(object sender, EventArgs e)
        {
            toplamTutarG4 += (comboBox18.SelectedIndex + 1) * db.Cay();
            label2.Text = toplamTutarG4.ToString();

            //listbox item kısmı

            string urunAciklamasi = "ÇAY  X ";
            listBox1.Items.Add(urunAciklamasi + (comboBox18.SelectedIndex + 1));

            //Liste işlemleri
            urunIsımleri.Add(urunAciklamasi + (comboBox1.SelectedIndex + 1));
            urunFiyatlari.Add(db.Cay());
        }
        private void btnFincanCay_Click(object sender, EventArgs e)
        {
            toplamTutarG4 += (comboBox17.SelectedIndex + 1) * db.FincanCay();
            label2.Text = toplamTutarG4.ToString();

            //listbox item kısmı

            string urunAciklamasi = "FİNCAN ÇAY  X ";
            listBox1.Items.Add(urunAciklamasi + (comboBox17.SelectedIndex + 1));

            //Liste işlemleri
            urunIsımleri.Add(urunAciklamasi + (comboBox1.SelectedIndex + 1));
            urunFiyatlari.Add(db.FincanCay());
        }
        private void btnMadenSuyu_Click(object sender, EventArgs e)
        {
            toplamTutarG4 += (comboBox16.SelectedIndex + 1) * db.MadenSuyu();
            label2.Text = toplamTutarG4.ToString();

            //listbox item kısmı

            string urunAciklamasi = "MADEN SUYU  X ";
            listBox1.Items.Add(urunAciklamasi + (comboBox16.SelectedIndex + 1));

            //Liste işlemleri
            urunIsımleri.Add(urunAciklamasi + (comboBox1.SelectedIndex + 1));
            urunFiyatlari.Add(db.MadenSuyu());
        }
        private void btnKutuSise_Click(object sender, EventArgs e)
        {
            toplamTutarG4 += (comboBox21.SelectedIndex + 1) * db.KutuSiseVeMesrubatCesitleri();
            label2.Text = toplamTutarG4.ToString();

            //listbox item kısmı

            string urunAciklamasi = "KUTU ŞİŞE İÇECEK ÇEŞİTLERİ  X ";
            listBox1.Items.Add(urunAciklamasi + (comboBox21.SelectedIndex + 1));

            //Liste işlemleri
            urunIsımleri.Add(urunAciklamasi + (comboBox1.SelectedIndex + 1));
            urunFiyatlari.Add(db.KutuSiseVeMesrubatCesitleri());

        }
        private void btnCopKovasi_Click(object sender, EventArgs e)
        {

        }
    }
}
