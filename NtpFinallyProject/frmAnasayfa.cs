using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace NtpFinallyProject
{
    public partial class frmAnasayfa : Form
    {
        public List<double> gunSonu = new List<double>();
        public List<double> gunSonuKredi = new List<double>();
        public List<double> gunSonuNakit = new List<double>();

        frmGunSonuVerileri frmGunSonuVerileri = new frmGunSonuVerileri();

        frmMasa1 fm1 = new frmMasa1();
        frmMasa2 fm2 = new frmMasa2();
        frmMasa3 fm3 = new frmMasa3();
        frmMasa4 fm4 = new frmMasa4();
        frmMasa5 fm5 = new frmMasa5();
        frmMasa6 fm6 = new frmMasa6();
        frmMasa7 fm7 = new frmMasa7();
        frmMasa8 fm8 = new frmMasa8();


        frmGelAl1 gelal1 = new frmGelAl1();
        frmGelAl2 gelal2 = new frmGelAl2();
        frmGelAl3 gelal3 = new frmGelAl3();
        frmGelAl4 gelal4 = new frmGelAl4();

        double gunSonuTutari = 0;
        double gunSonuNakitTutarı = 0;
        double gunSonuKrediTutarı = 0;

       
        public void hesabiGosterM1(double toplamTutar)
        {
            this.lblTutarM1.Visible = true;
            this.lblTutarM1.Text = "HESAP = " + toplamTutar.ToString() + " TL";

        }
        public void hesabiGosterM2(double toplamTutar)
        {
            this.lblTutarM2.Visible = true;
            this.lblTutarM2.Text = "HESAP = " + toplamTutar.ToString() + " TL";

        }
        public void hesabiGosterM3(double toplamTutar)
        {
            this.lblTutarM3.Visible = true;
            this.lblTutarM3.Text = "HESAP = " + toplamTutar.ToString() + " TL";

        }
        public void hesabiGosterM4(double toplamTutar)
        {
            this.lblTutarM4.Visible = true;
            this.lblTutarM4.Text = "HESAP = " + toplamTutar.ToString() + " TL";

        }
        public void hesabiGosterM5(double toplamTutar)
        {
            this.lblTutarM5.Visible = true;
            this.lblTutarM5.Text = "HESAP = " + toplamTutar.ToString() + " TL";

        }
        public void hesabiGosterM6(double toplamTutar)
        {
            this.lblTutarM6.Visible = true;
            this.lblTutarM6.Text = "HESAP = " + toplamTutar.ToString() + " TL";

           

        }
        public void hesabiGosterM7(double toplamTutar)
        {
            this.lblTutarM7.Visible = true;
            this.lblTutarM7.Text = "HESAP = " + toplamTutar.ToString() + " TL";

        }
        public void hesabiGosterM8(double toplamTutar)
        {
            this.lblTutarM8.Visible = true;
            this.lblTutarM8.Text = "HESAP = " + toplamTutar.ToString() + " TL";

        }
        public void hesabiGosterG1(double toplamTutar)
        {
            this.lblTutarG1.Visible = true;
            this.lblTutarG1.Text = "HESAP = " + toplamTutar.ToString() + " TL";

        }
        public void hesabiGosterG2(double toplamTutar)
        {
            this.lblTutarG2.Visible = true;
            this.lblTutarG2.Text = "HESAP = " + toplamTutar.ToString() + " TL";

        }
        public void hesabiGosterG3(double toplamTutar)
        {
            this.lblTutarG3.Visible = true;
            this.lblTutarG3.Text = "HESAP = " + toplamTutar.ToString() + " TL";

        }
        public void hesabiGosterG4(double toplamTutar)
        {
            this.lblTutarG4.Visible = true;
            this.lblTutarG4.Text = "HESAP = " + toplamTutar.ToString() + " TL";

        }


        public bool masaDoluMuM1()

        {

            if (fm1.listBox1.Items.Count != 0)
            {

                return true;
            }
            else
            {
                return false;
            }
        }
        public bool masaDoluMuM2()
        {

            if (fm2.listBox1.Items.Count != 0)
            {
                return true;
            }
            else
            {
                return false;
            }





        }
        public bool masaDoluMuM3()
        {

            if (fm3.listBox1.Items.Count != 0)
            {
                return true;
            }
            else
            {
                return false;
            }




        }
        public bool masaDoluMuM4()
        {

            if (fm4.listBox1.Items.Count != 0)
            {
                return true;
            }
            else
            {
                return false;
            }




        }
        public bool masaDoluMuM5()
        {

            if (fm5.listBox1.Items.Count != 0)
            {
                return true;
            }
            else
            {
                return false;
            }




        }
        public bool masaDoluMuM6()
        {

            if (fm6.listBox1.Items.Count != 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool masaDoluMuM7()
        {

            if (fm7.listBox1.Items.Count != 0)
            {
                return true;
            }
            else
            {
                return false;
            }




        }
        public bool masaDoluMuM8()
        {

            if (fm8.listBox1.Items.Count != 0)
            {
                return true;
            }
            else
            {
                return false;
            }




        }
        public bool GelAlDolumu1()
        {

            if (gelal1.listBox1.Items.Count != 0)
            {
                return true;
            }
            else
            {
                return false;
            }




        }
        public bool GelAlDolumu2()
        {

            if (gelal2.listBox1.Items.Count != 0)
            {
                return true;
            }
            else
            {
                return false;
            }




        }
        public bool GelAlDolumu3()
        {

            if (gelal3.listBox1.Items.Count != 0)
            {
                return true;
            }
            else
            {
                return false;
            }




        }
        public bool GelAlDolumu4()
        {

            if (gelal4.listBox1.Items.Count != 0)
            {
                return true;
            }
            else
            {
                return false;
            }




        }


        public frmAnasayfa()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnMasa1_Click(object sender, EventArgs e)
        {


            fm1.listBox1.Items.Clear();
            foreach (var item in fm1.urunIsımleri)
            {
                fm1.listBox1.Items.Add(item);

            }
            this.Hide();
            fm1.Show();


        }

        private void btnMasa2_Click(object sender, EventArgs e)
        {
            fm2.Show();
            this.Hide();

        }
        private void btnMasa3_Click(object sender, EventArgs e)
        {
            fm3.Show();
            this.Hide();
        }
        private void btnMasa4_Click(object sender, EventArgs e)
        {
            fm4.Show();
            this.Hide();
        }
        private void btnMasa5_Click(object sender, EventArgs e)
        {
            fm5.Show();
            this.Hide();
        }
        private void btnMasa6_Click(object sender, EventArgs e)
        {
            fm6.Show();
            this.Hide();
        }
        private void btnMasa7_Click(object sender, EventArgs e)
        {
            fm7.Show();
            this.Hide();
        }
        private void btnMasa8_Click(object sender, EventArgs e)
        {
            fm8.Show();
            this.Hide();
        }
        private void btnGelAl1_Click(object sender, EventArgs e)
        {
            gelal1.Show();
            this.Hide();
        }
        private void btnGelAl2_Click(object sender, EventArgs e)
        {
            gelal2.Show();
            this.Hide();
        }
        private void btnGelAl3_Click(object sender, EventArgs e)
        {
            gelal3.Show();
            this.Hide();
        }
        private void btnGelAl4_Click(object sender, EventArgs e)
        {
            gelal4.Show();
            this.Hide();
        }
        public void GunSonunuTemizle()
        {
            gunSonu.Clear();
            gunSonuKredi.Clear();
            gunSonuNakit.Clear();
            gunSonuKrediTutarı = 0;
            gunSonuNakitTutarı = 0;
            gunSonuTutari = 0;
        }
        public void gunSonlarınıListele()
        {
            
            OleDbConnection connection = new OleDbConnection(Baglanti.baglanti);
            connection.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("select * from GunSonuVerileri", connection);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            frmGunSonuVerileri.dataGridView1.DataSource = tablo;
            connection.Close();




        }

        public void gunSonuKayıtEkle(DateTime tarih, double nakit,double kredi,double toplamTutar) {

            OleDbConnection connection = new OleDbConnection(Baglanti.baglanti);
            connection.Open();
            OleDbCommand komut = new OleDbCommand("insert into GunSonuVerileri (TARİH,NAKİT,KREDI_KARTI,TOPLAM_TUTAR) values (@tarih,@nakit,@kredi,@toplamTutar)");
           
            komut.Parameters.AddWithValue("@tarih",tarih);
            komut.Parameters.AddWithValue("@nakit", nakit);
            komut.Parameters.AddWithValue("@kredi", kredi);
            komut.Parameters.AddWithValue("@toplamTutar", toplamTutar);

            komut.Connection = connection;
            komut.ExecuteNonQuery();
            connection.Close();
            gunSonlarınıListele();


        }

   
        private void btnGunSonuAl_Click(object sender, EventArgs e)
        {
            DateTime bugun = DateTime.Now;

            if (btnMasa1.BackColor == Color.Green && btnMasa2.BackColor == Color.Green && btnMasa3.BackColor == Color.Green && btnMasa4.BackColor == Color.Green && btnMasa5.BackColor == Color.Green &&
                btnMasa6.BackColor == Color.Green && btnMasa7.BackColor == Color.Green && btnMasa8.BackColor == Color.Green && btnGelAl1.BackColor == Color.Green && btnGelAl2.BackColor == Color.Green &&
                btnGelAl3.BackColor == Color.Green && btnGelAl4.BackColor == Color.Green)
            {

                DialogResult secenek = MessageBox.Show("GÜN SONU YAZDIRMA İŞLEMİNİ ONAYLIYOR MUSUNUZ ?", "Bilgilendirme Penceresi", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (secenek == DialogResult.Yes)
                {
                 

                    frmGunSonu gunSonufrm = new frmGunSonu();

                    foreach (double item1 in gunSonu)
                    {
                        gunSonuTutari += item1;
                        
                    }


                    foreach (double item2 in gunSonuNakit)
                    {
                        gunSonuNakitTutarı += item2;
                     
                    }


                    foreach (double item3 in gunSonuKredi)
                    {
                       
                        gunSonuKrediTutarı += item3;
                      

                    }
                  
                    gunSonuKayıtEkle(bugun,gunSonuNakitTutarı,gunSonuKrediTutarı,gunSonuTutari);

                    gunSonufrm.lblKredi.Text = gunSonuKrediTutarı.ToString() + " TL";
                    gunSonufrm.lblNakit.Text = gunSonuNakitTutarı.ToString() + " TL";
                    gunSonufrm.lblToplam.Text = gunSonuTutari.ToString() + " TL";


                    GunSonunuTemizle();



                    gunSonufrm.Show();
                }






            }

            else
            {
                MessageBox.Show("TAMAMLANMAYAN SİPARİŞLER MEVCUT. \nLÜTFEN SİPARİŞLERİNİZİ TAMAMLAYINIZ !", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }




        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult secenek = MessageBox.Show("UYGULAMAYI KAPATMAK İSTİYOR MUSUNUZ ?", "WARNING", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (secenek == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblTutarM2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmUrunler frmUrunler = new frmUrunler();
            frmUrunler.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gunSonlarınıListele();
            frmGunSonuVerileri.Show();
            this.Hide();
        }
    }
}