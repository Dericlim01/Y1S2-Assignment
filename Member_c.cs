using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Y1S2
{
    internal class Member_c
    {
        // Create three private member field
        private string memName;
        private string email;
        private string phoneNum;
        static SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["myDB"].ToString());

        public string Email { get => email; set => email = value; }
        public string PhoneNum { get => phoneNum; set => phoneNum = value; }

        // Create a constructor
        public Member_c(string membername, string emailadd, string phonenumber)
        {
            memName = membername;
            email = emailadd;
            phoneNum = phonenumber;
        }

        // Create a constructor for login
        public Member_c(string membername)
        {
            memName = membername;
        }

        // Add Member
        public string addMember()
        {
            string status;
            connect.Open();
            // Insert data into student
            string query = "insert into member (name, email, phoneNumber) values (@name, @em, @num)";
            SqlCommand cmd = new SqlCommand(query, connect);
            cmd.Parameters.AddWithValue("@name", memName);
            cmd.Parameters.AddWithValue("@em", email);
            cmd.Parameters.AddWithValue("@num", phoneNum);

            // Insert data into users
            string query2 = "insert into users (username, password, role) values (@name, '123', 'member')";
            SqlCommand cmd2 = new SqlCommand(query2, connect);
            cmd2.Parameters.AddWithValue("@name", memName);

            cmd2.ExecuteNonQuery();
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                status = "Registration Successful.";
            }
            else
            {
                status = "Unable to register.";
            }
            connect.Close();
            return status;
        }

        // View All member
        public static ArrayList viewAll()
        {
            ArrayList nm = new ArrayList();
            connect.Open();
            SqlCommand cmd = new SqlCommand("select name from member", connect);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                nm.Add(rd.GetString(0)); // Add to arraylist
            }
            connect.Close();
            return nm;
        }

        // View Member Profile
        public static void viewProfile(Member_c o1) // object as parameter
        {
            connect.Open();
            string query = "select * from member where name = @a";
            SqlCommand cmd = new SqlCommand(query, connect);
            cmd.Parameters.AddWithValue("@a", o1.memName);

            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                o1.email = rd.GetString(2);
                o1.phoneNum = rd.GetString(3);
            }
            connect.Close();
        }

        // Update Member Profile
        public string updateProfile(string em, string num)
        {
            string status;
            connect.Open();
            string query = "update member set email = @e, phoneNumber = @p where name = @nm";
            SqlCommand cmd = new SqlCommand(query, connect);
            cmd.Parameters.AddWithValue("@e", em);
            cmd.Parameters.AddWithValue("@p", num);
            cmd.Parameters.AddWithValue("@nm", memName);

            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                status = "update successfully.";
            }
            else
            {
                status = "unable to update.";
            }
            connect.Close();
            return status;
        }
    }
}
