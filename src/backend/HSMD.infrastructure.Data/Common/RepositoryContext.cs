﻿using HSMD.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSMD.Infrastructure.Data.Common
{
    public class RepositoryContext : DbContext 
    {
        public RepositoryContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Hospital> Hospitals { get; set; }
        public DbSet<HospitalAddress> HospitalAddress { get; set; }
        public  DbSet<Staff> Staff { get; set; }


    }
}
