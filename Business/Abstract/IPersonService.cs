using Core.Entities.Concrete;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IPersonService
    {
        IResult Add(Person person);
        IResult Update(Person person);
        IResult Delete(Person person);
        Person GetByMail(string mail);
        Person GetById(int id);
    }
}
