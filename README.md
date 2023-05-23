Chromebook Database Program
===========================
This program uses a SQLServer database that stores a school's Chromebook information such as who it's been loaned to, when, and where it is. Built as a Windows Forms Application in C#.

## Use Intructions

The testing version of the program runs off a local SQL database that needs to be set up and defined in the code before running. You will need to set up SQL Server Management Studio with the SQL Server Express plugin available here:

1. https://learn.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?redirectedfrom=MSDN&view=sql-server-ver16 - SSMS
2. https://www.microsoft.com/en-us/sql-server/sql-server-downloads - SQL Express

Express allows you to test the system's capabilities without the need of an external server.

The program will automatically pull the name of the device and will only require the name of the database and tables being used. Both of these are stored in 'databaseName', 'mainTable', and 'locTable' respectivee to their uses. For the sake of simplicity please set up the database on Microsoft SQL Server Management Studio under the default device local path.

The SQL queries to initialize the tables as well as the testing data set are stored inside 'school_cbdb_program/sql-queries/v0.1.2'. Named as such because of when this update to the data set was introduced.

Once complete the program can be launched from VS and should be ready for testing.

v0.2.0 Regenerative branch
---------------------------

Changes:

1. mainDB is now "cbdb" - Change local database accordingly
2. mainTable is now "ASCB" - new table is initiated with the appropriate SQL Query in the new v0.2 folder
3. adds storedTable "STCB" - references the new table that contains the assets that are not assigned
4. AssignForm - will contain all functions that involve assigning an asset to a student
5. CreateForm - will contain all functions that involve adding an asset to a particular stock location
6. ADD and REMOVE buttons have been deleted as they are no longer needed in Form1
wwww
v0.1.4 Update - Help button
---------------------------

Desc: 

The HELP button has been added. Mostly a place holder feature for the duration of the program's development. In order to avoid redundancy with changing controls the actual guide will be written as soon as v1.0 is shipped.

Feat:

1. HELP button

v0.1.3 Clear button update
---------------------------

Desc:

This feature update introduces a CLEAR button which does exactly what it's labeled as. It will clear all entries. This update also cleans up patch notes a bit to look a bit nicer and be easier to read.

Feat:

1. CLEAR button
2. Cleaned README

Sum:

Creating a new branch to work on the development of the locations feature as well as the help feature side by side. Will be tricky to independently implement the locations feature so I might focus next patch on the HELP feature first.

v0.1.2 Stable modular patch
---------------------------

Desc:

This patch for the most part only changes some of the connection string to be easier to update in the event the table has to be migrated an a different name needs to be used. The new table has been made and named "CB3" for the sake of simplicity. The table now has a new "LOC" column which will contain the value of a non-assigned ASSET. The "LOC" table has also been created but has not been implemented and only consists of a primary key "ID" column and an "LOCNAME" column.

Feat:

1. New CB3 table
    Same as the old table but adds LOC column
2. Modularity changes
    string mainTable has been initialized to CB3
    string locTable has been initialized to LOC
3. Removed unused SELECT column from previous build
4. SQL queries to initialize tables and test data set in 'school_cbdb_program/sql-queries/v0.1.2'

Sum:

Still at a usable state but the code will need to be majorly redone in order to accomodate the new location system. This means that testing for that new feature will require a branch that simplifies the ADD functionality. The entire button function will need to be redone. Location first needs to be set up with a new Form to allow the creation and removal of locations.

v0.1.1 Stable Test Version
---------------------------

Desc:

Finally! The program is now self-dependant and no longer requires knowledge of the values in the table to maintain a working database. The duplicate check functions add further functionality to the ADD button making it all the more easier to keep track of duplicates. Removing the EDIT button from the previous version simplifies controls greatly.

Feat:

1. ADD button
    uses [checkDuplicateAsset()]
    uses [checkDuplicateName()]

Sum:

This version has been tested and proved stable and covers most common cases. Rare cases will need to be debugged as the come up. Next step is the implementation of the locations column and the addition of the help form which lists the instructions for how to use the program.

v0.1 Find function and data model, ready for advanced features
---------------------------

Desc:

The program has finally been set up in a way that will allow effective local testing. Through the use of ChatGPT the test Data model has been expanded to at least 100 values of random asset numbers and names. The find function has also been implemented. While primitive, as it can only search through one entry at a time, it does enough for its main purpose.

Feat:

1. Find button
    [public void findAsset(String tag)]
    [public void findFirst(String first)]
    [public void findLast(String last)]

Sum: Next step should be to incorporate the clone cgeck function to ensure data isn't overwritten unintentionally. Should also look into fleshing out the Find button to search with more than one query at a time.

v0.0.4 Remove function added and new documentation
---------------------------

Desc:

The Remove function has finally been implemented with an error warning similar to the one used in the Add button function. The documentation in the code has also been added to in the form of new details that improve understanding of the methods. The program will now find the device name itself through a variable set once the program launches to eliminate the need to update code when testing on other machines. Dropdown was added for the locations entry which still needs to be developed and a checkbox column has also been added to the dataGridCB.

Feat:

1. machineName variable will take the name of the current machine and automatically set the local server name for testing purposes
2. Checkbox column
3. Remove function
4. Locations drop down added

Sum:

Still need to implement a trial version of the dropdown for the locations as well as a Find function. In order to test the Find function, however, a Clone Check procedure needs to be implemented as well as a sample size of data for testing purposes.

v0.0.3 Finalized table link and 2 main functions added
---------------------------

Desc:

The table has been linked and tested. Documentation has been written, roughly, accordingly. The addRow, removeRow, and refreshGrid functions have been implemented and tested. No issues with the functins and the table themselves have arised.

Feat:

1. addRow(string tag) - Adds a row for the column under asset that corresponds with the tag string, takes one input requires 3 data points
2. removeRow(String tag) - Adds a row for the column under asset that corresponds with the tag string, takes one input
3. refreshGrid() - Displays updates to the table as soon as the function is called, takes no inputs

Sum:

Documentation in the code itself needs to be looked through and reassesed. It should specify which points of the link between program and the table cause what. The use of the removeRow() function needs to be implemented as well. No errors but "else" instance in the addRow() function could lead to one. This should also be looked into further.

v0.0.2 Introducing database link based off original trial program.
---------------------------

Desc: 

The code for the main functions in the original program are reintroduced. A .cs file with said functions has been created in case they are lost. It also includes how to set up the local server in order to work on it without accessing an external server.

Use:

1. school_cbdb_database as database name, if working off net
2. CBDB1 as the table name using the query in sql-queries > cbdb1_table.sql

Sum:

Code is very broken as is. The main functions need to be revised and renamed accordingly and comments need to be rewritten to make more sense. Using the external .cs file did not make the change any easier if anything it has made it harder. However the database was linked, theoretically as there is no way to test it right now. Will look over issues later.

v0.0.1 Initial Functionality
---------------------------

Desc:

Rebuild of the original code which cleans up the system to be more concise and easy to change. This version allows the user to add, remove, and edit information on the database. This update only includes the intial files to begin the development

Use:

1. .NET Framework 4.7.2
2. Microsoft.Data.SqlClient 5.1.1 (NuGet Package)

Sum:

Database and Table will be set up locally for testing. The table will include a Locations, Asset, FirstName, and LastName Columns