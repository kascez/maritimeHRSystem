using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class FindAdministrators : AbstractGenericOperation
    {
        protected override object Execute(IDomainObject entity)
        {
            List<Administrator> engagements = broker.SelectJoin(entity).OfType<Administrator>().ToList();
            return engagements;
        }

        protected override void Validate(IDomainObject entity)
        {
            if (!(entity is Administrator))
            {
                throw new ArgumentException();
            }
        }
    }
}
