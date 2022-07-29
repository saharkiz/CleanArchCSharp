using System;
using System.Collections.Generic;
using System.Text;
using Ats.CLEANARCH.CSM.ClientApi.SharedModel;

namespace Ats.CLEANARCH.CSM.ClientApi.Domain.Abstraction
{
  public interface IRepository
  {
    List<CsmAuthorizeResponse> GetResult(Guid UserKey, Guid ResourceKey);
  }
}
