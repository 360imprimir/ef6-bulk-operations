using System.Data;

namespace Tanneryd.BulkOperations.EF6
{
    internal class SystemSqlBulkCopy : IBulkCopy
    {
        private readonly System.Data.SqlClient.SqlBulkCopy sqlBulkCopy;

        public SystemSqlBulkCopy(System.Data.SqlClient.SqlBulkCopy sqlBulkCopy)
        {
            this.sqlBulkCopy = sqlBulkCopy;
        }

        public void WriteToServer(DataTable table)
        {
            this.sqlBulkCopy.WriteToServer(table.CreateDataReader());
        }
    }
}
