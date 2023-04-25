using Microsoft.Data.SqlClient;
using System.Data;

namespace ChromebookDBApp
{
    public partial class Form1 : Form
    {
        string connectionString = "Data Source=DesktopJR\\SQLEXPRESS;Initial Catalog=ChromebooksV1;Integrated Security=True;TrustServerCertificate=True";

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Refresh function that initializes as soon as a 
        /// </summary>
        public void refreshGrid() //refresh function
        {
            string sqlQuery = "SELECT * FROM CHROMEBOOKSDB2";

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand(sqlQuery, sqlConnection);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlConnection.Close();
        }

        public void removeRow(String tag) //remove function
        {
            string sqlQuery = "DELETE FROM CHROMEBOOKSDB2 WHERE ChromeTag = " + "'" + tag + "'";

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand(sqlQuery, sqlConnection);
            cmd.ExecuteNonQuery();
            sqlConnection.Close();

            txtAsset.Text = "";
            txtUserFn.Text = "";
            txtUserLn.Text = "";
        }

        public void addRow(String tag)//add function
        {
            string sqlQuery = "INSERT INTO CHROMEBOOKSDB2 (ChromeTag, ChromeUserFn, ChromeUserLn) VALUES (" + "'" + txtAsset.Text + "'" + "," + "'" + txtUserFn.Text + "'" + "," + "'" + txtUserLn.Text + "'" + ")";

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand(sqlQuery, sqlConnection);
            cmd.ExecuteNonQuery();
            sqlConnection.Close();

            txtAsset.Text = "";
            txtUserFn.Text = "";
            txtUserLn.Text = "";
        }

        private void button3_Click(object sender, EventArgs e) //Remove a Chromebook
        {
            removeRow(txtAsset.Text);
            refreshGrid();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //Adds a Chromebook and user to DB
        {
            if(txtAsset.Text.Length > 5)
            {
                addRow(txtAsset.Text);
                refreshGrid();
            }
            else
            {
                string message = "Tag must be 6 digits.";
                string title = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                if(result == DialogResult.OK)
                {
                    txtAsset.Text = "";
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            refreshGrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void button2_Click(object sender, EventArgs e) //edit button
        {
            string sqlQuery = "UPDATE CHROMEBOOKSDB2 SET ChromeUserFn = '" + txtUserFn.Text + "', ChromeUserLn = '" + txtUserLn.Text + "' WHERE ChromeTag = '" + txtAsset.Text + "'";

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand(sqlQuery, sqlConnection);
            cmd.ExecuteNonQuery();
            sqlConnection.Close();

            refreshGrid();
        }
    }
}