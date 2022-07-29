using System;
using System.Collections.Generic;
using System.Text;

namespace Ats.CLEANARCH.CSM.ClientApi.Extension.Guards
{
  public interface IGuardClause
  {
  }
  class Guard : IGuardClause
  {

    public static IGuardClause Against { get; } = new Guard();

    private Guard() { }
  }
}
