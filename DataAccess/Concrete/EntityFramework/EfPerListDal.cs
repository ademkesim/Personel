using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concreate;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfPerListDal : EfEntityRepositoryBase<PerList, PoldyContext>, IPerListDal
    {
    }
}
