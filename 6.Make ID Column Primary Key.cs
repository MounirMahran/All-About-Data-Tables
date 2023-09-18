//Set A Primary Key
DataTable EmployeesDataTable = new DataTable();

EmployeesDataTable.Columns.Add("ID", typeof(int));
EmployeesDataTable.Columns.Add("Name", typeof(string));
EmployeesDataTable.Columns.Add("Country", typeof(string));
EmployeesDataTable.Columns.Add("Salary", typeof(int));
EmployeesDataTable.Columns.Add("DateOfBirth", typeof(DateTime));

DataColumn[] primaryKeys = new DataColumn[1];
primaryKeys[0] = EmployeesDataTable.Columns["ID"];
EmployeesDataTable.PrimaryKey = primaryKeys;


//If we tried to enter a row that has present ID DT will refuse it
EmployeesDataTable.Rows.Add(1, "Samir Kamona", "Liebia", 1578, DateTime.Now);
EmployeesDataTable.Rows.Add(2, "Ahmed Nakhla", "Assuit", 8547, DateTime.Now);
EmployeesDataTable.Rows.Add(3, "Abdo Gebna", "Toronto", 1258, DateTime.Now);
EmployeesDataTable.Rows.Add(4, "Saed Kotta", "France", 9623, DateTime.Now);
EmployeesDataTable.Rows.Add(5, "Medhat Fakousa", "Stuttgart", 24878, DateTime.Now);



foreach (DataRow row in EmployeesDataTable.Rows)
{
    Console.WriteLine("ID: {0}\t Name: {1}\t Country: {2}\t Salary: {3}\t Date Of Birth: {4}\t",
                       row["ID"], row["Name"], row["Country"], row["Salary"], row["DateOfBirth"]);
}

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
