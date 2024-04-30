using AutoMapper;


namespace CleanArchitectureDemo.Application.Beach.GetAllBeach
{
    public class GetAllBeachesMapper : Profile
    {
        public GetAllBeachesMapper() { CreateMap<CleanArchitectureDemo.Domain.Entities.Beach, GetAllBeachesResponse>(); }
    }
}
