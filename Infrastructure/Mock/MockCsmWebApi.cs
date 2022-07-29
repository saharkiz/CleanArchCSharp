using System;
using System.Collections.Generic;
using Ats.CLEANARCH.CSM.ClientApi.Domain.Abstraction;
using Ats.CLEANARCH.CSM.ClientApi.SharedModel;

namespace Ats.CLEANARCH.CSM.ClientApi.Infrastructure.Mock
{
  internal class MockCsmWebApi : IRepository
  {
    public List<CsmAuthorizeResponse> GetResult(Guid UserKey, Guid ResourceKey)
    {
      List<CsmAuthorizeResponse> listofRights = new List<CsmAuthorizeResponse>();
      listofRights.AddRange(
          new List<CsmAuthorizeResponse> {
            new CsmAuthorizeResponse() {
              applicationKey = "8d7c559a-f4f2-4dd3-8a90-8535fc845c64",
              efmUserGuid = new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"),
              resourceKey =  new Guid("4127bbda-82ac-4b3b-b532-96de96390d98"),
              courtIdentifier = "string"
            },
            new CsmAuthorizeResponse() {
              applicationKey = "8d7c559a-f4f2-4dd3-8a90-8535fc845c64",
              efmUserGuid =  new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"),
              resourceKey =  new Guid("7b41c604-2553-479a-9aee-242d10942da4"),
              courtIdentifier = "string"
            },
            new CsmAuthorizeResponse() {
              applicationKey = "8d7c559a-f4f2-4dd3-8a90-8535fc845c64",
              efmUserGuid =  new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"),
              resourceKey =  new Guid("3fb8b04f-7d1c-493d-a611-fe31b6a03ad4"),
              courtIdentifier = "string"
            },
          }
        );
      return listofRights;
    }
  }
}
