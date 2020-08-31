using System;
using System.Collections.Generic;
using System.Text;

namespace Internship.Domain.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public bool IsDelete { get; set; }
        public string UserImg { get; set; }
        public DateTime CreateDate { get; set; }

    }
}
