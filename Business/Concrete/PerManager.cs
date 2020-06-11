using Business.Abstract;
using Business.Constans;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    class PerManager : IPerService
    {
        private IPerDal _perDal;

        public PerManager(IPerDal perDal)
        {
            _perDal = perDal;
        }

        public IResult Add(Per per)
        {
            _perDal.Add(per);
            return new SuccessResult(Messages.PersonAdded);
        }

        public IResult Update(Per per)
        {
            _perDal.Update(per);
            return new SuccessResult(Messages.PersonUpdated);
        }
        public IResult Delete(Per per)
        {
            _perDal.Delete(per);
            return new SuccessResult(Messages.PersonDeleted);
        }

        public IDataResult<List<Per>> GetList()
        {
            return new SuccessDataResult<List<Per>>(_perDal.GetList());
        }

    }
}
