using Internship.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace InternShip.App.ViewModels
{
    public class UserViewModel
    {
        public IEnumerable<User> Users { get; set; }
    }
}
