﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions.Configuration;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace school_cbdb_program
{
    public partial class Form1 : Form
    {
        public static string machineName = System.Windows.Forms.SystemInformation.ComputerName; //This simplifies local testing by automatically setting the connection string without needing to input it manually. As long as the rest of the database is set up correctly nothing needs to be done to this.
        public static string mainDB = "cbdb"; //database string, will simplify the name change of the database used when needed
        
        string connectionString = "Data Source=" + machineName + "\\SQLEXPRESS;Initial Catalog=" + mainDB + ";Integrated Security=True;TrustServerCertificate=True"; //database connection string, using the machineName variable to autonmatically assign the 
        string mainTable = "ASCB"; //table string, reused in place of the main table that contains all assigned chromebooks
        string storedTable = "STCB"; //table string, reused in place of the table that contains all unasigned chromebooks
        string locTable = "LOC"; //table string, used for the loc table

        /// <summary>
        /// reusable function to automatically display new information as the databae is updated
        /// Takes no parameters
        /// Change the tablename being referenced according to the scenario
        /// </summary>
        public void refreshGrid() //refresh function, Change TABLENAME to the name of the table being displayed as well as the DATAGRIDVIEWNAME used to display
        {
            string sqlQueryOne = "SELECT * FROM " + mainTable; //query used to display the rows and columns inside the CBDB1 table

            SqlConnection sqlConnectionOne = new SqlConnection(connectionString); //This initializes an instantaneous connection with the "connectionString" variable

            sqlConnectionOne.Open();
            SqlCommand cmd = new SqlCommand(sqlQueryOne, sqlConnectionOne);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridASCB.DataSource = dt; //this line assigns the table's values to the "dataGridCB"
            sqlConnectionOne.Close();

            string sqlQueryTwo = "SELECT * FROM " + storedTable; //query used to display the rows and columns inside the CBDB1 table

            SqlConnection sqlConnectionTwo = new SqlConnection(connectionString); //This initializes an instantaneous connection with the "connectionString" variable

            sqlConnectionTwo.Open();
            SqlCommand cmdTwo = new SqlCommand(sqlQueryTwo, sqlConnectionTwo);
            cmdTwo.ExecuteNonQuery();
            DataTable dtst = new DataTable();
            SqlDataAdapter dast = new SqlDataAdapter(cmdTwo);
            dast.Fill(dtst);
            dataGridSTCB.DataSource = dtst; //this line assigns the table's values to the "dataGridCB"
            sqlConnectionTwo.Close();
        }

        /// <returns>False if the asset tag has not been used, true if yes</returns>
        public bool checkDuplicateAsset(string tag) //checks if the asset tag is a duplicate
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();

            using (var sqlCommand = new SqlCommand("SELECT * FROM " + mainTable + " WHERE ASSET LIKE '" + tag + "'", sqlConnection))
            {
                
                SqlDataReader reader = sqlCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    return true;
                }
                else
                {
                    return false;
                }

                reader.Close();
                reader.Dispose();

            }

            sqlConnection.Close();
        }

        /// <summary>
        /// The function will take in a first and last valie which would each return a string. The strings will be validated through the table to determine whether the values have been duplicated or not
        /// The system will then return the bool appropriately
        /// </summary>
        /// <param name="first"></param>
        /// <param name="last"></param>
        /// <returns>False if the strings are not duplicates, true if yes</returns>
        public bool checkDuplicateName(string first, string last) //check if the both the first and last name are duplicates
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();

            using (var sqlCommand = new SqlCommand("SELECT * FROM " + mainTable + " WHERE FIRSTNAME = '" + first + "' AND LASTNAME = '" + last + "'", sqlConnection))
            {

                SqlDataReader reader = sqlCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    return true;
                }
                else
                {
                    return false;
                }

                reader.Close();
                reader.Dispose();

            }

            sqlConnection.Close();
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

        //These are the main button functions
        private void Form1_Load(object sender, EventArgs e) //form load code
        {

        }

        /// <summary>
        /// Launches the help window which includes use instructions
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e) //help button
        {
            var newForm = new Form2help();
            newForm.Show();
        }

        /// <summary>
        /// Launches the create window that allows the user to add chromebooks to the entire database
        /// This step would be required to ensure that no unregistered chrombooks are assigned to students
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e) //create button
        {
            var newForm = new CreateForm();
            newForm.Show();
        }

        /// <summary>
        /// Launches the assign window that assigns a chromebook from the stored table to the inputted student
        /// The assigned chromebook must've been previously added to the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button7_Click(object sender, EventArgs e)
        {
            var newForm = new AssignForm();
            newForm.Show();
        }
    }
}