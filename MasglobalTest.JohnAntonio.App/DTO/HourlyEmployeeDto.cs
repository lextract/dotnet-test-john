namespace MasglobalTest.JohnAntonio.App.DTO
{
    public class HourlyEmployeeDto : EmployeeDto
    {
        public HourlyEmployeeDto(decimal hourlySalary)
        {
            ContractTypeName = "Hourly Salary Employee";
            AnnualSalary = 120 * hourlySalary * 12;
        }
            
    }
}
