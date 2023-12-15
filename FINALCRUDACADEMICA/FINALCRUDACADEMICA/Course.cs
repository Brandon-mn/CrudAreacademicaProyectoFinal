using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CRUD
{
    public partial class Course : Form
    {
        public Course()
        {
            InitializeComponent();
        }
        private const string connectionString = "Data Source=DESKTOP-886NS64\\SQLEXPRESS; Initial Catalog=AreaAcademicaBn;Integrated Security=True;"; // Reemplaza con tu cadena de conexión

        private void AcademicAward_Load(object sender, EventArgs e)
        {
            LoadAcademicAward();

        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadDataFromGrid();
        }

        private void LoadAcademicAward()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT Course.*, Student.name AS StudentName, Student.lastName AS StudentLastName,Employee.name AS EmployeeName,Employee.lastName AS EmployeeLastName\r\nFROM Course LEFT JOIN Student ON Course.idStudent = Student.idStudent LEFT JOIN Employee ON Course.idEmployee = Employee.idEmployee;";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT name, idStudent FROM Student WHERE status =1";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable combotable = new DataTable();
                comboBox1.Items.Clear();
                adapter.Fill(combotable);
                foreach (DataRow row in combotable.Rows)
                {
                    string supplierInfo = $"{row["idStudent"]} - {row["name"]}";
                    comboBox1.Items.Add(supplierInfo);

                }

            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT name, idEmployee FROM Employee WHERE status =1";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable combotableapp = new DataTable();
                comboBox2.Items.Clear();
                adapter.Fill(combotableapp);
                foreach (DataRow row in combotableapp.Rows)
                {
                    string supplierInfos = $"{row["idEmployee"]} - {row["name"]}";
                    comboBox2.Items.Add(supplierInfos);
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

            string Applicationcb = comboBox2.SelectedItem.ToString();
            int idApplication = 0;

            // Obtener el EmployeeID de ReportInfo
            string[] reportInfoPartss = Applicationcb.Split('-');
            if (reportInfoPartss.Length >= 2)
            {
                int.TryParse(reportInfoPartss[0].Trim(), out idApplication);
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Course (courseName, credits, description, enrollmentCapacity, idStudent, idEmployee) " +
               "VALUES (@courseName, @credits, @description, @enrollmentCapacity, @idStudent, @idEmployee)";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@courseName", textBox1.Text);
                cmd.Parameters.AddWithValue("@credits", Convert.ToInt32(txtDescription.Text));
                cmd.Parameters.AddWithValue("@description", txtDirector.Text);
                cmd.Parameters.AddWithValue("@enrollmentCapacity", Convert.ToInt32(txtPhone.Text));
                //cmd.Parameters.AddWithValue("@name", textBox2.Text);
                cmd.Parameters.AddWithValue("@idStudent", idStudent);
                cmd.Parameters.AddWithValue("@idEmployee", idApplication);
                cmd.ExecuteNonQuery();
                LoadAcademicAward();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int departmentId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["idCourse"].Value);

                string ReportInfo = comboBox1.SelectedItem.ToString();
                int idStudent = 0;

                // Obtener el EmployeeID de ReportInfo
                string[] reportInfoParts = ReportInfo.Split('-');
                if (reportInfoParts.Length >= 2)
                {
                    int.TryParse(reportInfoParts[0].Trim(), out idStudent);
                }
                string Applicationcb = comboBox2.SelectedItem.ToString();
                int idApplication = 0;

                // Obtener el EmployeeID de ReportInfo
                string[] reportInfoPartss = Applicationcb.Split('-');
                if (reportInfoPartss.Length >= 2)
                {
                    int.TryParse(reportInfoPartss[0].Trim(), out idApplication);
                }
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE Course SET courseName = @courseName, credits = @credits, description = @description, enrollmentCapacity = @enrollmentCapacity, idStudent = @idStudent, idEmployee = @idEmployee WHERE idCourse = @idCourse;\r\n";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@idCourse", departmentId);
                    cmd.Parameters.AddWithValue("@courseName", textBox1.Text);
                    cmd.Parameters.AddWithValue("@credits", Convert.ToInt32(txtDescription.Text));
                    cmd.Parameters.AddWithValue("@description", txtDirector.Text);
                    cmd.Parameters.AddWithValue("@enrollmentCapacity", Convert.ToInt32(txtPhone.Text));
                    //cmd.Parameters.AddWithValue("@name", textBox2.Text);
                    cmd.Parameters.AddWithValue("@idStudent", idStudent);
                    cmd.Parameters.AddWithValue("@idEmployee", idApplication);
                    cmd.ExecuteNonQuery();
                    LoadAcademicAward();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un curso para actualizar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadDataFromGrid()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                textBox1.Text = selectedRow.Cells["courseName"].Value.ToString();
                txtDescription.Text = selectedRow.Cells["credits"].Value.ToString();
                txtDirector.Text = selectedRow.Cells["description"].Value.ToString();
                txtPhone.Text = selectedRow.Cells["enrollmentCapacity"].Value.ToString();
                // textBox2.Text = selectedRow.Cells["name"].Value.ToString();
                comboBox1.SelectedValue = selectedRow.Cells["idStudent"].Value; // Ajusta según tu interfaz
                comboBox2.SelectedValue = selectedRow.Cells["idEmployee"].Value; // Ajusta según tu interfaz
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int departmentId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["idCourse"].Value);

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM Course WHERE idCourse = @idCourse";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@idCourse", departmentId);

                    cmd.ExecuteNonQuery();
                    LoadAcademicAward();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un departamento para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
