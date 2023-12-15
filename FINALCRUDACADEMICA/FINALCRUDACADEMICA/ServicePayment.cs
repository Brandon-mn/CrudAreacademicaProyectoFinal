using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CRUD
{
    public partial class ServicePayment : Form
    {
        public ServicePayment()
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
                string query = "SELECT sp.idServicePayment, sp.amount, sp.paymentDate, sp.paymentMethod, sp.bank, a.ApplicantFirstName AS idApplication, s.serviceCost AS idService, sp.Status AS ServicePaymentStatus FROM ServicePayment sp INNER JOIN Application a ON sp.idApplication = a.idApplication INNER JOIN Service s ON sp.idService = s.idService WHERE sp.Status = 1;\r\n";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
            }




            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT idApplication, ApplicantFirstName FROM Application WHERE status =1";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable combotable = new DataTable();
                comboBox1.Items.Clear();
                adapter.Fill(combotable);
                foreach (DataRow row in combotable.Rows)
                {
                    string supplierInfos = $"{row["idApplication"]} - {row["ApplicantFirstName"]}";
                    comboBox1.Items.Add(supplierInfos);

                }

            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT idService, serviceCost FROM Service WHERE status =1";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable ds = new DataTable();
                comboBox2.Items.Clear();
                adapter.Fill(ds);

                foreach (DataRow row in ds.Rows)
                {
                    string classInfo = $"{row["idService"]} - {row["serviceCost"]}";
                    comboBox2.Items.Add(classInfo);
                }

               

            }

        }
        private void LoadDataFromGrid()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                txtName.Text = selectedRow.Cells["amount"].Value.ToString();
                dateTimePicker1.Text = selectedRow.Cells["paymentDate"].Value.ToString();
                txtlastname.Text = selectedRow.Cells["paymentMethod"].Value.ToString();
                textBox1.Text = selectedRow.Cells["bank"].Value.ToString();
                chkStatus.Checked = Convert.ToBoolean(selectedRow.Cells["ServicePaymentStatus"].Value);

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

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO ServicePayment (amount, paymentDate, paymentMethod,bank,idApplication, status, idService) " +
                               "VALUES (@amount, @paymentDate, @paymentMethod, @bank, @idApplication, @status, @idService)";

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@amount", txtName.Text);
                cmd.Parameters.AddWithValue("@paymentDate", dateTimePicker1.Text);
                cmd.Parameters.AddWithValue("@paymentMethod", txtlastname.Text);
                cmd.Parameters.AddWithValue("@bank", textBox1.Text);
                cmd.Parameters.AddWithValue("@idApplication", idContract);
                cmd.Parameters.AddWithValue("@idService", idPosition);

                cmd.Parameters.AddWithValue("@status", chkStatus.Checked);
                cmd.ExecuteNonQuery();
                loadEmployee();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {


            int departmentId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["idServicePayment"].Value);

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
                string query = "UPDATE ServicePayment SET amount = @amount, paymentDate = @paymentDate, paymentMethod  = @paymentMethod , bank  = @bank, idApplication  = @idApplication,idService = @idService, status = @status " +
               "WHERE idServicePayment = @idKardex";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@idKardex", departmentId);
                cmd.Parameters.AddWithValue("@amount", txtName.Text);
                cmd.Parameters.AddWithValue("@paymentDate", dateTimePicker1.Text);
                cmd.Parameters.AddWithValue("@paymentMethod", txtlastname.Text);
                cmd.Parameters.AddWithValue("@bank", textBox1.Text);
                cmd.Parameters.AddWithValue("@idApplication", idStudent);
                cmd.Parameters.AddWithValue("@status", chkStatus.Checked);
                cmd.Parameters.AddWithValue("@idService", idApplication);

                cmd.ExecuteNonQuery();
                loadEmployee();

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
                int departmentId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["idServicePayment"].Value);

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "Update ServicePayment set status = 0 WHERE idServicePayment = @idKardex";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@idKardex", departmentId);
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
        }


    }
}
