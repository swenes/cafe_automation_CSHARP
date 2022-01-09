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
    public partial class frmKayitOlGRCK : Form
    {
        Database db = new Database();
        frmGirisYapGRCK fm1 = new frmGirisYapGRCK();
        public frmKayitOlGRCK()
        {
            InitializeComponent();
        }

        private void frmKayitOlGRCK_Load(object sender, EventArgs e)
        {

        }
        private void btnKayıtOl_Click(object sender, EventArgs e)
        {





            if (txtKayitKullaniciAdi.Text.Equals(""))
            {

                MessageBox.Show("Kullanıcı Adı Bölümü Boş Bırakılamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else if (txtKayitSifre.Text.Equals(""))
            {

                MessageBox.Show("Şifre Bölümü Boş Bırakılamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else if (txtKayitTelefon.Text.Equals(""))
            {

                MessageBox.Show("Telefon Numarası Bölümü Boş Bırakılamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else if (txtKayitEmail.Text.Equals(""))
            {

                MessageBox.Show("E-Mail Bölümü Boş Bırakılamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }

            else
            {
                db.KayitOl(txtKayitKullaniciAdi.Text, txtKayitSifre.Text, txtKayitTelefon.Text, txtKayitEmail.Text);

                this.Hide();
                fm1.Show();
            }

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            fm1.Show();

        }

        private void btnAnasayfa_Click(object sender, EventArgs e)
        {

            frmGirisYapGRCK giris = new frmGirisYapGRCK();
            giris.Show();
            this.Hide();
        }
    }
}
