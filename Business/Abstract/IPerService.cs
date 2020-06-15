using Core.Utilities.Results;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IPerService
    {
        IResult Add(PerList per);
        IResult Update(PerList per);
        IResult Delete(PerList per);
        IDataResult<List<PerList>> GetList();
    }
}
