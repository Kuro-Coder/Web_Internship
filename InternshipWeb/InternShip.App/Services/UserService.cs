using System;
using System.Collections.Generic;
using System.Text;
using InternShip.App.Interfaces;
using Internship.Domain.Interfaces;
using Internship.Domain.Models;
using InternShip.App.ViewModels;

namespace InternShip.App.Services
{
    //that Working from Repository in AppLayer Services
    public class UserService : IUserService
    {
        private IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public UserViewModel GetUsers()
        {
            return new UserViewModel()
            {
                Users = _userRepository.GetUsers()
            };
        }
    }
}
