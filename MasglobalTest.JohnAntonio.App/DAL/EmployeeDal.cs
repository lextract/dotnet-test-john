using MasglobalTest.JohnAntonio.App.Model;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace MasglobalTest.JohnAntonio.App.DAL
{
    internal class EmployeeDal
    {
        private static string Endpoint { get; } = UrisApi.MasGlobalApi + "Employees/";

        public static async Task<List<Employee>> GetEmployees()
        {
            List<Employee> employees = null;
            HttpResponseMessage res = await HttpConnector.Client.GetAsync(Endpoint);
            if (res.IsSuccessStatusCode)
            {
                string jsonStr = await res.Content.ReadAsStringAsync();
                employees = JsonConvert.DeserializeObject<List<Employee>>(jsonStr);
            }
            return employees;
        }
    }

}
