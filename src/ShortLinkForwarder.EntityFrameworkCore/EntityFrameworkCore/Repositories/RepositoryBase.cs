using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace ShortLinkForwarder.EntityFrameworkCore.Repositories
{
    public class RepositoryBase<TEntity, TPrimaryKey> : EfCoreRepository<ShortLinkForwarderDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        public RepositoryBase(IDbContextProvider<ShortLinkForwarderDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
