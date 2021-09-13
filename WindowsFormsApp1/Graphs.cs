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
    public partial class Graphs : Form
    {
        public Graphs()
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

        private void Graphs_Load(object sender, EventArgs e)
        {
            //Personnel Cities
            SqlCommand komut = new SqlCommand("Select StaffCity, COUNT(*) from Table_StaffInfo group by StaffCity", bglnt.connect2());
            SqlDataReader dr1 = komut.ExecuteReader();
            while (dr1.Read())
            {
                chart1.Series["Cities"].Points.AddXY(dr1[0], dr1[1]);
            }
            bglnt.connect2().Close();

            //Meslek-Maaş Ortalaması

            SqlCommand komut2 = new SqlCommand("Select StaffJTitle,Avg(StaffSalary) from Table_StaffInfo group by StaffJTitle", bglnt.connect2());

            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                chart2.Series["Profession-Salary"].Points.AddXY(dr2[0], dr2[1]);
            }
            bglnt.connect2().Close();
        }

          
    }
}
