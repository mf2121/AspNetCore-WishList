using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WishList.Data
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<item> Items { get; set; }
        public ApplicationDBContext(DbContextOptions options);
    }
}
