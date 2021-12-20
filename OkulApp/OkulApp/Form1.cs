using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkulApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Sinif[] siniflar = new Sinif[];

            List<Sinif> lst = new List<Sinif>();
            var snf = new Sinif();

            snf.Kontenjan = 20;
            snf.SinifAd = "1-A";
            snf.SinifId = 1;

            lst.Add(snf);


        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlConnection cn = null;
            try
            {
                cn = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Okul2;Integrated Security=true;");
                cn.Open();
                SqlCommand cmd = new SqlCommand($"Insert into Ogrenci (Ad,Soyad,Numara,SinifId) values('{txtAd.Text}','{txtSoyad.Text}',{txtNumara.Text},{cmbSinif.Text})", cn);
                //cmd.ExecuteNonQuery();

                int sonuc = cmd.ExecuteNonQuery();
                MessageBox.Show(sonuc > 0 ? "İşlem Başarılı " : "Başarısız");
                cn.Close();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (cn != null && cn.State != ConnectionState.Closed)//Null Check
                {
                    cn.Close();
                }
            }

        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            SqlConnection cn = null;
            try
            {
                cn = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Okul2;Integrated Security=true;");
                cn.Open();
                SqlCommand cmd = new SqlCommand($"Select * from Ogrenci where Numara={txtNO.Text.Trim()}", cn);
                //cmd.ExecuteNonQuery();

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    txtAd.Text = dr["Ad"].ToString();
                    txtSoyad.Text = dr["Soyad"].ToString();
                    txtNumara.Text = dr["Numara"].ToString();
                    cmbSinif.Text = dr["SinifId"].ToString();
                }
                else
                {
                    MessageBox.Show("Öğrenci Bulunamadı");
                }

                dr.Close();

            }
            catch (SqlException)
            {
                MessageBox.Show("Bu Numara Kayıtlı");
            }

            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (cn != null && cn.State != ConnectionState.Closed)//Null Check
                {
                    cn.Close();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection cn = null;
            try
            {
                cn = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Okul2;Integrated Security=true;");
                cn.Open();
                SqlCommand cmd = new SqlCommand($"Select SinidId,SinfAd,Kontenjan from tblSinif", cn);
                //cmd.ExecuteNonQuery();

                SqlDataReader dr = cmd.ExecuteReader();

                var lst = new List<Sinif>();

                while (dr.Read())
                {
                    var snf = new Sinif();
                    snf.Kontenjan = Convert.ToInt32(dr["Kontenjan"]);
                    snf.SinifAd = dr["SinifAd"].ToString();
                    snf.SinifId = Convert.ToInt32(dr["SinifId"]);
                    lst.Add(snf);

                }


                dr.Close();

            }
            catch (SqlException)
            {
                MessageBox.Show("Bu Numara Kayıtlı");
            }

            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (cn != null && cn.State != ConnectionState.Closed)//Null Check
                {
                    cn.Close();
                }
            }
        }
    }
}
