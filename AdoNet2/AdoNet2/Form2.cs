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

namespace AdoNet2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Disconnected Mimari yöntemi ile veri listeleme
            SqlDataAdapter adp = new SqlDataAdapter("select * from Kitap", FormRecords.connectionString);
            DataTable dt = new DataTable();
            adp.Fill(dt);

            // ListView kontrolünün sütunlarını oluşturma
            listView1.View = View.Details;
            listView1.Columns.Add("Kitap Adı");
            listView1.Columns.Add("Yazar");
            listView1.Columns.Add("Sayfa Sayısı");
            listView1.Columns.Add("Fiyat");
            listView1.Columns.Add("Yayın Tarihi");
            listView1.Columns.Add("Yayın Evi");
            listView1.Columns.Add("Stok Durumu");
            listView1.Columns.Add("Tür");
            listView1.Width = 800;

            // Verileri ListView'e ekleme
            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(row["KitapAd"].ToString());
                item.SubItems.Add(row["KitapYazar"].ToString());
                item.SubItems.Add(row["KitapSayfa"].ToString());
                item.SubItems.Add(row["KitapFiyat"].ToString());
                item.SubItems.Add(row["KitapTarih"].ToString());
                item.SubItems.Add(row["KitapYayınEvi"].ToString());
                item.SubItems.Add(row["StokDurumu"].ToString());
                item.SubItems.Add(row["KitapTürü"].ToString());

                listView1.Items.Add(item);
            }

            // Otomatik genişlik ayarı
            foreach (ColumnHeader column in listView1.Columns)
            {
                column.Width = 100;
            }
        }
    }
    }

