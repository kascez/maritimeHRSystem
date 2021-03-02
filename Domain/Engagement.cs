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
    public class Engagement : IDomainObject
    {
        [Browsable(false)]
        public int ID { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public int Salary { get; set; }
        public Workplace Workplace { get; set; }
        public Sailor Sailor { get; set; }
        [Browsable(false)]
        public List<Sailor> Sailors { get; set; }
        [Browsable(false)]
        public string Table => "Engagement";
        [Browsable(false)]
        public string InsertValues => $"'{DateFrom}', '{DateTo}', {Salary}, {Workplace.ID}, {Sailor.ID}";
        [Browsable(false)]
        public string UpdateValues => $"DateFrom = '{DateFrom}', Dateto = '{DateTo}', Salary = {Salary}, Workplaceid = {Workplace.ID}, Sailorid = {Sailor.ID}";
        [Browsable(false)]
        public string SearchWhere { get ; set ; }
        [Browsable(false)]
        public string SearchId => $"ID = {ID}";
        [Browsable(false)]
        public string JoinFull => $"e join workplace w on (w.id = e.workplaceid) join sailor s on (s.id = e.sailorid)";
        [Browsable(false)]
        public object ColumnID => "ID";

        public List<IDomainObject> GetReaderResult(SqlDataReader reader)
        {
            List<IDomainObject> list = new List<IDomainObject>();
            while (reader.Read())
            {
                Engagement u = new Engagement
                {
                    ID = reader.GetInt32(0),
                    DateFrom = reader.GetDateTime(1),
                    DateTo = reader.GetDateTime(2),
                    Salary = reader.GetInt32(3),
                    Workplace = new Workplace
                    {
                        ID = reader.GetInt32(4)
                    },
                    Sailor = new Sailor
                    {
                        ID = reader.GetInt32(5)
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
                Engagement u = new Engagement
                {
                    ID = reader.GetInt32(0),
                    DateFrom = reader.GetDateTime(1),
                    DateTo = reader.GetDateTime(2),
                    Salary = reader.GetInt32(3),
                    Workplace = new Workplace
                    {
                        ID = reader.GetInt32(4),
                        Company = new Company
                        {
                            ID = reader.GetInt32(7)
                        },
                        Name = reader.GetString(8),
                        NumberOfPlaces = reader.GetInt32(9)
                    },
                    Sailor = new Sailor
                    {
                        ID = reader.GetInt32(5),
                        Username = reader.GetString(11),
                        Password = reader.GetString(12),
                        Name = reader.GetString(13),
                        Surname = reader.GetString(14),
                        Email = reader.GetString(15),
                        NumberOfMaritimeLicence = reader.GetString(16),
                        Country = new Country
                        {
                            ID = reader.GetInt32(17)
                        },
                        SailorRank = new SailorRank
                        {
                            ID = reader.GetInt32(18)
                        }
                    }
                };
                list.Add(u);
            }
            return list;
        }
    }
}
