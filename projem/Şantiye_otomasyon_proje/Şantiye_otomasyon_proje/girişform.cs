﻿using System;
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
    public partial class girişform : Form
    {
        public girişform()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-T0T772B\\;Initial Catalog=Şantiye_personel;Integrated Security=True");
        private void buttongiris_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand grskmt = new SqlCommand("Select * From table_yonetici where kullanıcıad=@w1 and şifre=@w2", baglanti);
            grskmt.Parameters.AddWithValue("@w1", textBoxkullanıcıad.Text);
            grskmt.Parameters.AddWithValue("@w2", textBoxsifre.Text);
            SqlDataReader dtrdr = grskmt.ExecuteReader();
            if (dtrdr.Read())
            {
                Form1 frm = new Form1();
                frm.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre",":(",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            baglanti.Close();
        }

        private void girişform_Load(object sender, EventArgs e)
        {

        }
    }
}
