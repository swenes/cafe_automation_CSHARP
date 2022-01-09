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
    public partial class frmGirisYapGRCK : Form
    {
        Database db = new Database();



        frmEmailKontrolGRCK frmEmailKontrol = new frmEmailKontrolGRCK();



        public frmGirisYapGRCK()
        {
            InitializeComponent();
        }

        private void frmGirisYapGRCK_Load(object sender, EventArgs e)
        {

        }
        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text.Equals(""))
            {

                MessageBox.Show("Kullanıcı Adı bölümü Boş Bırakılamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else if (txtSifre.Text.Equals(""))
            {

                MessageBox.Show("Şifre bölümü Boş Bırakılamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }

            else if (db.GirisYap(txtKullaniciAdi.Text, txtSifre.Text))
            {

                this.Hide();


            }
           

        }

        private void linkLabelKayit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            this.Hide();
            frmKayitOlGRCK form2 = new frmKayitOlGRCK();
            form2.Show();


        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult giriskapanis = MessageBox.Show("Programı kapatmak istediğinizden eminmisiniz ? ", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (giriskapanis == DialogResult.No)
            {
                e.Cancel = true;
                return;

            }
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            frmEmailKontrol.Show();
            this.Hide();


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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                //karakteri göster.
                txtSifre.PasswordChar = '\0';
            }
            //değilse karakterlerin yerine * koy.
            else
            {
                txtSifre.PasswordChar = '*';
            }
        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
