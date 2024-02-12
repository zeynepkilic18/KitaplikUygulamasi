using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AdoNet2
{
    public partial class FormRecords : Form
    {
        public FormRecords()
        {
            InitializeComponent();
            this.IsMdiContainer = true; //Form içinde form açılabilir anlamına geldi

        }

        public static string connectionString = "Server=LERI\\SQLEXPRESS;Database=Kitaplik;Integrated Security=true";
        SqlConnection baglanti = new SqlConnection(connectionString);
        private void Form1_Load(object sender, EventArgs e)
        {
            // Resmin dosya yolunu projenize göre güncelleyin
            string imagePath = @"  C:\Users\18zey\OneDrive\Masaüstü\html dersleri\resimler\ce66ff30237b80c8d986ffdff39745c5.jpg";

            // Resmi formun arka planına ayarla
            this.BackgroundImage = Image.FromFile(imagePath);

            // Resmi form boyutuna göre düzgün bir şekilde yerleştir
            this.BackgroundImageLayout = ImageLayout.Stretch;
            //add_Column("Kitap", "StokDurumu","BIT");
            //add_Column("Kitap", "KitapTürü","NVARCHAR(50)");
           

            //Disconnected Mimari yöntemi ile veri listeleme
            SqlDataAdapter adp = new SqlDataAdapter("select * from Kitap", baglanti);
            DataTable dt = new DataTable();
            adp.Fill(dt);

            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            //dataGridView1.Columns["KitapAd"].Visible = false;        istenilen sütunu tablodan siler
            //dataGridView1.Columns["KitapYazar"].Visible=false;
           

        }
      
        private bool CheckIfColumnExists(string tableName, string columnName)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                DataTable schema = connection.GetSchema("Columns", new[] { null, null, tableName, columnName });
                return schema.Rows.Count > 0;
            }
        }


        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //string no = textBoxNo.Text;
            string name = textBoxName.Text;
            string author = textBoxAuthor.Text;
            string page = textBoxPage.Text;
            string price = textBoxPrice.Text;
            DateTime date = dateTimePicker.Value;
            string publisher = textBoxPublisher.Text;
            bool isStockAvailable = radioButtonExist.Checked;
            string bookGenre=comboBoxBookGenre.Text;



            // Bağlantı oluşturma
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Bağlantıyı açma
                connection.Open();

                // SQL sorgusu ve parametreleri tanımlama
                string insertQuery = "INSERT INTO Kitap (KitapAd, KitapYazar, KitapSayfa, KitapFiyat, KitapTarih, KitapYayınEvi,StokDurumu,KitapTürü) " +
                                     "VALUES (@KitapAd, @KitapYazar, @KitapSayfa, @KitapFiyat, @KitapTarih, @KitapYayınEvi,@StokDurumu,@KitapTürü)";

                // Komut oluşturma
                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    // Parametreler oluşturma ve değerlerini atama
                    //command.Parameters.AddWithValue("@KitapNo", no);
                    command.Parameters.AddWithValue("@KitapAd", name);
                    command.Parameters.AddWithValue("@KitapYazar", author);
                    command.Parameters.AddWithValue("@KitapSayfa", page);
                    command.Parameters.AddWithValue("@KitapFiyat", price);
                    command.Parameters.AddWithValue("@KitapTarih", date);
                    command.Parameters.AddWithValue("@KitapYayınEvi", publisher);
                    command.Parameters.AddWithValue("@StokDurumu", isStockAvailable);
                    command.Parameters.AddWithValue("@KitapTürü", bookGenre);


                    try
                    {
                        // Komutu çalıştırma
                        int rowsAffected = command.ExecuteNonQuery();
                        Console.WriteLine($"Satırlar etkilendi: {rowsAffected}");
                        SqlDataAdapter adp = new SqlDataAdapter("SELECT * FROM Kitap", connection);
                        DataTable dt = new DataTable();
                        adp.Fill(dt);
                        dataGridView1.DataSource = dt;
                        dataGridView1.Refresh();
                        clear();
                        MessageBox.Show("Kitap kaydı başarıyla eklendi");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Hata oluştu: {ex.Message}");
                    }
                }
            }

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            String no2=labelDelete2.Text;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string deleteQuery= "DELETE FROM Kitap WHERE KitapNo = @KitapNo";
                using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                {
                    command.Parameters.AddWithValue("@KitapNo",no2);
                    try
                    {
                        // Komutu çalıştırma
                        int rowsAffected = command.ExecuteNonQuery();
                        Console.WriteLine($"Satırlar etkilendi: {rowsAffected}");
                        if (rowsAffected > 0)
                        {
                            SqlDataAdapter adp = new SqlDataAdapter("SELECT * FROM Kitap", connection);
                            DataTable dt = new DataTable();
                            adp.Fill(dt);
                            dataGridView1.DataSource = dt;
                            labelDelete2.Text = " ";
                            MessageBox.Show("Kitap kaydı başarıyla silindi");
                        }
                        else
                        {
                            MessageBox.Show("Silinecek kitap bulunamadı");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Hata oluştu: {ex.Message}");
                    }
                }
            }
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            string no = label_id.Text;
            string name = textBoxBookName2.Text;
            string author = textBoxBookAuthor2.Text;
            string page = textBoxBookPage2.Text;
            string price = textBoxBookPrice2.Text;
            DateTime date = dateTimePicker2.Value;
            string publisher = textBoxBookPublisher2.Text;
            bool isStockAvailable2 = radioButtonExist2.Checked;
            string bookGenre2=comboBoxBookGenre2.Text;

            // Bağlantı oluşturma
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Bağlantıyı açma
                connection.Open();

                // SQL sorgusu ve parametreleri tanımlama
                string updateQuery = "UPDATE Kitap SET KitapAd=@KitapAd,KitapFiyat = @KitapFiyat,KitapYazar=@KitapYazar,KitapSayfa=@KitapSayfa,KitapTarih=@KitapTarih,KitapYayınEvi=@KitapYayınEvi,StokDurumu=@StokDurumu,KitapTürü=@KitapTürü WHERE KitapNo = @KitapNo";

                // Komut oluşturma
                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    // Parametreler oluşturma ve değerlerini atama
                    command.Parameters.AddWithValue("@KitapNo", no);
                    command.Parameters.AddWithValue("@KitapAd", name);
                    command.Parameters.AddWithValue("@KitapYazar", author);
                    command.Parameters.AddWithValue("@KitapSayfa", page);
                    command.Parameters.AddWithValue("@KitapFiyat", price);
                    command.Parameters.AddWithValue("@KitapTarih", date);
                    command.Parameters.AddWithValue("@KitapYayınEvi", publisher);
                    command.Parameters.AddWithValue("@StokDurumu", isStockAvailable2);
                    command.Parameters.AddWithValue("@KitapTürü", bookGenre2);

                    try
                    {
                        // Komutu çalıştırma
                        int rowsAffected = command.ExecuteNonQuery();
                        Console.WriteLine($"Satırlar etkilendi: {rowsAffected}");
                        if (rowsAffected > 0)
                        {
                            // DataGridView'i güncelle
                            SqlDataAdapter adp = new SqlDataAdapter("SELECT * FROM Kitap", connection);
                            DataTable dt = new DataTable();
                            adp.Fill(dt);
                            dataGridView1.DataSource = dt;
                            dataGridView1.Refresh();
                            clear();
                            MessageBox.Show("Kitap bilgisi başarıyla güncellendi");
                        }
                        else
                        {
                            MessageBox.Show("Güncellenecek kitap bulunamadı");
                        }
                        
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Hata oluştu: {ex.Message}");
                    }
                }
            }
        }

        private void add_Column(string table, string columnName, string columnType)
        {
            if (!CheckIfColumnExists(table, columnName))
            {
                string alterTableQuery = $"ALTER TABLE {table} ADD {columnName} {columnType}";

                // Bağlantı oluşturma
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Bağlantıyı açma
                    connection.Open();

                    // Sorguyu çalıştırma
                    using (SqlCommand command = new SqlCommand(alterTableQuery, connection))
                    {
                        try
                        {
                            // Sorguyu çalıştırma
                            command.ExecuteNonQuery();
                            MessageBox.Show($"{columnName} sütunu başarıyla oluşturuldu.");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Hata oluştu: {ex.Message}");
                        }
                    }
                }
            }
        }

        private void clear()
        {
            textBoxName.Text = " ";
            textBoxAuthor.Text = " ";
            textBoxPage.Text = " ";
            textBoxPrice.Text = " ";
            dateTimePicker.Value = DateTime.Now;
            textBoxPublisher.Text = " ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            // Form2'nin boyutunu Form1'in boyutuna ayarla
            form2.Size = this.Size;

            // Form2'yi tam ortaya yerleştir
            form2.StartPosition = FormStartPosition.CenterScreen;

            // Form1'in üzerine gelmesini sağla
            form2.TopMost = true;

            // Form2'yi göster
            form2.ShowDialog();
        }

        int secilensatir;

        private void dataGridView1_CellEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            secilensatir = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            label_id.Text = secilensatir.ToString();
            textBoxBookName2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxBookAuthor2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBoxBookPage2.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBoxBookPrice2.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBoxBookPublisher2.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            //comboBoxBookGenre. = dataGridView1.CurrentRow.Cells[7].Value.ToString();

            textBoxName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxAuthor.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBoxPage.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBoxPrice.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBoxPublisher.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

            labelDelete2.Text = secilensatir.ToString();
        }
    }

}