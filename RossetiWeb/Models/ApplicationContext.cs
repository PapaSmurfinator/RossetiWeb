﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RossetiWeb.Models;

namespace RossetiWeb.Models
{
        public class ApplicationContext : DbContext
        {
        public DbSet<Ascillogram> Ascillograms { get; set; }
        public DbSet<AscillogramCategory> AscillogramCategories { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
        : base(options)
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        
    }
}
