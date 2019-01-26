using MasglobalTest.JohnAntonio.App.DTO;
using MasglobalTest.JohnAntonio.App.Model;
using System;

namespace MasglobalTest.JohnAntonio.App.BLL
{
    internal class EmployeesFactory
    {
        public static EmployeeDto GetEmployee(Employee employee)
        {
            EmployeeDto employeeDto = null;
            switch (employee.ContractTypeName)
            {
                case "HourlySalaryEmployee":
                    employeeDto = new HourlyEmployeeDto(employee.HourlySalary);
                    break;
                case "MonthlySalaryEmployee":
                    employeeDto = new MonthlyEmployeeDto(employee.MonthlySalary);
                    break;
                default:
                    throw new NotSupportedException(
                        $"The employee type of contract '{employee.ContractTypeName}' is not supported.");
            }
            employeeDto.Id = employee.Id;
            employeeDto.Name = employee.Name;
            employeeDto.RoleName = employee.RoleName;
            return employeeDto;
        }
    }
}
