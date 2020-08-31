using System;
using System.Collections.Generic;
using System.Text;
using Internship.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Internship.IoC.Context
{
    public class InternshipDBContext:DbContext
    {
        public InternshipDBContext(DbContextOptions<InternshipDBContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
    }
}
