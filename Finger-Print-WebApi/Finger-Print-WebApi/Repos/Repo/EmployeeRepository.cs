using Finger_Print_WebApi.Data;
using Finger_Print_WebApi.Models.Domain;
using Finger_Print_WebApi.Repos.IRepo;
using Microsoft.EntityFrameworkCore;

namespace Finger_Print_WebApi.Repos.Repo
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly FingerPrintDBContext fingerPrintDBContext;

        public EmployeeRepository(FingerPrintDBContext fingerPrintDBContext)
        {
            this.fingerPrintDBContext = fingerPrintDBContext;
        }
        public async Task<IEnumerable<Employee>> GetAllAsync()
        {
            return await fingerPrintDBContext.Employees.ToListAsync();
        }
    }
}
