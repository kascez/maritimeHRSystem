using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace SystemOperations
{
    public class FindCompanies : AbstractGenericOperation
    {
        protected override object Execute(IDomainObject entity)
        {
            List<Company> companies = broker.SelectJoin(entity).OfType<Company>().ToList();
            return companies;
        }

        protected override void Validate(IDomainObject entity)
        {
            if (!(entity is Company))
            {
                throw new ArgumentException();
            }
        }
    }
}
