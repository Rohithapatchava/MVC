using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreMvctask.Models;//needed for model class
using Microsoft.EntityFrameworkCore;//needed for Dbcontext

namespace CoreMvctask.Data
{
    public class Bookcontext:DbContext
    {
        public Bookcontext(DbContextOptions<Bookcontext> options):base( options)
        {

        }
        public DbSet<Book> Books { get; set; }
    }
}
