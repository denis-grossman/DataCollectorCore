using DataCollectorLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataCollectorLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataStorageConnection> DataStorageConnections { get; private set; }
        public static void InitializeDataStorageConnections(bool database, bool textFiles)
        {
            if (database)
            {
                // TODO - Create the SQLite Connection
                SqlConnector sql = new SqlConnector();
                DataStorageConnections.Add(sql);
            }
            if (textFiles)
            {
                // TODO - Create the Text Connection
                TextConnector text = new TextConnector();
                DataStorageConnections.Add(text);
            }
        }
    }
}
