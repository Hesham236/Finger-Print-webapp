using Finger_Print_WebApi.Models.Domain;
using Finger_Print_WebApi.Models.DTO.ContractDto;

namespace Finger_Print_WebApi.Repos.IRepo
{
    public interface IContractRepository
    {
        Task<IEnumerable<Contract>> GetAllContractsAsync();
        Task<Contract> AddContractAsync(ContractDto contractDto);
        Task<Contract> UpdateContractAsync(int id,Contract contract);
    }
}
