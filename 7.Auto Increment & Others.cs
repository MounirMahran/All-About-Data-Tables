//Starting with data table creation and simple operations
DataTable EmployeesDataTable = new DataTable();

//EmployeesDataTable.Columns.Add("ID", typeof(int));
//EmployeesDataTable.Columns.Add("Name", typeof(string));
//EmployeesDataTable.Columns.Add("Country", typeof(string));
//EmployeesDataTable.Columns.Add("Salary", typeof(int));
//EmployeesDataTable.Columns.Add("DateOfBirth", typeof(DateTime));


//Add ID Data Column
DataColumn dtColumn = new DataColumn();

dtColumn.ColumnName = "ID";
dtColumn.DataType = typeof(int);
dtColumn.Unique = true;
dtColumn.AutoIncrement = true;
dtColumn.ReadOnly = true;
dtColumn.AutoIncrementSeed = 1;
dtColumn.AutoIncrementStep = 1;
//Add It To The Data Table
EmployeesDataTable.Columns.Add(dtColumn);


//Add Name Data Column
DataColumn dtColumn1 = new DataColumn();

dtColumn1.ColumnName = "Name";
dtColumn1.DataType = typeof(string);
dtColumn1.Unique = false;
dtColumn1.AutoIncrement = false;
dtColumn1.ReadOnly = false;
//Add It To The Data Table
EmployeesDataTable.Columns.Add(dtColumn1);


//Add Country Data Column
DataColumn dtColumn2 = new DataColumn();

dtColumn2.ColumnName = "Country";
dtColumn2.DataType = typeof(string);
dtColumn2.Unique = false;
dtColumn2.AutoIncrement = false;
dtColumn2.ReadOnly = false;
//Add It To The Data Table
EmployeesDataTable.Columns.Add(dtColumn2);

//Add Salary Data Column
DataColumn dtColumn3 = new DataColumn();

dtColumn3.ColumnName = "Salary";
dtColumn3.DataType = typeof(string);
dtColumn3.Unique = false;
dtColumn3.AutoIncrement = false;
dtColumn3.ReadOnly = false;
//Add It To The Data Table
EmployeesDataTable.Columns.Add(dtColumn3);

//Add Country Data Column
DataColumn dtColumn4 = new DataColumn();

dtColumn4.ColumnName = "Date Of Birth";
dtColumn4.DataType = typeof(DateTime);
dtColumn4.Unique = false;
dtColumn4.AutoIncrement = false;
dtColumn4.ReadOnly = false;
//Add It To The Data Table
EmployeesDataTable.Columns.Add(dtColumn4);


//Set ID As A Primary Key
DataColumn[] primaryKeys = new DataColumn[1];
primaryKeys[0] = EmployeesDataTable.Columns["ID"];
EmployeesDataTable.PrimaryKey = primaryKeys;


//Fill Data Table With Data
EmployeesDataTable.Rows.Add(null, "Samir Kamona", "Liebia", 1578, DateTime.Now);
EmployeesDataTable.Rows.Add(null, "Ahmed Nakhla", "Assuit", 8547, DateTime.Now);
EmployeesDataTable.Rows.Add(null, "Abdo Gebna", "Toronto", 1258, DateTime.Now);
EmployeesDataTable.Rows.Add(null, "Saed Kotta", "France", 9623, DateTime.Now);
EmployeesDataTable.Rows.Add(null, "Medhat Fakousa", "Stuttgart", 24878, DateTime.Now);



foreach (DataRow row in EmployeesDataTable.Rows)
{
    Console.WriteLine("ID: {0}\t Name: {1}\t Country: {2}\t Salary: {3}\t Date Of Birth: {4}\t",
                       row["ID"], row["Name"], row["Country"], row["Salary"], row["Date Of Birth"]);
}

