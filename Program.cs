namespace Builder;

class Program
{
    static void Main(string[] args)
    {
        List<Employee> employees = new() {
            new Employee{ Name = "Pavel", Salary = 100},
            new Employee{ Name = "Liza", Salary = 80},
            new Employee{ Name = "Anna", Salary = 40}
        };

        var builder = new EmployeeReportBuilder(employees);
        
        builder.BuildFooter();
        builder.BuildBody();
        builder.BuildFooter();

        var report = builder.GetReport();

        System.Console.Write(report.ToString());
    }
}
