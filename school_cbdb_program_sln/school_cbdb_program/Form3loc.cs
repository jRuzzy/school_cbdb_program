using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace school_cbdb_program
{
    public partial class Form3loc : Form
    {
        public static string machineName = System.Windows.Forms.SystemInformation.ComputerName; //This simplifies local testing by automatically setting the connection string without needing to input it manually. As long as the rest of the database is set up correctly nothing needs to be done to this.
        public static string mainDB = "school_cbdb_database"; //database string, will simplify the name change of the database used when needed

        string connectionString = "Data Source=" + machineName + "\\SQLEXPRESS;Initial Catalog=" + mainDB + ";Integrated Security=True;TrustServerCertificate=True"; //database connection string, using the machineName variable to autonmatically assign the 
        string mainTable = "CB3"; //table string, reused in place of the main table in all references needed
        string locTable = "LOC"; //table string, used for the loc table

        public void refreshGrid() //refresh function, Change TABLENAME to the name of the table being displayed as well as the DATAGRIDVIEWNAME used to display
        {
            string sqlQuery = "SELECT * FROM " + locTable; //query used to display the rows and columns inside the CBDB1 table

            SqlConnection sqlConnection = new SqlConnection(connectionString); //This initializes an instantaneous connection with the "connectionString" variable

            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand(sqlQuery, sqlConnection);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt; //this line assigns the table's values to the "dataGridCB"
            sqlConnection.Close();
        }

        public Form3loc()
        {
            InitializeComponent();
            refreshGrid();
        }

        private void button1_Click(object sender, EventArgs e) //add button
        {

        }

        private void button2_Click(object sender, EventArgs e) //edit button
        {

        }
    }
}
