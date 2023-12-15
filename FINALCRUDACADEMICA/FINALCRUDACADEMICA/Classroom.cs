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
    public partial class Classroom : Form
    {
        public Classroom()
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
                string query = "SELECT * FROM marcos.AreaAcademicaBn.dbo.Classroom WHERE status=1;";
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
                string query = "INSERT INTO marcos.AreaAcademicaBn.dbo.Classroom (name, roomNumber, capacity, status) VALUES (@title, @date, @type, @status)";

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@title", txtDescription.Text);
                cmd.Parameters.AddWithValue("@date", txtDirector.Text);
                cmd.Parameters.AddWithValue("@type", textBox1.Text);
                cmd.Parameters.AddWithValue("@status", chkStatus.Checked);

                cmd.ExecuteNonQuery();
                LoadAcademicAward();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int departmentId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["idClassroom"].Value);


                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE marcos.AreaAcademicaBn.dbo.Classroom SET name = @title, roomNumber = @date, capacity = @type, status = @status WHERE idClassroom = @idAcademicDiploma;";


                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@idAcademicDiploma", departmentId);
                    cmd.Parameters.AddWithValue("@title", txtDescription.Text);
                    cmd.Parameters.AddWithValue("@date", txtDirector.Text);
                    cmd.Parameters.AddWithValue("@type", textBox1.Text);
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

                txtDescription.Text = selectedRow.Cells["name"].Value.ToString();
                txtDirector.Text = selectedRow.Cells["roomNumber"].Value.ToString();
                textBox1.Text = selectedRow.Cells["capacity"].Value.ToString();
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
                int departmentId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["idClassroom"].Value);

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "Update marcos.AreaAcademicaBn.dbo.Classroom set status = 0 WHERE idClassroom = @idDepartment";

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
