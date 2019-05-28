using SimECommerce.BOL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SimECommerce.Application.Repos
{
    public interface IUserRepo : IEntityRepo<AspNetUsers>
    {
        Task AddAsync(AspNetUsers user, CancellationToken cancellationToken = default);
    }
}
