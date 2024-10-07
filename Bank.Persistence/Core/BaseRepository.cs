using Ardalis.Specification.EntityFrameworkCore;
using Bank.Aplication.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Persistence.Core
{
    public  class BaseRepository<T> : RepositoryBase<T>, IBaseRepository<T> where T : class
    {
        private readonly DbContext _dbContext;

        public BaseRepository(DbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
