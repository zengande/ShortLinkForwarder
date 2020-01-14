using Microsoft.EntityFrameworkCore;
using ShortLinkForwarder.Links;
using System;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.EntityFrameworkCore;

namespace ShortLinkForwarder.EntityFrameworkCore.Repositories
{
    public interface ILinkRepository : IRepository<Link, long>
    {
        Task<Link> GetByTokenAsync(string token);

        Task<Link> FindOneAsync(Expression<Func<Link, bool>> where);
    }

    public class LinkRepository : RepositoryBase<Link, long>, ILinkRepository
    {
        public LinkRepository(IDbContextProvider<ShortLinkForwarderDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }

        public Task<Link> FindOneAsync(Expression<Func<Link, bool>> where)
        {
            return DbSet.FirstOrDefaultAsync(where);
        }

        public Task<Link> GetByTokenAsync(string token)
        {
            return FindOneAsync(l => l.Token == token);
        }
    }
}
