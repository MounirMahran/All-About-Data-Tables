//Starting with data table creation and simple operations
DataTable EmployeesDataTable = new DataTable();

EmployeesDataTable.Columns.Add("ID", typeof(int));
EmployeesDataTable.Columns.Add("Name", typeof(string));
EmployeesDataTable.Columns.Add("Country", typeof(string));
EmployeesDataTable.Columns.Add("Salary", typeof(int));
EmployeesDataTable.Columns.Add("DateOfBirth", typeof(DateTime));

EmployeesDataTable.Rows.Add(1, "Samir Kamona", "Liebia", 1578, DateTime.Now);
EmployeesDataTable.Rows.Add(2, "Ahmed Nakhla", "Assuit", 8547, DateTime.Now);
EmployeesDataTable.Rows.Add(3, "Abdo Gebna", "Toronto", 1258, DateTime.Now);
EmployeesDataTable.Rows.Add(4, "Saed Kotta", "France", 9623, DateTime.Now);
EmployeesDataTable.Rows.Add(5, "Medhat Fakousa", "Stuttgart", 24878, DateTime.Now);


int NumOfEmps = 0;
double SumOfSals = 0;
double AvgOfSals = 0;
double MinSal = 0;
double MaxSal = 0;

NumOfEmps = EmployeesDataTable.Rows.Count;
SumOfSals = Convert.ToDouble(EmployeesDataTable.Compute("SUM(Salary)", string.Empty));
AvgOfSals = Convert.ToDouble(EmployeesDataTable.Compute("AVG(Salary)", string.Empty));
MinSal = Convert.ToDouble(EmployeesDataTable.Compute("MIN(Salary)", string.Empty));
MaxSal = Convert.ToDouble(EmployeesDataTable.Compute("MAX(Salary)", string.Empty));


foreach (DataRow row in EmployeesDataTable.Rows)
{
    Console.WriteLine("ID: {0}\t Name: {1}\t Country: {2}\t Salary: {3}\t Date Of Birth: {4}\t",
                       row["ID"], row["Name"], row["Country"], row["Salary"], row["DateOfBirth"]);
}

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("Num Of Employees: " + NumOfEmps);
Console.WriteLine("Sum Of Salaries : " + SumOfSals);
Console.WriteLine("AVG Of Salaries : " + AvgOfSals);
Console.WriteLine("Min Salary      : " + MinSal);
Console.WriteLine("Max Salary      : " + MaxSal);

