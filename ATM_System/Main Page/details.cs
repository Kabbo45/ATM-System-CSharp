using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_System.Main_Page
{
    public partial class details : Form
    {
        MySqlConnection con = new MySqlConnection(sql_connection.Connection());
        private MySqlDataReader rdr;
        public string cc = original_main.x;
        public int cc2 = original_main.qwe;


        public static string name;
        public static string phone;
        public static string permanent_ad;
        public static string present_ad;
        public static int gender;
        public static int nid;
        public static string occupation;
        public static int monthly_income;
        public static string user;
        public static int pin;
        public static string ac_no;
        public static string sex;

        public details()
        {
            InitializeComponent();
            xx();
        }

        public void xx()
        {
            getdata();
            loaddata();
        }

        public void getdata()
        {
            con.Open();
            if (cc2 == 1)
            {
                MySqlCommand cmd2 = con.CreateCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "SELECT * from reg_bank where username='" + cc + "'";
                cmd2.ExecuteNonQuery();
                rdr = cmd2.ExecuteReader();
                rdr.Read();
                name = rdr.GetString("name");
                phone = rdr.GetString("phone");
                permanent_ad = rdr.GetString("permanent_ad");
                present_ad = rdr.GetString("present_ad");
                gender = rdr.GetInt32("gender");
                nid = rdr.GetInt32("nid");
                occupation = rdr.GetString("occupation");
                monthly_income = rdr.GetInt32("monthly_income");
                user = rdr.GetString("username");
                pin = rdr.GetInt32("pin");
                ac_no = rdr.GetString("ac_no");
                label20.Text = "AC No";
            }

            else if (cc2 == 2)
            {
                label20.Show();
                MySqlCommand cmd3 = con.CreateCommand();
                cmd3.CommandType = CommandType.Text;
                cmd3.CommandText = "SELECT * from reg_card where username='" + cc + "'";
                cmd3.ExecuteNonQuery();
                rdr = cmd3.ExecuteReader();
                rdr.Read();
                name = rdr.GetString("name");
                phone = rdr.GetString("phone");
                permanent_ad = rdr.GetString("permanent_ad");
                present_ad = rdr.GetString("present_ad");
                gender = rdr.GetInt32("gender");
                nid = rdr.GetInt32("nid");
                occupation = rdr.GetString("occupation");
                monthly_income = rdr.GetInt32("monthly_income");
                user = rdr.GetString("username");
                pin = rdr.GetInt32("pin");
                ac_no = rdr.GetString("card_no");
                label20.Text = "Card No";
            }
            con.Close();
        }

        public void loaddata()
        {
            q1.Text = name;
            q2.Text = phone;
            q3.Text = permanent_ad;
            q4.Text = present_ad;
            if (gender == 1)
            {
                q5.Text = "Male";
            }
            else if (gender == 2)
            {
                q5.Text = "Female";
            }
            else if (gender == 3)
            {
                q5.Text = "Others";
            }
            q6.Text = nid.ToString();
            q7.Text = occupation;
            q8.Text = monthly_income.ToString();
            q9.Text = user;
            q10.Text = ac_no;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            xx();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
