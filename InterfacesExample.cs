using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CSharpUdemy
{




        //what is in the program is the two lines below

    //var dbMigrator = new DbMigrator(new FileLogger(@"C:\Users\kirbo\Documents\code_projects\CSharpUdemy\txt.txt"));
    //dbMigrator.Migrate();





    public class DbMigrator
    {
        private readonly ILogger _logger;
        public DbMigrator(ILogger logger)
        {
            _logger = logger;
        }
        public void Migrate()
        {
            _logger.LogInfo("Migrating started at " + DateTime.Now);

            _logger.LogError("unexpected hex char" + DateTime.Now);

            _logger.LogInfo("Migrating finished at " + DateTime.Now);
        }
    }

    public class FileLogger : ILogger
    {
        private readonly string _path;

        public FileLogger(string path)
        {
            _path = path;
        }
        public void LogError(string message)
        {
            Log(message, "ERROR");
        }

        public void LogInfo(string message)
        {
            Log(message, "INFO");
        }

        private void Log(string message, string messageType)
        {
            using (var streamWriter = new StreamWriter(_path, true))
            {
                streamWriter.WriteLine(messageType + ": " + message);
            }
        }

    }

    public class ConsoleLogger : ILogger
    {
        public void LogError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Error: " + message);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void LogInfo(string message)
        {
            Console.WriteLine("Info: " + message);
        }
    }

    public interface ILogger
    {
        void LogError(string message);
        void LogInfo(string message);
    }

}