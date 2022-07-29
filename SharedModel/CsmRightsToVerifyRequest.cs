using System;
using System.Collections.Generic;
using System.Text;

namespace Ats.CLEANARCH.CSM.ClientApi.SharedModel
{
  public class CsmAuthorizeRequest
  {
    public string applicationKey { get; set; }
    public Guid efmUserGuid { get; set; } //guid?
    public Guid resourceKey { get; set; } //guid?
    public string courtIdentifier { get; set; } //needed?

  }
  public class CsmRightsToVerifyRequest
  {
      public List<CsmAuthorizeRequest> RightsToVerify { get; set; }
  }
}
