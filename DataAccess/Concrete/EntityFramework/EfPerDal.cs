using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfPerDal:EfEntityRepositoryBase<Per, PoldyContext>, IPerDal
    {
    }
}
