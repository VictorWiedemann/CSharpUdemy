using System;
using System.Runtime.CompilerServices;

namespace CSharpUdemy
{
    public class DbMigrator
    {
        private readonly Logger _logger;

        public DbMigrator(Logger logger)
        {
            _logger = logger;
        }

        public void Migrate()
        {
            _logger.Log("We are migrating blah blah blah");
        }

    }

    public class Logger
    {
        public void Log(string var) {
            Console.WriteLine(var);
        }
    }
}