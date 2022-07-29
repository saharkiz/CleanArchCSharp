using System;
using System.Collections.Generic;
using Ats.CLEANARCH.CSM.ClientApi.Application.Abstraction;
using Ats.CLEANARCH.CSM.ClientApi.Core.Entities;

namespace Ats.CLEANARCH.CSM.ClientApi.Application
{
  class UserRightsByUserId : IGetUserRights
  {
    public List<Rights> Handle(Guid UserKey, Guid ResourceKey)
    {
      throw new NotImplementedException();
    }
  }
}
