using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Model
{
    class User : DataAccess
    {
        public User()
        {
            this.tablename = "users";
        }
    }
}
