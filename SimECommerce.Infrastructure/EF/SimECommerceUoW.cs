using SimECommerce.Application.Repos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SimECommerce.DAL.EF
{
    public class SimECommerceUoW:IUoW
    {
        readonly SimECommerceContext _simEcommerceContext;
        public SimECommerceUoW(SimECommerceContext simEcommerceContext)
        {
            _simEcommerceContext = simEcommerceContext;
        }

        public Task SaveChangeAsync(CancellationToken cancellationToken = default) =>
            _simEcommerceContext.SaveChangesAsync(cancellationToken);

    }
}
