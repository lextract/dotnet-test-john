namespace MasglobalTest.JohnAntonio.App.DTO
{
    public class MonthlyEmployeeDto : EmployeeDto
    {
        public MonthlyEmployeeDto(decimal monthlySalary)
        {
            ContractTypeName = "Monthly Salary Employee";
            AnnualSalary = monthlySalary * 12;
        }

    }
}
