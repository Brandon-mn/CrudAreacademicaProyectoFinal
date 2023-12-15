using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace CRUD
{
    public partial class TeacherEvaluation : Form
    {
        public TeacherEvaluation()
        {
            InitializeComponent();
            LoadPosition();
        }
        private const string connectionString = "Data Source=DESKTOP-886NS64\\SQLEXPRESS;Initial Catalog=AreaAcademicaBn;Integrated Security=True;"; // Reemplaza con tu cadena de conexión

        private void LoadPosition()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT te.idTeacherEvaluation, te.date, te.calification, te.status, s.name AS SubjectName, st.name AS StudentName FROM TeacherEvaluation te INNER JOIN Subject s ON te.idSubject = s.idSubject INNER JOIN Student st ON te.idStudent = st.idStudent WHERE te.status = 1;\r\n";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT idStudent, name FROM Student WHERE status =1";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable combotable = new DataTable();
                comboBox2.Items.Clear();
                adapter.Fill(combotable);
                foreach (DataRow row in combotable.Rows)
                {
                    string supplierInfos = $"{row["idStudent"]} - {row["name"]}";
                    comboBox2.Items.Add(supplierInfos);

                }

            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT idSubject, name FROM Subject WHERE status =1";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable combotable = new DataTable();
                comboBox1.Items.Clear();
                adapter.Fill(combotable);
                foreach (DataRow row in combotable.Rows)
                {
                    string supplierInfos = $"{row["idSubject"]} - {row["name"]}";
                    comboBox1.Items.Add(supplierInfos);

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
            string ReportInfos = comboBox2.SelectedItem.ToString();
            int idstudent = 0;

            // Obtener el StudentID de ReportInfos (corregido)
            string[] reportInfoPartss = ReportInfos.Split('-');
            if (reportInfoPartss.Length >= 2)
            {
                int.TryParse(reportInfoPartss[0].Trim(), out idstudent);
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO TeacherEvaluation (date, calification, idStudent, idSubject, status) " +
                               "VALUES (@date, @calification, @idStudent, @idSubject, @status)";

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@date", dateTimePicker1.Text);
                cmd.Parameters.AddWithValue("@calification", txtName.Text);
                cmd.Parameters.AddWithValue("@idStudent", idstudent);  
                cmd.Parameters.AddWithValue("@idSubject", idContract);
                cmd.Parameters.AddWithValue("@status", chkStatus.Checked);

                cmd.ExecuteNonQuery();
                LoadPosition();
            }
        }


        private void LoadDataFromGrid()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                txtName.Text = selectedRow.Cells["calification"].Value.ToString();
                dateTimePicker1.Text = selectedRow.Cells["date"].Value.ToString();
                chkStatus.Checked = Convert.ToBoolean(selectedRow.Cells["status"].Value);
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
                int departmentId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["idTeacherEvaluation"].Value);
                string ReportInfo = comboBox1.SelectedItem.ToString();
                int idContract = 0;

                // Obtener el EmployeeID de ReportInfo
                string[] reportInfoParts = ReportInfo.Split('-');
                if (reportInfoParts.Length >= 2)
                {
                    int.TryParse(reportInfoParts[0].Trim(), out idContract);
                }
                string ReportInfos = comboBox2.SelectedItem.ToString();
                int idstudent = 0;

                // Obtener el StudentID de ReportInfos (corregido)
                string[] reportInfoPartss = ReportInfos.Split('-');
                if (reportInfoPartss.Length >= 2)
                {
                    int.TryParse(reportInfoPartss[0].Trim(), out idstudent);
                }
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open(); 
                    string query = "UPDATE TeacherEvaluation SET date = @date, calification = @calification, idStudent  = @idStudent , idSubject = @idSubject, status = @status " +
                                   "WHERE idTeacherEvaluation = @idDepartment";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@idDepartment", departmentId);
                    cmd.Parameters.AddWithValue("@date", dateTimePicker1.Text);
                    cmd.Parameters.AddWithValue("@calification", txtName.Text);
                    cmd.Parameters.AddWithValue("@idStudent", idstudent);
                    cmd.Parameters.AddWithValue("@idSubject", idContract);
                    cmd.Parameters.AddWithValue("@status", chkStatus.Checked);

                    cmd.ExecuteNonQuery();
                    LoadPosition();

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
                int departmentId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["idTeacherEvaluation"].Value);

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "Update TeacherEvaluation set status = 0 WHERE idTeacherEvaluation = @idTeacherEvaluation";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@idTeacherEvaluation", departmentId);

                    cmd.ExecuteNonQuery();
                    LoadPosition();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un departamento para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Position_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MM/dd/yyyy";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadDataFromGrid();

        }
    }
}
