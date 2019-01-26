using MasglobalTest.JohnAntonio.App.BLL;
using MasglobalTest.JohnAntonio.App.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;

namespace MasglobalTest.JohnAntonio.Web.Controllers
{
    public class EmployeesController : ApiController
    {
        public async Task<IEnumerable<EmployeeDto>> Get()
        {
            return await EmployeeBll.GetEmployees();
        }

        public async Task<IEnumerable<EmployeeDto>> Get(int id)
        {
            return await EmployeeBll.GetEmployee(id);
        }
        
    }
}