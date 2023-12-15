using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CRUD
{
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
            loadEmployee();
        }
        private const string connectionString = "Data Source=DESKTOP-886NS64\\SQLEXPRESS;Initial Catalog=AreaAcademicaBn;Integrated Security=True;"; // Reemplaza con tu cadena de conexión

        private void loadEmployee()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT s.idStudent, s.name, s.lastName, s.middleName, s.dateOfBirth, s.gender, s.address, s.phoneNumber, s.email, s.status AS StudentStatus, sp.description AS StudyPlanDescription FROM Student s INNER JOIN StudyPlan sp ON s.idPlan = sp.idPlan WHERE s.status = 1";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
            }



            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT idPlan, description FROM StudyPlan WHERE status =1";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable combotable = new DataTable();
                comboBox1.Items.Clear();
                adapter.Fill(combotable);
                foreach (DataRow row in combotable.Rows)
                {
                    string supplierInfos = $"{row["idPlan"]} - {row["description"]}";
                    comboBox1.Items.Add(supplierInfos);

                }

            }

        }
        private void LoadDataFromGrid()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                txtName.Text = selectedRow.Cells["name"].Value.ToString();
                txtlastname.Text = selectedRow.Cells["lastName"].Value.ToString();
                txtgender.Text = selectedRow.Cells["middleName"].Value.ToString();
                dataGridView1.Text = selectedRow.Cells["dateOfBirth"].Value.ToString();
                txtphonenumer.Text = selectedRow.Cells["gender"].Value.ToString();
                txtaddress.Text = selectedRow.Cells["address"].Value.ToString();
                txtemail.Text = selectedRow.Cells["phoneNumber"].Value.ToString();
                txtmaritalstatus.Text = selectedRow.Cells["email"].Value.ToString();
                chkStatus.Checked = Convert.ToBoolean(selectedRow.Cells["StudentStatus"].Value);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string ReportInfo = comboBox1.SelectedItem.ToString();
            int idContract = 0;

            // Obtener el EmployeeID de ReportInfo
            string[] reportInfoParts = ReportInfo.Split('-');
            if (reportInfoParts.Length >= 2)
            {
                int.TryParse(reportInfoParts[0].Trim(), out idContract);
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Student (name, lastName, middleName, dateOfBirth , gender, address, phoneNumber, email, idPlan, status) " +
                               "VALUES (@name, @lastName,@middleName, @dateOfBirth, @gender, @address,@phoneNumber, @email, @idApplication, @status)";

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@lastName", txtlastname.Text);
                cmd.Parameters.AddWithValue("@middleName", txtgender.Text);
                cmd.Parameters.AddWithValue("@dateOfBirth", dateTimePicker1.Text);
                cmd.Parameters.AddWithValue("@gender", txtgender.Text);
                cmd.Parameters.AddWithValue("@address", txtaddress.Text);
                cmd.Parameters.AddWithValue("@phoneNumber", txtName.Text);
                cmd.Parameters.AddWithValue("@email", txtemail.Text);
                cmd.Parameters.AddWithValue("@idApplication", idContract);
                cmd.Parameters.AddWithValue("@status", chkStatus.Checked);
                cmd.ExecuteNonQuery();
                loadEmployee();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {


            int departmentId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["idStudent"].Value);

            string ReportInfo = comboBox1.SelectedItem.ToString();
            int idStudent = 0;

            // Obtener el EmployeeID de ReportInfo
            string[] reportInfoParts = ReportInfo.Split('-');
            if (reportInfoParts.Length >= 2)
            {
                int.TryParse(reportInfoParts[0].Trim(), out idStudent);
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE Student SET name = @name, lastName = @lastName, middleName = @middleName, dateOfBirth  = @dateOfBirth , gender  = @gender , address = @address, phoneNumber = @phoneNumber, email  = @email,idPlan = @idPlan, status = @status " +
               "WHERE idStudent = @idEmployee";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@idEmployee", departmentId);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@lastName", txtlastname.Text);
                cmd.Parameters.AddWithValue("@middleName", txtgender.Text);
                cmd.Parameters.AddWithValue("@dateOfBirth", dateTimePicker1.Text);
                cmd.Parameters.AddWithValue("@gender", txtphonenumer.Text);
                cmd.Parameters.AddWithValue("@address", txtaddress.Text);
                cmd.Parameters.AddWithValue("@phoneNumber", txtemail.Text);
                cmd.Parameters.AddWithValue("@email", txtmaritalstatus.Text);
                cmd.Parameters.AddWithValue("@idPlan", idStudent);
                cmd.Parameters.AddWithValue("@status", chkStatus.Checked);
                cmd.ExecuteNonQuery();
                loadEmployee();

            }





        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadDataFromGrid();

        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int departmentId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["idStudent"].Value);

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "Update Student set status = 0 WHERE idStudent = @idStudent";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@idStudent", departmentId);

                    cmd.ExecuteNonQuery();
                    loadEmployee();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un departamento para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MM/dd/yyyy";

        }


    }
}
