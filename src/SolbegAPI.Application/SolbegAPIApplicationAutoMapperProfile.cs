using AutoMapper;

namespace SolbegAPI;

public class SolbegAPIApplicationAutoMapperProfile : Profile
{
    public SolbegAPIApplicationAutoMapperProfile()
    {
        CreateMap<Employee, EmployeeDto>();
        CreateMap<PostEmployeeDto, Employee>();
    }
}
