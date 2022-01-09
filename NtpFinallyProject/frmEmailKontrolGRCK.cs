using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NtpFinallyProject
{
    public partial class frmEmailKontrolGRCK : Form
    {
        Database db = new Database();
        public frmEmailKontrolGRCK()
        {
            InitializeComponent();
        }

        private void frmEmailKontrolGRCK_Load(object sender, EventArgs e)
        {


        }
        private void button1_Click(object sender, EventArgs e)

        {
          

            if (txtKullaniciAdiSifreYenileme.Text.Equals(""))
            {

                MessageBox.Show("Kullanıcı Adı bölümü Boş Bırakılamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else if (txtEmailSifreYenileme.Text.Equals(""))
            {

                MessageBox.Show("Şifre bölümü Boş Bırakılamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }


            else if (db.mailAynıMı(txtKullaniciAdiSifreYenileme.Text.ToString(), txtEmailSifreYenileme.Text.ToString()))
            {
                frmSifreYenilemeGRCK frmSifreYenilemeGRCK = new frmSifreYenilemeGRCK();

                frmSifreYenilemeGRCK.Show();
                this.Hide();
                



            }

            else { MessageBox.Show("Kullanıcı adı ile E-Mail hesabı uyuşmuyor!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information); }

        }

        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            frmGirisYapGRCK giris = new frmGirisYapGRCK();
            giris.Show();
            this.Hide();
        }
    }
}
