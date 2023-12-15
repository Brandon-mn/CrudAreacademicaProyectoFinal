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
using System.Xml.Linq;

namespace CRUD
{
    public partial class Applications : Form
    {
        public Applications()
        {
            InitializeComponent();
        }
        private const string connectionString = "Data Source=DESKTOP-886NS64\\SQLEXPRESS;Initial Catalog=AreaAcademicaBn;Integrated Security=True;"; // Reemplaza con tu cadena de conexión

        private void Application_Load(object sender, EventArgs e)
        {
            LoadApplication();
            textBox2.Format = DateTimePickerFormat.Custom;

            textBox2.CustomFormat = "MM/dd/yyyy";

            textBox5.Format = DateTimePickerFormat.Custom;

            textBox5.CustomFormat = "MM/dd/yyyy";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Application (ApplicantFirstName, ApplicantLastName, Gender, DateOfBirth, TemporalID, SchoolOfOrigin, ApplicationDate, Grade, PreferredCareer, SecondPreferredCareer, ThirdPreferredCareer, status) VALUES (@ApplicantFirstName, @ApplicantLastName, @Gender, @DateOfBirth, @TemporalID, @SchoolOfOrigin, @ApplicationDate, @Grade, @PreferredCareer, @SecondPreferredCareer, @ThirdPreferredCareer, @status) ";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@ApplicantFirstName", txtDescription.Text);
                cmd.Parameters.AddWithValue("@ApplicantLastName", txtDirector.Text);
                cmd.Parameters.AddWithValue("@Gender", textBox1.Text);
                cmd.Parameters.AddWithValue("@DateOfBirth", textBox2.Text);
                cmd.Parameters.AddWithValue("@TemporalID", textBox3.Text);
                cmd.Parameters.AddWithValue("@SchoolOfOrigin", textBox4.Text);
                cmd.Parameters.AddWithValue("@ApplicationDate", textBox5.Text);
                cmd.Parameters.AddWithValue("@Grade", textBox6.Text);
                cmd.Parameters.AddWithValue("@PreferredCareer", textBox7.Text);
                cmd.Parameters.AddWithValue("@SecondPreferredCareer", textBox8.Text);
                cmd.Parameters.AddWithValue("@ThirdPreferredCareer", textBox9.Text);
                cmd.Parameters.AddWithValue("@Status", chkStatus.Checked);

                cmd.ExecuteNonQuery();
                LoadApplication();
            }
        }
        public void LoadApplication()
        {



            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "Select *from Application WHERE status = 1";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int departmentId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["idApplication"].Value);

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE Application SET ApplicantFirstName = @name, ApplicantLastName = @description, Gender = @contractType, DateOfBirth = @salary, TemporalID = @TemporalID, SchoolOfOrigin = @SchoolOfOrigin, ApplicationDate = @ApplicationDate, Grade = @Grade, PreferredCareer = @PreferredCareer, SecondPreferredCareer = @SecondPreferredCareer, ThirdPreferredCareer = @ThirdPreferredCareer, status = @status WHERE idApplication = @idDepartment;";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@idDepartment", departmentId);
                    cmd.Parameters.AddWithValue("@ApplicantFirstName", txtDescription.Text);
                    cmd.Parameters.AddWithValue("@ApplicantLastName", txtDirector.Text);
                    cmd.Parameters.AddWithValue("@Gender", textBox1.Text);
                    cmd.Parameters.AddWithValue("@DateOfBirth", textBox2.Text);
                    cmd.Parameters.AddWithValue("@TemporalID", textBox3.Text);
                    cmd.Parameters.AddWithValue("@SchoolOfOrigin", textBox4.Text);
                    cmd.Parameters.AddWithValue("@ApplicationDate", textBox5.Text);
                    cmd.Parameters.AddWithValue("@Grade", textBox6.Text);
                    cmd.Parameters.AddWithValue("@PreferredCareer", textBox7.Text);
                    cmd.Parameters.AddWithValue("@SecondPreferredCareer", textBox8.Text);
                    cmd.Parameters.AddWithValue("@ThirdPreferredCareer", textBox9.Text);
                    cmd.Parameters.AddWithValue("@Status", chkStatus.Checked);

                    cmd.ExecuteNonQuery();
                    LoadApplication();

                }
            }
            else
            {
                MessageBox.Show("Seleccione un departamento para actualizar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadDataFromGrid();
        }
        private void LoadDataFromGrid()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                txtDescription.Text = selectedRow.Cells["ApplicantFirstName"].Value.ToString();
                txtDirector.Text = selectedRow.Cells["ApplicantLastName"].Value.ToString();
                textBox1.Text = selectedRow.Cells["Gender"].Value.ToString();
                textBox2.Text = selectedRow.Cells["DateOfBirth"].Value.ToString();
                textBox3.Text = selectedRow.Cells["TemporalID"].Value.ToString();
                textBox4.Text = selectedRow.Cells["SchoolOfOrigin"].Value.ToString();
                textBox5.Text = selectedRow.Cells["ApplicationDate"].Value.ToString();
                textBox6.Text = selectedRow.Cells["Grade"].Value.ToString();
                textBox7.Text = selectedRow.Cells["PreferredCareer"].Value.ToString();
                textBox8.Text = selectedRow.Cells["SecondPreferredCareer"].Value.ToString();
                textBox9.Text = selectedRow.Cells["ThirdPreferredCareer"].Value.ToString();


                chkStatus.Checked = Convert.ToBoolean(selectedRow.Cells["status"].Value);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int departmentId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["idApplication"].Value);

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "Update Application set status = 0 WHERE idApplication = @idDepartment";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@idDepartment", departmentId);

                    cmd.ExecuteNonQuery();
                    LoadApplication();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un departamento para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
