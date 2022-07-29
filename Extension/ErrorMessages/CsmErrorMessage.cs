using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Ats.CLEANARCH.CSM.ClientApi.Extension.ErrorMessages
{

  public enum CsmErrorMessage : uint
  {
    [Description("CSM Url empty")]
    EmptyUrl,
    [Description("Repository Not Implemented")]
    RepoNotImplemented,
  }
}
