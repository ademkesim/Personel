using Core.Utilities.Results;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IPerService
    {
        IResult Add(Per per);
        IResult Update(Per per);
        IResult Delete(Per per);
        IDataResult<List<Per>> GetList();
    }
}
