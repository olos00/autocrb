using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace AutoCRBP_X
{
    public partial class Exam : Form
    {
        private DBConnect dbConnect;
        private OleDbCommand sqlCommand;
        private OleDbDataAdapter sqlDataAdapter;
        private DataSet dataSet;

        public Exam()
        {
            InitializeComponent();
        }

        private void Exam_Load(object sender, EventArgs e)
        {
            dbConnect = new DBConnect();

            sqlDataAdapter = new OleDbDataAdapter();

            FillDataGrid(dataGridView1, SelectExam(), "exam_report");
            FillComboBox(cbCourse, SelectCourse(), "course_name", "term_no");

            int rel, clerk, gdw, inv;
            int relA, relB, clerkA, clerkB, gdwA, gdwB, invA, invB;
            relA = Convert.ToInt32(txtRelP.Text);
            relB = Convert.ToInt32(txtRelA.Text);
            rel = relA * relB;
            clerkA = Convert.ToInt32(txtClerkP.Text);
            clerkB = Convert.ToInt32(txtClerkA.Text);
            clerk = clerkA * clerkB;
            gdwA = Convert.ToInt32(txtGdwP.Text);
            gdwB = Convert.ToInt32(txtGdwA.Text);
            gdw = gdwA * gdwB;
            invA = Convert.ToInt32(txtInvP.Text);
            invB = Convert.ToInt32(txtInvA.Text);
            inv = invA * invB;
            txtTotal.Text = (rel + clerk + gdw + inv).ToString();
        }

        private void btnCourseAdd_Click(object sender, EventArgs e)
        {
            Course courseInstance = new Course();
            courseInstance.FormClosed += (object s, FormClosedEventArgs fcea) => {
                FillDataGrid(dataGridView1, SelectExam(), "exam_report");
                FillComboBox(cbCourse, SelectCourse(), "course_name", "term_no");
                this.Show();
            };

            courseInstance.Shown += (object s, EventArgs ea) => this.Hide();
            courseInstance.Show();
        }

        private DataSet SelectExam()
        {
            DataSet dt = new DataSet();
            sqlCommand = new OleDbCommand("SELECT * FROM exam_report", dbConnect.Open());
            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlDataAdapter.Fill(dt, "exam_report");

            dbConnect.Close();
            return dt;
        }

        private DataTable SelectCourse()
        {
            DataSet dt = new DataSet();
            sqlCommand = new OleDbCommand("SELECT * FROM course", dbConnect.Open());
            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlDataAdapter.Fill(dt, "course");

            dbConnect.Close();
            return dt.Tables["course"];
        }

        private void btnAppend_Click(object sender, EventArgs e)
        {
            if (hiddenTxtCourse.Text == "" || dtExamDate.Text == "" || txtStartTime.Text == "" || txtEndTime.Text == "" || hiddenTxtCand.Text == "" || txtRelP.Text == "" || txtInvP.Text == "" || txtClerkP.Text == "" || txtGdwP.Text == "" || txtRelA.Text == "" || txtInvA.Text == "" || txtClerkA.Text == "" || txtGdwA.Text == "" || txtTotal.Text == "")
            {
                MessageBox.Show("Enter all the fields!", "Missing Values", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string startTime = txtStartTime.Text + (radoStartAM.Checked ? radoStartAM.Text : radoStartPM.Text);
                string endTime = txtEndTime.Text + (radoEndAM.Checked ? radoEndAM.Text : radoEndPM.Text);

                sqlCommand = new OleDbCommand("INSERT INTO exam_report(exam_name,exam_date,start_time,end_time,no_students,no_reliever,no_invigilator,no_clerk,no_gdw,rate_reliever,rate_invigilator,rate_clerk,rate_gdw,total) VALUES(@exam_name,@exam_date,@start_time,@end_time,@no_students,@no_reliever,@no_invigilator,@no_clerk,@no_gdw,@rate_reliever,@rate_invigilator,@rate_clerk,@rate_gdw,@total)", dbConnect.Open());
                sqlCommand.Parameters.AddWithValue("@exam_name", hiddenTxtCourse.Text);
                sqlCommand.Parameters.AddWithValue("@exam_date", dtExamDate.Text);
                sqlCommand.Parameters.AddWithValue("@start_time", startTime);
                sqlCommand.Parameters.AddWithValue("@end_time", endTime);
                sqlCommand.Parameters.AddWithValue("@no_students", hiddenTxtCand.Text);
                sqlCommand.Parameters.AddWithValue("@no_reliever", txtRelP.Text);
                sqlCommand.Parameters.AddWithValue("@no_invigilator", txtInvP.Text);
                sqlCommand.Parameters.AddWithValue("@no_clerk", txtClerkP.Text);
                sqlCommand.Parameters.AddWithValue("@no_gdw", txtGdwP.Text);
                sqlCommand.Parameters.AddWithValue("@rate_reliever", txtRelA.Text);
                sqlCommand.Parameters.AddWithValue("@rate_invigilator", txtInvA.Text);
                sqlCommand.Parameters.AddWithValue("@rate_clerk", txtClerkA.Text);
                sqlCommand.Parameters.AddWithValue("@rate_gdw", txtGdwA.Text);
                sqlCommand.Parameters.AddWithValue("@total", txtTotal.Text);


                sqlDataAdapter.InsertCommand = sqlCommand;
                sqlDataAdapter.InsertCommand.ExecuteNonQuery();

                dataSet = SelectExam();
                dataGridView1.DataSource = dataSet;
                dataGridView1.DataMember = "exam_report";

                dbConnect.Close();
            }
        }

        private void btnAddCourseCandidates_Click(object sender, EventArgs e)
        {
            int itemCount = lbCourseAdded.Items.Count;

            if (itemCount <= 10)
            {
                string courseText = cbCourse.Text + String.Format(" ({0} Term)", cbCourse.SelectedValue.ToString());
                lbCourseAdded.Items.Add(courseText);
                lbCandidateCount.Items.Add(txtCandidatesCount.Text);

                UpdateTB(null, null);
                //txtCourse.Text = String.Join("," + Environment.NewLine, lbCourseAdded.Items.Cast<String>().ToArray());
                //txtCand.Text = String.Join(",", lbCandidateCount.Items.Cast<String>().ToArray());
            }

            else MessageBox.Show("Too many items added!", "Limit Items to 10", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lbCourseAdded.Items.Clear();
            lbCandidateCount.Items.Clear();

            txtCandidatesCount.Text = "";
            hiddenTxtCourse.Text = "";
            hiddenTxtCand.Text = "";
            txtTotal.Text = "";

            txtStartTime.Text = "";
            txtEndTime.Text = "";

            FillDataGrid(dataGridView1, SelectExam(), "exam_report");
            FillComboBox(cbCourse, SelectCourse(), "course_name", "term_no");
        }

        private void txtStartTime_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (sender as TextBox);
            uint startTime = 0;

            UInt32.TryParse(tb.Text, out startTime);

            if (startTime != 0)
            {
                txtEndTime.Text = startTime <= 12 ? ((startTime + 3) % 12).ToString() : "";
            }

            else txtEndTime.Text = "";
        }

        private void SelectListBox(object sender, EventArgs e)
        {
            if ((sender as ListBox) == lbCourseAdded)
                lbCandidateCount.SelectedIndex = lbCourseAdded.SelectedIndex;
            else lbCourseAdded.SelectedIndex = lbCandidateCount.SelectedIndex;
        }

        private void UpdateTB(object sender, EventArgs e)
        {
            hiddenTxtCourse.Text = String.Join(", " + Environment.NewLine, lbCourseAdded.Items.Cast<String>().ToArray());
            hiddenTxtCand.Text = String.Join(", ", lbCandidateCount.Items.Cast<String>().ToArray());
        }

        private void btnRemoveCourseCandidates_Click(object sender, EventArgs e)
        {
            int remIndex = lbCandidateCount.SelectedIndex;
            if (remIndex != -1)
            {
                lbCourseAdded.Items.RemoveAt(remIndex);
                lbCandidateCount.Items.RemoveAt(remIndex);

                UpdateTB(null, null);
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            String prompt = "Click OK to delete all records from this table." + Environment.NewLine + "Continue?";

            if (MessageBox.Show(prompt, "Clear all records", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sqlCommand = new OleDbCommand("DELETE FROM exam_report", dbConnect.Open());

                sqlDataAdapter.DeleteCommand = sqlCommand;
                sqlDataAdapter.DeleteCommand.ExecuteNonQuery();
                dbConnect.Close();


                //sqlCommand = new OleDbCommand("ALTER TABLE exam_report ALTER COLUMN id COUNTER(1,1)", dbConnect.Open());
                //sqlCommand.ExecuteNonQuery();

                dataGridView1.Refresh();
                dbConnect.Close();

                FillDataGrid(dataGridView1, SelectExam(), "exam_report");
                FillComboBox(cbCourse, SelectCourse(), "course_id", "course_id");
            }
        }

        private void FillDataGrid(DataGridView dg, DataSet ds, string dataMember)
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

        private void CalcRem(object sender, CancelEventArgs e)
        {
            try
            {
                uint rel, clerk, gdw, inv;
                uint relA, relB, clerkA, clerkB, gdwA, gdwB, invA, invB;
                relA = Convert.ToUInt32(txtRelP.Text);
                relB = Convert.ToUInt32(txtRelA.Text);
                rel = relA * relB;
                clerkA = Convert.ToUInt32(txtClerkP.Text);
                clerkB = Convert.ToUInt32(txtClerkA.Text);
                clerk = clerkA * clerkB;
                gdwA = Convert.ToUInt32(txtGdwP.Text);
                gdwB = Convert.ToUInt32(txtGdwA.Text);
                gdw = gdwA * gdwB;
                invA = Convert.ToUInt32(txtInvP.Text);
                invB = Convert.ToUInt32(txtInvA.Text);
                inv = invA * invB;
                txtTotal.Text = (rel + clerk + gdw + inv).ToString();

                e.Cancel = false;
                errorApp.SetError(sender as Control, "");
            }
            catch
            {
                e.Cancel = true;
                errorApp.SetError(sender as Control, "Incorrect Value");
                //(sender as TextBox).Text = "0";
            }
        }

        private void CandidatesIntValidation(object sender, CancelEventArgs e)
        {
            try
            {
                UInt32.Parse((sender as TextBox).Text);
                e.Cancel = false;
                errorApp.SetError(sender as Control, "");
            }

            catch
            {
                e.Cancel = true;
                errorApp.SetError(sender as Control, "Incorrect Input");
            }
        }
    }
}
