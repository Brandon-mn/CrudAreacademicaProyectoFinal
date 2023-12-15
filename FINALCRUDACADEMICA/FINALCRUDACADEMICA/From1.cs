using System.Data;
using System.Data.SqlClient;

namespace CRUD
{
    public partial class Form1 : Form
    {
        private const string connectionString = "Data Source=DESKTOP-886NS64\\SQLEXPRESS;Initial Catalog=AreaAcademica;Integrated Security=True;"; // Reemplaza con tu cadena de conexión

        public Form1()
        {
            InitializeComponent();
            LoadDepartments();
        }
        private void LoadDepartments()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Department WHERE status =1";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            // Configurar el formato del DateTimePicker para mostrar solo la hora
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "HH:mm"; // HH representa la hora en formato de 24 horas sin AM/PM
                                                    // Configurar el formato del DateTimePicker para mostrar solo la hora
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "HH:mm"; // HH representa la hora en formato de 24 horas sin AM/PM
            dateTimePicker3.Format = DateTimePickerFormat.Custom;
            dateTimePicker3.CustomFormat = "dd/MM/yyyy";
            // 
            MessageBox.Show("" + dateTimePicker3.Text);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Department (name, description, director, foundingDate, phone, email, location, openingHour, closingHour, status) " +
                               "VALUES (@name, @description, @director, @foundingDate, @phone, @email, @location, @openingHour, @closingHour, @status)";

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@description", txtDescription.Text);
                cmd.Parameters.AddWithValue("@director", txtDirector.Text);
                cmd.Parameters.AddWithValue("@foundingDate", dateTimePicker3.Text);
                cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@location", txtLocation.Text);
                cmd.Parameters.AddWithValue("@openingHour", dateTimePicker1.Text);
                cmd.Parameters.AddWithValue("@closingHour", dateTimePicker2.Text);
                cmd.Parameters.AddWithValue("@status", chkStatus.Checked);

                cmd.ExecuteNonQuery();
                LoadDepartments();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Department (name, description, director, foundingDate, phone, email, location, openingHour, closingHour, status) " +
                               "VALUES (@name, @description, @director, @foundingDate, @phone, @email, @location, @openingHour, @closingHour, @status)";

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@description", txtDescription.Text);
                cmd.Parameters.AddWithValue("@director", txtDirector.Text);
                cmd.Parameters.AddWithValue("@foundingDate", dateTimePicker3.Text);
                cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@location", txtLocation.Text);
                cmd.Parameters.AddWithValue("@openingHour", dateTimePicker1.Text);
                cmd.Parameters.AddWithValue("@closingHour", dateTimePicker2.Text);
                cmd.Parameters.AddWithValue("@status", chkStatus.Checked);

                cmd.ExecuteNonQuery();
                LoadDepartments();
            }
        }
        private void ClearFields()
        {
            txtName.Text = "";
            txtDescription.Text = "";
            txtDirector.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            txtLocation.Text = "";

            chkStatus.Checked = true;
        }

        private void LoadDataFromGrid()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                txtName.Text = selectedRow.Cells["name"].Value.ToString();
                txtDescription.Text = selectedRow.Cells["description"].Value.ToString();
                txtDirector.Text = selectedRow.Cells["director"].Value.ToString();
                dateTimePicker3.Text = selectedRow.Cells["foundingDate"].Value.ToString();
                txtPhone.Text = selectedRow.Cells["phone"].Value.ToString();
                txtEmail.Text = selectedRow.Cells["email"].Value.ToString();
                txtLocation.Text = selectedRow.Cells["location"].Value.ToString();
                dateTimePicker1.Text = selectedRow.Cells["openingHour"].Value.ToString();
                dateTimePicker2.Text = selectedRow.Cells["closingHour"].Value.ToString();
                chkStatus.Checked = Convert.ToBoolean(selectedRow.Cells["status"].Value);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int departmentId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["idDepartment"].Value);

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE Department SET name = @name, description = @description, director = @director, foundingDate = @foundingDate, " +
                                   "phone = @phone, email = @email, location = @location, openingHour = @openingHour, closingHour = @closingHour, status = @status " +
                                   "WHERE idDepartment = @idDepartment";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@idDepartment", departmentId);
                    cmd.Parameters.AddWithValue("@name", txtName.Text);
                    cmd.Parameters.AddWithValue("@description", txtDescription.Text);
                    cmd.Parameters.AddWithValue("@director", txtDirector.Text);
                    cmd.Parameters.AddWithValue("@foundingDate", dateTimePicker3.Text);
                    cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@location", txtLocation.Text);
                    cmd.Parameters.AddWithValue("@openingHour", dateTimePicker1.Text);
                    cmd.Parameters.AddWithValue("@closingHour", dateTimePicker2.Text);
                    cmd.Parameters.AddWithValue("@status", chkStatus.Checked);

                    cmd.ExecuteNonQuery();
                    LoadDepartments();
                    ClearFields();
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int departmentId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["idDepartment"].Value);

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "Update Department set status = 0 WHERE idDepartment = @idDepartment";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@idDepartment", departmentId);

                    cmd.ExecuteNonQuery();
                    LoadDepartments();
                    ClearFields();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un departamento para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Menu Menufrm = new Menu();
            Menufrm.Show();
            this.Hide();
        }
    }
}