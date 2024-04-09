namespace Builder;


public class EmployeeReportBuilder : IEmployeeReportBuilder {
	private EmployeeReport _employeeReport;

	private readonly List<Employee> _employees;

	public EmployeeReportBuilder(List<Employee> employees)
	{
		_employees = employees;
		_employeeReport = new();
	}

	public void BuildHreader(){
		_employeeReport.Header = $"Employee report on date: {DateTime.Now}\n";

		_employeeReport.Header += "-------------------------------------------------------\n";
	}

	public void BuildBody(){
		_employeeReport.Body = "";
		foreach (Employee e in _employees)
		{
			_employeeReport.Body += $"Employee: {e.Name}\t\t Salary: {e.Salary}$\n";
		}
	}

	public void BuildFooter(){
		_employeeReport.Footer = "-------------------------------------------------------\n";

		_employeeReport.Footer += $"Count of employee: {_employees.Count()}\t\t Sum salary: {_employees.Sum(e => e.Salary)}";

	}

	public EmployeeReport GetReport(){
		EmployeeReport employeeReport = _employeeReport;

		_employeeReport = new();

		return employeeReport;
	}
}