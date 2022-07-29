using System;
using System.Collections.Generic;
using System.Text;

namespace Ats.CLEANARCH.CSM.ClientApi.Extension.Exceptions
{
  public class CsmApiException : Exception
  {
    public CsmApiException(string message)
        : base($"CSM API Exception occured: {message}") 
        { }
  }
}
