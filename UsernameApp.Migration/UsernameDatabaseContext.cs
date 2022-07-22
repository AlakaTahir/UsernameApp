using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using UsernameAppmodel;

namespace UsernameApp.Migration
{
    public class UsernameDatabaseContext: DbContext
    {
        public UsernameDatabaseContext()
        {
        }

        public UsernameDatabaseContext(DbContextOptions<UsernameDatabaseContext> options)
             : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("");
        }

        public DbSet<Namecollectormodel> DateHistory { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }

   
}
