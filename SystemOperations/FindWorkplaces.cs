using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace SystemOperations
{
    public class FindWorkplaces : AbstractGenericOperation
    {
        protected override object Execute(IDomainObject entity)
        {
            List<Workplace> workplaces = broker.SelectJoin(entity).OfType<Workplace>().ToList();
            return workplaces;
        }

        protected override void Validate(IDomainObject entity)
        {
            if (!(entity is Workplace))
            {
                throw new ArgumentException();
            }
        }
    }
}
