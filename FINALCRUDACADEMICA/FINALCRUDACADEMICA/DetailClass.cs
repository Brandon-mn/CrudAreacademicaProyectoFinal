using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD
{
    public partial class DetailClass : Form
    {
        public DetailClass()
        {
            InitializeComponent();
        }
        private const string connectionString = "Data Source=DESKTOP-886NS64\\SQLEXPRESS;Initial Catalog=AreaAcademicaBn;Integrated Security=True;"; // Reemplaza con tu cadena de conexión

        private void AcademicDiploma_Load(object sender, EventArgs e)
        {
            LoadAcademicAward();
        }
        private void LoadAcademicAward()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "Select DetailClass.idDetailClass, DetailClass.startTime, DetailClass.endTime, DetailClass.days, DetailClass.status,\r\n    DetailClass.idClass, Class.idGroup, Groupp.groupName, Class.idEmployee, Employee.name AS EmployeeName,Employee.lastName AS EmployeeLastName,\r\n    Class.idSubject,Subject.name AS SubjectName,Class.idClassroom,Classroom.name AS ClassroomName FROM DetailClass\r\nINNER JOIN Class ON DetailClass.idClass = Class.idClass INNER JOIN Groupp ON Class.idGroup = Groupp.idGroup\r\nINNER JOIN Employee ON Class.idEmployee = Employee.idEmployee INNER JOIN Subject ON Class.idSubject = Subject.idSubject\r\nINNER JOIN Classroom ON Class.idClassroom = Classroom.idClassroom WHERE DetailClass.status = 1;";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT idGroup, idClass FROM Class WHERE status =1";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable combotable = new DataTable();
                comboBox1.Items.Clear();
                adapter.Fill(combotable);
                foreach (DataRow row in combotable.Rows)
                {
                    string supplierInfo = $"{row["idClass"]} - {row["idGroup"]}";
                    comboBox1.Items.Add(supplierInfo);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
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
                string query = "INSERT INTO DetailClass (startTime, endTime, days, status, idClass) " +
               "VALUES (@startTime, @endTime, @days, @status, @idClass)";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@days", txtDescription.Text);
                cmd.Parameters.AddWithValue("@startTime", textBox1.Text);
                cmd.Parameters.AddWithValue("@endTime", textBox2.Text);
                cmd.Parameters.AddWithValue("@idClass", idStudent);
                cmd.Parameters.AddWithValue("@Status", chkStatus.Checked);
                cmd.ExecuteNonQuery();
                LoadAcademicAward();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int departmentId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["idDetailClass"].Value);

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
                    string query = "UPDATE DetailClass SET startTime = @startTime, endTime = @endTime, days = @days, status = @status, idClass = @idClass " +
               "WHERE idDetailClass = @idDetailClass";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@idDetailClass", departmentId);
                    cmd.Parameters.AddWithValue("@days", txtDescription.Text);
                    cmd.Parameters.AddWithValue("@startTime", textBox1.Text);
                    cmd.Parameters.AddWithValue("@endTime", textBox2.Text);
                    cmd.Parameters.AddWithValue("@idClass", idStudent);
                    cmd.Parameters.AddWithValue("@Status", chkStatus.Checked);
                    cmd.ExecuteNonQuery();
                    LoadAcademicAward();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un departamento para actualizar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadDataFromGrid()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                textBox1.Text = selectedRow.Cells["startTime"].Value.ToString();
                textBox2.Text = selectedRow.Cells["startTime"].Value.ToString();
                txtDescription.Text = selectedRow.Cells["days"].Value.ToString();
                comboBox1.SelectedValue = selectedRow.Cells["idClass"].Value;
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
                int conferenceId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["idDetailClass"].Value);
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "Update DetailClass set status = 0 WHERE idDetailClass = @idDetailClass";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@idDetailClass", conferenceId);

                    cmd.ExecuteNonQuery();
                    LoadAcademicAward();
                }
            }
            else
            {
                MessageBox.Show("Seleccione una conferencia para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
