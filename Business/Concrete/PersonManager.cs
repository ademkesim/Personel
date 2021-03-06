﻿using Business.Abstract;
using Business.Constans;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class PersonManager : IPersonService
    {
        private IPersonDal _personDal;

        public PersonManager(IPersonDal personDal)
        {
            _personDal = personDal;
        }

        public IResult Add(Person person)
        {
            _personDal.Add(person);
            return new SuccessResult(Messages.PersonAdded);
        }

        public IResult Update(Person person)
        {
            _personDal.Update(person);
            return new SuccessResult(Messages.PersonUpdated);
        }

        public IResult Delete(Person person)
        {
            _personDal.Delete(person);
            return new SuccessResult(Messages.PersonDeleted);
        }


        public IDataResult<List<Person>> GetList()
        {
            return new SuccessDataResult<List<Person>>(_personDal.GetList());
        }

        public Person GetByMail(string mail)
        {
            return _personDal.Get(u => u.mail == mail);
        }

        public Person GetById(int id)
        {
            return _personDal.Get(u => u.PersonId == id);
        }
    }
}
