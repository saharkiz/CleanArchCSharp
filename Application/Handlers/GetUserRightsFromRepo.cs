using System;
using System.Collections.Generic;
using System.Text;
using Ats.CLEANARCH.CSM.ClientApi.Core.Entities;
using Ats.CLEANARCH.CSM.ClientApi.Extension.Exceptions;

namespace Ats.CLEANARCH.CSM.ClientApi.Application.Handlers
{
  public class GetUserRightsFromRepo
  {
    public List<Rights> Handle(Guid UserKey, Guid ResourceKey)
    {
      try
      {
        string ComSecServiceUrl = @"https://localhost/service";
        //var IRepo = new Infrastructure.Mock.MockCsmWebApi();
        var IRepo = new Infrastructure.CsmAuthorize(ComSecServiceUrl);

        var RightsList = new Domain.Adapters.GetUserRights(IRepo).Handle(UserKey, ResourceKey);
        return RightsList;
      }
      catch (Exception ex)
      {
        throw new CsmApiException(ex.Message);
      }
    }
  }
}
