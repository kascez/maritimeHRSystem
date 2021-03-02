using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class Country : IDomainObject
    {
        [Browsable(false)]
        public int ID { get; set; }
        public string Name { get; set; }
        [Browsable(false)]
        public string Table => "Country";
        [Browsable(false)]
        public string InsertValues => $"{ID}, '{Name}'";
        [Browsable(false)]
        public string UpdateValues => $"ID = {ID}, Name = '{Name}'";
        [Browsable(false)]
        public string SearchWhere { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        [Browsable(false)]
        public string SearchId => $"where ID = {ID}";
        [Browsable(false)]
        public string JoinFull => "";
        [Browsable(false)]
        public object ColumnID => "ID";

        public override string ToString()
        {
            return Name;
        }

        public List<IDomainObject> GetReaderResult(SqlDataReader reader)
        {
            List<IDomainObject> list = new List<IDomainObject>();
            while (reader.Read())
            {
                Country c = new Country
                {
                    ID = reader.GetInt32(0),
                    Name = reader.GetString(1)
                };
                list.Add(c);
            }
            return list;
        }

        public List<IDomainObject> GetReaderResultJoin(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }
    }
}
