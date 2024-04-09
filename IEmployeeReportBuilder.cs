namespace Builder;

public interface IEmployeeReportBuilder{

	void BuildHreader();

	void BuildBody();

	void BuildFooter();

	EmployeeReport GetReport();
}