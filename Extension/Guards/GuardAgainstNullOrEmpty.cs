﻿using System;

namespace Ats.CLEANARCH.CSM.ClientApi.Extension.Guards
{
  public static partial class GuardClauseExtensions
  {
    public static T Null<T>(
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

    public static string NullOrEmpty(
        this IGuardClause guardClause,
        string input,
        string parameterName,
        string message = null)
    {
      Guard.Against.Null(input, parameterName, message);
      if (input == string.Empty)
      {
        throw new ArgumentException(message ?? $"Required input {parameterName} was empty.", parameterName);
      }
      return input;
    }
  }
}
