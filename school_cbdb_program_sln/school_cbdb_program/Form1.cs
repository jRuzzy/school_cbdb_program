using System;
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
        public static string mainDB = "school_cbdb_database"; //database string, will simplify the name change of the database used when needed
        
        string connectionString = "Data Source=" + machineName + "\\SQLEXPRESS;Initial Catalog=" + mainDB + ";Integrated Security=True;TrustServerCertificate=True"; //database connection string, using the machineName variable to autonmatically assign the 
        string mainTable = "CB3"; //table string, reused in place of the main table in all references needed
        string locTable = "LOC"; //table string, used for the loc table

        //These are all the main funtions that are used to simplify code reused
        /// <summary>
        /// Clears all entry spaces
        /// </summary>
        public void clearAll() //clears all text boxes
        {
            assetTagEntry.Text = "";
            firstNameEntry.Text = "";
            lastNameEntry.Text = "";
        }

        /// <summary>
        /// reusable function to automatically display new information as the databae is updated
        /// Takes no parameters
        /// Change the tablename being referenced according to the scenario
        /// </summary>
        public void refreshGrid() //refresh function, Change TABLENAME to the name of the table being displayed as well as the DATAGRIDVIEWNAME used to display
        {
            string sqlQuery = "SELECT * FROM " + mainTable; //query used to display the rows and columns inside the CBDB1 table

            SqlConnection sqlConnection = new SqlConnection(connectionString); //This initializes an instantaneous connection with the "connectionString" variable

            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand(sqlQuery, sqlConnection);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridCB.DataSource = dt; //this line assigns the table's values to the "dataGridCB"
            sqlConnection.Close();
        }

        /// <summary>
        /// reusable function which removes an item from a specified asset in the ASSET column of the table
        /// </summary>
        /// <param name="tag">Entered in the assetTagEntry box in the program. Reference in the ASSET column</param>
        public void removeRow(String tag) //remove function, replace CBDB1 accordingly, ASSETTAG accordingly
        {
            string sqlQuery = "DELETE FROM " + mainTable + " WHERE ASSET = " + "'" + tag + "'"; //deletes an item from the ASSET line refrenced by "tag" in the CBDB1

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand(sqlQuery, sqlConnection);
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }

        /// <summary>
        /// reusable remove function that removes an item from a specified tag for the ASSET column
        /// </summary>
        /// <param name="tag">Entered in the assetTagEntry box in the program. Reference in the ASSET column</param>
        public void addRow(String tag)//add function, replace CBDB1 accordingly, ASSETTAG, FIRST, LAST accordingly
        {
            //adds a row of the values ASSET, FIRSTNAME, LASTNAME from the corresponding entry boxes
            string sqlQuery = "INSERT INTO " + mainTable + " (ASSET, FIRSTNAME, LASTNAME) VALUES (" + "'" + assetTagEntry.Text + "'" + "," + "'" + firstNameEntry.Text + "'" + "," + "'" + lastNameEntry.Text + "'" + ")";

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand(sqlQuery, sqlConnection);
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }
        
        //these three are the find functions used to locate a sepcific attribute value
        /// <summary>
        /// this function will execute a select query through the asset column for a value containing the "tag" inputted
        /// </summary>
        /// <param name="tag">this is the value inside the asset tag that the user is trying to find</param>
        public void findAsset(String tag)
        {
            string sqlQuery = "SELECT * FROM " + mainTable + " WHERE ASSET LIKE '%" + tag + "%'";

            SqlConnection sqlConnection = new SqlConnection(connectionString); //This initializes an instantaneous connection with the "connectionString" variable

            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand(sqlQuery, sqlConnection);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridCB.DataSource = dt; //this line assigns the table's values to the "dataGridCB"
            sqlConnection.Close();
        }

        /// <summary>
        /// this function will execute a select query through the firstname column for a value containing the "first" inputted
        /// </summary>
        /// <param name="first">this is the value inside the first name that the user is trying to find</param>
        public void findFirst(String first)
        {
            string sqlQuery = "SELECT * FROM " + mainTable + " WHERE FIRSTNAME LIKE '%" + first + "%'";

            SqlConnection sqlConnection = new SqlConnection(connectionString); //This initializes an instantaneous connection with the "connectionString" variable

            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand(sqlQuery, sqlConnection);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridCB.DataSource = dt; //this line assigns the table's values to the "dataGridCB"
            sqlConnection.Close();
        }

        /// <summary>
        /// this function will execute a select query through the firstname column for a value containing the "first" inputted
        /// </summary>
        /// <param name="last">this is the value inside the last name that the user is trying to find</param>
        public void findLast(String last)
        {
            string sqlQuery = "SELECT * FROM " + mainTable + " WHERE LASTNAME LIKE '%" + last + "%'";

            SqlConnection sqlConnection = new SqlConnection(connectionString); //This initializes an instantaneous connection with the "connectionString" variable

            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand(sqlQuery, sqlConnection);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridCB.DataSource = dt; //this line assigns the table's values to the "dataGridCB"
            sqlConnection.Close();
        }

        //duplicate check 
        /// <summary>
        /// This function will check whether the inputted asset tag value has been duplicated through the database. It will then return the bool accordingly
        /// </summary>
        /// <param name="tag"></param>
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
        /// Utilizes the addRow function to create a new item in the CBDB1 table
        /// Uses entries from the assetTagEntry, firstNameEntry, and lastNameEntry as values used for the item
        /// The button's functions will also check whether the values inputted have been duplicated or not
        /// </summary>
        /// <param name="sender">built in event parameter</param>
        /// <param name="e">built in event parameter</param>
        private void button1_Click(object sender, EventArgs e) //add button
        {
            if (assetTagEntry.Text.Length == 6 && (firstNameEntry.Text != "" && lastNameEntry.Text != "")) //if the tag has 6 digits and a first and last name are included, proceed without error
            {
                if (!checkDuplicateAsset(assetTagEntry.Text)) //if the asset isn't a duplicate continue
                {
                    if (!checkDuplicateName(firstNameEntry.Text, lastNameEntry.Text)) //if the name isn't a duplicate continue
                    {
                        addRow(assetTagEntry.Text);
                        refreshGrid();
                        clearAll();
                    }
                    else //The name is a dupicate and the user is asked to remove the assigned name
                    {
                        string message = "This person has already been assigned an item. Please remove the item first.";
                        string title = "Duplicate Assignment Error";
                        MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                        DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Stop);
                        if (result == DialogResult.OK)
                        {
                            clearAll();
                        }
                    }
                }
                else //The asset is a duplicate
                {
                    if (!checkDuplicateName(firstNameEntry.Text, lastNameEntry.Text)) //if the name isn't a duplicate, ask to overwrite the assignment
                    {
                        string message = "Would you like to overwrite the Asset assignment?";
                        string title = "Duplicate Asset Error";
                        MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                        DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question);
                        if (result == DialogResult.OK)
                        {
                            removeRow(assetTagEntry.Text);
                            addRow(assetTagEntry.Text);
                            clearAll();
                        }
                    }
                    else //The item is an exact duplicate, clears all entries
                    {
                        string message = "This asset and assignment already exist";
                        string title = "Duplicate Item Error";
                        MessageBox.Show(message, title);

                        clearAll();
                    }
                }
            }
            else if (assetTagEntry.Text.Length != 6) //if the tag is not 6 digits the user will be displayed an error and forced to fix the mistake
            {
                string message = "Asset Tag must be 6 digits.";
                string title = "Input Error";
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Stop);
                if (result == DialogResult.OK)
                {
                    clearAll();
                }
            }
            else //if a first and last name are not specified the user will be displayed an error and forced to correct it
            {
                string message = "Please assign both a first and last name.";
                string title = "Input Error";
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Stop);
                if (result == DialogResult.OK)
                {
                    clearAll();
                }
            }
        }

        /// <summary>
        /// Creates a delete query to clear a row from the table based on the value inputted for the ASSET column
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e) //delete button
        {
            if(assetTagEntry.Text.Length == 6) //as long as the asset entry has a 6 digit number, the removeRow function will be called with a value of the Text inside the entry then refreshed
            {
                removeRow(assetTagEntry.Text);
                refreshGrid();

                clearAll();
            }
            else //if asset entry is not 6 digits the user will be warned and forced to correct it
            {
                string message = "Asset Tag must be 6 digits.";
                string title = "Input Error";
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.OK)
                {
                    clearAll();
                }
            }
        }

        /// <summary>
        /// Creates a SELECT query for the ASSET, FIRSTNAME, and LASTNAME attributes in that exact order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button6_Click(object sender, EventArgs e) //find button
        {
            if (assetTagEntry.Text.Length > 0) //as long as the asset entry has a 6 digit number, the removeRow function will be called with a value of the Text inside the entry then refreshed
            {
                findAsset(assetTagEntry.Text);
            }
            else if (firstNameEntry.Text.Length > 0)
            {
                findFirst(firstNameEntry.Text);
            }
            else if (lastNameEntry.Text.Length > 0)
            {
                findLast(lastNameEntry.Text);
            }
            else //if asset entry is not 6 digits the user will be warned and forced to correct it
            {
                string message = "Refresh list?";
                string title = "Resfresh Request";
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.OK)
                {
                    clearAll();

                    refreshGrid();
                }
            }
        }

        /// <summary>
        /// Creates a clear request with the clearAll() func
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e) //clear button
        {
            clearAll();
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
    }
}
