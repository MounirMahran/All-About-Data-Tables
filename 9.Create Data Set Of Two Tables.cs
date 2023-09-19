//
//Starting with data table creation and simple operations
//
DataTable EmployeesDataTable = new DataTable("EmployeesDataTable");

/*EmployeesDataTable.Columns.Add("ID", typeof(int));
EmployeesDataTable.Columns.Add("Name", typeof(string));
EmployeesDataTable.Columns.Add("Country", typeof(string));
EmployeesDataTable.Columns.Add("Salary", typeof(int));
EmployeesDataTable.Columns.Add("DateOfBirth", typeof(DateTime));
*/

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
EmployeesDataTable.Rows.Add(null, "Karim Bambo", "Stuttgart", 24878, DateTime.Now);


/*
foreach (DataRow row in EmployeesDataTable.Rows)
{
    Console.WriteLine("ID: {0}\t Name: {1}\t Country: {2}\t Salary: {3}\t Date Of Birth: {4}\t",
                       row["ID"], row["Name"], row["Country"], row["Salary"], row["Date Of Birth"]);
}

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
*/


//
//Creating Departments Data Table
//
//Create 1st Column
DataColumn DepIDDataColumn = new DataColumn();
DepIDDataColumn.ColumnName = "ID";
DepIDDataColumn.DataType = typeof(int);
DepIDDataColumn.Unique = true;
DepIDDataColumn.AllowDBNull = false;
DepIDDataColumn.AutoIncrement = true;
DepIDDataColumn.AutoIncrementSeed = 1;
DepIDDataColumn.AutoIncrementStep = 1;

//Create 2nd Column
DataColumn DepNameDataColumn = new DataColumn();
DepNameDataColumn.ColumnName = "Name";
DepNameDataColumn.DataType = typeof(string);
DepNameDataColumn.Unique = false;
DepNameDataColumn.AllowDBNull = true;

//Add Columns To DT
DataTable DepartmentsDataTable = new DataTable("DepartmentsDataTable");
DepartmentsDataTable.Columns.Add(DepIDDataColumn);
DepartmentsDataTable.Columns.Add(DepNameDataColumn);


//Fill Table With Data
DepartmentsDataTable.Rows.Add(null, "IT");
DepartmentsDataTable.Rows.Add(null, "Accounting");
DepartmentsDataTable.Rows.Add(null, "HR");

/*
//Print Deps DT
foreach(DataRow row in DepartmentsDataTable.Rows)
{
    Console.WriteLine("Dep ID: {0}\t Dep Name: {1}", row["ID"], row["Name"]);
}
*/

//
//Create Data Set And Print Tables Content From It
//
DataSet dataSet = new DataSet();
dataSet.Tables.Add(EmployeesDataTable);
dataSet.Tables.Add(DepartmentsDataTable);

//Print Emps DT
foreach (DataRow row in dataSet.Tables["EmployeesDataTable"].Rows)
{
    Console.WriteLine("ID: {0}\t Name: {1}\t Country: {2}\t Salary: {3}\t Date Of Birth: {4}\t",
                       row["ID"], row["Name"], row["Country"], row["Salary"], row["Date Of Birth"]);
}

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();



//Print Deps DT
foreach (DataRow row in dataSet.Tables["DepartmentsDataTable"].Rows)
{
    Console.WriteLine("Dep ID: {0}\t Dep Name: {1}", row["ID"], row["Name"]);
}