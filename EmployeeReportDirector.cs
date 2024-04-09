namespace Builder;

public class EmployeeReportDirector{

	private readonly IEmployeeReportBuilder _builder;
	public EmployeeReportDirector(IEmployeeReportBuilder builder)
	{
		_builder = builder;
	}

	public void Builder(){

		_builder.BuildHreader();
      _builder.BuildBody();
      _builder.BuildFooter();
		
	}
}