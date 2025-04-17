using DesignPattern.DataAccessLayer.Abstract;
using DesignPattern.DataAccessLayer.Concrete;
using DesignPattern.DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.DataAccessLayer.EntityFramework
{
   public class EfProcessDAL:GenericRepository<Process>, IProcessDAL
    {
        public EfProcessDAL(Context context):base(context)
        {
            
        }
    }
}
