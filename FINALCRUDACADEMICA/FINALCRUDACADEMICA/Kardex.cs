using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CRUD
{
    public partial class Kardex : Form
    {
        public Kardex()
        {
            InitializeComponent();
        }
        private const string connectionString = "Data Source=DESKTOP-886NS64\\SQLEXPRESS;Initial Catalog=AreaAcademicaBn;Integrated Security=True;"; // Reemplaza con tu cadena de conexión

        private void AcademicAward_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;

            dateTimePicker1.CustomFormat = "MM/dd/yyyy";
            LoadAcademicAward();

        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadDataFromGrid();
        }

        private void LoadAcademicAward()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT Kardex.idKardex, Kardex.grade, Kardex.name AS name, Kardex.date, Kardex.status,Student.idStudent as idStudent, Student.name AS StudentName, Student.lastName AS StudentLastName,\r\nClass.idClass, Class.idGroup, Class.idEmployee, Class.idSubject, Class.idClassroom FROM Kardex INNER JOIN Student ON Kardex.idStudent = Student.idStudent\r\nINNER JOIN Class ON Kardex.idClass = Class.idClass WHERE Kardex.status = 1;";
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
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT idGroup, idClass FROM Class WHERE status =1";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable combotableapp = new DataTable();
                comboBox2.Items.Clear();
                adapter.Fill(combotableapp);
                foreach (DataRow row in combotableapp.Rows)
                {
                    string supplierInfos = $"{row["idClass"]} - {row["idGroup"]}";
                    comboBox2.Items.Add(supplierInfos);
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
                string query = "INSERT INTO Kardex (grade, name, date, status, idStudent, idClass) " +
                   "VALUES (@grade, @name, @date, @status, @idStudent, @idClass)";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@grade", textBox1.Text);
                cmd.Parameters.AddWithValue("@name", txtDescription.Text);
                cmd.Parameters.AddWithValue("@date", dateTimePicker1.Text);
                cmd.Parameters.AddWithValue("@idStudent", idStudent);
                cmd.Parameters.AddWithValue("@idClass", idApplication);
                cmd.Parameters.AddWithValue("@status", chkStatus.Checked);
                cmd.ExecuteNonQuery();
                LoadAcademicAward();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int departmentId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["idKardex"].Value);
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
                    string query = "UPDATE Kardex SET grade = @grade, name = @name, date = @date, status = @status, idStudent = @idStudent, idClass = @idClass WHERE idKardex = @idKardex";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@idKardex", departmentId);
                    cmd.Parameters.AddWithValue("@grade", textBox1.Text);
                    cmd.Parameters.AddWithValue("@name", txtDescription.Text);
                    cmd.Parameters.AddWithValue("@date", dateTimePicker1.Text);
                    cmd.Parameters.AddWithValue("@idStudent", idStudent);
                    cmd.Parameters.AddWithValue("@idClass", idApplication);
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
                textBox1.Text = selectedRow.Cells["grade"].Value.ToString();
                txtDescription.Text = selectedRow.Cells["name"].Value.ToString();
                comboBox1.SelectedValue = selectedRow.Cells["idStudent"].Value;
                comboBox2.SelectedValue = selectedRow.Cells["idClass"].Value;
                chkStatus.Checked = Convert.ToBoolean(selectedRow.Cells["status"].Value);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int departmentId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["idKardex"].Value);

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "Update Kardex set status = 0 WHERE idKardex = @idKardex";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@idKardex", departmentId);
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
