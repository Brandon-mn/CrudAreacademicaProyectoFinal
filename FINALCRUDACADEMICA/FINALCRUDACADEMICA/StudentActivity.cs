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
    public partial class StudentActivity : Form
    {
        public StudentActivity()
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
                string query = "SELECT SA.idStudentActivity, SA.status, SA.idStudent, S.name AS StudentName, S.lastName AS StudentLastName,\r\nSA.idActivity, A.activityName FROM StudentActivity SA INNER JOIN Student S ON SA.idStudent = S.idStudent\r\nINNER JOIN Activity A ON SA.idActivity = A.idActivity WHERE SA.status = 1;";
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
                string query = "SELECT activityName, idActivity FROM Activity WHERE status =1";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable combotableapp = new DataTable();
                comboBox2.Items.Clear();
                adapter.Fill(combotableapp);
                foreach (DataRow row in combotableapp.Rows)
                {
                    string supplierInfos = $"{row["idActivity"]} - {row["activityName"]}";
                    comboBox2.Items.Add(supplierInfos);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
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
                string query = "INSERT INTO StudentActivity (idStudent, idActivity, status) VALUES (@idStudent, @idActivity, @status)";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@idStudent", idSubject);
                cmd.Parameters.AddWithValue("@idActivity", idClassroom);
                cmd.Parameters.AddWithValue("@status", chkStatus.Checked);
                cmd.ExecuteNonQuery();
                LoadAcademicAward();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int departmentId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["idStudentActivity"].Value);
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
                    string query = "UPDATE StudentActivity SET idStudent = @idStudent, idActivity = @idActivity, status = @status WHERE idStudentActivity = @idStudentActivity";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@idStudentActivity", departmentId);
                    cmd.Parameters.AddWithValue("@idStudent", idSubject);
                    cmd.Parameters.AddWithValue("@idActivity", idClassroom);
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
                comboBox1.SelectedValue = selectedRow.Cells["idStudent"].Value;
                comboBox2.SelectedValue = selectedRow.Cells["idActivity"].Value;
                // textBox1.Text = selectedRow.Cells["idClass"].Value.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int departmentId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["idStudentActivity"].Value);

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "Update StudentActivity set status = 0 WHERE idStudentActivity = @idStudentActivity";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@idStudentActivity", departmentId);
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
