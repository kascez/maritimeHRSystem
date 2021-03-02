using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class LoginSailor : AbstractGenericOperation
    {
        public Sailor Result { get; private set; }
        protected override object Execute(IDomainObject entity)
        {
            Sailor s = (Sailor)entity;
            foreach (Sailor sa in broker.Select(entity))
            {
                if (sa.Username == s.Username && sa.Password == s.Password)
                {
                    Result = sa;
                    return true;
                }
            }
            return false;
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
