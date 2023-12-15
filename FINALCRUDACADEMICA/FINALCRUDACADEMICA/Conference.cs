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
    public partial class Conference : Form
    {
        public Conference()
        {
            InitializeComponent();
        }
        private const string connectionString = "Data Source=DESKTOP-886NS64\\SQLEXPRESS;Initial Catalog=AreaAcademicaBn;Integrated Security=True;"; // Reemplaza con tu cadena de conexión

        private void AcademicDiploma_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;

            dateTimePicker1.CustomFormat = "MM/dd/yyyy";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;

            dateTimePicker2.CustomFormat = "MM/dd/yyyy";
            LoadAcademicAward();
        }
        private void LoadAcademicAward()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT Conference.*, Department.name AS DepartmentName, Department.director AS DepartmentDirector FROM Conference INNER JOIN Department ON Conference.idDepartment = Department.idDepartment;";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT name, idDepartment FROM Department WHERE status =1";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable combotable = new DataTable();
                comboBox1.Items.Clear();
                adapter.Fill(combotable);
                foreach (DataRow row in combotable.Rows)
                {
                    string supplierInfo = $"{row["idDepartment"]} - {row["name"]}";
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
                string query = "INSERT INTO Conference (nameConference, startDate, endDate, location, idDepartment) " +
               "VALUES (@nameConference, @startDate, @endDate, @location, @idDepartment)";


                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@nameConference", txtDescription.Text);
                cmd.Parameters.AddWithValue("@startDate", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@endDate", dateTimePicker2.Value);
                cmd.Parameters.AddWithValue("@location", txtDirector.Text);
                cmd.Parameters.AddWithValue("@idDepartment", idStudent);
                cmd.ExecuteNonQuery();
                LoadAcademicAward();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int departmentId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["idConference"].Value);

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
                    string query = "UPDATE Conference SET nameConference = @nameConference, startDate = @startDate, endDate = @endDate, location = @location, idDepartment = @idDepartment " +
               "WHERE idConference = @idConference";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@nameConference", txtDescription.Text); // Ajusta según tu interfaz de usuario
                    cmd.Parameters.AddWithValue("@startDate", dateTimePicker1.Value); // Ajusta según tu interfaz de usuario
                    cmd.Parameters.AddWithValue("@endDate", dateTimePicker2.Value); // Ajusta según tu interfaz de usuario
                    cmd.Parameters.AddWithValue("@location", txtDirector.Text); // Puedes ajustar según tu interfaz de usuario
                    cmd.Parameters.AddWithValue("@idDepartment", idStudent); // Ajusta según la lógica de tu aplicación, deberías tener el idDepartment disponible
                    cmd.Parameters.AddWithValue("@idConference", departmentId); // Ajusta según la lógica de tu aplicación, deberías tener el idConference disponible
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

                dateTimePicker1.Value = Convert.ToDateTime(selectedRow.Cells["startDate"].Value); // Ajusta según el nombre real de la columna
                dateTimePicker2.Value = Convert.ToDateTime(selectedRow.Cells["endDate"].Value); // Ajusta según el nombre real de la columna
                txtDescription.Text = selectedRow.Cells["nameConference"].Value.ToString(); // Ajusta según el nombre real de la columna
                txtDirector.Text = selectedRow.Cells["location"].Value.ToString(); // Ajusta según el nombre real de la columna
                comboBox1.SelectedValue = selectedRow.Cells["idDepartment"].Value; // Ajusta según el nombre real de la columna
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
                int conferenceId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["idConference"].Value);
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM Conference WHERE idConference = @idConference";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@idConference", conferenceId);

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
