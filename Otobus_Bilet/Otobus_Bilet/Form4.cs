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

namespace ilerinesnetaban
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();

        //kayıt ol
        private void btnkayit_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("INSERT INTO KULLANICI(KullaniciAdi,Sifre,SatisYap,Satisİptal) VALUES (@p1,@p2,@p3,@p4)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtkullanici.Text);
            komut.Parameters.AddWithValue("@p2", txtsifre.Text);
            komut.Parameters.AddWithValue("@p3", chyap.Checked);
            komut.Parameters.AddWithValue("@p4", chiptal.Checked);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kullanıcı kayıt edildi.\nGiriş sayfasına yönlendiriliyorsunuz.");
            Form3 fr3 = new Form3();
            fr3.Show();
            this.Close();


        }
    }
}
