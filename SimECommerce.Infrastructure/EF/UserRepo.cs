using SimECommerce.Application.Repos;
using SimECommerce.BOL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SimECommerce.DAL.EF
{
    public class UserRepo : BaseRepo<AspNetUsers>, IUserRepo
    {
        public UserRepo(SimECommerceContext simEcommerceContext) : base(simEcommerceContext)
        { }
        public Task AddAsync(AspNetUsers user, CancellationToken cancellationToken = default) =>
            this._simEcommerceContext.AspNetUsers.AddAsync(user, cancellationToken);
    }
}
