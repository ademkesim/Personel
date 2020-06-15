using Business.Abstract;
using Business.Constans;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;
using DataAccess.Concrete.EntityFramework.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Business.Concrete
{
    class PerManager : IPerService
    {
        private IPerDal _perDal;

        public PerManager(IPerDal perDal)
        {
            _perDal = perDal;
        }

        public IResult Add(PerList per)
        {
            _perDal.Add(per);
            return new SuccessResult(Messages.PersonAdded);
        }

        public IResult Update(PerList per)
        {
            _perDal.Update(per);
            return new SuccessResult(Messages.PersonUpdated);
        }
        public IResult Delete(PerList per)
        {
            _perDal.Delete(per);
            return new SuccessResult(Messages.PersonDeleted);
        }

        public IDataResult<List<PerList>> GetList()
        {
            using (var ctx = new PoldyContext())
            {
                var per01 = ctx.per01a.FromSqlRaw("Select * From v_perlist").ToList();
                return new SuccessDataResult<List<PerList>>(per01);
            }
        }
    }
}
