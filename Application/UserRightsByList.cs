using System;
using System.Collections.Generic;
using Ats.CLEANARCH.CSM.ClientApi.Application.Abstraction;
using Ats.CLEANARCH.CSM.ClientApi.Application.Handlers;
using Ats.CLEANARCH.CSM.ClientApi.Core.Entities;

namespace Ats.CLEANARCH.CSM.ClientApi.Application
{
  public class UserRightsByList: IGetUserRights
  {
    public List<Rights> Handle(Guid UserKey, Guid ResourceKey)
    {
      return new GetUserRightsFromRepo().Handle(UserKey, ResourceKey);
    }
  }
}
