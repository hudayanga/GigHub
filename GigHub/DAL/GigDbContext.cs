using GigHub.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GigHub.DAL
{
    public class GigDbContext : DbContext
    {
        public  DbSet<Gig> Gigs { get; set; }
        public DbSet<Genre> Genres { get; set; }

    }
}