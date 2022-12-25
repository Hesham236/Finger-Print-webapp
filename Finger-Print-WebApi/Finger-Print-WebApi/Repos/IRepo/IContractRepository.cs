using Finger_Print_WebApi.Models.Domain;

namespace Finger_Print_WebApi.Repos.IRepo
{
    public interface IContractRepository
    {
        Task<IEnumerable<Contract>> GetAllContractsAsync();
    }
}
