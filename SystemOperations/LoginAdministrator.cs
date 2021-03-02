using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class LoginAdministrator : AbstractGenericOperation
    {
        public Administrator Result { get; private set; }
        protected override object Execute(IDomainObject entity)
        {
            Administrator a = (Administrator)entity;
            foreach(Administrator ad in broker.Select(new Administrator()))
            {
                if (ad.Username == a.Username && ad.Password == a.Password)
                {
                    Result = ad;
                    return true;
                }
            }
            return false;
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
