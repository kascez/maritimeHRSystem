using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace SystemOperations
{
    public class FindSailors : AbstractGenericOperation
    {
        protected override object Execute(IDomainObject entity)
        {
            List<Sailor> sailors = broker.SelectJoin(entity).OfType<Sailor>().ToList();
            return sailors;
        }

        protected override void Validate(IDomainObject entity)
        {
            if (!(entity is Sailor))
            {
                throw new ArgumentException();
            }
        }
    }
}
