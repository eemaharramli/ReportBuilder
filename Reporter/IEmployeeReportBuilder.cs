namespace Reporter;

public interface IEmployeeReportBuilder
{
    //void BuildHeader();
    IEmployeeReportBuilder BuildHeader();
    //void BuildBody();
    IEmployeeReportBuilder BuildBody();
    //void BuildFooter();
    IEmployeeReportBuilder BuildFooter();

    EmployeeReport GetReport();
}