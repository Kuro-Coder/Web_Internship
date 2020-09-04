using System;
using System.Collections.Generic;
using System.Text;
using Internship.Domain.Models;

namespace Internship.Domain.Repositoryes
{
    //update delete insert in User Table
    public interface IUserRepository
    {
        IEnumerable<User> GetUsers();
    }
}
