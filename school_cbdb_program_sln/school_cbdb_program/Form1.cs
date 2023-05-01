﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace school_cbdb_program
{
    public partial class Form1 : Form
    {
        //database connection string
        string connectionString = "Data Source=LaptopJR\\SQLEXPRESS;Initial Catalog=school_cbdb_database;Integrated Security=True;TrustServerCertificate=True";

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
            dataGridCB.DataSource = dt;
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

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
