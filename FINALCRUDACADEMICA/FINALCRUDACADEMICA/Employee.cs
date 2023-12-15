using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CRUD
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
            loadEmployee();
        }
        private const string connectionString = "Data Source=DESKTOP-886NS64\\SQLEXPRESS;Initial Catalog=AreaAcademicaBn;Integrated Security=True;"; // Reemplaza con tu cadena de conexión

        private void loadEmployee()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT e.idEmployee, e.name, e.lastName, e.dateOfBirth, e.gender, e.address, e.phoneNumber, e.email, e.maritalStatus, e.hireDate, e.hasPreviousExperiencie, e.status AS status, c.contractType AS contractType, a.PreferredCareer, p.name AS positionName FROM Employee e INNER JOIN Contract c ON e.idContract = c.idContract INNER JOIN Application a ON e.idApplication = a.idApplication INNER JOIN Position p ON e.idPosition = p.idPosition where e.status = 1;";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;

            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT idContract, contractType FROM Contract WHERE status =1";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable combotable = new DataTable();
                comboBox1.Items.Clear();
                adapter.Fill(combotable);
                foreach (DataRow row in combotable.Rows)
                {
                    string supplierInfos = $"{row["idContract"]} - {row["contractType"]}";
                    comboBox1.Items.Add(supplierInfos);

                }

            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT idPosition, name FROM Position WHERE status =1";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable ds = new DataTable();
                comboBox2.Items.Clear();
                adapter.Fill(ds);
                foreach (DataRow row in ds.Rows)
                {
                    string supplierInfoss = $"{row["idPosition"]} - {row["name"]}";
                    comboBox2.Items.Add(supplierInfoss);

                }

            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT idApplication, PreferredCareer FROM Application WHERE status =1";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable df = new DataTable();
                comboBox3.Items.Clear();
                adapter.Fill(df);
                foreach (DataRow row in df.Rows)
                {
                    string supplierInfosss = $"{row["idApplication"]} - {row["PreferredCareer"]}";
                    comboBox3.Items.Add(supplierInfosss);

                }

            }
        }
        private void LoadDataFromGrid()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                txtName.Text = selectedRow.Cells["name"].Value.ToString();
                txtlastname.Text = selectedRow.Cells["lastName"].Value.ToString();
                dateTimePicker1.Text = selectedRow.Cells["dateOfBirth"].Value.ToString();
                txtgender.Text = selectedRow.Cells["gender"].Value.ToString();
                txtaddress.Text = selectedRow.Cells["address"].Value.ToString();
                txtphonenumer.Text = selectedRow.Cells["phoneNumber"].Value.ToString();
                txtemail.Text = selectedRow.Cells["email"].Value.ToString();
                txtmaritalstatus.Text = selectedRow.Cells["maritalStatus"].Value.ToString();
                dateTimePicker2.Text = selectedRow.Cells["hireDate"].Value.ToString();
                txthasprevious.Text = selectedRow.Cells["hasPreviousExperiencie"].Value.ToString();
                
                chkStatus.Checked = Convert.ToBoolean(selectedRow.Cells["status"].Value);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string ReportInfo = comboBox1.SelectedItem.ToString();
            int idContract = 0;

            // Obtener el EmployeeID de ReportInfo
            string[] reportInfoParts = ReportInfo.Split('-');
            if (reportInfoParts.Length >= 2)
            {
                int.TryParse(reportInfoParts[0].Trim(), out idContract);
            }
            string ReportInfo2 = comboBox2.SelectedItem.ToString();
            int idPosition = 0;

            // Obtener el EmployeeID de ReportInfo
            string[] reportInfoParts2 = ReportInfo2.Split('-');
            if (reportInfoParts2.Length >= 2)
            {
                int.TryParse(reportInfoParts2[0].Trim(), out idPosition);
            }
            string ReportInfo3 = comboBox3.SelectedItem.ToString();
            int idApplication = 0;

            // Obtener el EmployeeID de ReportInfo
            string[] reportInfoParts3 = ReportInfo3.Split('-');
            if (reportInfoParts3.Length >= 2)
            {
                int.TryParse(reportInfoParts3[0].Trim(), out idApplication);
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Employee (name, lastName, dateOfBirth , gender, address, phoneNumber, email, maritalStatus, hireDate,hasPreviousExperiencie, idContract,idPosition, idApplication, status) " +
                               "VALUES (@name, @lastName, @dateOfBirth, @gender, @address,@phoneNumber, @email, @maritalStatus, @hireDate, @hasPreviousExperiencie,@idContract, @idPosition, @idApplication, @status)";

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@lastName", txtlastname.Text);
                cmd.Parameters.AddWithValue("@dateOfBirth", dateTimePicker1.Text);
                cmd.Parameters.AddWithValue("@gender", txtgender.Text);
                cmd.Parameters.AddWithValue("@address", txtaddress.Text);
                cmd.Parameters.AddWithValue("@phoneNumber", txtName.Text);
                cmd.Parameters.AddWithValue("@email", txtemail.Text);
                cmd.Parameters.AddWithValue("@maritalStatus", txtmaritalstatus.Text);
                cmd.Parameters.AddWithValue("@hireDate", dateTimePicker2.Text);
                cmd.Parameters.AddWithValue("@hasPreviousExperiencie", txthasprevious.Text);
                cmd.Parameters.AddWithValue("@idContract", idContract);
                cmd.Parameters.AddWithValue("@idPosition", idPosition);
                cmd.Parameters.AddWithValue("@idApplication", idApplication);
                cmd.Parameters.AddWithValue("@status", chkStatus.Checked);
                cmd.ExecuteNonQuery();
                loadEmployee();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            
                
                    int departmentId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["idEmployee"].Value);

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
                    string Applicationcbd = comboBox3.SelectedItem.ToString();
                    int idApplicationn = 0;

                    // Obtener el EmployeeID de ReportInfo
                    string[] reportInfoPartsss = Applicationcbd.Split('-');
                    if (reportInfoPartsss.Length >= 2)
                    {
                        int.TryParse(reportInfoPartss[0].Trim(), out idApplicationn);
                    }
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "UPDATE Employee SET name = @name, lastName = @lastName, dateOfBirth  = @dateOfBirth , gender  = @gender , address = @address, phoneNumber = @phoneNumber, email  = @email , maritalStatus  = @maritalStatus , hireDate  = @hireDate ,hasPreviousExperiencie  = @hasPreviousExperiencie,idContract  = @idContract, idPosition  = @idPosition, idApplication  = @idApplication, status = @status " +
                       "WHERE idEmployee = @idEmployee";
                        SqlCommand cmd = new SqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@idEmployee", departmentId);
                        cmd.Parameters.AddWithValue("@name", txtName.Text);
                        cmd.Parameters.AddWithValue("@lastName", txtlastname.Text);
                        cmd.Parameters.AddWithValue("@dateOfBirth", dateTimePicker1.Text);
                        cmd.Parameters.AddWithValue("@gender", txtgender.Text);
                        cmd.Parameters.AddWithValue("@address", txtaddress.Text);
                        cmd.Parameters.AddWithValue("@phoneNumber", txtName.Text);
                        cmd.Parameters.AddWithValue("@email", txtemail.Text);
                        cmd.Parameters.AddWithValue("@maritalStatus", txtmaritalstatus.Text);
                        cmd.Parameters.AddWithValue("@hireDate", dateTimePicker2.Text);
                        cmd.Parameters.AddWithValue("@hasPreviousExperiencie", txthasprevious.Text);
                        cmd.Parameters.AddWithValue("@idContract",idApplication);
                        cmd.Parameters.AddWithValue("@idPosition", idStudent);
                        cmd.Parameters.AddWithValue("@idApplication",idApplicationn);
                        cmd.Parameters.AddWithValue("@status", chkStatus.Checked);

                        cmd.ExecuteNonQuery();
                        loadEmployee();
                        //SqlCommand cmd = new SqlCommand(query, connection);
                        //cmd.Parameters.AddWithValue("@idDepartment", departmentId);
                        //cmd.Parameters.AddWithValue("@contactInfo", textBox1.Text);
                        //cmd.Parameters.AddWithValue("@gender", txtDescription.Text);
                        //cmd.Parameters.AddWithValue("@address", txtDirector.Text);
                        //cmd.Parameters.AddWithValue("@nationality", txtPhone.Text);
                        //cmd.Parameters.AddWithValue("@name", textBox2.Text);
                        //cmd.Parameters.AddWithValue("@idStudent", idStudent);
                        //cmd.Parameters.AddWithValue("@idApplication", idApplication);
                        //cmd.Parameters.AddWithValue("@status", chkStatus.Checked);

                        //cmd.ExecuteNonQuery();
                        //LoadAcademicAward();
                    }
                
                
                //int departmentId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["idEmployee"].Value);
                //{

                //    using (SqlConnection connection = new SqlConnection(connectionString))
                //    {
                //        connection.Open();
                //string query = "UPDATE Employee SET name = @name, lastName = @lastName, dateOfBirth  = @dateOfBirth , gender  = @gender , address = @address, phoneNumber = @phoneNumber, email  = @email , maritalStatus  = @maritalStatus , hireDate  = @hireDate ,hasPreviousExperiencie  = @hasPreviousExperiencie,idContract  = @idContract, idPosition  = @idPosition, idApplication  = @idApplication, status = @status " +
                //               "WHERE idEmployee = @idEmployee";

                //        SqlCommand cmd = new SqlCommand(query, connection);
                //        cmd.Parameters.AddWithValue("@idEmployee", departmentId);
                //        cmd.Parameters.AddWithValue("@name", txtName.Text);
                //        cmd.Parameters.AddWithValue("@lastName", txtlastname.Text);
                //        cmd.Parameters.AddWithValue("@dateOfBirth", dateTimePicker1.Text);
                //        cmd.Parameters.AddWithValue("@gender", txtgender.Text);
                //        cmd.Parameters.AddWithValue("@address", txtaddress.Text);
                //        cmd.Parameters.AddWithValue("@phoneNumber", txtName.Text);
                //        cmd.Parameters.AddWithValue("@email", txtemail.Text);
                //        cmd.Parameters.AddWithValue("@maritalStatus", txtmaritalstatus.Text);
                //        cmd.Parameters.AddWithValue("@hireDate", dateTimePicker2.Text);
                //        cmd.Parameters.AddWithValue("@hasPreviousExperiencie", txthasprevious.Text);
                //        cmd.Parameters.AddWithValue("@idContract", comboBox1.Text);
                //        cmd.Parameters.AddWithValue("@idPosition", comboBox2.Text);
                //        cmd.Parameters.AddWithValue("@idApplication", comboBox3.Text);
                //        cmd.Parameters.AddWithValue("@status", chkStatus.Checked);

                //        cmd.ExecuteNonQuery();
                //        loadEmployee();
                //    }
                //}
            
          
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadDataFromGrid();

        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int departmentId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["idEmployee"].Value);

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "Update Employee set status = 0 WHERE idEmployee = @idEmployee";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@idEmployee", departmentId);

                    cmd.ExecuteNonQuery();
                    loadEmployee();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un departamento para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MM/dd/yyyy";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "MM/dd/yyyy";
        }


    }
}
