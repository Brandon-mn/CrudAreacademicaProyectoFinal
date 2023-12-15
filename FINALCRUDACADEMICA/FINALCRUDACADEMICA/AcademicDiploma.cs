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
    public partial class AcademicDiploma : Form
    {
        public AcademicDiploma()
        {
            InitializeComponent();
        }
        private const string connectionString = "Data Source=DESKTOP-886NS64\\SQLEXPRESS;Initial Catalog=AreaAcademicaBn;Integrated Security=True;"; // Reemplaza con tu cadena de conexión

        private void AcademicDiploma_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;

            dateTimePicker1.CustomFormat = "MM/dd/yyyy";
            LoadAcademicAward();
        }
        private void LoadAcademicAward()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT ad.*, s.phoneNumber, s.email FROM AcademicDiploma ad INNER JOIN Student s ON ad.idstudent = s.idStudent WHERE ad.status =1;";
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
                string query = "INSERT INTO AcademicDiploma (title, date, type, status, idstudent) " +
"VALUES (@title, @date, @type, @status, @idStudent)";


                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@title", txtDescription.Text);
                cmd.Parameters.AddWithValue("@date", dateTimePicker1.Text);
                cmd.Parameters.AddWithValue("@type", txtDirector.Text);
                cmd.Parameters.AddWithValue("@idStudent", idStudent);
                cmd.Parameters.AddWithValue("@status", chkStatus.Checked);

                cmd.ExecuteNonQuery();
                LoadAcademicAward();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int departmentId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["idAcademicDiploma"].Value);

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
                    string query = "UPDATE AcademicDiploma SET title = @title, date = @date, type = @type, status = @status, idStudent = @idStudent " +
"WHERE idAcademicDiploma = @idAcademicDiploma";


                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@idAcademicDiploma", departmentId);
                    cmd.Parameters.AddWithValue("@title", txtDescription.Text);
                    cmd.Parameters.AddWithValue("@date", dateTimePicker1.Text);
                    cmd.Parameters.AddWithValue("@type", txtDirector.Text);
                    cmd.Parameters.AddWithValue("@idStudent", idStudent);
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

                dateTimePicker1.Text = selectedRow.Cells["date"].Value.ToString();
                txtDescription.Text = selectedRow.Cells["title"].Value.ToString();
                txtDirector.Text = selectedRow.Cells["type"].Value.ToString();
                comboBox1.SelectedValue = selectedRow.Cells["idStudent"].Value;
                chkStatus.Checked = Convert.ToBoolean(selectedRow.Cells["status"].Value);
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
                int departmentId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["idAcademicDiploma"].Value);

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "Update AcademicDiploma set status = 0 WHERE idAcademicDiploma = @idDepartment";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@idDepartment", departmentId);

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
