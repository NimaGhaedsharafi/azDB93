using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace AzDBStructure.Model
{
    class Album : DataAccess
    {
        public Album()
        {
            this.tablename = "albums";
        }

    }
}
