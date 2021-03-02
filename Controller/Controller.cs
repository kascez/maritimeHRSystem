using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using DBBroker;
using SystemOperations;

namespace Controller
{
    public class Controller
    {
        public Administrator Administrator;
        public Sailor Sailor;
        private Broker broker = new Broker();
        private static Controller instance;
        private Controller() { }

        public static Controller Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Controller();
                }
                return instance;
            }
        }

        public bool LoginSailor(Sailor s)
        {
            AbstractGenericOperation ado = new LoginSailor();
            bool success = (bool)ado.ExecuteSO(s);
            return success;
        }

        public bool LoginAdministrator(Administrator a)
        {
            AbstractGenericOperation ado = new LoginAdministrator();
            bool success = (bool)ado.ExecuteSO(a);
            return success;
        }

        public bool DeleteCompany(Company c)
        {
            AbstractGenericOperation ado = new DeleteCompany();
            bool success = (bool)ado.ExecuteSO(c);
            return success;
        }

        public bool AddCompany(Company c)
        {
            AbstractGenericOperation ado = new AddCompany();
            bool success = (bool)ado.ExecuteSO(c);
            return success;
        }

        public bool AddEngagement(Engagement e)
        {
            AbstractGenericOperation ado = new AddEngagement();
            bool success = (bool)ado.ExecuteSO(e);
            return success;
        }

        public bool AddSailor(Sailor s)
        {
            AbstractGenericOperation ado = new AddSailor();
            bool success = (bool)ado.ExecuteSO(s);
            return success;
        }

        public bool UpdateCompany(Company c)
        {
            AbstractGenericOperation ado = new UpdateCompany();
            bool success = (bool)ado.ExecuteSO(c);
            return success;
        }

        public bool UpdateSailor(Sailor s)
        {
            AbstractGenericOperation ado = new UpdateSailor();
            bool success = (bool)ado.ExecuteSO(s);
            return success;
        }

        public bool UpdateWorkplace(Workplace w)
        {
            AbstractGenericOperation ado = new UpdateWorkplace();
            bool success = (bool)ado.ExecuteSO(w);
            return success;
        }

        public List<Company> ReturnCompanies()
        {
            AbstractGenericOperation ado = new ReturnCompanies();
            List<Company> c = (List<Company>)ado.ExecuteSO(new Company());
            return c;
        }

        public List<Sailor> ReturnSailors()
        {
            AbstractGenericOperation ado = new ReturnSailors();
            List<Sailor> s = (List<Sailor>)ado.ExecuteSO(new Sailor());
            return s;
        }

        public List<SailorRank> ReturnRanks()
        {
            AbstractGenericOperation ado = new ReturnRanks();
            List<SailorRank> s = (List<SailorRank>)ado.ExecuteSO(new SailorRank());
            return s;
        }

        public List<Country> ReturnCountries()
        {
            AbstractGenericOperation ado = new ReturnCountries();
            List<Country> c = (List<Country>)ado.ExecuteSO(new Country());
            return c;
        }

        public List<Engagement> ReturnEngagements()
        {
            AbstractGenericOperation ado = new ReturnEngagements();
            List<Engagement> e = (List<Engagement>)ado.ExecuteSO(new Engagement());
            return e;
        }

        public List<Workplace> ReturnWorkplaces()
        {
            AbstractGenericOperation ado = new ReturnWorkplaces();
            List<Workplace> w = (List<Workplace>)ado.ExecuteSO(new Workplace());
            return w;
        }

        public List<Company> FindCompanies(Company cc)
        {
            AbstractGenericOperation ado = new FindCompanies();
            List<Company> c = (List<Company>)ado.ExecuteSO(cc);
            return c;
        }

        public List<Administrator> FindAdministrators(Administrator aa)
        {
            AbstractGenericOperation ado = new FindAdministrators();
            List<Administrator> a = (List<Administrator>)ado.ExecuteSO(aa);
            return a;
        }

        public List<Sailor> FindSailors(Sailor ss)
        {
            AbstractGenericOperation ado = new FindSailors();
            List<Sailor> s = (List<Sailor>)ado.ExecuteSO(ss);
            return s;
        }

        public List<Engagement> FindEngagements(Engagement ee)
        {
            AbstractGenericOperation ado = new FindEngagements();
            List<Engagement> e = (List<Engagement>)ado.ExecuteSO(ee);
            return e;
        }

        public List<Workplace> FindWorkplaces(Workplace ww)
        {
            AbstractGenericOperation ado = new FindWorkplaces();
            List<Workplace> w = (List<Workplace>)ado.ExecuteSO(ww);
            return w;
        }
    }
}
