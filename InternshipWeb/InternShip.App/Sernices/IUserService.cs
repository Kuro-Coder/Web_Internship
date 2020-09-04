using System;
using System.Collections.Generic;
using System.Text;
using InternShip.App.ViewModels;

namespace InternShip.App.Sernices
{
    public interface IUserService
    {
        UserViewModel GetUsers();
    }
}
