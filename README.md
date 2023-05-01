# school_cbdb_program
This program uses a SQLServer database that stores a school's Chromebook information such as who it's been loaned to, when, and where it is. Built as a Windows Forms Application in C#.

--------------------------------------------------------------------------------------------------------------------------------------------

v0.0.1 Initial Functionality

Desc:

Rebuild of the original code which cleans up the system to be more concise and easy to change. This version allows the user to add, remove, and edit information on the database. This update only includes the intial files to begin the development

Use:

1. .NET Framework 4.7.2
2. Microsoft.Data.SqlClient 5.1.1 (NuGet Package)

Sum:

Database and Table will be set up locally for testing. The table will include a Locations, Asset, FirstName, and LastName Columns

--------------------------------------------------------------------------------------------------------------------------------------------

v0.0.2 Introducing database link based off original trial program.

Desc: 

The code for the main functions in the original program are reintroduced. A .cs file with said functions has been created in case they are lost. It also includes how to set up the local server in order to work on it without accessing an external server.

Use:

1. school_cbdb_database as database name, if working off net
2. CBDB1 as the table name using the query in sql-queries > cbdb1_table.sql

Sum:

Code is very broken as is. The main functions need to be revised and renamed accordingly and comments need to be rewritten to make more sense. Using the external .cs file did not make the change any easier if anything it has made it harder. However the database was linked, theoretically as there is no way to test it right now. Will look over issues later.