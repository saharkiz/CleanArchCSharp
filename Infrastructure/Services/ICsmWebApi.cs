using System.Threading.Tasks;
using Refit;
using Ats.CLEANARCH.CSM.ClientApi.SharedModel;

namespace Ats.CLEANARCH.CSM.ClientApi.Infrastructure.Services
{
  [Headers(
    "Content-Type: application/json",
    "api-version: 2022.1"
    )]
  public interface ICsmWebApi
  {
    [Get("/api/firm")]
    Task<object> Test();

    [Post("/api/authorize")]
    Task<VerifiedRights> Authorize([Body] CsmRightsToVerifyRequest requestBody);

    [Get("/api/user-right/{efmUserGuid}/{roleKey}")]
    Task<object> UserRight(string efmUserGuid, string roleKey);
  }
}
