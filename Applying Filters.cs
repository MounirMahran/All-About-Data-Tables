//Applying filters to data table

DataRow[] dataRows = EmployeesDataTable.Select("Country = 'France'");

NumOfEmps = dataRows.Count();

foreach (DataRow row in dataRows)
{
    Console.WriteLine("ID: {0}\t Name: {1}\t Country: {2}\t Salary: {3}\t Date Of Birth: {4}\t",
                       row["ID"], row["Name"], row["Country"], row["Salary"], row["DateOfBirth"]);
}


SumOfSals = Convert.ToDouble(EmployeesDataTable.Compute("SUM(Salary)", "Country = 'France'"));
AvgOfSals = Convert.ToDouble(EmployeesDataTable.Compute("AVG(Salary)", "Country = 'France'"));
MinSal = Convert.ToDouble(EmployeesDataTable.Compute("MIN(Salary)", "Country = 'France'"));
MaxSal = Convert.ToDouble(EmployeesDataTable.Compute("MAX(Salary)", "Country = 'France'"));

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("Num Of Employees: " + NumOfEmps);
Console.WriteLine("Sum Of Salaries : " + SumOfSals);
Console.WriteLine("AVG Of Salaries : " + AvgOfSals);
Console.WriteLine("Min Salary      : " + MinSal);
Console.WriteLine("Max Salary      : " + MaxSal);


Console.WriteLine();
Console.WriteLine();
Console.WriteLine();



dataRows = EmployeesDataTable.Select("Country = 'France' OR Country = 'Assuit'");

NumOfEmps = dataRows.Count();

foreach (DataRow row in dataRows)
{
    Console.WriteLine("ID: {0}\t Name: {1}\t Country: {2}\t Salary: {3}\t Date Of Birth: {4}\t",
                       row["ID"], row["Name"], row["Country"], row["Salary"], row["DateOfBirth"]);
}


SumOfSals = Convert.ToDouble(EmployeesDataTable.Compute("SUM(Salary)", "Country = 'France' OR Country = 'Assuit'"));
AvgOfSals = Convert.ToDouble(EmployeesDataTable.Compute("AVG(Salary)", "Country = 'France' OR Country = 'Assuit'"));
MinSal = Convert.ToDouble(EmployeesDataTable.Compute("MIN(Salary)", "Country = 'France' OR Country = 'Assuit'"));
MaxSal = Convert.ToDouble(EmployeesDataTable.Compute("MAX(Salary)", "Country = 'France' OR Country = 'Assuit'"));

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("Num Of Employees: " + NumOfEmps);
Console.WriteLine("Sum Of Salaries : " + SumOfSals);
Console.WriteLine("AVG Of Salaries : " + AvgOfSals);
Console.WriteLine("Min Salary      : " + MinSal);
Console.WriteLine("Max Salary      : " + MaxSal);
