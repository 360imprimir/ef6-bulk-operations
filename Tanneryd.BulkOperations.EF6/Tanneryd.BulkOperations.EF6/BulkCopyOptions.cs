using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanneryd.BulkOperations.EF6
{
    [Flags]
    public enum BulkCopyOptions
    {
        //
        // Summary:
        //     Use the default values for all options.
        Default = 0,
        //
        // Summary:
        //     Preserve source identity values. When not specified, identity values are assigned
        //     by the destination.
        KeepIdentity = 1,
        //
        // Summary:
        //     Check constraints while data is being inserted. By default, constraints are not
        //     checked.
        CheckConstraints = 2,
        //
        // Summary:
        //     Obtain a bulk update lock for the duration of the bulk copy operation. When not
        //     specified, row locks are used.
        TableLock = 4,
        //
        // Summary:
        //     Preserve null values in the destination table regardless of the settings for
        //     default values. When not specified, null values are replaced by default values
        //     where applicable.
        KeepNulls = 8,
        //
        // Summary:
        //     When specified, cause the server to fire the insert triggers for the rows being
        //     inserted into the database.
        FireTriggers = 0x10,
        //
        // Summary:
        //     When specified, each batch of the bulk-copy operation will occur within a transaction.
        //     If you indicate this option and also provide a System.Data.SqlClient.SqlTransaction
        //     object to the constructor, an System.ArgumentException occurs.
        UseInternalTransaction = 0x20,
        //
        // Summary:
        //     When specified, AllowEncryptedValueModifications enables bulk copying of encrypted
        //     data between tables or databases, without decrypting the data. Typically, an
        //     application would select data from encrypted columns from one table without decrypting
        //     the data (the app would connect to the database with the column encryption setting
        //     keyword set to disabled) and then would use this option to bulk insert the data,
        //     which is still encrypted. For more information, see Always Encrypted. Use caution
        //     when specifying AllowEncryptedValueModifications as this may lead to corrupting
        //     the database because the driver does not check if the data is indeed encrypted,
        //     or if it is correctly encrypted using the same encryption type, algorithm and
        //     key as the target column.
        AllowEncryptedValueModifications = 0x40
    }
}
