using CleanArchitectureDemo.Application.Context;
using CleanArchitectureDemo.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureDemo.Infrastructure.Context
{
    public class MyWorldDbContext : DbContext, IMyWorldDbContext
    {
        public MyWorldDbContext(DbContextOptions<MyWorldDbContext> options) : base(options)
        {

        }
        public DbSet<Beach> Beach { get; set; }

        public async Task<int> SaveToDbAsync()
        {
            return await SaveChangesAsync();
        }
    }
}
