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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        sqlbaglanti bgl = new sqlbaglanti();

        private void btngiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("SELECT * FROM KULLANICI WHERE KullaniciAdi='" + txtkullanici.Text + "' and Sifre='" + txtsifre.Text + "'",bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read() == true)
            {
                Form1 fr = new Form1();
                fr.txtid.Text = dr["Id"].ToString();
                fr.Show();
                txtkullanici.Clear();
                txtsifre.Clear();
                //this.Hide();
            }
            else
            {
                MessageBox.Show("HATALI GİRİŞ");
            }
            bgl.baglanti().Close();
        }

        //çıkış buton
        private void btncikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //kayıt buton
        private void btnkayit_Click(object sender, EventArgs e)
        {
            Form4 fr4 = new Form4();
            fr4.ShowDialog();
        }
    }
}
