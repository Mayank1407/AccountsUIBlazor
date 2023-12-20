using AccountApi.Core;
using AutoMapper;

namespace AccountsUIBlazor.UIModels
{
   public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<UICustomer, Customer>().ReverseMap();

        }
    }
}
