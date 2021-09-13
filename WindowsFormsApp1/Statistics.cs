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
    public partial class Statistics : Form
    {
        public Statistics()
        {
            InitializeComponent();
        }

        SqlConnect bglnt = new SqlConnect();

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 gecis = new Form1();
            gecis.Show();
            this.Hide();

        }

        private void Statistics_Load(object sender, EventArgs e)
        {
            //Total personnel count

            SqlCommand komut1 = new SqlCommand("Select count(*) from Table_StaffInfo",bglnt.connect2());
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read()) 
            {
                label8.Text = dr1[0].ToString();
            }
            bglnt.connect2().Close();

            //Married personnel count

            SqlCommand komut2 = new SqlCommand("Select count(*) from Table_StaffInfo where StaffMartialStat=1", bglnt.connect2());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                label9.Text = dr2[0].ToString();
            }
            bglnt.connect2().Close();

            //Single personnel count
            SqlCommand komut3 = new SqlCommand("Select count(*) from Table_StaffInfo where StaffMartialStat=0", bglnt.connect2());
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                label10.Text = dr3[0].ToString();
            }
            bglnt.connect2().Close();

            //Total profession count -- AYNI MESLEKLERİ ALMAMASI GEREKTİĞİ İÇİN
            SqlCommand komut4 = new SqlCommand("Select count(distinct(JobTitle)) from Table_JTitle", bglnt.connect2());
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                label11.Text = dr4[0].ToString();
            }
            bglnt.connect2().Close();

            //Totat city count
            SqlCommand komut5 = new SqlCommand("Select count(distinct(StaffCity)) from Table_StaffInfo", bglnt.connect2());
            SqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                label12.Text = dr5[0].ToString();
            }
            bglnt.connect2().Close();

            //Total Salary
            SqlCommand komut6 = new SqlCommand("Select sum(StaffSalary) from Table_StaffInfo", bglnt.connect2());
            SqlDataReader dr6 = komut6.ExecuteReader();
            while (dr6.Read())
            {
                label13.Text = dr6[0].ToString();
            }
            bglnt.connect2().Close();

            //Average Salary

            SqlCommand komut7 = new SqlCommand("Select avg(StaffSalary) from Table_StaffInfo", bglnt.connect2());
            SqlDataReader dr7 = komut7.ExecuteReader();
            while (dr7.Read())
            {
                label14.Text = dr7[0].ToString();
            }
            bglnt.connect2().Close();

        }
    }
}
