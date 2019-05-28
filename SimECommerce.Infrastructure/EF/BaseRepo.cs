using Microsoft.EntityFrameworkCore;
using SimECommerce.Application.Repos;
using SimECommerce.Application.Services.Queries;
using SimECommerce.BOL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SimECommerce.DAL.EF
{
    public class BaseRepo<T> : IEntityRepo<T> where T : BaseEntity
    {
        readonly protected SimECommerceContext _simEcommerceContext;
        protected BaseRepo(SimECommerceContext simEcommerceContext)
        {
            _simEcommerceContext = simEcommerceContext;
        }


        public Task<T> GetById(int id, CancellationToken cancellationToken = default) =>
         _simEcommerceContext.Set<T>().FindAsync(id, cancellationToken);


        public Task<T> GetByStringId(string id, CancellationToken cancellationToken = default) =>
         _simEcommerceContext.Set<T>().FindAsync(id, cancellationToken);


        public Task<List<T>> ListAsync(IQuery<T> query = null, CancellationToken cancellationToken = default)
        {
            var filterQuery = _simEcommerceContext.Set<T>()
                .AsQueryable().Where(query.Criteria);
            if (query.Skip > 0)
            {
                filterQuery = filterQuery.Skip(query.Skip);
            }
            if (query.Take > 0)
            {
                filterQuery = filterQuery.Take(query.Take);
            }
            if (query.OrderBy != null || query.OrderByDescending != null)
            {
                IOrderedQueryable<T> q;
                if (query.OrderBy != null)
                {
                    q = filterQuery.OrderBy(query.OrderBy);
                }
                else
                {
                    q = filterQuery.OrderByDescending(query.OrderByDescending);
                }
                if (query.ThenBy != null)
                {
                    q = q.ThenBy(query.ThenBy);
                }
                else if (query.ThenByDescending != null)
                {
                    q = q.ThenByDescending(query.ThenByDescending);
                }
                filterQuery = q;
            }
            return filterQuery.ToListAsync(cancellationToken);
        }
    }
}
