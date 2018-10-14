using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AutoCRBP_X
{
    class DBConnect
    {
        public enum DBStatus
        {
            Database_Ready,
            Database_NotFound,
            Connection_Opened,
            Connection_Closed,
            Connection_Error
        };

        public OleDbConnection con;
        public DBStatus currentStatus;

        public DBConnect()
        {
            try
            {
                //Relative to application path
                //Use it only for release
                //Debug will have db overwrite
                //string dbPath = Application.StartupPath.ToString() + "\\database\\autocrb.accdb";
                
                //Dont ask ._.
                string dbPath = Application.StartupPath.ToString() + "..\\..\\..\\..\\database\\autocrb.accdb";
                con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + dbPath + ";Persist Security Info=True");
                con.Open();
                currentStatus = DBStatus.Database_Ready;
            }

            catch (OleDbException)
            {
                String message = "Could not connect to the database!"
                    + Environment.NewLine
                    + "Please ensure that the database file 'autocrb.accdb' is present in database folder!";

                MessageBox.Show(message, "Database Error", MessageBoxButtons.OK);
                this.currentStatus = DBStatus.Database_NotFound;
            }

            finally
            {
                //Close it once initialized, open con when required
                con.Close();
            }
        }

        public OleDbConnection Open()
        {
            try
            {
                con.Close();
                con.Open();
                currentStatus = DBStatus.Connection_Opened;
            }

            catch (OleDbException ex)
            {
                currentStatus = DBStatus.Connection_Error;
                MessageBox.Show("Unable to Open Connection!" + Environment.NewLine + ex.ToString(),
                    "Connection Error!", MessageBoxButtons.OK);
            }

            return con;
        }

        public OleDbConnection Close()
        {
            try
            {
                con.Close();
                currentStatus = DBStatus.Connection_Closed;
            }

            catch (OleDbException ex)
            {
                currentStatus = DBStatus.Connection_Error;
                MessageBox.Show("Unable to Close Connection!" + Environment.NewLine + ex.ToString(),
                    "Connection Error!", MessageBoxButtons.OK);
            }

            return con;
        }
    }
}
