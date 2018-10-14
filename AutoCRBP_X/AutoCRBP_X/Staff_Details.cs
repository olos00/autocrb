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
    public partial class Staff_Details : Form
    {
        private DBConnect dbConnect;
        private OleDbCommand sqlCommand;
        private OleDbDataAdapter sqlDataAdapter;


        public Staff_Details()
        {
            InitializeComponent();
        }

        private void Staff_Load(object sender, EventArgs e)
        {

            dbConnect = new DBConnect();
            sqlDataAdapter = new OleDbDataAdapter();

            //Fill Datagrid with values
            FillDataGrid(dataGridView1, SelectStaffReport(), "staff_report");

            //Fill Combobox with values
            FillComboBox(cbStaffName, SelectStaff(), "staff_name", "staff_regno");
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            Staff staffInstance = new Staff();
            staffInstance.FormClosed += StaffInstance_FormClosed;
            this.Hide();
            staffInstance.Show();
        }

        private void StaffInstance_FormClosed(object sender, FormClosedEventArgs e)
        {
            FillComboBox(cbStaffName, SelectStaff(), "staff_name", "staff_regno");
            this.Show();
        }

        private void cbStaffName_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtRegno.Text = "";
            txtDesg.Text = "";

            if ((sender as ComboBox).Items.Count == 0)
                return;

            try
            {
                txtRegno.Text = cbStaffName.SelectedValue.ToString();

                sqlCommand = new OleDbCommand("SELECT designation FROM staff WHERE staff_regno = @staff_regno", dbConnect.Open());

                sqlCommand.Parameters.AddWithValue("@staff_regno", cbStaffName.SelectedValue.ToString());

                sqlDataAdapter.SelectCommand = sqlCommand;
                txtDesg.Text = sqlDataAdapter.SelectCommand.ExecuteScalar().ToString();

                dbConnect.Close();
            }

            catch { }
        }

        private void CalculateTotal(object sender, EventArgs e)
        {

        }

        private DataTable SelectStaff()
        {
            DataSet dt = new DataSet();
            sqlCommand = new OleDbCommand("SELECT * FROM staff", dbConnect.Open());
            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlDataAdapter.Fill(dt, "staff");

            dbConnect.Close();
            return dt.Tables["staff"];
        }

        private DataSet SelectStaffReport()
        {
            DataSet dt = new DataSet();
            sqlCommand = new OleDbCommand("SELECT * FROM staff_report", dbConnect.Open());
            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlDataAdapter.Fill(dt, "staff_report");

            dbConnect.Close();
            return dt;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbStaffName.Text == "" || txtDesg.Text == "" || dtpExamDate.Text == "" || txtTotalSession.Text == "" || txtRate.Text == "" || txtTotal.Text == "")
            {
                MessageBox.Show("Enter all the fields!", "Missing Values", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                sqlCommand = new OleDbCommand("INSERT INTO staff_report(staff_name,staff_regno,designation,session_date,session_timing,total_session,rate_session,total) VALUES(@staff_name,@staff_regno,@designation,@session_date,@session_timing,@total_session,@rate_session,@total)", dbConnect.Open());
                
                sqlCommand.Parameters.AddWithValue("@staff_name", cbStaffName.Text);
                sqlCommand.Parameters.AddWithValue("@staff_regno", txtRegno.Text);
                sqlCommand.Parameters.AddWithValue("@designation", txtDesg.Text);
                sqlCommand.Parameters.AddWithValue("@session_date", dtpExamDate.Text);
                if (radoAN.Checked)
                {
                    sqlCommand.Parameters.AddWithValue("@session_timing", radoAN.Text);
                }
                else
                {
                    sqlCommand.Parameters.AddWithValue("@session_timing", radoFN.Text);
                }
                sqlCommand.Parameters.AddWithValue("@total_session", txtTotalSession.Text);
                sqlCommand.Parameters.AddWithValue("@rate_session", txtRate.Text);
                sqlCommand.Parameters.AddWithValue("@total", txtTotal.Text);
                sqlDataAdapter.InsertCommand = sqlCommand;
                sqlDataAdapter.InsertCommand.ExecuteNonQuery();

                FillDataGrid(dataGridView1, SelectStaffReport(), "staff_report");

                dbConnect.Close();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int row = dataGridView1.SelectedCells[0].RowIndex;
            long id = long.Parse(dataGridView1.Rows[row].Cells[0].Value.ToString());

            String prompt = String.Format("ID:{0}"
                + Environment.NewLine
                + "Staff Name:{1}"
                + Environment.NewLine
                + "Designation:{2}",
                id,
                dataGridView1.Rows[row].Cells[1].Value.ToString(),
                dataGridView1.Rows[row].Cells[2].Value.ToString()
            );

            if (MessageBox.Show(prompt, "Delete this record?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sqlCommand = new OleDbCommand("DELETE FROM staff_report WHERE id=@id", dbConnect.Open());
                sqlCommand.Parameters.AddWithValue("@id", id);

                sqlDataAdapter.DeleteCommand = sqlCommand;
                sqlDataAdapter.DeleteCommand.ExecuteNonQuery();

                FillDataGrid(dataGridView1, SelectStaffReport(), "staff_report");

                dbConnect.Close();
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            String prompt = "Click OK to delete all records from this table." + Environment.NewLine + "Continue?";

            if (MessageBox.Show(prompt, "Clear all records", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sqlCommand = new OleDbCommand("DELETE FROM staff_report", dbConnect.Open());

                sqlDataAdapter.DeleteCommand = sqlCommand;
                sqlDataAdapter.DeleteCommand.ExecuteNonQuery();
                dbConnect.Close();

                
                sqlCommand = new OleDbCommand("ALTER TABLE staff_report ALTER COLUMN id COUNTER(1,1)", dbConnect.Open());
                sqlCommand.ExecuteNonQuery();

                dataGridView1.Refresh();
                dbConnect.Close();

                FillDataGrid(dataGridView1, SelectStaffReport(), "staff_report");
            }

        }

        private void FillDataGrid(DataGridView dg,DataSet ds, string dataMember)
        {
            dg.DataSource = ds;
            dg.DataMember = dataMember;
        }

        private void FillComboBox(ComboBox cb, DataTable dt, string displayMember, string valueMember)
        {
            cb.DataSource = dt;
            cb.DisplayMember = displayMember;
            cb.ValueMember = valueMember;
            cb.Refresh();
        }

        private void CalculateTotal(object sender, CancelEventArgs e)
        {
            try
            {
                int sess, rate, total;
                sess = Convert.ToInt32(txtTotalSession.Text);
                rate = Convert.ToInt32(txtRate.Text);
                total = sess * rate;
                txtTotal.Text = "" + total;

                e.Cancel = false;
                errorApp.SetError(sender as Control, "");
            }

            catch
            {
                /*
                txtTotalSession.Text = "0";
                txtTotal.Text = "0";
                txtRate.Text = "0";
                */
                e.Cancel = true;
                errorApp.SetError(sender as Control, "Incorrect Value");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
