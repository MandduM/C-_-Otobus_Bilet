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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.16.0;Data Source=C:\\Users\\Administrator\\Desktop\\Otobus_db.accdb");
        sqlbaglanti bgl = new sqlbaglanti();

        //Aracın içindeki koltukları listeleme
        void KoltukSırala()
        {
            int x = 50, y = 50, sayac = 1, pad = 0; //Butonların form üzerinde yerleşimi için x ve y değişkeni tanımladım sayactan koltukların numaraları tayin edilidi ve pad ile boşluk yapıldı.
            for (int i = 0; i < 10; i++)
            {
                for (int J = 0; J < 4; J++) // her sırada 4 tane tane buton olması için for döngüsü kullandım
                {
                    Button btn = new Button(); // yeni buton oluşturuldu
                    btn.Width = btn.Height = 50; // yüksekliği ve genişliği için 50 ayarlandı  konumunu tayin etmek için  
                    if (J % 2 == 0 && J != 0) // ilk iki butonu yerleştir arayada boşluk bırak
                    {
                        pad += 20; // butonlar arasında bir koridor oluştur
                    }
                    btn.Left = x * J + pad; // x yani yatayda ki konumu 
                    btn.Top = y * i; // y eksenindeki konumu 
                    btn.BackColor = Color.Gray; // butonumuzun rengi için 
                    btn.Text = sayac.ToString(); // her koltuğun numarası 1 den başlayıp 40 sayısına doğru gitmesi için 
                    btn.Name = "btn" + sayac.ToString();
                    sayac++;
                    btn.Click += new EventHandler(btn_click);
                    panel1.Controls.Add(btn);
                }
                pad = 0;
            }
        }

        //Araçta Satılan koltukların cinsiyetine göre renkelendirme yapılması
        void DoluKoltuk()
        {
            SqlCommand komut = new SqlCommand(cmdText: "SELECT * FROM BILET", bgl.baglanti()); // form çalıştırıldığında veritabanımızdan verileri çekme işlemi
            SqlDataReader oku = komut.ExecuteReader(); // satır satır veritabanımızdaki verileri okumamızı sağladık böylelikle bunların tayinlerini gerçekleştirebilicez 
            while (oku.Read())
            {
                if (oku["cinsiyet"].ToString() == "Bay")
                    ((Button)panel1.Controls["btn" + oku["koltukNo"].ToString()]).BackColor = Color.SkyBlue; // işlemi yapılan kişinin cinsiyeti bay olduğu için buton rengimiz mavi 
                else
                    ((Button)panel1.Controls["btn" + oku["koltukNo"].ToString()]).BackColor = Color.Pink; // işlemi yapılan kişinin cinsiyeti bayan olduğu için buton rengimiz pembe

            }
            oku.Dispose();
            bgl.baglanti().Close();
        }

        //form load
        private void Form1_Load(object sender, EventArgs e)
        {
            KoltukSırala();
            DoluKoltuk();
        }

        //btn
        private void btn_click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();

            SqlCommand komut1=new SqlCommand("SELECT * FROM KULLANICI WHERE Id='"+txtid.Text+"'",bgl.baglanti()); //yetki belirleme
            SqlDataReader dr = komut1.ExecuteReader();
            if (dr.Read() == true)
            {
                frm2.btnsatiş.Enabled =(bool)dr["SatisYap"];
                frm2.btniptal.Enabled = (bool)dr["Satisİptal"];
            }

            frm2.koltukNo = ((Button)sender).Text; // hangi butona basarsak o buton üzerindeki texti al koltuk numarası olarak tayin et 

            frm2.Text = "Koltuk No: " + frm2.koltukNo; // o formda ki koltuk numarasını yanına koltuk no olarak yaz
            SqlCommand komut = new SqlCommand(cmdText: "SELECT * FROM BILET WHERE KoltukNo=" + frm2.koltukNo, bgl.baglanti()); // tıklanan butondan seçilen bilgileri veritabanından çekmeyi yaptım
            SqlDataReader oku = komut.ExecuteReader(); // tek tek alanları okumamızı sağlayacak ve komutu çalıştırıcak 
            while (oku.Read ())
            {
                frm2.Controls["txtAd"].Text = oku["adi"].ToString(); // atama işlemi
                frm2.Controls["txtSoyad"].Text = oku["soyadi"].ToString();
                frm2.Controls["cmbCinsiyet"].Text = oku["cinsiyet"].ToString();
            }


            oku.Dispose();

            bgl.baglanti().Close();
            frm2.ShowDialog();
            if (frm2.Controls["cmbCinsiyet"].Text == "Bay") // satış yapıldıysa mavi olsun buton
                ((Button)sender).BackColor = Color.SkyBlue;
            if (frm2.Controls["cmbCinsiyet"].Text == "Bayan") // satış yapıldıysa pembe olsun buton
                ((Button)sender).BackColor = Color.Pink;
            if (frm2.Controls["cmbCinsiyet"].Text == "") // satış iptal edildiyse gri olsun buton
                ((Button)sender).BackColor = Color.Gray;
            frm2.Dispose();
        }
    }
}
