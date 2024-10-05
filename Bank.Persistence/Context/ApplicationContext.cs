using Bank.Aplication.Interfaces;
using Bank.Domain.Common;
using Bank.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Persistence.Context
{
    public class ApplicationContext : DbContext
    {
        private readonly IDateTimeService _dateTime;

        public ApplicationContext(DbContextOptions<ApplicationContext> options, IDateTimeService dateTime) : base(options
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            _dateTime = dateTime;
        }

        public DbSet<Cliente> Clientes { get; set; }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<BaseEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.Created = _dateTime.NowUtc;
                        break;
                    case EntityState.Modified:
                        entry.Entity.LastModified = _dateTime.NowUtc;
                        break;
                }

            }
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
