using System;
using System.Collections.Generic;
using System.Text;
using InternShip.App.Interfaces;
using InternShip.App.Services;
using Internship.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Internship.Data.Repository;

namespace Internship.Infra.IoC
{
    public class DependencyContainer
    {
        //Injections
        public static void RegisterServices(IServiceCollection service)
        {

            #region Application Layer Service Injections

            service.AddScoped<IUserService, UserService>();

            #endregion



            #region Domain Layer Interfaces and Data Layer Repository Injections

            service.AddScoped<IUserRepository, UserRepository>();

            #endregion

        }
    }
}
