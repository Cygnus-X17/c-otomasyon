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

namespace Şantiye_otomasyon_proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-T0T772B\\;Initial Catalog=Şantiye_personel;Integrated Security=True");

        //Temizle metodu 
        void temizle()
        {
            textboxid.Text = "";
            textBoxad.Text = "";
            textBoxsoyad.Text = "";
            textBoxmslk.Text = "";
            comboBoxsehir.Text = "";
            maskedTextBoxmaas.Text = "";
            radioButtonbekar.Checked = false;
            radioButtonevli.Checked = false;
            //İmleci Textbox AD'a odaklıyoruz..
            textBoxad.Focus();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // this.table_personelTableAdapter.Fill(this.şantiye_personelDataSet.Table_personel);
            baglanti.Open();
            SqlDataAdapter DA = new SqlDataAdapter("select * from Table_doktor",baglanti);
            DataTable DT = new DataTable();
            DA.Fill(DT);
            dataGridView1.DataSource = DT;
            baglanti.Close();
        }

        private void buttonlist_Click(object sender, EventArgs e)
        {
            this.table_personelTableAdapter.Fill(this.şantiye_personelDataSet.Table_personel);
        }

        private void buttonkydt_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutlar = new SqlCommand("insert into Table_personel (Personelad,Personelsoyad,personelsehir,personelmeslek,personelmaas,personeldurum) values (@q1,@q2,@q3,@q4,@q5,@q6)",baglanti);
            komutlar.Parameters.AddWithValue("@q1", textBoxad.Text);
            komutlar.Parameters.AddWithValue("@q2", textBoxsoyad.Text);
            komutlar.Parameters.AddWithValue("@q3", comboBoxsehir.Text);
            komutlar.Parameters.AddWithValue("@q4", textBoxmslk.Text);
            komutlar.Parameters.AddWithValue("@q5", maskedTextBoxmaas.Text);
            komutlar.Parameters.AddWithValue("@q6", label8.Text);
            komutlar.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel Eklendi !","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void radioButtonevli_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonevli.Checked==true)
            {
                label8.Text = "True";
            }
        }

        private void radioButtonbekar_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonbekar.Checked==true)
            {
                label8.Text = "False";
            }
        }

        private void buttontmzle_Click(object sender, EventArgs e)
        {
            temizle();  
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            textboxid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            textBoxad.Text= dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            textBoxsoyad.Text= dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            comboBoxsehir.Text= dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            textBoxmslk.Text= dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            maskedTextBoxmaas.Text= dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            label8.Text= dataGridView1.Rows[secilen].Cells[6].Value.ToString();
        }


        //LABEL8'deki text değiştiğinde ne olsun ? 
        private void label8_TextChanged(object sender, EventArgs e)
        {
            if (label8.Text=="True")
            {
                radioButtonevli.Checked = true;
            }
            if (label8.Text=="False")       
            {
                radioButtonbekar.Checked = true;
            }
        }

        private void buttonsil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand silmekomutu = new SqlCommand("Delete from Table_personel Where personelid=@f1",baglanti);
            silmekomutu.Parameters.AddWithValue("@f1", textboxid.Text);
            silmekomutu.ExecuteNonQuery();
            baglanti.Close ();
            MessageBox.Show("Kayıt Silindi !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttongnclle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand guncelle = new SqlCommand("Update table_personel set personelad=@g1,personelsoyad=@g2,personelsehir=@g3,personelmeslek=@g4,personelmaas=@g5,personeldurum=@g6 where personelid=@g7", baglanti);
            guncelle.Parameters.AddWithValue("@g1", textBoxad.Text);
            guncelle.Parameters.AddWithValue("@g2", textBoxsoyad.Text);
            guncelle.Parameters.AddWithValue("@g3", comboBoxsehir.Text);
            guncelle.Parameters.AddWithValue("@g4", textBoxmslk.Text);
            guncelle.Parameters.AddWithValue("@g5", maskedTextBoxmaas.Text);
            guncelle.Parameters.AddWithValue("@g6", label8.Text);
            guncelle.Parameters.AddWithValue("@g7", textboxid.Text);
            guncelle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel Güncellendi !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonistatistik_Click(object sender, EventArgs e)
        {
            Formiststsk fr = new Formiststsk();
            fr.Show();
        }

        private void buttongrfk_Click(object sender, EventArgs e)
        {
            grafikler frgr = new grafikler();
            frgr.Show();
        }

        private void varsayılanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void yeşilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.GreenYellow;
        }

        private void maviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.AliceBlue;
        }

        private void grafiklerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grafikler frgr = new grafikler();
            frgr.Show();
        }

        private void istatistiklerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formiststsk fr = new Formiststsk();
            fr.Show();
        }

        private void hakkındaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu Proje Mehmet Fatih Suna Tarafından Yapılmıştır.", "Hakkında", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void yenileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.table_personelTableAdapter.Fill(this.şantiye_personelDataSet.Table_personel);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
