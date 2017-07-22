using System;

using Newtonsoft.Json;

using NLog;

namespace ProjectTimeTracker.Logging
{
    public class NLogger<T> : ILogger<T>
        where T : class
    {
        private readonly Logger _logger;

        public NLogger()
        {
            _logger = LogManager.GetLogger(typeof(T).Name);
        }

        public void Debug(string message, object context = null)
        {
            Write(_logger.Debug, message, context);
        }

        public void Debug(object context)
        {
            Write(_logger.Debug, context);
        }

        public void Debug(Exception exception, string message, object context = null)
        {
            Write(_logger.Debug, exception, message, context);
        }

        public void Error(string message, object context = null)
        {
            Write(_logger.Error, message, context);
        }

        public void Error(object context)
        {
            Write(_logger.Error, context);
        }

        public void Error(Exception exception, string message, object context = null)
        {
            Write(_logger.Error, exception, message, context);
        }

        public void Fatal(string message, object context = null)
        {
            Write(_logger.Fatal, message, context);
        }

        public void Fatal(object context)
        {
            Write(_logger.Fatal, context);
        }

        public void Fatal(Exception exception, string message, object context = null)
        {
            Write(_logger.Fatal, exception, message, context);
        }

        public void Info(string message, object context = null)
        {
            Write(_logger.Info, message, context);
        }

        public void Info(object context)
        {
            Write(_logger.Info, context);
        }

        public void Info(Exception exception, string message, object context = null)
        {
            Write(_logger.Info, exception, message, context);
        }

        public void Trace(string message, object context = null)
        {
            Write(_logger.Trace, message, context);
        }

        public void Trace(object context)
        {
            Write(_logger.Trace, context);
        }

        public void Trace(Exception exception, string message, object context = null)
        {
            Write(_logger.Trace, exception, message, context);
        }

        public void Warn(string message, object context = null)
        {
            Write(_logger.Warn, message, context);
        }

        public void Warn(object context)
        {
            Write(_logger.Warn, context);
        }

        public void Warn(Exception exception, string message, object context = null)
        {
            Write(_logger.Warn, exception, message, context);
        }

        private void Write(Action<string> logAction, string message, object context = null)
        {
            if (context == null) { logAction(message); }
            else { logAction(message + Environment.NewLine + JsonConvert.SerializeObject(context, Formatting.Indented)); }
        }

        private void Write(Action<string> logAction, object context = null)
        {
            logAction(JsonConvert.SerializeObject(context, Formatting.Indented));
        }

        private void Write(Action<Exception, string> logAction, Exception exception, string message, object context = null)
        {
            if (context == null) { logAction(exception, message); }
            else { logAction(exception, message + Environment.NewLine + JsonConvert.SerializeObject(context, Formatting.Indented)); }
        }
    }
}
