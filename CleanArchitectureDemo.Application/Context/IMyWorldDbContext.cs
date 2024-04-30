using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureDemo.Application.Context
{
    public interface IMyWorldDbContext
    {
        DbSet<CleanArchitectureDemo.Domain.Entities.Beach> Beach { get; }

        Task<int> SaveToDbAsync();
    }
}
