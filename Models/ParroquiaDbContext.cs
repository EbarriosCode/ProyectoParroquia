using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Models
{
    public class ParroquiaDbContext : DbContext
    {
        public ParroquiaDbContext(DbContextOptions<ParroquiaDbContext> options)
            : base(options)
        {}
    }
}
