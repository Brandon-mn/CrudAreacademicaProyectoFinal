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
using System.Security.Cryptography;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CRUD
{
    public partial class Class : Form
    {
        public Class()
        {
            InitializeComponent();
        }
        private const string connectionString = "Data Source=DESKTOP-886NS64\\SQLEXPRESS;Initial Catalog=AreaAcademicaBn;Integrated Security=True;"; // Reemplaza con tu cadena de conexión

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
                string query = "SELECT Class.idClass,Class.idGroup,Groupp.groupName,Class.idEmployee,Employee.name AS EmployeeName,Employee.lastName AS EmployeeLastName,Class.idSubject, Subject.name AS SubjectName,Class.idClassroom,Classroom.name AS ClassroomName FROM Class INNER JOIN Groupp ON Class.idGroup = Groupp.idGroup INNER JOIN Employee ON Class.idEmployee = Employee.idEmployee INNER JOIN Subject ON Class.idSubject = Subject.idSubject INNER JOIN Classroom ON Class.idClassroom = Classroom.idClassroom WHERE Class.status = 1;\r\n";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT groupName, idGroup FROM Groupp WHERE status =1";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable combotable = new DataTable();
                comboBox4.Items.Clear();
                adapter.Fill(combotable);
                foreach (DataRow row in combotable.Rows)
                {
                    string supplierInfo = $"{row["idGroup"]} - {row["groupName"]}";
                    comboBox4.Items.Add(supplierInfo);
                }
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT name, idEmployee FROM Employee WHERE status =1";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable combotableapp = new DataTable();
                comboBox3.Items.Clear();
                adapter.Fill(combotableapp);
                foreach (DataRow row in combotableapp.Rows)
                {
                    string supplierInfos = $"{row["idEmployee"]} - {row["name"]}";
                    comboBox3.Items.Add(supplierInfos);
                }
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT name, idSubject FROM Subject WHERE status =1";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable combotableapp = new DataTable();
                comboBox1.Items.Clear();
                adapter.Fill(combotableapp);
                foreach (DataRow row in combotableapp.Rows)
                {
                    string supplierInfos = $"{row["idSubject"]} - {row["name"]}";
                    comboBox1.Items.Add(supplierInfos);
                }
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT name, idClassroom FROM Classroom WHERE status =1";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable combotableapp = new DataTable();
                comboBox2.Items.Clear();
                adapter.Fill(combotableapp);
                foreach (DataRow row in combotableapp.Rows)
                {
                    string supplierInfos = $"{row["idClassroom"]} - {row["name"]}";
                    comboBox2.Items.Add(supplierInfos);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ReportInfo = comboBox4.SelectedItem.ToString();
            int idStudent = 0;

            // Obtener el EmployeeID de ReportInfo
            string[] reportInfoParts = ReportInfo.Split('-');
            if (reportInfoParts.Length >= 2)
            {
                int.TryParse(reportInfoParts[0].Trim(), out idStudent);
            }

            string Applicationcb = comboBox3.SelectedItem.ToString();
            int idApplication = 0;

            // Obtener el EmployeeID de ReportInfo
            string[] reportInfoPartss = Applicationcb.Split('-');
            if (reportInfoPartss.Length >= 2)
            {
                int.TryParse(reportInfoPartss[0].Trim(), out idApplication);
            }
            string Subjectcb = comboBox1.SelectedItem.ToString();
            int idSubject = 0;

            // Obtener el EmployeeID de ReportInfo
            string[] reportInfoPartsss = Subjectcb.Split('-');
            if (reportInfoPartsss.Length >= 2)
            {
                int.TryParse(reportInfoPartsss[0].Trim(), out idSubject);
            }
            string Classroomcb = comboBox2.SelectedItem.ToString();
            int idClassroom = 0;

            // Obtener el EmployeeID de ReportInfo
            string[] reportInfoPartssss = Classroomcb.Split('-');
            if (reportInfoPartssss.Length >= 2)
            {
                int.TryParse(reportInfoPartssss[0].Trim(), out idClassroom);
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Class(idGroup, idEmployee, idSubject, idClassroom, status) VALUES (@idGroup, @idEmployee, @idSubject, @idClassroom, @status)";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@idGroup", idStudent);
                cmd.Parameters.AddWithValue("@idEmployee", idApplication);
                cmd.Parameters.AddWithValue("@idSubject", idSubject);
                cmd.Parameters.AddWithValue("@idClassroom", idClassroom);
                cmd.Parameters.AddWithValue("@status", chkStatus.Checked);
                cmd.ExecuteNonQuery();
                LoadAcademicAward();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int departmentId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["idClass"].Value);
                string ReportInfo = comboBox4.SelectedItem.ToString();
                int idStudent = 0;

                // Obtener el EmployeeID de ReportInfo
                string[] reportInfoParts = ReportInfo.Split('-');
                if (reportInfoParts.Length >= 2)
                {
                    int.TryParse(reportInfoParts[0].Trim(), out idStudent);
                }

                string Applicationcb = comboBox3.SelectedItem.ToString();
                int idApplication = 0;

                // Obtener el EmployeeID de ReportInfo
                string[] reportInfoPartss = Applicationcb.Split('-');
                if (reportInfoPartss.Length >= 2)
                {
                    int.TryParse(reportInfoPartss[0].Trim(), out idApplication);
                }
                string Subjectcb = comboBox1.SelectedItem.ToString();
                int idSubject = 0;

                // Obtener el EmployeeID de ReportInfo
                string[] reportInfoPartsss = Subjectcb.Split('-');
                if (reportInfoPartsss.Length >= 2)
                {
                    int.TryParse(reportInfoPartsss[0].Trim(), out idSubject);
                }
                string Classroomcb = comboBox2.SelectedItem.ToString();
                int idClassroom = 0;

                // Obtener el EmployeeID de ReportInfo
                string[] reportInfoPartssss = Classroomcb.Split('-');
                if (reportInfoPartssss.Length >= 2)
                {
                    int.TryParse(reportInfoPartssss[0].Trim(), out idClassroom);
                }
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE Class SET idGroup = @idGroup, idEmployee = @idEmployee, idSubject = @idSubject, idClassroom = @idClassroom, status = @status WHERE idClass = @idClass;\r\n";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@idClass", departmentId);
                    cmd.Parameters.AddWithValue("@idGroup", idStudent);
                    cmd.Parameters.AddWithValue("@idEmployee", idApplication);
                    cmd.Parameters.AddWithValue("@idSubject", idStudent);
                    cmd.Parameters.AddWithValue("@idClassroom", idClassroom);
                    cmd.Parameters.AddWithValue("@status", chkStatus.Checked);
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
                comboBox4.SelectedValue = selectedRow.Cells["idGroup"].Value;
                comboBox3.SelectedValue = selectedRow.Cells["idEmployee"].Value;
                comboBox1.SelectedValue = selectedRow.Cells["idSubject"].Value;
                comboBox2.SelectedValue = selectedRow.Cells["idClassroom"].Value;
                // textBox1.Text = selectedRow.Cells["idClass"].Value.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int departmentId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["idClass"].Value);

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "Update Class set status = 0 WHERE idClass = @idClass";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@idClass", departmentId);
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
