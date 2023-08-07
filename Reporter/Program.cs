using Reporter;

List<Employee> employees = new ()
{
    new Employee{Name = "Elnur", Salary = 1000},
    new Employee{Name = "Ramiz", Salary = 1200},
    new Employee{Name = "Ilkin", Salary = 1300}
};

var builder = new EmployeeReportBuilder(employees);
var director = new EmployeeReportDirector(builder);

director.Build();

var report = builder.GetReport();

Console.WriteLine(report);
Console.ReadKey();