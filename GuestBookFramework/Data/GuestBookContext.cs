using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using GuestBookFramework.Models.Entities;

namespace GuestBookFramework.Data
{
    public class GuestBookContext:DbContext
    {
        public DbSet<Comment> Comments { get; set; }
    }
}