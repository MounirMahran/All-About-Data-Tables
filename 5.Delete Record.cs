//To Delete A Record

DataRow[] dataRows1 = EmployeesDataTable.Select("ID = 4");

foreach (DataRow dataRow in dataRows1)
{
    dataRow.Delete();
}


foreach (DataRow row in EmployeesDataTable.Rows)
{
    Console.WriteLine("ID: {0}\t Name: {1}\t Country: {2}\t Salary: {3}\t Date Of Birth: {4}\t",
                       row["ID"], row["Name"], row["Country"], row["Salary"], row["DateOfBirth"]);
}
