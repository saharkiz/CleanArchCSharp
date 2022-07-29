using System;
using System.Collections.Generic;
using Ats.CLEANARCH.CSM.ClientApi.Core.Entities;

namespace Ats.CLEANARCH.CSM.ClientApi.Application.Abstraction
{
  public interface IGetUserRights
  {
    List<Rights> Handle(Guid UserKey, Guid ResourceKey);
  }
}
