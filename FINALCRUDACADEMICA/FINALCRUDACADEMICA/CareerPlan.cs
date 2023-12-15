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
    public partial class CareerPlan : Form
    {
        public CareerPlan()
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
                string query = "SELECT \r\n    CareerPlan.idCareerPlan,\r\n    CareerPlan.status AS CareerPlanStatus,\r\n    Career.idCareer,\r\n    Career.careerName AS CareerName,\r\n    Career.description AS CareerDescription,\r\n    StudyPlan.idPlan,\r\n    StudyPlan.description AS PlanDescription FROM \r\n    CareerPlan\r\nINNER JOIN \r\n    Career ON CareerPlan.idCareer = Career.idCareer\r\nINNER JOIN \r\n    StudyPlan ON CareerPlan.idPlan = StudyPlan.idPlan WHERE CareerPlan.status = 1;\r\n";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT careerName, idCareer FROM Career WHERE status =1";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable combotable = new DataTable();
                comboBox1.Items.Clear();
                adapter.Fill(combotable);
                foreach (DataRow row in combotable.Rows)
                {
                    string supplierInfo = $"{row["idCareer"]} - {row["careerName"]}";
                    comboBox1.Items.Add(supplierInfo);
                }
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT description, idPlan FROM StudyPlan WHERE status =1";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable combotableapp = new DataTable();
                comboBox2.Items.Clear();
                adapter.Fill(combotableapp);
                foreach (DataRow row in combotableapp.Rows)
                {
                    string supplierInfos = $"{row["idPlan"]} - {row["description"]}";
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
                string query = "INSERT INTO CareerPlan (idCareer, idPlan, status) VALUES (@idCareer, @idPlan, @status)";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@idCareer", idSubject);
                cmd.Parameters.AddWithValue("@idPlan", idClassroom);
                cmd.Parameters.AddWithValue("@status", chkStatus.Checked);
                cmd.ExecuteNonQuery();
                LoadAcademicAward();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int departmentId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["idCareerPlan"].Value);
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
                    string query = "UPDATE CareerPlan SET idCareer = @idCareer, idPlan = @idPlan, status = @status WHERE idCareerPlan = @idCareerPlan";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@idCareerPlan", departmentId);
                    cmd.Parameters.AddWithValue("@idCareer", idSubject);
                    cmd.Parameters.AddWithValue("@idPlan", idClassroom);
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
                comboBox1.SelectedValue = selectedRow.Cells["idCareer"].Value;
                comboBox2.SelectedValue = selectedRow.Cells["idPlan"].Value;
                // textBox1.Text = selectedRow.Cells["idClass"].Value.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int departmentId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["idCareerPlan"].Value);

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "Update CareerPlan set status = 0 WHERE idCareerPlan = @idCareerPlan";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@idCareerPlan", departmentId);
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
