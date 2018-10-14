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
using AutoCRBP_X.Reports;

namespace AutoCRBP_X
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            DBConnect dbConnect = new DBConnect();

            if (dbConnect.currentStatus == DBConnect.DBStatus.Database_Ready)
            {
                lblDbStatus.Text += dbConnect.currentStatus;
            }

            else
            {
                lblDbStatus.Text += DBConnect.DBStatus.Database_NotFound;
                menuStrip1.Enabled = false;
            }
        }
         
        void ShowDashboard(object s, EventArgs e)
        {
            this.Show();
        }

        void HideDashboard(object s, EventArgs e)
        {
            this.Hide();
        }

        private void coursesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Course f = new Course();
            f.Shown += HideDashboard;
            f.FormClosed += ShowDashboard;

            f.Show();
        }

        private void staffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Staff f = new Staff();
            f.Shown += HideDashboard;
            f.FormClosed += ShowDashboard;

            f.Show();
        }

        public void staffDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Staff_Details f = new Staff_Details();
            f.Shown += HideDashboard;
            f.FormClosed += ShowDashboard;

            f.Show();
        }

        private void examDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exam f = new Exam();
            f.Shown += HideDashboard;
            f.FormClosed += ShowDashboard;

            f.Show();
        }

        private void examReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report_Exam f = new Report_Exam();
            f.Shown += HideDashboard;
            f.FormClosed += ShowDashboard;

            f.Show();
        }

        private void staffReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report_Staff f = new Report_Staff();
            f.Shown += HideDashboard;
            f.FormClosed += ShowDashboard;

            f.Show();
        }
    }
}
