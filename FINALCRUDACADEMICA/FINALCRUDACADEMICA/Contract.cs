using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CRUD
{
    public partial class Contract : Form
    {
        public Contract()
        {
            InitializeComponent();
            LoadPosition();
        }
        private const string connectionString = "Data Source=DESKTOP-886NS64\\SQLEXPRESS; Initial Catalog=AreaAcademicaBn;Integrated Security=True;"; // Reemplaza con tu cadena de conexión

        private void LoadPosition()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Contract WHERE status =1";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Contract (startDate, endDate, salary, contractType, status) " +
                       "VALUES (@startDate, @endDate, @salary, @contractType, @status)";

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@startDate", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@endDate", dateTimePicker2.Value);
                cmd.Parameters.AddWithValue("@salary", decimal.Parse(txtPhone.Text));
                cmd.Parameters.AddWithValue("@contractType", txtDirector.Text);
                cmd.Parameters.AddWithValue("@status", chkStatus.Checked);
                cmd.ExecuteNonQuery();
                LoadPosition();
            }
        }
        private void LoadDataFromGrid()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                dateTimePicker1.Value = Convert.ToDateTime(selectedRow.Cells["startDate"].Value);
                dateTimePicker2.Value = Convert.ToDateTime(selectedRow.Cells["endDate"].Value);
                txtDirector.Text = selectedRow.Cells["contractType"].Value.ToString();
                txtPhone.Text = selectedRow.Cells["salary"].Value.ToString();
                chkStatus.Checked = Convert.ToBoolean(selectedRow.Cells["status"].Value);
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadDataFromGrid();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int departmentId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["idContract"].Value);

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE Contract SET startDate = @startDate, endDate = @endDate, salary = @salary, contractType = @contractType, status = @status " +
                           "WHERE idContract = @idContract";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@idContract", departmentId);
                    cmd.Parameters.AddWithValue("@startDate", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@endDate", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@contractType", txtDirector.Text);
                    cmd.Parameters.AddWithValue("@salary", txtPhone.Text);
                    cmd.Parameters.AddWithValue("@status", chkStatus.Checked);
                    cmd.ExecuteNonQuery();
                    LoadPosition();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un departamento para actualizar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int departmentId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["idContract"].Value);

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE Contract SET status = 0 WHERE idContract = @idContract";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@idContract", departmentId);

                    cmd.ExecuteNonQuery();
                    LoadPosition();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un departamento para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Position_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;

            dateTimePicker1.CustomFormat = "MM/dd/yyyy";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;

            dateTimePicker2.CustomFormat = "MM/dd/yyyy";
            LoadPosition();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void chkStatus_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Contract (startDate, endDate, salary, contractType, status) " +
                       "VALUES (@startDate, @endDate, @salary, @contractType, @status)";

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@startDate", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@endDate", dateTimePicker2.Value);
                cmd.Parameters.AddWithValue("@salary", decimal.Parse(txtPhone.Text));
                cmd.Parameters.AddWithValue("@contractType", txtDirector.Text);
                cmd.Parameters.AddWithValue("@status", chkStatus.Checked);
                cmd.ExecuteNonQuery();
                LoadPosition();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int departmentId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["idContract"].Value);

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE Contract SET startDate = @startDate, endDate = @endDate, salary = @salary, contractType = @contractType, status = @status " +
                           "WHERE idContract = @idContract";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@idContract", departmentId);
                    cmd.Parameters.AddWithValue("@startDate", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@endDate", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@contractType", txtDirector.Text);
                    cmd.Parameters.AddWithValue("@salary", txtPhone.Text);
                    cmd.Parameters.AddWithValue("@status", chkStatus.Checked);
                    cmd.ExecuteNonQuery();
                    LoadPosition();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un departamento para actualizar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int departmentId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["idContract"].Value);

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE Contract SET status = 0 WHERE idContract = @idContract";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@idContract", departmentId);

                    cmd.ExecuteNonQuery();
                    LoadPosition();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un departamento para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
