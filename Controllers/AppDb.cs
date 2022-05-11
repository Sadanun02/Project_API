using System;
using MySqlConnector;

namespace demoapi
{
    public class AppDb : IDisposable
    {
        public MySqlConnection Connection { get; }
        public AppDb(string connectionstring)
        {
            Connection = new MySqlConnection(connectionstring);
        }

        public void Dispose() => Connection.Dispose();
    }
}

