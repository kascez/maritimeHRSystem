using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Domain
{
    public interface IDomainObject
    {
        string Table { get; }
        string InsertValues { get; }
        string UpdateValues { get; }
        string SearchWhere { get; set; }
        string SearchId { get; }
        string JoinFull { get; }
        object ColumnID { get; }
        List<IDomainObject> GetReaderResultJoin(SqlDataReader reader);
        List<IDomainObject> GetReaderResult(SqlDataReader reader);
    }
}
