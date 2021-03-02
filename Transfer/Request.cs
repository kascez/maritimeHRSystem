using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transfer
{
    [Serializable]
    public class Request
    {
        public object Object { get; set; }
        public Operation Operation { get; set; }
    }

    public enum Operation
    {
        Login,
        Register,
        LoginSailor,
        LoginAdministrator,
        ReturnRanks,
        ReturnCountries,
        ReturnCompanies,
        ReturnSailors,
        ReturnWorkplaces,
        ReturnEngagements,
        FindCompanies,
        FindSailors,
        FindEngagements,
        FindWorkplaces,
        UpdateCompany,
        UpdateSailor,
        UpdateWorkplace,
        DeleteCompany,
        AddCompany,
        AddEngagement,
        AddSailor,
        FindAdministrators
    }
}
