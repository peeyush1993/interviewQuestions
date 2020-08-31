using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewQuestion
{
   public sealed class Logger
    {
        private Logger()
        {
        }
        private System.IO.StreamWriter _output = null;
        private static string _logFile = @"C:\Users\Peeyush_Anand\Desktop\interviewCodeTest\InterviewQuestion\logDetails.Log";
        private static int _logLevel = 1;
        
        private static Logger _logger = null;
        private static readonly object _obj = new object();
        public static Logger GetLoggerInstance()
        {
            lock (_obj)
            {
                if (_logger == null)
                {
                    _logger = new Logger();
                }
            }
            return _logger;

        }
        public void ExceptionLogwriter(string s, int severity)
        {
            if (severity <= _logLevel)
            {
                if (_output == null)
                {
                    _output = new System.IO.StreamWriter(_logFile, true, System.Text.UnicodeEncoding.Default);
                }
                _output.WriteLine(System.DateTime.Now + "|" + severity + "|" + s, new object[0]);

                if (_output != null)
                {
                    _output.Close();
                    _output= null;               }
            }
        
        }


    }
}
