using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//
using System.Data.OleDb;
//using System.Data.SqlClient;

namespace AutoCRBP_X
{
    public partial class Course : Form
    {
        private DBConnect dBConnect;
        private OleDbCommand sqlCommand;
        private OleDbDataAdapter sqlDataAdapter;
        private DataSet dataSet;

        public Course()
        {
            InitializeComponent();
        }

        private void CourseAdd_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'autocrbDataSet.course' table. You can move, or remove it, as needed.
            //this.courseTableAdapter.Fill(this.autocrbDataSet.course);
            dBConnect = new DBConnect();
            sqlDataAdapter = new OleDbDataAdapter();

            dataGridView1.DataMember = "course";
            dataGridView1.DataSource = SelectCourses();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtCourseName.Text == "" || txtTerm.Text == "")
            {
                MessageBox.Show("Enter all the fields", "Missing Values!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                sqlCommand = new OleDbCommand("INSERT INTO course(course_name, term_no) VALUES(@course_name,@term_no)", dBConnect.Open());
                sqlCommand.Parameters.AddWithValue("@course_name", txtCourseName.Text);
                sqlCommand.Parameters.AddWithValue("@term_no", txtTerm.Text);

                sqlDataAdapter.InsertCommand = sqlCommand;
                sqlDataAdapter.InsertCommand.ExecuteNonQuery();

                dataSet = SelectCourses();
                dataGridView1.DataSource = dataSet;
                dataGridView1.DataMember = "course";

                dBConnect.Close();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                int row = dataGridView1.SelectedCells[0].RowIndex;
                long course_id = long.Parse(dataGridView1.Rows[row].Cells[0].Value.ToString());

                string prompt = String.Format("CourseName: {0}", dataGridView1.Rows[row].Cells[1].Value.ToString());

                if (MessageBox.Show(prompt, "Remove this field?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    sqlCommand = new OleDbCommand("DELETE FROM course WHERE course_id=@course_id", dBConnect.Open());
                    sqlCommand.Parameters.AddWithValue("@course_id", course_id);

                    sqlDataAdapter.DeleteCommand = sqlCommand;
                    sqlDataAdapter.DeleteCommand.ExecuteNonQuery();

                    dataGridView1.DataSource = SelectCourses();
                    dataGridView1.DataMember = "course";

                    dBConnect.Close();
                }
            }

            catch
            {
                dBConnect.Close();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCourseName.Text = "";
            txtTerm.Text = "";
        }

        private DataSet SelectCourses()
        {
            DataSet dt = new DataSet();
            sqlCommand = new OleDbCommand("SELECT * FROM course", dBConnect.Open());
            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlDataAdapter.Fill(dt, "course");

            dBConnect.Close();
            return dt;
        }
    }
}
