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

namespace AutoCRBP_X
{
    public partial class Staff : Form
    {
        private DBConnect dBConnect;
        private OleDbCommand sqlCommand;
        private OleDbDataAdapter sqlDataAdapter;
        private DataSet dataSet;

        public Staff()
        {
            InitializeComponent();
        }

        private void AddStaff(object sender, EventArgs e)
        {
            if (txtRegno.Text == "" || txtName.Text == "" || txtDesg.Text == "")
            {
                MessageBox.Show("Enter all the fields!", "Missing Values", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                sqlCommand = new OleDbCommand("SELECT count(staff_regno) FROM staff WHERE staff_regno=@staff_regno", dBConnect.Open());
                sqlCommand.Parameters.AddWithValue("@staff_regno", txtRegno.Text);

                if ((int) sqlCommand.ExecuteScalar() > 0)
                {
                    MessageBox.Show("This Staff Regno is already present!", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    dBConnect.Close();
                    return;
                }

                sqlCommand = new OleDbCommand("INSERT INTO staff(staff_regno, staff_name, designation) VALUES(@staff_regno, @staff_name, @designation)", dBConnect.Open());
                sqlCommand.Parameters.AddWithValue("@staff_regno", txtRegno.Text);
                sqlCommand.Parameters.AddWithValue("@staff_name", txtName.Text);
                sqlCommand.Parameters.AddWithValue("@designation", txtDesg.Text);

                sqlDataAdapter.InsertCommand = sqlCommand;
                sqlDataAdapter.InsertCommand.ExecuteNonQuery();

                dataSet = SelectStaff();
                dataGridView1.DataSource = dataSet;
                dataGridView1.DataMember = "staff";

                dBConnect.Close();
            }
        }

        private void Staff_Load(object sender, EventArgs e)
        {
            dBConnect = new DBConnect();
            sqlDataAdapter = new OleDbDataAdapter();

            dataGridView1.DataMember = "staff";
            dataGridView1.DataSource = SelectStaff();
        }

        private DataSet SelectStaff()
        {
            DataSet dt = new DataSet();
            sqlCommand = new OleDbCommand("SELECT * FROM staff", dBConnect.Open());
            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlDataAdapter.Fill(dt, "staff");

            dBConnect.Close();
            return dt;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int row = dataGridView1.SelectedCells[0].RowIndex;
            string staff_regno = dataGridView1.Rows[row].Cells[0].Value.ToString();

            if (MessageBox.Show("Staff Regno:" + staff_regno, "Delete this Staff?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sqlCommand = new OleDbCommand("DELETE FROM staff WHERE staff_regno=@staff_regno", dBConnect.Open());
                sqlCommand.Parameters.AddWithValue("@staff_regno", staff_regno);

                sqlDataAdapter.DeleteCommand = sqlCommand;
                sqlDataAdapter.DeleteCommand.ExecuteNonQuery();

                dataGridView1.DataSource = SelectStaff();
                dataGridView1.DataMember = "staff";

                dBConnect.Close();
            }
        }
    }
}
