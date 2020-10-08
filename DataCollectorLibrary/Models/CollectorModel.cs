using System;
using System.Collections.Generic;
using System.Text;

namespace DataCollectorLibrary
{
    public class CollectorModel
    {
        /// <summary>
        /// Represents list of connections in this particular project configuration
        /// </summary>
        public List<NodeModel> Nodes { get; set; } = new List<NodeModel>();
        public DataStorageConnectionsModel DataStorageConnections { get; set; } = new DataStorageConnectionsModel();
    }
}
