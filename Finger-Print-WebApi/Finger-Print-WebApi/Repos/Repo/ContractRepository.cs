using AutoMapper;
using Finger_Print_WebApi.Data;
using Finger_Print_WebApi.Models.Domain;
using Finger_Print_WebApi.Models.DTO.ContractDto;
using Finger_Print_WebApi.Repos.IRepo;
using Microsoft.EntityFrameworkCore;

namespace Finger_Print_WebApi.Repos.Repo
{
    public class ContractRepository  : IContractRepository
    {
        private readonly FingerPrintDBContext fingerPrintDBContext;
        private readonly IMapper mapper;
        public ContractRepository(FingerPrintDBContext fingerPrintDBContext,IMapper mapper)
        {
            this.fingerPrintDBContext = fingerPrintDBContext;
            this.mapper = mapper;
        }


        public async Task<IEnumerable<Contract>> GetAllContractsAsync()
        {
            return await fingerPrintDBContext.Contracts.ToListAsync();
        }
        public async Task<Contract> AddContractAsync(ContractDto contractDto)
        {
            var con = mapper.Map<Contract>(contractDto);
            await fingerPrintDBContext.Contracts.AddAsync(con);
            fingerPrintDBContext.SaveChanges();
            return con;
        }
        public async Task<Contract> UpdateContractAsync(int id, Contract contract)
        {
            var foundcon = await fingerPrintDBContext.Contracts.FirstOrDefaultAsync(x=>x.Id == id);
            if (foundcon == null) return null;

            foundcon.type = contract.type;
            foundcon.start_date = contract.start_date;
            foundcon.end_date = contract.end_date;

            await fingerPrintDBContext.SaveChangesAsync();
            return contract;
        }
    }
}
