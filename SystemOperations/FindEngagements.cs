using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace SystemOperations
{
    public class FindEngagements : AbstractGenericOperation
    {
        protected override object Execute(IDomainObject entity)
        {
            List<Engagement> engagements = broker.SelectJoin(entity).OfType<Engagement>().ToList();
            return engagements;
        }

        protected override void Validate(IDomainObject entity)
        {
            if (!(entity is Engagement))
            {
                throw new ArgumentException();
            }
        }
    }
}
