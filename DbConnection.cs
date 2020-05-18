using System;
using Microsoft.VisualBasic;

namespace CSharpUdemy
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; set; }
        public TimeSpan Timeout { get; set; }

        public abstract void Open();
        public abstract void Close();

        public DbConnection(string connectionString)
        {
            ConnectionString = connectionString ?? throw new NullReferenceException();
            Console.WriteLine("printing {0}", connectionString);
            Timeout = TimeSpan.Zero; 
        }
    }

    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString) : base(connectionString)
        {
            Console.WriteLine("doing second part SQL {0}", connectionString);
        }

        public override void Open()
        {
            Console.WriteLine("open SQL connection");
        }

        public override void Close()
        {
            Console.WriteLine("close SQL connection");
        }
    }


    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString) : base(connectionString)
        {
            Console.WriteLine("doing second part Oracle {0}", connectionString);
        }

        public override void Open()
        {
            Console.WriteLine("open Oracle connection");
        }

        public override void Close()
        {
            Console.WriteLine("close Oracle connection");
        }
    }
}