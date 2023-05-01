//This will initiate the link with the server database and the device that is running the application. DEVICENAME and DATABASENAME would need to be changed accordingly
string connectionString = "Data Source=DEVICENAME\\SQLEXPRESS;Initial Catalog=DATABASENAME;Integrated Security=True;TrustServerCertificate=True"

//Standard functions that run most of the queries in adding, removing, and updating what is shown in the datagridview
public void refreshGrid() //refresh function, Change TABLENAME to the name of the table being displayed as well as the DATAGRIDVIEWNAME used to display
        {
            string sqlQuery = "SELECT * FROM TABLENAME";

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand(sqlQuery, sqlConnection);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            DATAGRIDVIEWNAME.DataSource = dt;
            sqlConnection.Close();
        }

        public void removeRow(String tag) //remove function, replace TABLENAME, ASSETTAG accordingly
        {
            string sqlQuery = "DELETE FROM TABLENAME WHERE ASSETTAG = " + "'" + tag + "'";

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand(sqlQuery, sqlConnection);
            cmd.ExecuteNonQuery();
            sqlConnection.Close();

            ASSET.Text = "";
            FIRST.Text = "";
            LAST.Text = "";
        }

        public void addRow(String tag)//add function, replace TABLENAME, ASSETTAG, FIRST, LAST accordingly
        {
            string sqlQuery = "INSERT INTO TABLENAME (ASSETTAG, FIRST, LAST) VALUES (" + "'" + ASSET.Text + "'" + "," + "'" + FIRST.Text + "'" + "," + "'" + LAST.Text + "'" + ")";

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand(sqlQuery, sqlConnection);
            cmd.ExecuteNonQuery();
            sqlConnection.Close();

            ASSET.Text = "";
            FIRST.Text = "";
            LAST.Text = "";
        }