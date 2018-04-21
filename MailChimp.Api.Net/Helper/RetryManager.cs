﻿using System;
using System.Threading;

namespace MailChimp.Api.Net.Helper
{
  public class RetryManager
  {
    private const int RetryCount = 3;
    private const int TimeToWait = 5000;

    public void RetryExecute(Action action)
    {
      int retryCountLeft = RetryCount;
      do
      {
        try
        {
          if (action != null)
          {
            action();
            return;
          }
          return;
        }
        catch (TimeoutException)
        {
          if (retryCountLeft == 0)
          {
            throw;
          }
          Thread.Sleep(TimeToWait);
        }
      } while (retryCountLeft-- > 0);
    }

    public T RetryExecute<T>(Func<T> action)
    {
      int retryCountLeft = RetryCount;
      do
      {
        try
        {
          return action != null ? action() : default(T);
        }
        catch (TimeoutException)
        {
          if (retryCountLeft == 0)
          {
            throw;
          }
          Thread.Sleep(TimeToWait);
        }
      } while (retryCountLeft-- > 0);

      return default(T);
    }
  }
}