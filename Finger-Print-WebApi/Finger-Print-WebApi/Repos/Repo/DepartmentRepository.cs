using AutoMapper;
using Finger_Print_WebApi.Data;
using Finger_Print_WebApi.Models.Domain;
using Finger_Print_WebApi.Models.DTO.DepartmentDto;
using Finger_Print_WebApi.Repos.IRepo;
using Microsoft.EntityFrameworkCore;

namespace Finger_Print_WebApi.Repos.Repo
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly FingerPrintDBContext fingerPrintDBContext;
        private readonly IMapper mapper;
        public DepartmentRepository(FingerPrintDBContext fingerPrintDBContext,IMapper mapper)
        {
            this.fingerPrintDBContext = fingerPrintDBContext;
            this.mapper = mapper;
        }


        //Routes
        public async Task<Department> AddDepartmentAsync(DepartmentsDto departmentsDto)
        {
            var dep = mapper.Map<Department>(departmentsDto);
            await fingerPrintDBContext.AddAsync(dep);
            fingerPrintDBContext.SaveChanges();
            return dep;
        }
        public async Task<IEnumerable<Department>> GetAllDepartmentsAsync()
        {
           return await fingerPrintDBContext.Departments.ToListAsync();
        }
        public async Task<Department> DeleteDepartmentAsync(int id)
        {
            var dep = await fingerPrintDBContext.Departments.FirstOrDefaultAsync(x => x.Id == id);
            if (dep == null) return null;
            fingerPrintDBContext.Departments.Remove(dep);
            fingerPrintDBContext.SaveChanges();
            return dep;
        }
    }
}
