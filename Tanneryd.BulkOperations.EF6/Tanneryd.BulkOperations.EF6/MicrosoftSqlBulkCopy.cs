using System.Data;

namespace Tanneryd.BulkOperations.EF6
{
    internal class MicrosoftSqlBulkCopy : IBulkCopy
    {
        private readonly Microsoft.Data.SqlClient.SqlBulkCopy sqlBulkCopy;

        public MicrosoftSqlBulkCopy(Microsoft.Data.SqlClient.SqlBulkCopy sqlBulkCopy)
        {
            this.sqlBulkCopy = sqlBulkCopy;
        }

        public void WriteToServer(DataTable table)
        {
            this.sqlBulkCopy.WriteToServer(table.CreateDataReader());
        }
    }
}
