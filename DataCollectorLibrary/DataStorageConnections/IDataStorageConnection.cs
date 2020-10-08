using System;
using System.Collections.Generic;
using System.Text;

namespace DataCollectorLibrary.DataAccess
{
    public interface IDataStorageConnection
    {
        CollectorModel CreateCollector(CollectorModel model);

    }
}
