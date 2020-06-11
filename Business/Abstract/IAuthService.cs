using Core.Entities.Concrete;
using Core.Security.Jwt;
using Core.Utilities.Results;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IAuthService
    {
        IDataResult<Person> Register(UserForRegisterDto userForRegisterDto, string password);
        IDataResult<Person> Login(UserForLoginDto userForLoginDto);
        IResult UserExists(string email);
        IDataResult<AccessToken> CreateAccessToken(Person person);
    }
}
