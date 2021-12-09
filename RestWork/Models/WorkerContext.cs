using System;
using Microsoft.EntityFrameworkCore;

namespace RestWork.Models
{
    public class WorkerContext: DbContext
    {
        public WorkerContext(DbContextOptions<WorkerContext> options): base(options)
        {

        }
        public DbSet<Worker> Workers { get; set; }
    }
}
