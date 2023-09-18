//Sorting data table
EmployeesDataTable.DefaultView.Sort = "ID DESC";
EmployeesDataTable = EmployeesDataTable.DefaultView.ToTable();

foreach (DataRow row in EmployeesDataTable.Rows)
{
    Console.WriteLine("ID: {0}\t Name: {1}\t Country: {2}\t Salary: {3}\t Date Of Birth: {4}\t",
                       row["ID"], row["Name"], row["Country"], row["Salary"], row["DateOfBirth"]);
}

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();


EmployeesDataTable.DefaultView.Sort = "Name DESC";
EmployeesDataTable = EmployeesDataTable.DefaultView.ToTable();

foreach (DataRow row in EmployeesDataTable.Rows)
{
    Console.WriteLine("ID: {0}\t Name: {1}\t Country: {2}\t Salary: {3}\t Date Of Birth: {4}\t",
                       row["ID"], row["Name"], row["Country"], row["Salary"], row["DateOfBirth"]);
}

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

EmployeesDataTable.DefaultView.Sort = "Salary ASC";
EmployeesDataTable = EmployeesDataTable.DefaultView.ToTable();

foreach (DataRow row in EmployeesDataTable.Rows)
{
    Console.WriteLine("ID: {0}\t Name: {1}\t Country: {2}\t Salary: {3}\t Date Of Birth: {4}\t",
                       row["ID"], row["Name"], row["Country"], row["Salary"], row["DateOfBirth"]);
}