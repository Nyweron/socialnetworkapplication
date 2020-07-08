using System.Linq;
using AutoMapper;
using Domain;

namespace Application.Comments
{
  public class MappingProfile : Profile
  {
    public MappingProfile()
    {
      CreateMap<Comment, CommentDto>()
        .ForMember(destination => destination.Username, options => options.MapFrom(source => source.Author.UserName))
        .ForMember(destination => destination.DisplayName, options => options.MapFrom(source => source.Author.DisplayName))
        .ForMember(destination => destination.Image, options => options.MapFrom(source => source.Author.Photos.FirstOrDefault(x => x.IsMain).Url));
    }
  }
}