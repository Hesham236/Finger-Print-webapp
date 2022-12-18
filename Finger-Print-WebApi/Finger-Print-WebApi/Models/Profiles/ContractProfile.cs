using AutoMapper;
using Finger_Print_WebApi.Models.DTO.ContractDto;

namespace Finger_Print_WebApi.Models.Profiles
{
    public class ContractProfile : Profile
    {
        public ContractProfile()
        {
            CreateMap<Models.Domain.Contract,ContractDto>();
        }
    }
}
