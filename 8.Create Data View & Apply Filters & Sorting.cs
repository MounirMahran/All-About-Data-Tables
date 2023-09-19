//
// Creating A Data View From DT
//
DataView EmployeesDataView = EmployeesDataTable.DefaultView;

//Printing DV
for (int i = 0; i < EmployeesDataView.Count; i++)
{
    Console.WriteLine("{0}, \t{1}, \t{2}, \t{3}, \t{4}", EmployeesDataView[i][0], EmployeesDataView[i][1], EmployeesDataView[i][2], EmployeesDataView[i][3], EmployeesDataView[i][4]);
}

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();


//
//Applying Filter To Get Employees That Get Salary > 8000
//
EmployeesDataView.RowFilter = "Salary > 8000";

//Printing Filtered DV
for (int i = 0; i < EmployeesDataView.Count; i++)
{
    Console.WriteLine("{0}, \t{1}, \t{2}, \t{3}, \t{4}", EmployeesDataView[i][0], EmployeesDataView[i][1], EmployeesDataView[i][2], EmployeesDataView[i][3], EmployeesDataView[i][4]);
}

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();


//
//Sorting Data View
//
EmployeesDataView.Sort = "Name ASC";

//Printing Sorted DV
for (int i = 0; i < EmployeesDataView.Count; i++)
{
    Console.WriteLine("{0}, \t{1}, \t{2}, \t{3}, \t{4}", EmployeesDataView[i][0], EmployeesDataView[i][1], EmployeesDataView[i][2], EmployeesDataView[i][3], EmployeesDataView[i][4]);
}