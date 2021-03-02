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
    public class Sailor : IDomainObject
    {
        [Browsable(false)]
        public int ID { get; set; }
        [Browsable(false)]
        public string Username { get; set; }
        [Browsable(false)]
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string NumberOfMaritimeLicence { get; set; }
        public Country Country { get; set; }
        public SailorRank SailorRank { get; set; }
        [Browsable(false)]
        public string Table => "Sailor";
        [Browsable(false)]
        public string InsertValues => $"'{Username}', '{Password}', '{Name}', '{Surname}', '{Email}', '{NumberOfMaritimeLicence}', {Country.ID}, {SailorRank.ID}";
        [Browsable(false)]
        public string UpdateValues => $"Username = '{Username}', Password = '{Password}', Name = '{Name}', Surname = '{Surname}', Email = '{Email}', NumberOfMaritimeLicence = '{NumberOfMaritimeLicence}', CountryId = {Country.ID}, Sailorrankid = {SailorRank.ID}";
        [Browsable(false)]
        public string SearchWhere { get ; set ; }
        [Browsable(false)]
        public string SearchId => $"ID = {ID}";
        [Browsable(false)]
        public string JoinFull => $"s join Country c on (s.Countryid = c.Id) join Sailorrank sr on (s.sailorRankid = sr.id)";
        [Browsable(false)]
        public object ColumnID => "Id";

        public override string ToString()
        {
            return Name + " " + Surname;
        }

        public List<IDomainObject> GetReaderResult(SqlDataReader reader)
        {
            List<IDomainObject> list = new List<IDomainObject>();
            while (reader.Read())
            {
                Sailor u = new Sailor
                {
                    ID = reader.GetInt32(0),
                    Username = reader.GetString(1),
                    Password = reader.GetString(2),
                    Name = reader.GetString(3),
                    Surname = reader.GetString(4),
                    Email = reader.GetString(5),
                    NumberOfMaritimeLicence = reader.GetString(6),
                    Country = new Country
                    {
                        ID = reader.GetInt32(7)
                    },
                    SailorRank = new SailorRank
                    {
                        ID = reader.GetInt32(8)
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
                Sailor u = new Sailor
                {
                    ID = reader.GetInt32(0),
                    Username = reader.GetString(1),
                    Password = reader.GetString(2),
                    Name = reader.GetString(3),
                    Surname = reader.GetString(4),
                    Email = reader.GetString(5),
                    NumberOfMaritimeLicence = reader.GetString(6),
                    Country = new Country
                    {
                        ID = reader.GetInt32(7),
                        Name = reader.GetString(10)
                    },
                    SailorRank = new SailorRank
                    {
                        ID = reader.GetInt32(8),
                        Name = reader.GetString(12)
                    }
                };
                list.Add(u);
            }
            return list;
        }
    }
}
