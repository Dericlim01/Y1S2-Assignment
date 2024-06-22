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
    public partial class TrainingSchedule : Form
    {
        public string name;
        public string role;
        public string ab;

        public TrainingSchedule()
        {
            InitializeComponent();
        }

        public TrainingSchedule(string n, string r)
        {
            InitializeComponent();
            name = n; role = r;
        }

        public TrainingSchedule(string n, string r, string a)
        {
            InitializeComponent();
            name = n; role = r; ab = a;
            btnAdd.Hide();
            btnEdit.Hide();
            btnDelete.Hide();
        }

        private void TrainingSchedule_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'swimmingclubdbDataSet2.Schedule' table. You can move, or remove it, as needed.
            this.scheduleTableAdapter.Fill(this.swimmingclubdbDataSet2.Schedule);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (scheduleDataGridView.SelectedRows.Count > 0)
            {
                int rowIndex = scheduleDataGridView.SelectedRows[0].Index;
                int id = Convert.ToInt32(scheduleDataGridView.Rows[rowIndex].Cells[0].Value);

                scheduleDataGridView.Rows.RemoveAt(rowIndex);

                using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["swimmingclubdb"].ToString()))
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand("DELETE FROM Schedule WHERE Id = @Id", cn))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Row deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string Level = CBLevel.Text;
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["swimmingclubdb"].ToString()))
            {
                if (cn.State == ConnectionState.Closed)
                    cn.Open();
                using (DataTable dt = new DataTable("Orders"))
                {
                    using (SqlCommand cmd = new SqlCommand("select date, time, level, remarks from Schedule where date between @fromdate and @todate and Level = @Level", cn))
                    {
                        cmd.Parameters.AddWithValue("@fromdate", DTPickerFrom.Text);
                        cmd.Parameters.AddWithValue("@todate", DTPickerTO.Text);
                        cmd.Parameters.AddWithValue("@Level", Level);
                        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                        sqlDataAdapter.Fill(dt);
                        scheduleDataGridView.DataSource = dt;
                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddSchedule add_sche = new AddSchedule();
            add_sche.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditSchedule edit_sche = new EditSchedule();
            edit_sche.ShowDialog();
        }

        public void ReadDataFromDatabase()
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["swimmingclubdb"].ToString()))
            {
                con.Open();
                string query = "SELECT * FROM Schedule";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                scheduleDataGridView.DataSource = dataTable;
            }
        }

        private void btnDA_Click(object sender, EventArgs e)
        {
            ReadDataFromDatabase();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Coach back = new Coach(name, role);
            back.ShowDialog();
        }

        private void scheduleDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
