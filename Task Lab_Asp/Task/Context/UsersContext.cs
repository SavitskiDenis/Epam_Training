using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Task.Models;

namespace Task.Context
{
    public class UsersContext: DbContext
    {
        public DbSet<User> Users { get; set; }

        public UsersContext() : base("DbUsers")
        {

        }
    }
}