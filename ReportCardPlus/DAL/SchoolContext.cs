using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ReportCardPlus.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ReportCardPlus.DAL
    {
    public class SchoolContext : DbContext
        {
        public SchoolContext() : base("SchoolContext")
            {
            }

        public DbSet<Student> Students { get; set; }
        public DbSet<User> Users { get; set; }
      

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            }
        }
    }