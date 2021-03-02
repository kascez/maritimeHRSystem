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
    public class Workplace : IDomainObject
    {
        [Browsable(false)]
        public int ID { get; set; }
        public string Name { get; set; }
        public int NumberOfPlaces { get; set; }
        public Company Company { get; set; }
        [Browsable(false)]
        public string Table => "Workplace";
        [Browsable(false)]
        public string InsertValues => $"{Company.ID}, '{Name}', {NumberOfPlaces}";
        [Browsable(false)]
        public string UpdateValues => $"CompanyID = {Company.ID}, Name = '{Name}', NumberOfPlaces = {NumberOfPlaces}";
        [Browsable(false)]
        public string SearchWhere { get ; set ; }
        [Browsable(false)]
        public string SearchId => $"ID = {ID}";
        [Browsable(false)]
        public string JoinFull => $"w join company c on (w.companyid = c.id)";
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
                Workplace u = new Workplace
                {
                    ID = reader.GetInt32(0),
                    Name = reader.GetString(2),
                    NumberOfPlaces = reader.GetInt32(3),
                    Company = new Company
                    {
                        ID = reader.GetInt32(1)
                    }
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
                Workplace u = new Workplace
                {
                    ID = reader.GetInt32(0),
                    Name = reader.GetString(2),
                    NumberOfPlaces = reader.GetInt32(3),
                    Company = new Company
                    {
                        ID = reader.GetInt32(1),
                        DateOfBirth = reader.GetDateTime(5),
                        Name = reader.GetString(6),
                        PIB = reader.GetString(7),
                        ShipTypes = reader.GetString(8),
                        DaughterCompany = reader.GetBoolean(9),
                        Administrator = new Administrator
                        {
                            ID = reader.GetInt32(10)
                        }
                    }
                };
                list.Add(u);
            }
            return list;
        }
    }
}
