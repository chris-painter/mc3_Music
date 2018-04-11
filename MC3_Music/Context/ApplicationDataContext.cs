﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using MC3_Music.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace MC3_Music.Context
{
    public class ApplicationDataContext : IdentityDbContext<AppUser>
    {
        public DbSet<Album> Albums { get; set; }
        public DbSet<Song> Songs { get; set; }

        public ApplicationDataContext()
            : base("DefaultConnection")
        { }

        //public System.Data.Entity.DbSet<AppUser> AppUsers { get; set; }

    }
}