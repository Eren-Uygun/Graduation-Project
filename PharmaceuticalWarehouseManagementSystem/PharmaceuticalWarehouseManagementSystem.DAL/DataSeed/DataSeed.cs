﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using Microsoft.Extensions.DependencyInjection;
using PharmaceuticalWarehouseManagementSystem.DAL.Context;
using PharmaceuticalWarehouseManagementSystem.ENTITY.Entity;
using PharmaceuticalWarehouseManagementSystem.KERNEL.Enum;
using PharmaceuticalWarehouseManagementSystem.Utility;

namespace PharmaceuticalWarehouseManagementSystem.DAL.DataSeed
{
   public static class DataSeed
    {

       public static void Seed(IServiceProvider serviceProvider)
       {
            using(var context = new ProjectContext(serviceProvider.GetRequiredService<DbContextOptions<ProjectContext>>()))
            {
                if (context.Employees.Any())
                {
                    return;
                }
                else
                {
                     context.Employees.AddRange( //  modelBuilder.Entity<Employee>().HasData(
                new Employee()
                {
                    ID=Guid.NewGuid(),
                    FirstName = "Admin",
                    LastName = "Admin",
                    Title = "DbAdmin",
                    Role = Role.Admin,
                    Email = "admin@mail.com",
                    Password = "123",
                    BirthDate = DateTime.Parse("10/11/2020 17:00"),
                    HireDate = DateTime.Parse("24/02/2020 09:05"),
                    CreatedComputerName = "DataSeed",
                    CreatedIP = Ipfinder.IpAddress,
                    CreatedDate = DateTime.Now,
                    Status = Status.Active
                },

                new Employee() 
                { 
                    ID=Guid.NewGuid(),
                    FirstName = "User",
                    LastName = "User",
                    Title = "DbAdmin",
                    Role = Role.User,
                    Email = "user@mail.com",
                    Password = "123",
                    BirthDate = DateTime.Parse("10/11/2020 17:00"),
                    HireDate = DateTime.Parse("24/02/2020 09:05"),
                    CreatedComputerName = "DataSeed",
                    CreatedIP = Ipfinder.IpAddress,
                    CreatedDate = DateTime.Now,
                    Status = Status.Active
                }

            );

                }



                if (context.Categories.Any())
                {
                    return;
                }
                else
                {
                      context.Categories.AddRange( //   modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    ID=Guid.NewGuid(),
                    CategoryName = "Ağrı kesici",
                    CategoryDescription = "Düşük ve orta düzey ağrı giderici ilaçlar",
                    CreatedComputerName = "DataSeed",
                    CreatedIP = Ipfinder.IpAddress,
                    CreatedDate = DateTime.Now,
                    Status = Status.Active

                },

                new Category()
                {
                    ID=Guid.NewGuid(),
                    CategoryName = "Ateş Düşürücü",
                    CategoryDescription = "Vücut sıcaklığını ayarlamaya yarayan ilaçlar",
                    CreatedComputerName = "DataSeed",
                    CreatedIP = Ipfinder.IpAddress,
                    CreatedDate = DateTime.Now,
                    Status = Status.Active
                }

            );
                }



              context.SaveChanges();
            }
       

          
            
          


        }


    }
}
