using Core.Utilities.Results;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IPerListService
    {
        IDataResult<List<PerList>> GetList();
    }
}
