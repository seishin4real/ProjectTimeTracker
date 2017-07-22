using System;

namespace ProjectTimeTracker.Logging
{
    public interface ILogger<out T>
        where T : class
    {
        void Debug(string message, object context = null);
        void Debug(object context);
        void Debug(Exception exception, string message, object context = null);

        void Error(string message, object context = null);
        void Error(object context);
        void Error(Exception exception, string message, object context = null);

        void Fatal(string message, object context = null);
        void Fatal(object context);
        void Fatal(Exception exception, string message, object context = null);

        void Info(string message, object context = null);
        void Info(object context);
        void Info(Exception exception, string message, object context = null);

        void Trace(string message, object context = null);
        void Trace(object context);
        void Trace(Exception exception, string message, object context = null);

        void Warn(string message, object context = null);
        void Warn(object context);
        void Warn(Exception exception, string message, object context = null);
    }
}
