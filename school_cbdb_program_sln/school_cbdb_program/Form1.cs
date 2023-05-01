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
    public partial class Form1 : Form
    {
        //database connection string
        string connectionString = "Data Source=LaptopJR\\SQLEXPRESS;Initial Catalog=school_cbdb_database;Integrated Security=True;TrustServerCertificate=True";

        /// <summary>
        /// reusable function to automatically display new information as the databae is updated
        /// Takes no parameters
        /// Change the tablename being referenced according to the scenario
        /// </summary>
        public void refreshGrid() //refresh function, Change TABLENAME to the name of the table being displayed as well as the DATAGRIDVIEWNAME used to display
        {
            string sqlQuery = "SELECT * FROM CBDB1";

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand(sqlQuery, sqlConnection);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridCB.DataSource = dt;
            sqlConnection.Close();
        }

        /// <summary>
        /// reusable function which removes an item from a specified asset in the ASSET column of the table
        /// </summary>
        /// <param name="tag">Entered in the assetTagEntry box in the program. Reference in the ASSET column</param>
        public void removeRow(String tag) //remove function, replace TABLENAME, ASSETTAG accordingly
        {
            string sqlQuery = "DELETE FROM CBDB1 WHERE ASSET = " + "'" + tag + "'";

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand(sqlQuery, sqlConnection);
            cmd.ExecuteNonQuery();
            sqlConnection.Close();

            assetTagEntry.Text = "";
            firstNameEntry.Text = "";
            lastNameEntry.Text = "";
        }

        /// <summary>
        /// reusable remove function that removes an item from a specified tag for the ASSET column
        /// </summary>
        /// <param name="tag">Entered in the assetTagEntry box in the program. Reference in the ASSET column</param>
        public void addRow(String tag)//add function, replace TABLENAME, ASSETTAG, FIRST, LAST accordingly
        {
            string sqlQuery = "INSERT INTO CBDB1 (ASSET, FIRSTNAME, LASTNAME) VALUES (" + "'" + assetTagEntry.Text + "'" + "," + "'" + firstNameEntry.Text + "'" + "," + "'" + lastNameEntry.Text + "'" + ")";

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand(sqlQuery, sqlConnection);
            cmd.ExecuteNonQuery();
            sqlConnection.Close();

            assetTagEntry.Text = "";
            firstNameEntry.Text = "";
            lastNameEntry.Text = "";
        }

        /// <summary>
        /// Form initialization
        /// Use refreshGrid function on startup to display the data from the CBDB1 table
        /// Takes no parameters
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            refreshGrid();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// Utilizes the addRow function to create a new item in the CBDB1 table
        /// Uses entries from the assetTagEntry, firstNameEntry, and lastNameEntry as values used for the item
        /// </summary>
        /// <param name="sender">built in event parameter</param>
        /// <param name="e">built in event parameter</param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (assetTagEntry.Text.Length == 6 && (firstNameEntry.Text != "" && lastNameEntry.Text != "")) //if the tag has 6 digits and a first and last name are included, proceed without error
            {
                addRow(assetTagEntry.Text);
                refreshGrid();
            }
            else if (assetTagEntry.Text.Length != 6) //if the tag is not 6 digits the user will be displayed an error and forced to fix the mistake
            {
                string message = "Asset Tag must be 6 digits.";
                string title = "Input Error";
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.OK)
                {
                    assetTagEntry.Text = "";
                    firstNameEntry.Text = "";
                    lastNameEntry.Text = "";
                }
            }
            else //if a first and last name are not specified the user will be displayed an error and forced to correct it
            {
                string message = "Please assign both a first and last name.";
                string title = "Input Error";
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.OK)
                {
                    assetTagEntry.Text = "";
                    firstNameEntry.Text = "";
                    lastNameEntry.Text = "";
                }
            }
        }
    }
}
