using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Storage
{
    public class StorageUser
    {
        private List<Administrator> users;
        public StorageUser()
        {
            users = new List<Administrator>() {
                new Administrator {
                Username = "zoky",
                Password = "123"
                }
            };
        }


        public List<Administrator> ReturnUsers()
        {
            return users;
        }
    }
}
