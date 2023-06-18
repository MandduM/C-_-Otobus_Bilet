using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace ilerinesnetaban
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();

        public string koltukNo = "";

        
        private void Form2_Load(object sender, EventArgs e)
        {

        }    

        //satiş buton
        private void btnsatiş_Click(object sender, EventArgs e)
        {
            //Güncelleme işlemi: önce sil sonra ekle 
            SqlCommand komut = new SqlCommand(/*cmdText:*/ "DELETE FROM BILET WHERE koltukNo=" + koltukNo, bgl.baglanti());
            komut.ExecuteNonQuery(); // komut çalıştırma
            komut = new SqlCommand(cmdText: "INSERT INTO BILET(KoltukNo,Adi,Soyadi,Cinsiyet)VALUES(@koltukNo,@ad,@soyad,@cinsiyet)", bgl.baglanti()); // ekleme işlemi
            komut.Parameters.AddWithValue(parameterName: "@koltukNo", koltukNo);
            komut.Parameters.AddWithValue(parameterName: "@ad", txtAd.Text);
            komut.Parameters.AddWithValue(parameterName: "@soyad", txtSoyad.Text);
            komut.Parameters.AddWithValue(parameterName: "@cinsiyet", cmbCinsiyet.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            komut.Parameters.Clear();
            this.Close();
        }

        //satiş iptal
        private void btniptal_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("DELETE FROM BILET WHERE koltukNo=" + koltukNo, bgl.baglanti());
            komut.ExecuteNonQuery();
            txtAd.Text = txtSoyad.Text = cmbCinsiyet.Text = "";
            bgl.baglanti().Close(); //bağlantımızı kapattık
            this.Close();
        }
    }
}
 