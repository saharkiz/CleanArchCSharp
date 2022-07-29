using System;
using System.Collections.Generic;
using Ats.CLEANARCH.CSM.ClientApi.Domain.Abstraction;
using Ats.CLEANARCH.CSM.ClientApi.Extension.ErrorMessages;
using Ats.CLEANARCH.CSM.ClientApi.Extension.Guards;
using Ats.CLEANARCH.CSM.ClientApi.Extension.Helper;
using Ats.CLEANARCH.CSM.ClientApi.SharedModel;

namespace Ats.CLEANARCH.CSM.ClientApi.Infrastructure
{
  internal class CsmAuthorize : IRepository
  {
    private readonly Services.ICsmWebApi _CsmWebApi;
    private readonly string _Url;
    private readonly List<CsmAuthorizeRequest> _UserListRequestAuthorize;

    public CsmAuthorize(string Url)
    {
      Guard.Against.NullOrEmpty(
                  Url,
                  nameof(Url),
                  EnumExtension.GetDescription(CsmErrorMessage.EmptyUrl)
                  );
      try
      {
        this._Url = Url;
        this._CsmWebApi = Refit.RestService.For<Services.ICsmWebApi>(_Url);
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }

    public List<CsmAuthorizeResponse> GetResult(Guid UserKey, Guid ResourceKey)
    {
      List<CsmAuthorizeRequest> UserListRequestAuthorize = new List<CsmAuthorizeRequest>();
      UserListRequestAuthorize.Add(
        new CsmAuthorizeRequest()
        {
          applicationKey = "3fa85f64-5717-4562-b3fc-2c963f66afa6",
          efmUserGuid = UserKey,
          resourceKey = ResourceKey,
          courtIdentifier = "string"
        }
      );
      var requestBody = new CsmRightsToVerifyRequest();
      requestBody.RightsToVerify = UserListRequestAuthorize;
      var CsmWebApiResult = this._CsmWebApi.Authorize(requestBody).Result;
      return CsmWebApiResult.VerifiedRight;
      //return new List<CsmAuthorizeResponse>();
    }
  }
}
