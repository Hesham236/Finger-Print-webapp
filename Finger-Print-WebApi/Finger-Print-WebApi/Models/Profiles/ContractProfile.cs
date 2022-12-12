using AutoMapper;

namespace Finger_Print_WebApi.Models.Profiles
{
    public class ContractProfile : Profile
    {
        public ContractProfile()
        {
            CreateMap<Models.Domain.Contract,Models.DTO.ContractDto>();
        }
    }
}
