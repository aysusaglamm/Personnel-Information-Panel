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

namespace WindowsFormsApp1
{
    public partial class UserEntry : Form
    {
        public UserEntry()
        {
            InitializeComponent();
        }
        SqlConnect bglnt = new SqlConnect();

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from Table_UserEntry where UserName=@p1 and UserPasswd=@m1", bglnt.connect2());
            komut.Parameters.AddWithValue("@p1", textBox2.Text);
            komut.Parameters.AddWithValue("@m1", textBox3.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Form1 gecis = new Form1();
                gecis.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Wrong username or password");
            textBox2.Text = "";
            textBox3.Text = "";

        }
    }
}
