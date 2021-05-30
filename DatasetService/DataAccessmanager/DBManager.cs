using ServiceStack.OrmLite;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace DatasetService
{
    public class DBManager : IDisposable
{
        public static readonly string connectionString = Utility.CONNSTRING;
        public OrmLiteConnectionFactory OrmLite;
        public DBManager()
        {
            OrmLite = new OrmLiteConnectionFactory(connectionString, MySqlDialect.Provider);
        }

        public void Dispose()
        {
            if (OrmLite != null)
            {
                OrmLite = null;
            }
        }
    }
}
