using NLog;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persona5APIv2.Core.Logging
{
    public interface ILogger<T>
    {
        void Log(LogLevel logLevel, string message, Exception ex = null);
        void LogDebug(string message);
        void LogInfo(string message);
        void LogWarning(string message);
        void LogError(Exception ex, string message);
        void LogTrace(string message);
    }
}
