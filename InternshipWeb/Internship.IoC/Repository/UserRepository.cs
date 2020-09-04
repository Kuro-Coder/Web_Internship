using System;
using System.Collections.Generic;
using System.Text;
using Internship.Data.Context;
using Internship.Domain.Interfaces;
using Internship.Domain.Models;

namespace Internship.Data.Repository
{
    //Query in DB for InterFaces in Domain Interfaces
    public class UserRepository : IUserRepository
    {
        private InternshipDBContext _context;

        public UserRepository(InternshipDBContext context)
        {
            _context = context;
        }
        public IEnumerable<User> GetUsers()
        {
            return _context.Users;
        }
    }
}
