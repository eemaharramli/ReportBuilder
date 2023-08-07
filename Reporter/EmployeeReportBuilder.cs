namespace Reporter;

public class EmployeeReportBuilder : IEmployeeReportBuilder
{
    private EmployeeReport _employeeReport;
    private readonly List<Employee> _employees;
    public EmployeeReportBuilder(List<Employee> employees)
    {
        _employees = employees;
        _employeeReport = new();
    }

    public IEmployeeReportBuilder BuildHeader()
    {
        _employeeReport.Header =
            $"EMPLOYEE REPORT ON DATE: {DateTime.Now}\n";
        _employeeReport.Header +=
            "\n------------------------------------\n";
        return this;
    }

    public IEmployeeReportBuilder BuildBody()
    {
        _employeeReport.Body =
            string.Join(Environment.NewLine, _employees.Select(x => $"Employee {x.Name}\t\tSalary: {x.Salary}$"));
        return this;
    }

    public IEmployeeReportBuilder BuildFooter()
    {
        _employeeReport.Footer = 
            "\n------------------------------------\n";
        _employeeReport.Footer +=
            $"\nTOTAL EMPLOYEES: {_employees.Count()}, " +
            $"TOTAL SALARY: {_employees.Sum(x=>x.Salary)}$";
        return this;
    }

    public EmployeeReport GetReport()
    {
        EmployeeReport employeeReport = _employeeReport;
        _employeeReport = new();
        return employeeReport;
    }
}