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
    public partial class frmMasa4 : Form
    {
        public List<string> urunIsımleri = new List<string>();
        public List<double> urunFiyatlari = new List<double>();
        double nakitOdemeToplamı = 0;
        double kartOdemeToplamı = 0;
        double toplamTutarM4 = 0;

        Database db = new Database();


        public frmMasa4()
        {
            InitializeComponent();
        }

        private void frmMasa4_Load(object sender, EventArgs e)
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
            toplamTutarM4 = 0;
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
                frmMasa1.anasayfa.hesabiGosterM4(toplamTutarM4);

                frmMasa1.anasayfa.btnMasa4.BackColor = Color.Maroon;
            }

            else
            {
                frmMasa1.anasayfa.lblTutarM4.Visible = false;

                frmMasa1.anasayfa.btnMasa4.BackColor = Color.Green;
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
                nakitOdemeToplamı = toplamTutarM4;
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
                kartOdemeToplamı = toplamTutarM4;
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

            toplamTutarM4 += (comboBox1.SelectedIndex + 1) * db.Profiterol1kg();
            label2.Text = toplamTutarM4.ToString();

            //listbox item kısmı

            string urunAciklamasi = "1 KİLO PROFİTEROL  X ";
            listBox1.Items.Add(urunAciklamasi + (comboBox1.SelectedIndex + 1));

            //Liste işlemleri
            urunIsımleri.Add(urunAciklamasi + (comboBox1.SelectedIndex + 1));
            urunFiyatlari.Add(db.Profiterol1kg());


        }
        private void btnProf750gr_Click(object sender, EventArgs e)
        {
            toplamTutarM4 += (comboBox3.SelectedIndex + 1) * db.Profiterol750gr();
            label2.Text = toplamTutarM4.ToString();

            //listbox item kısmı

            string urunAciklamasi = "750 GR PROFİTEROL  X ";
            listBox1.Items.Add(urunAciklamasi + (comboBox3.SelectedIndex + 1));

            //Liste işlemleri
            urunIsımleri.Add(urunAciklamasi + (comboBox1.SelectedIndex + 1));
            urunFiyatlari.Add(db.Profiterol750gr());
        }
        private void btnProf500gr_Click(object sender, EventArgs e)
        {
            toplamTutarM4 += (comboBox2.SelectedIndex + 1) * db.Profiterol500gr();
            label2.Text = toplamTutarM4.ToString();

            //listbox item kısmı

            string urunAciklamasi = "YARIM KİLO PROFİTEROL  X ";
            listBox1.Items.Add(urunAciklamasi + (comboBox2.SelectedIndex + 1));

            //Liste işlemleri
            urunIsımleri.Add(urunAciklamasi + (comboBox1.SelectedIndex + 1));
            urunFiyatlari.Add(db.Profiterol500gr());

        }
        private void btnProfPrsyn(object sender, EventArgs e)
        {
            toplamTutarM4 += (comboBox4.SelectedIndex + 1) * db.ProfiterolPorsiyon();
            label2.Text = toplamTutarM4.ToString();

            //listbox item kısmı

            string urunAciklamasi = "1 PORSİYON PROFİTEROL  X ";
            listBox1.Items.Add(urunAciklamasi + (comboBox4.SelectedIndex + 1));

            //Liste işlemleri
            urunIsımleri.Add(urunAciklamasi + (comboBox1.SelectedIndex + 1));
            urunFiyatlari.Add(db.ProfiterolPorsiyon());
        }
        private void btnEkler1KG_Click(object sender, EventArgs e)
        {
            toplamTutarM4 += (comboBox5.SelectedIndex + 1) * db.Ekler1KG();
            label2.Text = toplamTutarM4.ToString();

            //listbox item kısmı

            string urunAciklamasi = "1 KİLO EKLER  X ";
            listBox1.Items.Add(urunAciklamasi + (comboBox5.SelectedIndex + 1));

            //Liste işlemleri
            urunIsımleri.Add(urunAciklamasi + (comboBox1.SelectedIndex + 1));
            urunFiyatlari.Add(db.Ekler1KG());
        }
        private void btnEkler750GR_Click(object sender, EventArgs e)
        {
            toplamTutarM4 += (comboBox6.SelectedIndex + 1) * db.Ekler750gr();
            label2.Text = toplamTutarM4.ToString();

            //listbox item kısmı

            string urunAciklamasi = "750 GR EKLER  X ";
            listBox1.Items.Add(urunAciklamasi + (comboBox6.SelectedIndex + 1));

            //Liste işlemleri
            urunIsımleri.Add(urunAciklamasi + (comboBox1.SelectedIndex + 1));
            urunFiyatlari.Add(db.Ekler750gr());
        }
        private void btnEklerPrsyn_Click(object sender, EventArgs e)
        {
            toplamTutarM4 += (comboBox8.SelectedIndex + 1) * db.EklerPorsiyon();
            label2.Text = toplamTutarM4.ToString();

            //listbox item kısmı

            string urunAciklamasi = "1 PORSİYON EKLER  X ";
            listBox1.Items.Add(urunAciklamasi + (comboBox8.SelectedIndex + 1));

            //Liste işlemleri
            urunIsımleri.Add(urunAciklamasi + (comboBox1.SelectedIndex + 1));
            urunFiyatlari.Add(db.EklerPorsiyon());
        }
        private void btnEkler500GR_Click(object sender, EventArgs e)
        {
            toplamTutarM4 += (comboBox7.SelectedIndex + 1) * db.Ekler500gr();
            label2.Text = toplamTutarM4.ToString();

            //listbox item kısmı

            string urunAciklamasi = "500 GR EKLER  X ";
            listBox1.Items.Add(urunAciklamasi + (comboBox7.SelectedIndex + 1));

            //Liste işlemleri
            urunIsımleri.Add(urunAciklamasi + (comboBox1.SelectedIndex + 1));
            urunFiyatlari.Add(db.Ekler500gr());
        }
        private void btnTekKisilikPasta_Click(object sender, EventArgs e)
        {
            toplamTutarM4 += (comboBox9.SelectedIndex + 1) * db.TekKisilikPasta();
            label2.Text = toplamTutarM4.ToString();

            //listbox item kısmı

            string urunAciklamasi = "TEK KİŞİLİK DİLİM PASTA  X ";
            listBox1.Items.Add(urunAciklamasi + (comboBox9.SelectedIndex + 1));

            //Liste işlemleri
            urunIsımleri.Add(urunAciklamasi + (comboBox1.SelectedIndex + 1));
            urunFiyatlari.Add(db.TekKisilikPasta());

        }
        private void brnTrilice_Click(object sender, EventArgs e)
        {
            toplamTutarM4 += (comboBox32.SelectedIndex + 1) * db.Trilice();
            label2.Text = toplamTutarM4.ToString();

            //listbox item kısmı

            string urunAciklamasi = "TRİLİÇE  X ";
            listBox1.Items.Add(urunAciklamasi + (comboBox32.SelectedIndex + 1));

            //Liste işlemleri
            urunIsımleri.Add(urunAciklamasi + (comboBox1.SelectedIndex + 1));
            urunFiyatlari.Add(db.Trilice());

        }
        private void btnTiramisu_Click(object sender, EventArgs e)
        {
            toplamTutarM4 += (comboBox29.SelectedIndex + 1) * db.Tiramisu();
            label2.Text = toplamTutarM4.ToString();

            //listbox item kısmı

            string urunAciklamasi = "TİRAMİSU  X ";
            listBox1.Items.Add(urunAciklamasi + (comboBox29.SelectedIndex + 1));

            //Liste işlemleri
            urunIsımleri.Add(urunAciklamasi + (comboBox1.SelectedIndex + 1));
            urunFiyatlari.Add(db.Tiramisu());

        }
        private void btnMagnolia_Click(object sender, EventArgs e)
        {
            toplamTutarM4 += (comboBox28.SelectedIndex + 1) * db.Magnolia();
            label2.Text = toplamTutarM4.ToString();

            //listbox item kısmı

            string urunAciklamasi = "MAGNOLİA  X ";
            listBox1.Items.Add(urunAciklamasi + (comboBox28.SelectedIndex + 1));

            //Liste işlemleri
            urunIsımleri.Add(urunAciklamasi + (comboBox1.SelectedIndex + 1));
            urunFiyatlari.Add(db.Magnolia());


        }
        private void btnDonut_Click(object sender, EventArgs e)
        {
            toplamTutarM4 += (comboBox27.SelectedIndex + 1) * db.Donut();
            label2.Text = toplamTutarM4.ToString();

            //listbox item kısmı

            string urunAciklamasi = "DONUT  X ";
            listBox1.Items.Add(urunAciklamasi + (comboBox27.SelectedIndex + 1));

            //Liste işlemleri
            urunIsımleri.Add(urunAciklamasi + (comboBox1.SelectedIndex + 1));
            urunFiyatlari.Add(db.Donut());

        }
        private void btnMakaron_Click(object sender, EventArgs e)
        {
            toplamTutarM4 += (comboBox26.SelectedIndex + 1) * db.Makaron();
            label2.Text = toplamTutarM4.ToString();

            //listbox item kısmı

            string urunAciklamasi = "MAKARON  X ";
            listBox1.Items.Add(urunAciklamasi + (comboBox26.SelectedIndex + 1));

            //Liste işlemleri
            urunIsımleri.Add(urunAciklamasi + (comboBox1.SelectedIndex + 1));
            urunFiyatlari.Add(db.Makaron());
        }
        private void btnSanSebastian_Click(object sender, EventArgs e)
        {
            toplamTutarM4 += (comboBox25.SelectedIndex + 1) * db.SanSenbastian();
            label2.Text = toplamTutarM4.ToString();

            //listbox item kısmı

            string urunAciklamasi = "SANSEBASTİAN  X ";
            listBox1.Items.Add(urunAciklamasi + (comboBox25.SelectedIndex + 1));

            //Liste işlemleri
            urunIsımleri.Add(urunAciklamasi + (comboBox1.SelectedIndex + 1));
            urunFiyatlari.Add(db.SanSenbastian());

        }
        private void btn46Pasta_Click(object sender, EventArgs e)
        {
            toplamTutarM4 += (comboBox10.SelectedIndex + 1) * db.Pasta46();
            label2.Text = toplamTutarM4.ToString();

            //listbox item kısmı

            string urunAciklamasi = "4 - 6 KİŞİLİK PASTA  X ";
            listBox1.Items.Add(urunAciklamasi + (comboBox10.SelectedIndex + 1));

            //Liste işlemleri
            urunIsımleri.Add(urunAciklamasi + (comboBox1.SelectedIndex + 1));
            urunFiyatlari.Add(db.Pasta46());

        }
        private void btn68Pasta_Click(object sender, EventArgs e)
        {
            toplamTutarM4 += (comboBox11.SelectedIndex + 1) * db.Pasta68();
            label2.Text = toplamTutarM4.ToString();

            //listbox item kısmı

            string urunAciklamasi = "6 - 8 KİŞİLİK PASTA  X ";
            listBox1.Items.Add(urunAciklamasi + (comboBox11.SelectedIndex + 1));

            //Liste işlemleri
            urunIsımleri.Add(urunAciklamasi + (comboBox1.SelectedIndex + 1));
            urunFiyatlari.Add(db.Pasta68());
        }
        private void btnDondurma1Top_Click(object sender, EventArgs e)
        {
            toplamTutarM4 += (comboBox12.SelectedIndex + 1) * db.Dondurma1Top();
            label2.Text = toplamTutarM4.ToString();

            //listbox item kısmı

            string urunAciklamasi = "DONDURMA 1 TOP  X ";
            listBox1.Items.Add(urunAciklamasi + (comboBox12.SelectedIndex + 1));

            //Liste işlemleri
            urunIsımleri.Add(urunAciklamasi + (comboBox1.SelectedIndex + 1));
            urunFiyatlari.Add(db.Dondurma1Top());
        }
        private void btnDondurma1KG_Click(object sender, EventArgs e)
        {
            toplamTutarM4 += (comboBox31.SelectedIndex + 1) * db.Dondurma1Kg();
            label2.Text = toplamTutarM4.ToString();

            //listbox item kısmı

            string urunAciklamasi = "DONDURMA 1 KG  X ";
            listBox1.Items.Add(urunAciklamasi + (comboBox31.SelectedIndex + 1));

            //Liste işlemleri
            urunIsımleri.Add(urunAciklamasi + (comboBox1.SelectedIndex + 1));
            urunFiyatlari.Add(db.Dondurma1Kg());
        }
        private void btnDondurma500gr_Click(object sender, EventArgs e)
        {
            toplamTutarM4 += (comboBox30.SelectedIndex + 1) * db.Dondurma500Gr();
            label2.Text = toplamTutarM4.ToString();

            //listbox item kısmı

            string urunAciklamasi = "DONDURMA 500 GR  X ";
            listBox1.Items.Add(urunAciklamasi + (comboBox30.SelectedIndex + 1));

            //Liste işlemleri
            urunIsımleri.Add(urunAciklamasi + (comboBox1.SelectedIndex + 1));
            urunFiyatlari.Add(db.Dondurma500Gr());
        }
        private void btnTurkKahvesi_Click(object sender, EventArgs e)
        {
            toplamTutarM4 += (comboBox24.SelectedIndex + 1) * db.TurkKahvesi();
            label2.Text = toplamTutarM4.ToString();

            //listbox item kısmı

            string urunAciklamasi = "TÜRK KAHVESİ  X ";
            listBox1.Items.Add(urunAciklamasi + (comboBox24.SelectedIndex + 1));

            //Liste işlemleri
            urunIsımleri.Add(urunAciklamasi + (comboBox1.SelectedIndex + 1));
            urunFiyatlari.Add(db.TurkKahvesi());

        }
        private void btnKahveCesitleri_Click(object sender, EventArgs e)
        {
            toplamTutarM4 += (comboBox23.SelectedIndex + 1) * db.KahveCesitleri();
            label2.Text = toplamTutarM4.ToString();

            //listbox item kısmı

            string urunAciklamasi = "KAHVE ÇEŞİTLERİ  X ";
            listBox1.Items.Add(urunAciklamasi + (comboBox23.SelectedIndex + 1));

            //Liste işlemleri
            urunIsımleri.Add(urunAciklamasi + (comboBox1.SelectedIndex + 1));
            urunFiyatlari.Add(db.KahveCesitleri());
        }
        private void btnSu_Click(object sender, EventArgs e)
        {
            toplamTutarM4 += (comboBox22.SelectedIndex + 1) * db.Su();
            label2.Text = toplamTutarM4.ToString();

            //listbox item kısmı

            string urunAciklamasi = "SU  X ";
            listBox1.Items.Add(urunAciklamasi + (comboBox22.SelectedIndex + 1));

            //Liste işlemleri
            urunIsımleri.Add(urunAciklamasi + (comboBox1.SelectedIndex + 1));
            urunFiyatlari.Add(db.Su());
        }
        private void btnCay_Click(object sender, EventArgs e)
        {
            toplamTutarM4 += (comboBox18.SelectedIndex + 1) * db.Cay();
            label2.Text = toplamTutarM4.ToString();

            //listbox item kısmı

            string urunAciklamasi = "ÇAY  X ";
            listBox1.Items.Add(urunAciklamasi + (comboBox18.SelectedIndex + 1));

            //Liste işlemleri
            urunIsımleri.Add(urunAciklamasi + (comboBox1.SelectedIndex + 1));
            urunFiyatlari.Add(db.Cay());
        }
        private void btnFincanCay_Click(object sender, EventArgs e)
        {
            toplamTutarM4 += (comboBox17.SelectedIndex + 1) * db.FincanCay();
            label2.Text = toplamTutarM4.ToString();

            //listbox item kısmı

            string urunAciklamasi = "FİNCAN ÇAY  X ";
            listBox1.Items.Add(urunAciklamasi + (comboBox17.SelectedIndex + 1));

            //Liste işlemleri
            urunIsımleri.Add(urunAciklamasi + (comboBox1.SelectedIndex + 1));
            urunFiyatlari.Add(db.FincanCay());
        }
        private void btnMadenSuyu_Click(object sender, EventArgs e)
        {
            toplamTutarM4 += (comboBox16.SelectedIndex + 1) * db.MadenSuyu();
            label2.Text = toplamTutarM4.ToString();

            //listbox item kısmı

            string urunAciklamasi = "MADEN SUYU  X ";
            listBox1.Items.Add(urunAciklamasi + (comboBox16.SelectedIndex + 1));

            //Liste işlemleri
            urunIsımleri.Add(urunAciklamasi + (comboBox1.SelectedIndex + 1));
            urunFiyatlari.Add(db.MadenSuyu());
        }
        private void btnKutuSise_Click(object sender, EventArgs e)
        {
            toplamTutarM4 += (comboBox21.SelectedIndex + 1) * db.KutuSiseVeMesrubatCesitleri();
            label2.Text = toplamTutarM4.ToString();

            //listbox item kısmı

            string urunAciklamasi = "KUTU ŞİŞE İÇECEK ÇEŞİTLERİ  X ";
            listBox1.Items.Add(urunAciklamasi + (comboBox21.SelectedIndex + 1));

            //Liste işlemleri
            urunIsımleri.Add(urunAciklamasi + (comboBox1.SelectedIndex + 1));
            urunFiyatlari.Add(db.KutuSiseVeMesrubatCesitleri());

        }



        private void btnCopKovasi_Click(object sender, EventArgs e)
        {

            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("LÜTFEN SİPARİŞ EKLEYİNİZ !", "EKSİK SİPARİŞ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            else if (listBox1.SelectedItem.ToString() == "1 KİLO PROFİTEROL  X 1")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= db.Profiterol1kg();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "1 KİLO PROFİTEROL  X 2")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 2 * db.Profiterol1kg();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "1 KİLO PROFİTEROL  X 3")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 3 * db.Profiterol1kg();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "1 KİLO PROFİTEROL  X 4")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 4 * db.Profiterol1kg();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "1 KİLO PROFİTEROL  X 5")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 5 * db.Profiterol1kg();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "1 KİLO PROFİTEROL  X 6")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 6 * db.Profiterol1kg();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "1 KİLO PROFİTEROL  X 7")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 7 * db.Profiterol1kg();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "1 KİLO PROFİTEROL  X 8")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 8 * db.Profiterol1kg();
                label2.Text = toplamTutarM4.ToString();

            }
            else if (listBox1.SelectedItem.ToString() == "YARIM KİLO PROFİTEROL  X 1")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 1 * db.Profiterol500gr();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "YARIM KİLO PROFİTEROL  X 2")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 2 * db.Profiterol500gr();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "YARIM KİLO PROFİTEROL  X 3")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 3 * db.Profiterol500gr();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "YARIM KİLO PROFİTEROL  X 4")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 4 * db.Profiterol500gr();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "YARIM KİLO PROFİTEROL  X 5")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 5 * db.Profiterol500gr();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "YARIM KİLO PROFİTEROL  X 6")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 6 * db.Profiterol500gr();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "YARIM KİLO PROFİTEROL  X 7")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 7 * db.Profiterol500gr();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "YARIM KİLO PROFİTEROL  X 8")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 8 * db.Profiterol500gr();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "1 PORSİYON PROFİTEROL  X 1")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 1 * db.ProfiterolPorsiyon();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "1 PORSİYON PROFİTEROL  X 2")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 2 * db.ProfiterolPorsiyon();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "1 PORSİYON PROFİTEROL  X 3")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 3 * db.ProfiterolPorsiyon();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "1 PORSİYON PROFİTEROL  X 4")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 4 * db.ProfiterolPorsiyon();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "1 PORSİYON PROFİTEROL  X 5")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 5 * db.ProfiterolPorsiyon();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "1 PORSİYON PROFİTEROL  X 6")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 6 * db.ProfiterolPorsiyon();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "1 PORSİYON PROFİTEROL  X 7")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 7 * db.ProfiterolPorsiyon();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "1 PORSİYON PROFİTEROL  X 8")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 8 * db.ProfiterolPorsiyon();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "1 KİLO EKLER  X 1")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 1 * db.Ekler1KG();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "1 KİLO EKLER  X 2")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 2 * db.Ekler1KG();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "1 KİLO EKLER  X 3")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 3 * db.Ekler1KG();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "1 KİLO EKLER  X 4")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 4 * db.Ekler1KG();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "1 KİLO EKLER  X 5")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 5 * db.Ekler1KG();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "1 KİLO EKLER  X 6")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 6 * db.Ekler1KG();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "1 KİLO EKLER  X 7")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 7 * db.Ekler1KG();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "1 KİLO EKLER  X 8")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 8 * db.Ekler1KG();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "750 GR EKLER  X 1")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 1 * db.Ekler750gr();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "750 GR EKLER  X 2")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 2 * db.Ekler750gr();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "750 GR EKLER  X 3")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 3 * db.Ekler750gr();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "750 GR EKLER  X 4")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 4 * db.Ekler750gr();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "750 GR EKLER  X 5")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 5 * db.Ekler750gr();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "750 GR EKLER  X 6")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 6 * db.Ekler750gr();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "750 GR EKLER  X 7")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 7 * db.Ekler750gr();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "750 GR EKLER  X 8")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 8 * db.Ekler750gr();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "750 GR PROFİTEROL  X 1")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 1 * db.Profiterol750gr();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "750 GR PROFİTEROL  X 2")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 2 * db.Profiterol750gr();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "750 GR PROFİTEROL  X 3")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 3 * db.Profiterol750gr();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "750 GR PROFİTEROL  X 4")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 4 * db.Profiterol750gr();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "750 GR PROFİTEROL  X 5")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 5 * db.Profiterol750gr();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "750 GR PROFİTEROL  X 6")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 6 * db.Profiterol750gr();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "750 GR PROFİTEROL  X 7")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 7 * db.Profiterol750gr();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "750 GR PROFİTEROL  X 8")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 8 * db.Profiterol750gr();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "500 GR EKLER  X 1")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 1 * db.Ekler500gr();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "500 GR EKLER  X 2")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 2 * db.Ekler500gr();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "500 GR EKLER  X 3")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 3 * db.Ekler500gr();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "500 GR EKLER  X 4")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 4 * db.Ekler500gr();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "500 GR EKLER  X 5")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 5 * db.Ekler500gr();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "500 GR EKLER  X 6")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 6 * db.Ekler500gr();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "500 GR EKLER  X 7")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 7 * db.Ekler500gr();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "500 GR EKLER  X 8")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 8 * db.Ekler500gr();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "1 PORSİYON EKLER  X 1")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 1 * db.EklerPorsiyon();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "1 PORSİYON EKLER  X 2")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 2 * db.EklerPorsiyon();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "1 PORSİYON EKLER  X 3")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 3 * db.EklerPorsiyon();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "1 PORSİYON EKLER  X 4")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 4 * db.EklerPorsiyon();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "1 PORSİYON EKLER  X 5")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 5 * db.EklerPorsiyon();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "1 PORSİYON EKLER  X 6")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 6 * db.EklerPorsiyon();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "1 PORSİYON EKLER  X 7")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 7 * db.EklerPorsiyon();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "1 PORSİYON EKLER  X 8")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 8 * db.EklerPorsiyon();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "TEK KİŞİLİK DİLİM PASTA  X 1")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 1 * db.TekKisilikPasta();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "TEK KİŞİLİK DİLİM PASTA  X 2")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 2 * db.TekKisilikPasta();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "TEK KİŞİLİK DİLİM PASTA  X 3")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 3 * db.TekKisilikPasta();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "TEK KİŞİLİK DİLİM PASTA  X 4")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 4 * db.TekKisilikPasta();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "TEK KİŞİLİK DİLİM PASTA  X 5")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 5 * db.TekKisilikPasta();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "TEK KİŞİLİK DİLİM PASTA  X 6")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 6 * db.TekKisilikPasta();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "TEK KİŞİLİK DİLİM PASTA  X 7")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 7 * db.TekKisilikPasta();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "TEK KİŞİLİK DİLİM PASTA  X 8")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 8 * db.TekKisilikPasta();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "TRİLİÇE  X 1")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 1 * db.Trilice();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "TRİLİÇE  X 2")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 2 * db.Trilice();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "TRİLİÇE  X 3")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 3 * db.Trilice();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "TRİLİÇE  X 4")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 4 * db.Trilice();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "TRİLİÇE  X 5")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 5 * db.Trilice();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "TRİLİÇE  X 6")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 6 * db.Trilice();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "TRİLİÇE  X 7")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 7 * db.Trilice();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "TRİLİÇE  X 8")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 8 * db.Trilice();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "TİRAMİSU  X 1")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 1 * db.Tiramisu();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "TİRAMİSU  X 2")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 2 * db.Tiramisu();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "TİRAMİSU  X 3")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 3 * db.Tiramisu();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "TİRAMİSU  X 4")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 4 * db.Tiramisu();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "TİRAMİSU  X 5")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 5 * db.Tiramisu();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "TİRAMİSU  X 6")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 6 * db.Tiramisu();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "TİRAMİSU  X 7")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 7 * db.Tiramisu();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "TİRAMİSU  X 8")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 8 * db.Tiramisu();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "MAGNOLİA  X 1")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 1 * db.Magnolia();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "MAGNOLİA  X 2")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 2 * db.Magnolia();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "MAGNOLİA  X 3")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 3 * db.Magnolia();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "MAGNOLİA  X 4")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 4 * db.Magnolia();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "MAGNOLİA  X 5")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 5 * db.Magnolia();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "MAGNOLİA  X 6")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 6 * db.Magnolia();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "MAGNOLİA  X 7")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 7 * db.Magnolia();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "MAGNOLİA  X 8")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 8 * db.Magnolia();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "DONUT  X 1")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 1 * db.Donut();
                label2.Text = toplamTutarM4.ToString();
            }

            else if (listBox1.SelectedItem.ToString() == "DONUT  X 2")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 2 * db.Donut();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "DONUT  X 3")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 3 * db.Donut();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "DONUT  X 4")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 4 * db.Donut();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "DONUT  X 5")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 5 * db.Donut();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "DONUT  X 6")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 6 * db.Donut();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "DONUT  X 7")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 7 * db.Donut();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "DONUT  X 8")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 8 * db.Donut();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "MAKARON  X 1")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 1 * db.Makaron();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "MAKARON  X 2")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 2 * db.Makaron();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "MAKARON  X 3")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 3 * db.Makaron();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "MAKARON  X 4")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 4 * db.Makaron();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "MAKARON  X 5")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 5 * db.Makaron();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "MAKARON  X 6")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 6 * db.Makaron();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "MAKARON  X 7")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 7 * db.Makaron();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "MAKARON  X 8")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 8 * db.Makaron();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "SANSEBASTİAN  X 1")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 1 * db.SanSenbastian();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "SANSEBASTİAN  X 2")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 2 * db.SanSenbastian();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "SANSEBASTİAN  X 3")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 3 * db.SanSenbastian();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "SANSEBASTİAN  X 4")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 4 * db.SanSenbastian();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "SANSEBASTİAN  X 5")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 5 * db.SanSenbastian();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "SANSEBASTİAN  X 6")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 6 * db.SanSenbastian();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "SANSEBASTİAN  X 7")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 7 * db.SanSenbastian();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "SANSEBASTİAN  X 8")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 8 * db.SanSenbastian();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "4 - 6 KİŞİLİK PASTA  X 1")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 1 * db.Pasta46();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "4 - 6 KİŞİLİK PASTA  X 2")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 2 * db.Pasta46();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "4 - 6 KİŞİLİK PASTA  X 3")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 3 * db.Pasta46();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "4 - 6 KİŞİLİK PASTA  X 4")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 4 * db.Pasta46();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "4 - 6 KİŞİLİK PASTA  X 5")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 5 * db.Pasta46();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "4 - 6 KİŞİLİK PASTA  X 6")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 6 * db.Pasta46();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "4 - 6 KİŞİLİK PASTA  X 7")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 7 * db.Pasta46();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "4 - 6 KİŞİLİK PASTA  X 8")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 8 * db.Pasta46();
                label2.Text = toplamTutarM4.ToString();
            }

            else if (listBox1.SelectedItem.ToString() == "6 - 8 KİŞİLİK PASTA  X 1")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 1 * db.Pasta68();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "6 - 8 KİŞİLİK PASTA  X 2")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 2 * db.Pasta68();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "6 - 8 KİŞİLİK PASTA  X 3")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 3 * db.Pasta68();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "6 - 8 KİŞİLİK PASTA  X 4")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 4 * db.Pasta68();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "6 - 8 KİŞİLİK PASTA  X 5")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 5 * db.Pasta68();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "6 - 8 KİŞİLİK PASTA  X 6")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 6 * db.Pasta68();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "6 - 8 KİŞİLİK PASTA  X 7")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 7 * db.Pasta68();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "6 - 8 KİŞİLİK PASTA  X 8")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 8 * db.Pasta68();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "DONDURMA 1 TOP  X 1")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 1 * db.Dondurma1Top();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "DONDURMA 1 TOP  X 2")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 2 * db.Dondurma1Top();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "DONDURMA 1 TOP  X 3")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 3 * db.Dondurma1Top();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "DONDURMA 1 TOP  X 4")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 4 * db.Dondurma1Top();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "DONDURMA 1 TOP  X 5")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 5 * db.Dondurma1Top();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "DONDURMA 1 TOP  X 6")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 6 * db.Dondurma1Top();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "DONDURMA 1 TOP  X 7")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 7 * db.Dondurma1Top();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "DONDURMA 1 TOP  X 8")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 8 * db.Dondurma1Top();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "DONDURMA 1 KG  X 1")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 1 * db.Dondurma1Kg();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "DONDURMA 1 KG  X 2")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 2 * db.Dondurma1Kg();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "DONDURMA 1 KG  X 3")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 3 * db.Dondurma1Kg();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "DONDURMA 1 KG  X 4")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 4 * db.Dondurma1Kg();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "DONDURMA 1 KG  X 5")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 5 * db.Dondurma1Kg();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "DONDURMA 1 KG  X 6")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 6 * db.Dondurma1Kg();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "DONDURMA 1 KG  X 7")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 7 * db.Dondurma1Kg();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "DONDURMA 1 KG  X 8")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 8 * db.Dondurma1Kg();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "DONDURMA 500 GR  X 1")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 1 * db.Dondurma500Gr();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "DONDURMA 500 GR  X 2")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 2 * db.Dondurma500Gr();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "DONDURMA 500 GR  X 3")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 3 * db.Dondurma500Gr();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "DONDURMA 500 GR  X 4")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 4 * db.Dondurma500Gr();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "DONDURMA 500 GR  X 5")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 5 * db.Dondurma500Gr();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "DONDURMA 500 GR  X 6")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 6 * db.Dondurma500Gr();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "DONDURMA 500 GR  X 7")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 7 * db.Dondurma500Gr();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "DONDURMA 500 GR  X 8")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 8 * db.Dondurma500Gr();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "TÜRK KAHVESİ  X 1")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 1 * db.TurkKahvesi();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "TÜRK KAHVESİ  X 2")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 2 * db.TurkKahvesi();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "TÜRK KAHVESİ  X 3")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 3 * db.TurkKahvesi();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "TÜRK KAHVESİ  X 4")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 4 * db.TurkKahvesi();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "TÜRK KAHVESİ  X 5")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 5 * db.TurkKahvesi();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "TÜRK KAHVESİ  X 6")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 6 * db.TurkKahvesi();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "TÜRK KAHVESİ  X 7")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 7 * db.TurkKahvesi();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "TÜRK KAHVESİ  X 8")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 8 * db.TurkKahvesi();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "KAHVE ÇEŞİTLERİ  X 1")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 1 * db.KahveCesitleri();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "KAHVE ÇEŞİTLERİ  X 2")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 2 * db.KahveCesitleri();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "KAHVE ÇEŞİTLERİ  X 3")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 3 * db.KahveCesitleri();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "KAHVE ÇEŞİTLERİ  X 4")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 4 * db.KahveCesitleri();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "KAHVE ÇEŞİTLERİ  X 5")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 5 * db.KahveCesitleri();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "KAHVE ÇEŞİTLERİ  X 6")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 6 * db.KahveCesitleri();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "KAHVE ÇEŞİTLERİ  X 7")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 7 * db.KahveCesitleri();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "KAHVE ÇEŞİTLERİ  X 8")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 8 * db.KahveCesitleri();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "SU  X 1")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 1 * db.Su();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "SU  X 2")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 2 * db.Su();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "SU  X 3")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 3 * db.Su();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "SU  X 4")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 4 * db.Su();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "SU  X 5")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 5 * db.Su();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "SU  X 6")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 6 * db.Su();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "SU  X 7")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 7 * db.Su();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "SU  X 8")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 8 * db.Su();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "ÇAY  X 1")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 1 * db.Cay();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "ÇAY  X 2")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 2 * db.Cay();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "ÇAY  X 3")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 3 * db.Cay();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "ÇAY  X 4")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 4 * db.Cay();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "ÇAY  X 5")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 5 * db.Cay();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "ÇAY  X 6")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 6 * db.Cay();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "ÇAY  X 7")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 7 * db.Cay();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "ÇAY  X 8")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 8 * db.Cay();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "FİNCAN ÇAY  X 1")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 1 * db.FincanCay();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "FİNCAN ÇAY  X 2")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 2 * db.FincanCay();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "FİNCAN ÇAY  X 3")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 3 * db.FincanCay();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "FİNCAN ÇAY  X 4")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 4 * db.FincanCay();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "FİNCAN ÇAY  X 5")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 5 * db.FincanCay();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "FİNCAN ÇAY  X 6")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 6 * db.FincanCay();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "FİNCAN ÇAY  X 7")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 7 * db.FincanCay();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "FİNCAN ÇAY  X 8")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 8 * db.FincanCay();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "MADEN SUYU  X 1")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 1 * db.MadenSuyu();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "MADEN SUYU  X 2")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 2 * db.MadenSuyu();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "MADEN SUYU  X 3")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 3 * db.MadenSuyu();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "MADEN SUYU  X 4")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 4 * db.MadenSuyu();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "MADEN SUYU  X 5")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 5 * db.MadenSuyu();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "MADEN SUYU  X 6")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 6 * db.MadenSuyu();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "MADEN SUYU  X 7")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 7 * db.MadenSuyu();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "MADEN SUYU  X 8")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 8 * db.MadenSuyu();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "KUTU ŞİŞE İÇECEK ÇEŞİTLERİ  X 1")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 1 * db.KutuSiseVeMesrubatCesitleri();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "KUTU ŞİŞE İÇECEK ÇEŞİTLERİ  X 2")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 2 * db.KutuSiseVeMesrubatCesitleri();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "KUTU ŞİŞE İÇECEK ÇEŞİTLERİ  X 3")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 3 * db.KutuSiseVeMesrubatCesitleri();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "KUTU ŞİŞE İÇECEK ÇEŞİTLERİ  X 4")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 4 * db.KutuSiseVeMesrubatCesitleri();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "KUTU ŞİŞE İÇECEK ÇEŞİTLERİ  X 5")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 5 * db.KutuSiseVeMesrubatCesitleri();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "KUTU ŞİŞE İÇECEK ÇEŞİTLERİ  X 6")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 6 * db.KutuSiseVeMesrubatCesitleri();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "KUTU ŞİŞE İÇECEK ÇEŞİTLERİ  X 7")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 7 * db.KutuSiseVeMesrubatCesitleri();
                label2.Text = toplamTutarM4.ToString();
            }
            else if (listBox1.SelectedItem.ToString() == "KUTU ŞİŞE İÇECEK ÇEŞİTLERİ  X 8")
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                toplamTutarM4 -= 8 * db.KutuSiseVeMesrubatCesitleri();
                label2.Text = toplamTutarM4.ToString();
            }


































        }


    }















}

