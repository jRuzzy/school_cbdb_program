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

--------------------------------------------------------------------------------------------------------------------------------------------

v0.0.3 Finalized table link and 2 main functions added

Desc:

The table has been linked and tested. Documentation has been written, roughly, accordingly. The addRow, removeRow, and refreshGrid functions have been implemented and tested. No issues with the functins and the table themselves have arised.

Feat:

1. addRow(string tag) - Adds a row for the column under asset that corresponds with the tag string, takes one input requires 3 data points
2. removeRow(String tag) - Adds a row for the column under asset that corresponds with the tag string, takes one input
3. refreshGrid() - Displays updates to the table as soon as the function is called, takes no inputs

Sum:

Documentation in the code itself needs to be looked through and reassesed. It should specify which points of the link between program and the table cause what. The use of the removeRow() function needs to be implemented as well. No errors but "else" instance in the addRow() function could lead to one. This should also be looked into further.

--------------------------------------------------------------------------------------------------------------------------------------------

v0.0.4 Remove function added and new documentation

Desc:

The Remove function has finally been implemented with an error warning similar to the one used in the Add button function. The documentation in the code has also been added to in the form of new details that improve understanding of the methods. The program will now find the device name itself through a variable set once the program launches to eliminate the need to update code when testing on other machines. Dropdown was added for the locations entry which still needs to be developed and a checkbox column has also been added to the dataGridCB.

Feat:

1. machineName variable will take the name of the current machine and automatically set the local server name for testing purposes
2. Checkbox column
3. Remove function
4. Locations drop down added

Sum:

Still need to implement a trial version of the dropdown for the locations as well as a Find function. In order to test the Find function, however, a Clone Check procedure needs to be implemented as well as a sample size of data for testing purposes.