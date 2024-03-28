using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Y1S2
{
    public partial class Member : Form
    {
        // Create a field for name
        public static string name;

        static SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["swimmingclubdb"].ToString());
        public Member()
        {
            InitializeComponent();
        }

        // Constructor for login
        public Member(string n)
        {
            InitializeComponent();
            name = n;
        }

        // Initial display user profile
        private void Member_Load(object sender, EventArgs e)
        {
            lblname.Text = name;
            lbltype.Text = "Member";
        }

        private string password;

        // Add member
        private string add_member()
        {
            string status;

            connect.Open();
            SqlCommand check = new SqlCommand("select count(*) from users where username = @name", connect);
            check.Parameters.AddWithValue("@name", name);
            int count = Convert.ToInt32(check.ExecuteScalar());
            if (count > 0)
            {
                status = "This account already exist, pls create a new one or login instead.";
            }
            else
            {
                SqlCommand cmd = new SqlCommand("insert into users (username, password, role) values (@name, @password, member)", connect);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.ExecuteNonQuery();

                status = "Added Successfully.";
            }
            connect.Close();
            return status;
        }
    }
}
