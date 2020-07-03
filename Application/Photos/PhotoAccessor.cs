using Application.Interfaces;
using Microsoft.AspNetCore.Http;

namespace Application.Photos
{
  public class PhotoAccessor : IPhotoAccessor
  {
    public PhotoUploadResult AddPhoto(IFormFile file)
    {
      throw new System.NotImplementedException();
    }

    public string DeletePhoto(string publicId)
    {
      throw new System.NotImplementedException();
    }
  }
}