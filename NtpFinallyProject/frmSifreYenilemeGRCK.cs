using System;
using System.Windows.Forms;

namespace NtpFinallyProject
{
    public partial class frmSifreYenilemeGRCK : Form
    {
      
        frmGirisYapGRCK fm1 = new frmGirisYapGRCK();
        Database db = new Database();
        
     


        public frmSifreYenilemeGRCK()
        {
            InitializeComponent();
        }

        private void frmSifreYenilemeGRCK_Load(object sender, EventArgs e)
        {

        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            fm1.Show();
        }
        private void btnSifreGuncelle_Click(object sender, EventArgs e)
        {

            if (txtKullanıcıAdı.Text.Equals(""))
            {

                MessageBox.Show("KULLANICI ADI BOŞ BIRAKILAMAZ !", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else {
                if (txtYeniSifre1.Text.Equals(txtYeniSifre2.Text))
                {


                    db.sifreDegistir(txtKullanıcıAdı.Text.ToString(), txtYeniSifre1.Text.ToString());
                    DialogResult secenek = MessageBox.Show("ŞİFRENİZ BAŞARIYLA DEĞİŞTİRİLDİ. \nLÜTFEN UYGULAMAYI YENİDEN BAŞLATINIZ !", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (secenek == DialogResult.OK)


                        Application.Exit();


                }
                else
                {
                    MessageBox.Show("Girdiğiniz şifreler birbiri ile uyuşmuyor !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            
        }

        private void btnAnasayfa_Click(object sender, EventArgs e)
        {

            frmGirisYapGRCK giris = new frmGirisYapGRCK();
            giris.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                //karakteri göster.
                txtYeniSifre1.PasswordChar = '\0';
                txtYeniSifre2.PasswordChar = '\0';
            }
            //değilse karakterlerin yerine * koy.
            else
            {
                txtYeniSifre1.PasswordChar = '*';
                txtYeniSifre2.PasswordChar = '*';
            }
        }
    }
}
