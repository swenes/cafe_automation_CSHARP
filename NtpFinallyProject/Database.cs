using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data.OleDb;
namespace NtpFinallyProject
{
    class Database
    {
        
        public static OleDbConnection connection = new OleDbConnection(Baglanti.baglanti);
        OleDbCommand command;
        public static OleDbDataReader reader;
        //bağlantı işlemleri
        public static void connectionOpen()
        {
            if (connection.State != System.Data.ConnectionState.Open)
            {
                try
                {
                    connection.Open();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }
        public static void connectionClose()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                try
                {
                    connection.Close();
                    
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }
        //ürünler
        public double Profiterol1kg()
        {
            connectionOpen();

            double ucret = 0;
            OleDbCommand komut = new OleDbCommand("select * from Products where Id = '1' ");
            komut.Connection = connection;
            OleDbDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {

                ucret = Convert.ToDouble(reader["Price"]);

            }
            connectionClose();
            return ucret;

        }
        public double Profiterol750gr()
        {
            connectionOpen();

            double ucret = 0;
            OleDbCommand komut = new OleDbCommand("select * from Products where Id = '2' ");
            komut.Connection = connection;
            OleDbDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {

                ucret = Convert.ToDouble(reader["Price"]);

            }
            connectionClose();
            return ucret;
        }
        public double Profiterol500gr()
        {
            connectionOpen();

            double ucret = 0;
            OleDbCommand komut = new OleDbCommand("select * from Products where Id = '3' ");
            komut.Connection = connection;
            OleDbDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {

                ucret = Convert.ToDouble(reader["Price"]);

            }
            connectionClose();
            return ucret;

        }
        public double ProfiterolPorsiyon()
        {

            connectionOpen();
            double ucret = 0;

            OleDbCommand komut = new OleDbCommand("select * from Products where Id = '4' ");
            komut.Connection = connection;
            OleDbDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {

                ucret = Convert.ToDouble(reader["Price"]);

            }
            connectionClose();
            return ucret;

        }
        public double Ekler1KG()
        {

            connectionOpen();
            double ucret = 0;

            OleDbCommand komut = new OleDbCommand("select * from Products where Id = '16' ");
            komut.Connection = connection;
            OleDbDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {

                ucret = Convert.ToDouble(reader["Price"]);

            }
            connectionClose();
            return ucret;

        }
        public double Ekler750gr()
        {

            connectionOpen();
            double ucret = 0;

            OleDbCommand komut = new OleDbCommand("select * from Products where Id = '17' ");
            komut.Connection = connection;
            OleDbDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {

                ucret = Convert.ToDouble(reader["Price"]);

            }
            connectionClose();
            return ucret;

        }
        public double Ekler500gr()
        {
            connectionOpen();
            double ucret = 0;

            OleDbCommand komut = new OleDbCommand("select * from Products where Id = '18' ");
            komut.Connection = connection;
            OleDbDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {

                ucret = Convert.ToDouble(reader["Price"]);

            }
            connectionClose();
            return ucret;
        }
        public double EklerPorsiyon()
        {
            connectionOpen();
            double ucret = 0;

            OleDbCommand komut = new OleDbCommand("select * from Products where Id = '19' ");
            komut.Connection = connection;
            OleDbDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {

                ucret = Convert.ToDouble(reader["Price"]);

            }
            connectionClose();
            return ucret;
        }
        public double TekKisilikPasta()
        {
            connectionOpen();
            double ucret = 0;

            OleDbCommand komut = new OleDbCommand("select * from Products where Id = '13' ");
            komut.Connection = connection;
            OleDbDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {

                ucret = Convert.ToDouble(reader["Price"]);

            }
            connectionClose();
            return ucret;
        }
        public double Trilice()
        {
            connectionOpen();
            double ucret = 0;

            OleDbCommand komut = new OleDbCommand("select * from Products where Id = '6' ");
            komut.Connection = connection;
            OleDbDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {

                ucret = Convert.ToDouble(reader["Price"]);

            }
            connectionClose();
            return ucret;
        }
        public double Tiramisu()
        {
            connectionOpen();
            double ucret = 0;

            OleDbCommand komut = new OleDbCommand("select * from Products where Id = '11' ");
            komut.Connection = connection;
            OleDbDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {

                ucret = Convert.ToDouble(reader["Price"]);

            }
            connectionClose();
            return ucret;
        }
        public double Magnolia()
        {
            connectionOpen();
            double ucret = 0;

            OleDbCommand komut = new OleDbCommand("select * from Products where Id = '9' ");
            komut.Connection = connection;
            OleDbDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {

                ucret = Convert.ToDouble(reader["Price"]);

            }
            connectionClose();
            return ucret;
        }
        public double Donut()
        {
            connectionOpen();
            double ucret = 0;

            OleDbCommand komut = new OleDbCommand("select * from Products where Id = '8' ");
            komut.Connection = connection;
            OleDbDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {

                ucret = Convert.ToDouble(reader["Price"]);

            }
            connectionClose();
            return ucret;
        }
        public double Makaron()
        {
            connectionOpen();
            double ucret = 0;

            OleDbCommand komut = new OleDbCommand("select * from Products where Id = '7' ");
            komut.Connection = connection;
            OleDbDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {

                ucret = Convert.ToDouble(reader["Price"]);

            }
            connectionClose();
            return ucret;
        }
        public double SanSenbastian()
        {
            connectionOpen();
            double ucret = 0;

            OleDbCommand komut = new OleDbCommand("select * from Products where Id = '10' ");
            komut.Connection = connection;
            OleDbDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {

                ucret = Convert.ToDouble(reader["Price"]);

            }
            connectionClose();
            return ucret;
        }
        public double Pasta46()
        {
            connectionOpen();
            double ucret = 0;

            OleDbCommand komut = new OleDbCommand("select * from Products where Id = '14' ");
            komut.Connection = connection;
            OleDbDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {

                ucret = Convert.ToDouble(reader["Price"]);

            }
            connectionClose();
            return ucret;
        }
        public double Pasta68()
        {
            connectionOpen();
            double ucret = 0;

            OleDbCommand komut = new OleDbCommand("select * from Products where Id = '15' ");
            komut.Connection = connection;
            OleDbDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {

                ucret = Convert.ToDouble(reader["Price"]);

            }
            connectionClose();
            return ucret;



        }
        public double Dondurma1Top()
        {
            connectionOpen();
            double ucret = 0;

            OleDbCommand komut = new OleDbCommand("select * from Products where Id = '27' ");
            komut.Connection = connection;
            OleDbDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {

                ucret = Convert.ToDouble(reader["Price"]);

            }
            connectionClose();
            return ucret;
        }
        public double Dondurma1Kg()
        {
            connectionOpen();
            double ucret = 0;

            OleDbCommand komut = new OleDbCommand("select * from Products where Id = '29' ");
            komut.Connection = connection;
            OleDbDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {

                ucret = Convert.ToDouble(reader["Price"]);

            }
            connectionClose();
            return ucret;
        }
        public double Dondurma500Gr()
        {
            connectionOpen();
            double ucret = 0;

            OleDbCommand komut = new OleDbCommand("select * from Products where Id = '28' ");
            komut.Connection = connection;
            OleDbDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {

                ucret = Convert.ToDouble(reader["Price"]);

            }
            connectionClose();
            return ucret;
        }
        public double TurkKahvesi()
        {
            connectionOpen();
            double ucret = 0;

            OleDbCommand komut = new OleDbCommand("select * from Products where Id = '20' ");
            komut.Connection = connection;
            OleDbDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {

                ucret = Convert.ToDouble(reader["Price"]);

            }
            connectionClose();
            return ucret;
        }
        public double Cay()
        {
            connectionOpen();
            double ucret = 0;

            OleDbCommand komut = new OleDbCommand("select * from Products where Id = '22' ");
            komut.Connection = connection;
            OleDbDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {

                ucret = Convert.ToDouble(reader["Price"]);

            }
            connectionClose();
            return ucret;
        }
        public double KahveCesitleri()
        {
            connectionOpen();
            double ucret = 0;

            OleDbCommand komut = new OleDbCommand("select * from Products where Id = '21' ");
            komut.Connection = connection;
            OleDbDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {

                ucret = Convert.ToDouble(reader["Price"]);

            }
            connectionClose();
            return ucret;
        }
        public double FincanCay()
        {
            connectionOpen();
            double ucret = 0;

            OleDbCommand komut = new OleDbCommand("select * from Products where Id = '23' ");
            komut.Connection = connection;
            OleDbDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {

                ucret = Convert.ToDouble(reader["Price"]);

            }
            connectionClose();
            return ucret;
        }
        public double Su()
        {
            connectionOpen();
            double ucret = 0;

            OleDbCommand komut = new OleDbCommand("select * from Products where Id = '24' ");
            komut.Connection = connection;
            OleDbDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {

                ucret = Convert.ToDouble(reader["Price"]);

            }
            connectionClose();
            return ucret;
        }
        public double MadenSuyu()
        {
            connectionOpen();
            double ucret = 0;

            OleDbCommand komut = new OleDbCommand("select * from Products where Id = '25' ");
            komut.Connection = connection;
            OleDbDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {

                ucret = Convert.ToDouble(reader["Price"]);

            }
            connectionClose();
            return ucret;
        }
        public double KutuSiseVeMesrubatCesitleri()
        {
            connectionOpen();
            double ucret = 0;

            OleDbCommand komut = new OleDbCommand("select * from Products where Id = '26' ");
            komut.Connection = connection;
            OleDbDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {

                ucret = Convert.ToDouble(reader["Price"]);

            }
            connectionClose();
            return ucret;
        }




        //Diğer projeden gelen kodlar alttakiler


        public bool GirisYap(string kullaniciAdi, string sifre)
        {

            command = new OleDbCommand("Select * from [Customers] where " + "kullaniciAdi = '" + kullaniciAdi + "' and kullaniciSifresi = '" + sifre + "'", connection);

            connectionOpen();
            OleDbDataReader readers = command.ExecuteReader();


            try
            {
                if (readers.Read())
                {

                    frmMasa1.anasayfa.Show();

                    connection.Close();

                    return true;


                }

                else
                {

                    MessageBox.Show("Hatalı kullanıcı adı veya şifre girdiniz !", "Hatalı Giriş !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    connection.Close();



                }

            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }

            return false;
        }

        public void KayitOl(string kAdi, string kSifresi, string kTelefon, string kEmail)
        {

            try
            {

                connectionOpen();

                string kullaniciKayit = "insert into Customers(kullaniciAdi,kullaniciSifresi,kullaniciTelefonu,kullaniciEmail) " +
                "values (@kullaniciAdi,@kullaniciSifresi,@kullaniciTelefonu,@kullaniciEmail)";

                OleDbCommand command = new OleDbCommand(kullaniciKayit, connection);
                command.Parameters.AddWithValue("@kullaniciAdi", kAdi);
                command.Parameters.AddWithValue("@kullaniciSifresi", kSifresi);
                command.Parameters.AddWithValue("@kullaniciTelefonu", kTelefon);
                command.Parameters.AddWithValue("@kullaniciEmail", kEmail);


                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Müşteri Kayıt İşlemi Gerçekleşti.");




            }


            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }


        }
        public bool mailAynıMı(string kullaniciAdi, string email)
        {
            connectionOpen();

            command = new OleDbCommand("Select * from [Customers] where " + "kullaniciAdi = '" + kullaniciAdi + "' and kullaniciEmail = '" + email + "'", connection);
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                return true;
            }
            return false;

            connectionClose();

        }



        // YENİDEN SQL CONNECTİON VE KOMUT OLUŞTURUYORUM. (BAZI HATALARDAN DOLAYI()
        public void sifreDegistir(string kAdi, string kSifre)
        {
            OleDbConnection con = new OleDbConnection(Baglanti.baglanti);
            OleDbCommand komut = new OleDbCommand("update Customers set kullaniciSifresi=@ks where kullaniciAdi=@ka", con);

            komut.Connection = con;
            komut.Parameters.AddWithValue("@ka", kAdi);
            komut.Parameters.AddWithValue("@ks", kSifre);
            con.Open();
            OleDbDataReader reader = komut.ExecuteReader();

            con.Close();

          
        }

    }


}