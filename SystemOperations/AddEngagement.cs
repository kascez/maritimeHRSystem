using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class AddEngagement : AbstractGenericOperation
    {
        protected override object Execute(IDomainObject entity)
        {
            if (broker.Insert(entity) > 0)
            {
                return true;
            }
            return false;
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
