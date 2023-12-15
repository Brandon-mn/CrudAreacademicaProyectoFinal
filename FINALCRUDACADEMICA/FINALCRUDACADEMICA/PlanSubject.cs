using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CRUD
{
    public partial class PlanSubject : Form
    {
        public PlanSubject()
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
                string query = "SELECT ps.idPlanSubject, sp.description AS PlanDescription, s.name AS SubjectName, ps.status AS PlanSubjectStatus FROM PlanSubject ps INNER JOIN StudyPlan sp ON ps.idPlan = sp.idPlan AND sp.status = 1 INNER JOIN Subject s ON ps.idSubject = s.idSubject WHERE ps.status = 1;\r\n";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;

            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT idPlan, description FROM StudyPlan WHERE status =1";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable combotable = new DataTable();
                comboBox1.Items.Clear();
                adapter.Fill(combotable);
                foreach (DataRow row in combotable.Rows)
                {
                    string supplierInfo = $"{row["idPlan"]} - {row["description"]}";
                    comboBox1.Items.Add(supplierInfo);

                }

            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT idSubject, name FROM Subject WHERE status =1";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable ds = new DataTable();
                comboBox2.Items.Clear();
                adapter.Fill(ds);
                foreach (DataRow row in ds.Rows)
                {
                    string supplierInfo = $"{row["idSubject"]} - {row["name"]}";
                    comboBox2.Items.Add(supplierInfo);

                }

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
                string query = "INSERT INTO PlanSubject ( idPlan, idSubject, status) " +
                               "VALUES (@idContract, @idPosition, @status)";

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@idContract", idContract);
                cmd.Parameters.AddWithValue("@idPosition", idPosition);
                cmd.Parameters.AddWithValue("@status", chkStatus.Checked);
                cmd.ExecuteNonQuery();
                loadEmployee();
            }
        }
        private void LoadDataFromGrid()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];


                comboBox1.Text = selectedRow.Cells["PlanDescription"].Value.ToString();
                comboBox2.Text = selectedRow.Cells["SubjectName"].Value.ToString();
                chkStatus.Checked = Convert.ToBoolean(selectedRow.Cells["PlanSubjectstatus"].Value);
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadDataFromGrid();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int departmentId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["idPlanSubject"].Value);
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
                        string query = "UPDATE PlanSubject SET idPlan  = @idContract, idSubject  = @idPosition, status = @status " +
                                       "WHERE idPlanSubject = @idEmployeeEvent";

                        SqlCommand cmd = new SqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@idEmployeeEvent", departmentId);
                        cmd.Parameters.AddWithValue("@idContract", idStudent);
                        cmd.Parameters.AddWithValue("@idPosition", idApplication);
                        cmd.Parameters.AddWithValue("@status", chkStatus.Checked);

                        cmd.ExecuteNonQuery();
                        loadEmployee();
                    }
                
            }
            else
            {
                MessageBox.Show("Seleccione un departamento para actualizar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int departmentId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["idPlanSubject"].Value);

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "Update PlanSubject set status = 0 WHERE idPlanSubject= @idEmployeeEvent";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@idEmployeeEvent", departmentId);

                    cmd.ExecuteNonQuery();
                    loadEmployee();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un departamento para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

       
    }
}
