using MasglobalTest.JohnAntonio.App.DAL;
using MasglobalTest.JohnAntonio.App.DTO;
using MasglobalTest.JohnAntonio.App.Model;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MasglobalTest.JohnAntonio.App.BLL
{
    public static class EmployeeBll
    {
        public static async Task<IEnumerable<EmployeeDto>> GetEmployees()
        {
            var employees = await EmployeeDal.GetEmployees();

            var employeesDto = new List<EmployeeDto>();
            foreach (var employee in employees)
            {
                employeesDto.Add(EmployeesFactory.GetEmployee(employee));
            }
            return employeesDto;
        }

        public static async Task<IEnumerable<EmployeeDto>> GetEmployee(int id)
        {
            var employees = await EmployeeDal.GetEmployees();
            Employee employee = employees.FirstOrDefault(emp => emp.Id == id);
            if (employee == null)
                return new EmployeeDto[] { };
            return new EmployeeDto[] { EmployeesFactory.GetEmployee(employee) };
        }
    }
    
}
