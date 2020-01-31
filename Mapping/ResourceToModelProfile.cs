using AutoMapper;
using Restful_ASPNetCore.Models;
using Restful_ASPNetCore.Resources;

namespace Restful_ASPNetCore.Mapping
{
    public class ResourceToModelProfile : Profile
    {
        public ResourceToModelProfile()
        {
            CreateMap<SaveCategoryResource, Category>();
        }
    }
}
