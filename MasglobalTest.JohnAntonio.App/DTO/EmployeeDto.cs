namespace MasglobalTest.JohnAntonio.App.DTO
{
    public abstract class EmployeeDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ContractTypeName { get; protected set; }
        public string RoleName { get; set; }
        public decimal AnnualSalary { get; set; }

    }
}
