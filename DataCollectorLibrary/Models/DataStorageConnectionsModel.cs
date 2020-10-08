using DataCollectorLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataCollectorLibrary
{
    public class DataStorageConnectionsModel:IDataStorageConnection
    {
        public static List<DataStorageConnectionsModel> DataStorageConnections { get; set; } = new List<DataStorageConnectionsModel>();

        public CollectorModel CreateCollector(CollectorModel model)
        {
            throw new NotImplementedException();
        }
    }
}
