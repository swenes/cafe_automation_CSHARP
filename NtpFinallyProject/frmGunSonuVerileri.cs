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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Data.OleDb;

namespace NtpFinallyProject
{
    public partial class frmGunSonuVerileri : Form
    {
        OleDbConnection con;
        OleDbDataAdapter da;
        DataSet ds;
        OleDbCommand komut;
        public static void PDF_Disa_Aktar(DataGridView dataGridView1)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.OverwritePrompt = false;
            save.Title = "PDF Dosyaları";
            save.DefaultExt = "pdf";
            save.Filter = "PDF Dosyaları (*.pdf)|*.pdf|Tüm Dosyalar(*.*)|*.*";
            if (save.ShowDialog() == DialogResult.OK)
            {
                PdfPTable pdfTable = new PdfPTable(dataGridView1.ColumnCount);

                // Bu alanlarla oynarak tasarımı iyileştirebilirsiniz.
                pdfTable.DefaultCell.Padding = 3; // hücre duvarı ve veri arasında mesafe
                pdfTable.WidthPercentage = 80; // hücre genişliği
                pdfTable.HorizontalAlignment = Element.ALIGN_LEFT; // yazı hizalaması
                pdfTable.DefaultCell.BorderWidth = 1; // kenarlık kalınlığı
                // Bu alanlarla oynarak tasarımı iyileştirebilirsiniz.

                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                    cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240); // hücre arka plan rengi
                    pdfTable.AddCell(cell);
                }
                try
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            pdfTable.AddCell(cell.Value.ToString());
                        }
                    }
                }
                catch (NullReferenceException)
                {
                }
                using (FileStream stream = new FileStream(save.FileName + ".pdf", FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);// sayfa boyutu.
                    PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(pdfTable);
                    pdfDoc.Close();
                    stream.Close();
                }
            }
        }

        void griddoldur()
        {
            con = new OleDbConnection(Baglanti.baglanti);
            da = new OleDbDataAdapter("Select * From GunSonuVerileri", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "GunSonuVerileri");
            dataGridView1.DataSource = ds.Tables["GunSonuVerileri"];
            con.Close();
        }
        void KayıtSil()
        {
            string sorgu = "DELETE FROM GunSonuVerileri WHERE TARİH=@tarih";
            komut = new OleDbCommand(sorgu, con);
            txtTarih.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            komut.Parameters.AddWithValue("@tarih", txtTarih.Text);
            con.Open();
            komut.ExecuteNonQuery();
            con.Close();
            griddoldur();
        }


        public frmGunSonuVerileri()
        {
            InitializeComponent();
        }

        private void frmGunSonuVerileri_Load(object sender, EventArgs e)
        {
            griddoldur();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMasa1.anasayfa.Show();

        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTarih.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();


        }





        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult secenek = MessageBox.Show("SEÇİLEN SATIRI SİLMEK İSTİYOR MUSUNUZ ?", "Bilgilendirme Penceresi", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (secenek == DialogResult.Yes)
            {
                KayıtSil();

                griddoldur();
            }
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            PDF_Disa_Aktar(dataGridView1);
        }
    }
}
