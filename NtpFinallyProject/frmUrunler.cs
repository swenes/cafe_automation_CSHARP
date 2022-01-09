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
    public partial class frmUrunler : Form
    {

        OleDbConnection connection;
        OleDbCommand komut;
        OleDbDataAdapter da;


        public frmUrunler()

        {
            InitializeComponent();
        }

        public void urunleriListele()
        {
            connection = new OleDbConnection(Baglanti.baglanti);
            connection.Open();
            da = new OleDbDataAdapter("select * from Products", connection);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            connection.Close();



        }
        private void frmUrunler_Load(object sender, EventArgs e)
        {
            urunleriListele();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmMasa1.anasayfa.Show();
            this.Hide();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtUrunId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtUrunAdı.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtUrunFiyat.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult secenek = MessageBox.Show("DEĞİŞİKLERİ KAYDETMEK İSTİYOR MUSUNUZ ?", "Bilgilendirme Penceresi", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (secenek == DialogResult.Yes)
            {

                connection.Open();
                komut = new OleDbCommand();
                komut.Connection = connection;
                komut.CommandText = "UPDATE Products SET Name='" + txtUrunAdı.Text + "', Price='" + txtUrunFiyat.Text + "' where Id = '" + txtUrunId.Text + "'";
                komut.ExecuteNonQuery();
                connection.Close();
                urunleriListele();










                //connection.Open();
                //string sorgu = "UPDATE Products SET Name='"+txtUrunAdı.Text"', Price='"+txtUrunFiyat.Text"' where Id = '"+txtUrunId.Text"'";
                //komut = new OleDbCommand(sorgu, connection);
                //komut.Connection = connection;
                ////komut.Parameters.AddWithValue("@id", Convert.ToInt32(txtUrunId.Text));
                ////komut.Parameters.AddWithValue("@name", txtUrunAdı.Text.ToString());
                ////komut.Parameters.AddWithValue("@price", txtUrunFiyat.Text.ToString());

                ////komut.ExecuteNonQuery();
                //connection.Close();
                //urunleriListele();
            }


        }

        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            frmMasa1.anasayfa.Show();
            this.Hide();
        }
    }
}
