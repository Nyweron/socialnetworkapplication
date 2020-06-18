using AutoMapper;
using Domain;

namespace Application.Activities
{
  public class MappingProfile : Profile
  {
    public MappingProfile()
    {
      CreateMap<Activity, ActivityDto>();
      CreateMap<UserActivity, AttendeeDto>()
        .ForMember(destination => destination.Username, options => options.MapFrom(source => source.AppUser.UserName))
        .ForMember(destination => destination.DisplayName, options => options.MapFrom(source => source.AppUser.DisplayName));
    }
  }
}