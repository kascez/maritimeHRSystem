using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class AddCompany : AbstractGenericOperation
    {
        protected override object Execute(IDomainObject entity)
        {
            bool success = false;
            if (broker.Insert(entity) > 0)
            {
                success = true;
            }
            int noviId = broker.GetNewId(entity) - 1;
            foreach (Workplace w in c.Workplaces)
            {
                w.Company = new Company();
                w.Company.ID = noviId;
            }
            foreach (Workplace w in c.Workplaces)
            {
                if (broker.Insert(w) > 0)
                {
                    success = true;
                } else
                {
                    success = false;
                }
            }
            return success;
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
