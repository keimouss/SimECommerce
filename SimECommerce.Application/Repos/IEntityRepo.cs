using SimECommerce.Application.Services.Queries;
using SimECommerce.BOL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SimECommerce.Application.Repos
{
    public interface IEntityRepo<T>where T:BaseEntity
    {
        Task<T> GetById(int id, CancellationToken cancellationToken = default);
        Task<T> GetByStringId(string id, CancellationToken cancellationToken = default);
        Task<List<T>> ListAsync(IQuery<T> query = null, CancellationToken cancellationToken = default);
    }
}
