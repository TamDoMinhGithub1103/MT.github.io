using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Framework;
namespace Models
{
   public class AccountModel
    {
        private MTDbContext context = null;

        public AccountModel()
        {
            context = new MTDbContext();
        }
        public bool Login(string userName, string password)
        {
            var result = context.Account.SingleOrDefault(x => x.Username == userName && x.Password == password);
            if (result == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
