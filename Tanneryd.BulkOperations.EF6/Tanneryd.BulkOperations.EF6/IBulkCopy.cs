using System.Data;

namespace Tanneryd.BulkOperations.EF6
{
    internal interface IBulkCopy
    {
        void WriteToServer(DataTable table);
    }
}
