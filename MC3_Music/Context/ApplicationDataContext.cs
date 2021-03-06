﻿using MC3_Music.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
namespace MC3_Music.Context
{
    public class ApplicationDataContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Album> Albums { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Cart> Cart { get; set; }

        public DbSet<Transaction> Transactions { get; set; }

        public ApplicationDataContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        { }

        public static ApplicationDataContext Create()
        {
            return new ApplicationDataContext();
        }

        //public System.Data.Entity.DbSet<AppUser> AppUsers { get; set; }
    }
}