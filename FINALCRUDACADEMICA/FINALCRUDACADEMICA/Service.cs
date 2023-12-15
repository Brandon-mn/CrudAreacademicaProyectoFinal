using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CRUD
{
    public partial class Service : Form
    {
        public Service()
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
                string query = "SELECT s.idService, s.serviceCost, s.startDate, s.endDate, s.serviceDescription, s.ServiceName, ep.referenceNumber, s.status AS ServiceStatus FROM Service s INNER JOIN ExternalPayment ep ON s.idExternalPayment = ep.idExternalPayment WHERE s.status = 1;\r\n";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT idExternalPayment, referenceNumber FROM ExternalPayment WHERE status =1";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable combotable = new DataTable();
                comboBox1.Items.Clear();
                adapter.Fill(combotable);
                foreach (DataRow row in combotable.Rows)
                {
                    string supplierInfos = $"{row["idExternalPayment"]} - {row["referenceNumber"]}";
                    comboBox1.Items.Add(supplierInfos);

                }

            }
          


        }
        private void LoadDataFromGrid()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                txtName.Text = selectedRow.Cells["serviceCost"].Value.ToString();
                dateTimePicker1.Text = selectedRow.Cells["startDate"].Value.ToString();
                dateTimePicker2.Text = selectedRow.Cells["endDate"].Value.ToString();               
                txtlastname.Text = selectedRow.Cells["serviceDescription"].Value.ToString();
                textBox1.Text = selectedRow.Cells["ServiceName"].Value.ToString();
                chkStatus.Checked = Convert.ToBoolean(selectedRow.Cells["ServiceStatus"].Value);
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
            

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Service (serviceCost, startDate, endDate,serviceDescription,ServiceName, idExternalPayment,status) " +
                               "VALUES (@serviceCost, @startDate, @endDate, @serviceDescription, @ServiceName,@idExternalPayment, @status)";

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@serviceCost", txtName.Text);
                cmd.Parameters.AddWithValue("@startDate", dateTimePicker1.Text);
                cmd.Parameters.AddWithValue("@endDate", dateTimePicker2.Text);
                cmd.Parameters.AddWithValue("@serviceDescription", txtlastname.Text);
                cmd.Parameters.AddWithValue("@ServiceName", textBox1.Text);
                cmd.Parameters.AddWithValue("@idExternalPayment", idContract);
                cmd.Parameters.AddWithValue("@status", chkStatus.Checked);
                cmd.ExecuteNonQuery();
                loadEmployee();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {


            int departmentId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["idService"].Value);

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
                string query = "UPDATE Service SET serviceCost = @grade, startDate = @name, endDate  = @date , serviceDescription  = @idStudent, ServiceName  = @ServiceName,idExternalPayment  = @idExternalPayment, status = @status " +
               "WHERE idService = @idKardex";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@idKardex", departmentId);
                cmd.Parameters.AddWithValue("@grade", txtName.Text);
                cmd.Parameters.AddWithValue("@name",dateTimePicker1.Text);
                cmd.Parameters.AddWithValue("@date", dateTimePicker2.Text);
                cmd.Parameters.AddWithValue("@idStudent", txtlastname.Text);
                cmd.Parameters.AddWithValue("@ServiceName", textBox1.Text);
                cmd.Parameters.AddWithValue("@idExternalPayment", idStudent);
                cmd.Parameters.AddWithValue("@status", chkStatus.Checked);


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
                int departmentId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["idService"].Value);

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "Update Service set status = 0 WHERE idService = @idKardex";

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
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "MM/dd/yyyy";
        }


    }
}
