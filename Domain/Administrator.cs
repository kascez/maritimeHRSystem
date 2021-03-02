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
    public class Administrator : IDomainObject
    {
        [Browsable(false)]
        public int ID { get; set; }
        [Browsable(false)]
        public string Username { get; set; }
        [Browsable(false)]
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfAuthorization { get; set; }
        public int NumberOfLicence { get; set; }
        [Browsable(false)]
        public string Table => "Administrator";
        [Browsable(false)]
        public string InsertValues => $"";
        [Browsable(false)]
        public string UpdateValues => $"";
        [Browsable(false)]
        public string SearchWhere { get ; set ; }
        [Browsable(false)]
        public string SearchId => $"ID = {ID}";
        [Browsable(false)]
        public string JoinFull => $"";
        [Browsable(false)]
        public object ColumnID => "ID";

        public override string ToString()
        {
            return Name + " " + Surname;
        }

        public List<IDomainObject> GetReaderResult(SqlDataReader reader)
        {
            List<IDomainObject> list = new List<IDomainObject>();
            while (reader.Read())
            {
                Administrator u = new Administrator
                {
                    ID = reader.GetInt32(0),
                    Username = reader.GetString(1),
                    Password = reader.GetString(2),
                    Name = reader.GetString(3),
                    Surname = reader.GetString(4),
                    DateOfAuthorization = reader.GetDateTime(5),
                    NumberOfLicence = reader.GetInt32(6)
                };
                list.Add(u);
            }
            return list;
        }

        public List<IDomainObject> GetReaderResultJoin(SqlDataReader reader)
        {
            List<IDomainObject> list = new List<IDomainObject>();
            while (reader.Read())
            {
                Administrator u = new Administrator
                {
                    ID = reader.GetInt32(0),
                    Username = reader.GetString(1),
                    Password = reader.GetString(2),
                    Name = reader.GetString(3),
                    Surname = reader.GetString(4),
                    DateOfAuthorization = reader.GetDateTime(5),
                    NumberOfLicence = reader.GetInt32(6)
                };
                list.Add(u);
            }
            return list;
        }
    }
}
