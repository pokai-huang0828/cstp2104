using SharedCommon.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public class DBConfig : IDBConfig
    {
        private const string connectionString = "Server=tcp:cstp2104-phu-77.database.windows.net,1433;Initial Catalog=phubd1;Persist Security Info=False;User ID=phuadmin;Password=Kenny0828!!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        public string GetConnectionString()
        {
            return connectionString;
        }
    }
}
