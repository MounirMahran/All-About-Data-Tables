//To Update A Record 
DataRow[] dataRow2 = EmployeesDataTable.Select("ID = 3");

foreach (DataRow dataRow in dataRow2)
{
    dataRow["Name"] = "Amir Fathi";
    dataRow["Salary"] = 30233;
}


foreach (DataRow row in EmployeesDataTable.Rows)
{
    Console.WriteLine("ID: {0}\t Name: {1}\t Country: {2}\t Salary: {3}\t Date Of Birth: {4}\t",
                       row["ID"], row["Name"], row["Country"], row["Salary"], row["DateOfBirth"]);
}