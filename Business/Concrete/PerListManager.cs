using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concreate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class PerListManager:IPerListService
    {
        public IDataResult<List<PerList>> GetList()
        {
            using (var ctx = new PoldyContext())
            {
                var per01 = ctx.PerList.FromSqlRaw("Select * From v_perlist").ToList();
                return new SuccessDataResult<List<PerList>>(per01);
            }
        }
    }
}
