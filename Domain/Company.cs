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
    public class Company : IDomainObject
    {
        [Browsable(false)]
        public int ID { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Name { get; set; }
        public string PIB { get; set; }
        public string ShipTypes { get; set; }
        public bool DaughterCompany { get; set; }
        public Administrator Administrator { get; set; }
        [Browsable(false)]
        public List<Workplace> Workplaces { get; set; }
        [Browsable(false)]
        public string Table => "Company";
        [Browsable(false)]
        public string InsertValues => $"'{DateOfBirth}', '{Name}', '{PIB}', '{ShipTypes}', '{DaughterCompany}', {Administrator.ID}, 0";
        [Browsable(false)]
        public string UpdateValues => $"DateOfBirth = '{DateOfBirth}', Name = '{Name}', PIB = '{PIB}', ShipTypes = '{ShipTypes}', DaughterCompany = '{DaughterCompany}', Administratorid = {Administrator.ID}, Proba = 0";
        [Browsable(false)]
        public string SearchWhere { get ; set ; }
        [Browsable(false)]
        public string SearchId => $"ID = {ID}";
        [Browsable(false)]
        public string JoinFull => $"c join administrator a on (c.administratorid = a.id)";
        [Browsable(false)]
        public object ColumnID => $"id";

        public override string ToString()
        {
            return Name;
        }

        public List<IDomainObject> GetReaderResult(SqlDataReader reader)
        {
            List<IDomainObject> list = new List<IDomainObject>();
            while (reader.Read())
            {
                Company u = new Company
                {
                    ID = reader.GetInt32(0),
                    DateOfBirth = reader.GetDateTime(1),
                    Name = reader.GetString(2),
                    PIB = reader.GetString(3),
                    ShipTypes = reader.GetString(4),
                    DaughterCompany = reader.GetBoolean(5),
                    Administrator = new Administrator
                    {
                        ID = reader.GetInt32(6)
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
                Company u = new Company
                {
                    ID = reader.GetInt32(0),
                    DateOfBirth = reader.GetDateTime(1),
                    Name = reader.GetString(2),
                    PIB = reader.GetString(3),
                    ShipTypes = reader.GetString(4),
                    DaughterCompany = reader.GetBoolean(5),
                    Administrator = new Administrator
                    {
                        ID = reader.GetInt32(6),
                        Username = reader.GetString(9),
                        Password = reader.GetString(10),
                        Name = reader.GetString(11),
                        Surname = reader.GetString(12),
                        DateOfAuthorization = reader.GetDateTime(13),
                        NumberOfLicence = reader.GetInt32(14)
                    }
                };
                list.Add(u);
            }
            return list;
        }
    }
}
