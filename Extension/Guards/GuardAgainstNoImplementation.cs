using System;

namespace Ats.CLEANARCH.CSM.ClientApi.Extension.Guards
{
  public static partial class GuardClauseExtensions
  {
    public static T NotImplemented<T>(
      this IGuardClause guardClause,
      T input,
      string parameterName,
      string message = null)
    {
      if (input == null)
      {
        if (string.IsNullOrEmpty(message))
        {
          throw new ArgumentNullException(parameterName);
        }
        throw new ArgumentNullException(parameterName, message);
      }

      return input;
    }
  }
}
