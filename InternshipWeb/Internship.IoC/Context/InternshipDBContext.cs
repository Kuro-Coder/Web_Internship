using System;
using System.Collections.Generic;
using System.Text;
using Internship.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Internship.Data.Context
{
    public class InternshipDBContext:DbContext
    {
        public InternshipDBContext(DbContextOptions<InternshipDBContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
    }
}
