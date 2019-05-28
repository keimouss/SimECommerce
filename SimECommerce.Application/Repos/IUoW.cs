using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SimECommerce.Application.Repos
{
    public interface IUoW
    {
        Task SaveChangeAsync(CancellationToken cancellationToken = default);
    }
}
