using System;
using System.Collections.Generic;
using System.Text;

namespace Ats.CLEANARCH.CSM.ClientApi.Core.Entities
{
  public class Rights : IEntity<Guid>
  {
    public Guid? Resource { get; set; }
    public String ResourceName { get; set; }
    public Guid UserId { get; set; }

    public bool HasAccess()
    {
      return false;
    }
  }
}
