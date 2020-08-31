using System;
using System.Collections.Generic;
using System.Text;
using Internship.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Internship.Data.Context
{
    public class InternshipDBContext : DbContext
    {
        public InternshipDBContext(DbContextOptions<InternshipDBContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Filter For IsDelete in All Table

            modelBuilder.Entity<Role>()
                .HasQueryFilter(u => !u.IsDelete);

            modelBuilder.Entity<User>()
                .HasQueryFilter(u => !u.IsDelete);


            #endregion

            #region Seed Data For Roles

            modelBuilder.Entity<Role>().HasData(new Role()
            {
                RoleId = 1,
                RoleName = "مدیریت ارتباط با صنعت"
            }, new Role()
            {
                RoleId = 2,
                RoleName = "حسابداری"
            }, new Role()
            {
                RoleId = 3,
                RoleName = "امور دانشجویی"
            }, new Role()
            {
                RoleId = 4,
                RoleName = "دانشجو"
            }, new Role()
            {
                RoleId = 5,
                RoleName = "کاربر"
            }
            );

            #endregion

            base.OnModelCreating(modelBuilder);
        }
    }
}
