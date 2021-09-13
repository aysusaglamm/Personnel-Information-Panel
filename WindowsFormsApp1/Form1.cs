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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void list()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Table_StaffInfo",bglnt.connect2());
            da.Fill(dt);
            dataGridView2.DataSource = dt;

            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select * from Table_JTitle", bglnt.connect2());
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;


        }
        void read()
        {
            //Combobox'a meslek ekleme,çıkarma
            comboBoxjob.Items.Clear();
            SqlCommand komut2 = new SqlCommand("Select JobTitle from Table_JTitle", bglnt.connect2());
            SqlDataReader dr = komut2.ExecuteReader();
            while (dr.Read())
            {
                comboBoxjob.Items.Add(dr[0]);

            }
            
        }
        void clean()
        {
            textid.Text = " ";
            textname.Text = " ";
            textsname.Text = " ";
            maskedTc.Text = " ";
            comboBoxcity.Text = " ";
            comboBoxjob.Text = " ";
            maskedTextBoxsalary.Text = " ";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }
        SqlConnect bglnt = new SqlConnect();
        public string durum;

        private void Form1_Load(object sender, EventArgs e)
        {
            list();

        }

        private void button_add2_Click(object sender, EventArgs e)
        {
            
            SqlCommand komut = new SqlCommand("Insert into Table_JTitle (JobTitle) values (@p1)", bglnt.connect2());
            komut.Parameters.AddWithValue("@p1", textBoxjob.Text);
            komut.ExecuteNonQuery();
            bglnt.connect2().Close();
            MessageBox.Show("Profession added","Information" ,MessageBoxButtons.OK, MessageBoxIcon.Information);
            list();
            read();
            
           
        }

        private void button_remove2_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from Table_JTitle where ID=@m1", bglnt.connect2());
            komut.Parameters.AddWithValue("@m1", textBoxidd.Text);
            komut.ExecuteNonQuery();
            bglnt.connect2().Close();
            MessageBox.Show("Profession removed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            list();
            read();

        }

        private void button_update2_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Table_JTitle set JobTitle=@p1 where ID=@p2", bglnt.connect2());
            komut.Parameters.AddWithValue("@p1", textBoxjob.Text);
            komut.Parameters.AddWithValue("@p2", textBoxidd.Text);
            komut.ExecuteNonQuery();
            bglnt.connect2().Close();
            MessageBox.Show("Profession updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            list();
            read();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridView1.SelectedCells[0].RowIndex;
            textBoxidd.Text = dataGridView1.Rows[selected].Cells[0].Value.ToString();
            textBoxjob.Text = dataGridView1.Rows[selected].Cells[1].Value.ToString();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Insert into Table_StaffInfo (StaffName,StaffSurname,StaffTC,StaffCity,StaffJTitle,StaffSalary,StaffMartialStat) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)",bglnt.connect2());
            komut.Parameters.AddWithValue("@p1", textname.Text);
            komut.Parameters.AddWithValue("@p2", textsname.Text);
            komut.Parameters.AddWithValue("@p3", maskedTc.Text);
            komut.Parameters.AddWithValue("@p4", comboBoxcity.Text);
            komut.Parameters.AddWithValue("@p5", comboBoxjob.Text);
            komut.Parameters.AddWithValue("@p6", maskedTextBoxsalary.Text);
            komut.Parameters.AddWithValue("@p7", durum);
            komut.ExecuteNonQuery();
            bglnt.connect2().Close();
            MessageBox.Show("Staff added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            list();
            read();
            clean();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            durum ="1";        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            durum = "0";
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridView2.SelectedCells[0].RowIndex;
            textid.Text = dataGridView2.Rows[selected].Cells[0].Value.ToString();
            textname.Text = dataGridView2.Rows[selected].Cells[1].Value.ToString();
            textsname.Text = dataGridView2.Rows[selected].Cells[2].Value.ToString();
            maskedTc.Text = dataGridView2.Rows[selected].Cells[3].Value.ToString();
            comboBoxcity.Text = dataGridView2.Rows[selected].Cells[4].Value.ToString();
            comboBoxjob.Text = dataGridView2.Rows[selected].Cells[5].Value.ToString();
            maskedTextBoxsalary.Text = dataGridView2.Rows[selected].Cells[6].Value.ToString();
            if (dataGridView2.Rows[selected].Cells[7].Value.ToString() == "True" )
            {
                radioButton1.Checked = true;
            }
            else
            {
                radioButton2.Checked = true;
            }

        }

        private void button_remove_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from Table_StaffInfo where StaffID=@m1", bglnt.connect2());
            komut.Parameters.AddWithValue("@m1", textid.Text);
            komut.ExecuteNonQuery();
            bglnt.connect2().Close();
            MessageBox.Show("Staff removed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            list();
            read();
            clean();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Table_StaffInfo set StaffName=@p1,StaffSurname=@p2,StaffTC=@p3,StaffCity=@p4,StaffJTitle=@p5,StaffSalary=@p6,StaffMartialStat=@p7 where StaffID=@p8", bglnt.connect2());
            komut.Parameters.AddWithValue("@p1", textname.Text);
            komut.Parameters.AddWithValue("@p2", textsname.Text);
            komut.Parameters.AddWithValue("@p3", maskedTc.Text);
            komut.Parameters.AddWithValue("@p4", comboBoxcity.Text);
            komut.Parameters.AddWithValue("@p5", comboBoxjob.Text);
            komut.Parameters.AddWithValue("@p6", maskedTextBoxsalary.Text);
            komut.Parameters.AddWithValue("@p7", durum);
            komut.Parameters.AddWithValue("@p8", textid.Text);
            komut.ExecuteNonQuery();
            bglnt.connect2().Close();
            MessageBox.Show("Staff updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            list();
            read();
            clean();
        }

        private void button_stat_Click(object sender, EventArgs e)
        {
            Statistics gecis = new Statistics();
            gecis.Show();
            this.Hide();
        }

        private void button_graph_Click(object sender, EventArgs e)
        {
            Graphs gecis = new Graphs();
            gecis.Show();
            this.Hide();

        }

        private void button_search_Click(object sender, EventArgs e)
        {
            /*SqlCommand komut = new SqlCommand("Select * from Table_StaffInfo where StaffName=@p1", bglnt.connect2());
            komut.Parameters.AddWithValue("@p1", textBoxsearch.Text);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            da.Fill(dt);
            dataGridView2.DataSource = dt; */   /* İsmi ve soyismi tamamen yazman gerekiyor. */

            SqlCommand komut = new SqlCommand("Select * from Table_StaffInfo where StaffName like '%" + textBoxsearch.Text + "%' or StaffSurname like '%" + textBoxsearch.Text + "%'", bglnt.connect2());
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(komut);
            da1.Fill(dt1);
            dataGridView2.DataSource = dt1;

        }
    }
}
