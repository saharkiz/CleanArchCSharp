using System;
using System.Collections.Generic;
using System.Text;

namespace Ats.CLEANARCH.CSM.ClientApi.SharedModel
{
  public class CsmAuthorizeResponse
  {
    public string applicationKey { get; set; }
    public Guid efmUserGuid { get; set; } //guid?
    public Guid roleKey { get; set; } //guid?
    public Guid resourceKey { get; set; } //guid?
    public bool isLocationBased { get; set; }
    public int accessRight { get; set; }
    public string message { get; set; }
    public string courtIdentifier{get; set;} //needed?

  }
  public class VerifiedRights
  {
    public List<CsmAuthorizeResponse> VerifiedRight { get; set; }
  }
}
